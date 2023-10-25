using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(); // bu classın örneğini oluşturduk
            customerManager.Add();
            customerManager.Update();


            ProductManager productManager = new ProductManager(); // bu classın örneğini oluşturduk
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Engin";  // eşittir dediğimiz zaman SET bloğu çalışır
            customer.LastName = "Demiroğ";

            Customer customer2 = new Customer
            {
                Id=2, City="İstanbul", FirstName="Derin", LastName="Demiroğ"            
            };
            Console.WriteLine(customer2.FirstName);  //burada çalışan GET bloğudur.
            Console.ReadLine();
        }
    }
    //class CustomerManager
    //{
    //    public void Add()
    //    {
    //        Console.WriteLine("Customer Added!");
    //    }
    //    public void Update()
    //    {
    //        Console.WriteLine("Customer Updated!");
    //    }
    //}
    //class ProductManager
    //{
    //    public void Add()
    //    {
    //        Console.WriteLine("Product Added!");
    //    }
    //    public void Update()
    //    {
    //        Console.WriteLine("Product Updated!");
    //    }
    //}
}
