using System.Reflection;

namespace ReflectionPresentationConsoleApp
{
    internal class Program
    {
        static void makeConsoleSpace(string regionName)
        {
            Console.WriteLine();
            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine(regionName);
        }

        static void Main(string[] args)
        {
            makeConsoleSpace("object inspection");

            #region object inspection

            object obj = new JustForTest();
            Type objType = obj.GetType();

            PropertyInfo[] objProps = objType.GetProperties();
            FieldInfo[]  objFields = objType.GetFields();
            MethodInfo[] objMethods = objType.GetMethods();

            foreach (PropertyInfo propInfo in objProps)
            {
                Console.WriteLine($"propInfo.Name: {propInfo.Name}, propInfo.Type: {propInfo.PropertyType}");
            }
            foreach(FieldInfo fieldInfo in objFields)
            {
                Console.WriteLine($"fieldInfo.Name: {fieldInfo.Name}, fieldInfo.Type: {fieldInfo.FieldType}");
            }
            foreach(MethodInfo methodInfo in objMethods)
            {
                Console.WriteLine($"methodInfo.Name: {methodInfo.Name}, methodInfo.ReturnType: {methodInfo.ReturnType}");
            }

            #endregion

            makeConsoleSpace("dynamically loading assemblies");
            
            #region dynamically loading assemblies

            Assembly calculator = Assembly.LoadFrom("CalculatorConsoleApp.dll");
            //Type[] calculatorType = calculator.GetTypes();
            Type[] calculatorType = calculator.GetExportedTypes();
            foreach(Type type in calculatorType)
            {
                Console.WriteLine($"type.Name: {type.Name}");
                foreach(MethodInfo methodInfo in type.GetMethods())
                {
                    Console.WriteLine($"methodInfo.Name: {methodInfo.Name}, methodInfo.ReturnType: {methodInfo.ReturnType}");
                }
            }

            #endregion

            makeConsoleSpace("creating instances");

            #region creating instances

            // user input types = {"Manager", "Accountant", "Secretary"} == user role
            //string userInputType = "Accountant";
            string userInputType = "ReflectionPresentationConsoleApp.JustForTest, ReflectionPresentationConsoleApp";
            Type? objectType = Type.GetType(userInputType);

            if(objectType != null)
            {
                object? instance = Activator.CreateInstance(objectType);
                Console.WriteLine($"objectType.Name: {objectType.Name}");
            }
            else
            {
                Console.WriteLine("Type " + userInputType + " not found.");
            }

            #endregion

            makeConsoleSpace("accessing private members");

            #region accessing private members

            object fun = new JustForTest();
            Type funType = fun.GetType();

            FieldInfo[] privateFields = funType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach(FieldInfo fieldInfo in privateFields)
            {
                if(fieldInfo != null)
                {
                    Console.WriteLine($"privateField.Name: {fieldInfo.Name}");
                }
            }

            // for dll:
            foreach(Type type in calculatorType)
            {
                FieldInfo[] calculatorPrivateFields = type.GetFields(BindingFlags.Static |BindingFlags.NonPublic | BindingFlags.Instance);
                foreach(FieldInfo fieldInfo in calculatorPrivateFields)
                {
                    if(fieldInfo != null)
                    {
                        Console.WriteLine($"calculatorPrivateField.Name: {fieldInfo.Name}");
                    }
                }
            }


            #endregion

            makeConsoleSpace("dynamic method invocation");

            #region dynamic method invocation
            
            Assembly secondCalculator = Assembly.LoadFrom("CalculatorConsoleApp.dll");
            Type[] secondCalculatorType = calculator.GetExportedTypes();
            foreach(Type type in secondCalculatorType)
            {
                Console.WriteLine($"type.Name: {type.Name}");
                foreach(MethodInfo methodInfo in type.GetMethods())
                {
                    if(methodInfo.Name == "AddToPi")
                    {
                        foreach(var param in methodInfo.GetParameters())
                            Console.WriteLine($"\t param name:{param.Name}, param type: {param.ParameterType}");

                        var resultAddToPi = methodInfo.Invoke(secondCalculator, new object[] {2});
                        Console.WriteLine($"AddToPi method result: {resultAddToPi}");
                    }

                    if(methodInfo.Name == "Multiply")
                    {
                        foreach(var param in methodInfo.GetParameters())
                            Console.WriteLine($"\t param name:{param.Name}, param type: {param.ParameterType}");

                        var resultMultiply = methodInfo.Invoke(secondCalculator, new object[] { 2,  34});
                        Console.WriteLine($"Multiply method result: {resultMultiply}");
                    }
                    Console.WriteLine($"methodInfo.Name: {methodInfo.Name}, methodInfo.ReturnType: {methodInfo.ReturnType}");
                }
            }

            #endregion

            makeConsoleSpace("practical example");

            #region practical example
            List<Employee> employees = new() 
            { 
                new Manager("asghar", 300, 190, 50),
                new Accountant("shahab", 170, 220),
                new Secretary("parham", 200, 140)
            };

            foreach(Employee employee in employees)
            {
                Type employeeType = employee.GetType();
                MethodInfo? method = employeeType.GetMethod("paymentWithBonus");
                if(method != null)
                {
                    var payment = method.Invoke(employee, new object[] { });
                    Console.WriteLine($"Employee named {employee.Name} gets {payment} dollars this month");
                }
                else
                {
                    Console.WriteLine($"Employee named {employee.Name} gets {employee.payment()} dollars this month");
                }
                
            }

            #endregion

        }
    }
}