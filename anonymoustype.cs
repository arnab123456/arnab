using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPS2
{
    class anonymoustype
    {
        static void Main(string[] args)
        {
            var product = new { Name = "Keyboard", price = 650,Category="Electronics",Stock=10 };
            Console.WriteLine("Product Details");
            Console.WriteLine("Name:" + product.Name);
            Console.WriteLine("Price:Rs." + product.price+"\nCategory: "+product.Category);
            Console.Write("\n Press Enter to quit....");
            Console.ReadLine();
        }
    }
}
