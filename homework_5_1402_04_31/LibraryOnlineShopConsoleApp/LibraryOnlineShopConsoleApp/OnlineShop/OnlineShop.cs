namespace LibraryOnlineShopConsoleApp.OnlineShop
{
    internal class OnlineShop
    {
        public List<Customer> Customers { get; set; }
        public List<Product> AllProducts { get; set; }
        /// <summary>
        /// Add a product to customer's cart.
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="product"></param>
        public void AddToCart(Customer customer, Product product)
        {
            var indexOfCustomer = Customers.IndexOf(customer);
            Customers[indexOfCustomer].Cart.Add(product);
        }
        /// <summary>
        /// display our shop products.
        /// </summary>
        public void ShowProducts()
        {
            Console.WriteLine("Our shop contains: ");
            foreach (Product product in AllProducts)
            {
                product.ShowProduct();
            }
        }
        /// <summary>
        /// Paying for products. if money is not enough, no buying!!
        /// </summary>
        /// <param name="customer"></param>
        public void Pay(Customer customer)
        {
            float totalPrice = customer.TotalPrice();
            if (customer.BankBalance >= totalPrice)
            {
                foreach (Product product in AllProducts)
                {
                    product.Quantity -= 1;
                }
                customer.BankBalance -= totalPrice;
                customer.Cart.Clear();
                Console.WriteLine("Payment was successful.");
            }
            else
            {
                Console.WriteLine("Not enough money.");
            }
        }
    }
}
