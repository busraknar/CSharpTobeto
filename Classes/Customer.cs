using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Customer
    {
        //field
        //  public string FirstName;

        //Property
        //prop  yazıp tab a bas
        public int Id { get; set; }   //Müşterilerin özelliklerini  tutmak için kullandığımız nesne
        public string FirstName { get; set; }
        //private string _firstName;
        //public string FirstName
        //{
        //    get { return "Mrs."+ _firstName; }
        //    set { _firstName = value; }
        //}
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
