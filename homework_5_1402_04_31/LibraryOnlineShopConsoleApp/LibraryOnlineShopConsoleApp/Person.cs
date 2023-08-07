namespace LibraryOnlineShopConsoleApp
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public string PersonFullName()
        {
            return FirstName + " " + LastName;
        }
    }
    
}
