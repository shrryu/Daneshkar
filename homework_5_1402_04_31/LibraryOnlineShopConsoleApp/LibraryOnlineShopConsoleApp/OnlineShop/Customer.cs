namespace LibraryOnlineShopConsoleApp.OnlineShop
{
    internal class Customer : Person
    {
        public string Email { get; set; }
        public List<Product>? Cart { get; set; }
        public float BankBalance { get; set; }
        public float TotalPrice()
        {
            float totalPrice = 0;
            if(Cart != null)
            {
                foreach(Product product in Cart)
                {
                    totalPrice += product.Price;
                }

            }

            return totalPrice;
        }
        public void ShowCart()
        {
            Console.WriteLine("Your cart contains: ");
            foreach(Product product in Cart)
            {
                product.ShowProduct();
            }
        }
    }
}
