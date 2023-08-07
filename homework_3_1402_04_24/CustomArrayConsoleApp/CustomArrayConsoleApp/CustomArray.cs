#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

#endregion

namespace CustomArrayConsoleApp
{
    internal class CustomArrayTemplate<T>
    {

    }

    internal class CustomArray
    {
        static public int SecondMaxNumber(in int[] array)
        {
            if(array == null || array.Length == 0)
                throw new ArgumentException("array has no elements");

            if(array.Length > 1)
            {
                int maxElement = array[0];
                int secondMaxElement = array[0];

                for(int i = 1; i < array.Length; i++)
                {


                    if(array[i] > maxElement)
                    {
                        secondMaxElement = maxElement;
                        maxElement = array[i];
                    }
                }
                return secondMaxElement;

            }

            return array[0];
        }

        static public bool FindDuplicate(in int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                int element = array[i];
                for(int j = i + 1; j < array.Length; j++)
                {
                    if(element == array[j])
                        return true;
                }
            }

            return false;
        }

        static public string LogString(in int[] array)
        {
            string output = "for array with elements of: {";
            foreach(int element in array)
            {
                output += element;
                output += ", ";
            }
            output = output.Remove(output.Length - 2);
            output += "}";
            return output;
        }
    }
}
