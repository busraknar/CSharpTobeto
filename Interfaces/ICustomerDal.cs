using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomerDal  // Veritabanı işlemlerini DAL yapar.
    {
        void Add();
        void Update();
        void Delete();
    }
    class SqlServerCustomerDal : ICustomerDal
    {   //implement interface diyince otomatik aşağıdakiler geldi
        public void Add()
        {
            Console.WriteLine("Sql added!");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted!");
        }

        public void Update()
        {
            Console.WriteLine("Sql updated!");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added!");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted!");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated!");
        }
    }
    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Mysql added!");
        }

        public void Delete()
        {
            Console.WriteLine("Mysql deleted!");
        }

        public void Update()
        {
            Console.WriteLine("Mysql updated!");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add(); // hem oracle hem sqli destekler, örnek olarak
        }
    }

}
