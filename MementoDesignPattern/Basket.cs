using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern
{
    public class BasketSnapShot
    {
        public Basket Basket { get; set; }
    }
    public class Basket
    {
        private int id;
        private DateTime CreateDate;
        private List<Product> products = new List<Product>();
        public void Add(Product product)
        {
            products.Add(product);
        }
        public void Remove(Product product)
        {
            products.Remove(product);
        }
        public decimal GetTotalPrice()
        {
            return products.Sum(x =>x.Price);
        }
        public Basket CreateSnapShot()
        {
            return new Basket
            {
                id = id,
                products = new List<Product>(products)
            };
        }


        public void SetSnapShot(Basket basket)
        {
            Console.WriteLine("Restoring state...");
            this.products = basket.products;
        }


    }
    public class Product
    {
        public Product(int id, int price)
        {
            Id = id;
            Price = price;
        }

        public int Id { get; set; }
        public int Price { get; set; }
    }
}
