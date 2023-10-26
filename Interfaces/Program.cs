using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //Demo();

            //Bu veriyi Hem oracle veritabanı hem sqle yazmak istiyoruz

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),  //ilk eleman
                new OracleCustomerDal(), //ikinci eleman
                new MySqlCustomerDal()
            };
            foreach(var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void Demo()
        {
            //Interface= uygulamanın bağımlılıklarını sıfıra indirgemek için
            CustomerManager customerManager = new CustomerManager(); //class olduğu için NEW yapmalıyız.
            customerManager.Add(new OracleCustomerDal());
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            //manager.Add(new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", Address = "Ankara" });
            //ya da
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Engin",
                LastName = "Demiroğ",
                Address = "Ankara"
            };
            manager.Add(customer);
            Student student = new Student
            {
                Id = 1,
                FirstName = "Büşra",
                LastName = "Aknar",
                Departmant = "Bilgisayar"
            };
            manager.Add(student);
        }
    }
    interface IPerson  //temel nesneleri oluşturup onda implement etmek
    {    //İMPLEMENT İNTERFACE dedik otomatik tanımlandı.
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }
    class Customer : IPerson   //Iperson ı implement ettik
    {
       public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    class PersonManager
    {
        //public void Add(Customer customer)  //Parametre olarak müşteri nesnesi ver, ekleme yapacağım
        //{
        //    Console.WriteLine(customer.FirstName);
        //}    Böyle olunca manager.Add de student a ulaşamadık
        //
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }

}
