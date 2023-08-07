namespace LibraryOnlineShopConsoleApp.OnlineShop
{
    internal class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public void ShowProduct()
        {
            string logString = $"Product name: {Name}\t ";
            logString += $"Price: {Price}\t ";
            logString += $"Numbers available: {Quantity}\t ";

            Console.WriteLine(logString);
        }
    }
}
