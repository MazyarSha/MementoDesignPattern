// See https://aka.ms/new-console-template for more information
using MementoDesignPattern;

Console.WriteLine("Hello, World!");

Product product = new Product(1,10);
Product product1 = new Product(1, 10);

Basket basket = new Basket();

basket.Add(product1);
basket.Add(product);


BasketSnapShot basketSnapShot = new BasketSnapShot();
basketSnapShot.Basket = basket.CreateSnapShot();

Console.WriteLine(basket.GetTotalPrice());

basket.Remove(product);

Console.WriteLine(basket.GetTotalPrice());


basket.SetSnapShot(basketSnapShot.Basket);

Console.WriteLine(basket.GetTotalPrice());

