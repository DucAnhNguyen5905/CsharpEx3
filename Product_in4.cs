using System;
using Process_data; // Thêm tham chiếu đến project Process_data nếu chưa có

namespace CsharpBaitap3
{
    public class Product_in4
    {
        public void DisplayProductInfo()
        {
            ProductManagement productManagement = new ProductManagement();
            var products = productManagement.GetProducts();

            foreach (var product in products)
            {
                product.DisplayInfo();
                Console.WriteLine("-----------------------------------");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product_in4 productInfo = new Product_in4();
            productInfo.DisplayProductInfo();

            Console.ReadKey(); // Để giữ cửa sổ console mở
        }
    }
}
