using System;

namespace Gun2Odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Black Hoodie";
            product1.ProductPrice = 49.90;

            Product product2 = new Product();
            product2.ProductName = "AOT Necklace";
            product2.ProductPrice = 17.99;

            Product product3 = new Product();
            product3.ProductName = "New York Hat";
            product3.ProductPrice = 36.50;


            Product[] products = new Product[] {product1, product2, product3};

            for (int x = 0; x < products.Length; x++)
            {
                Console.WriteLine("Ürün Adı: " + products[x].ProductName + "    " + "Ürün Fiyatı: " + products[x].ProductPrice);
            }

            Console.WriteLine("~~~~ For döngüsünün bitişi ~~~~");

            foreach (var Product in products)
            {
                Console.WriteLine("Ürün Adı: " + Product.ProductName + "    " + Product.ProductPrice);
            }

            Console.WriteLine("~~~~ Foreach döngüsünün bitişi ~~~~");

            int y = 0;
            while (y < products.Length)
            {
                Console.WriteLine("Ürün Adı: " + products[y].ProductName + "    " + "Ürün Fiyatı: " + products[y].ProductPrice);
                y++;
            }

            Console.WriteLine("~~~~ While döngüsünün bitişi ~~~~");
        }
    }





    class Product
    {
        public string ProductName { get; set; }

        public double ProductPrice { get; set; }

    }
}
