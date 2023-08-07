namespace LibraryOnlineShopConsoleApp.Library
{
    internal class Book
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public Person Writer { get; set; }
        public string Publisher { get; set; }
        public int NumberOfPages { get; set; }
    }
}
