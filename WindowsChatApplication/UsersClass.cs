using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsChatApplication
{
    public class Customer
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Array inTable { get; set; }

        List<Customer> listofCustomers = new List<WindowsChatApplication.Customer>();

        public Customer()
        {
            //Create customer objects;
            // Good for individual construction; but not for bulk construciton.
            //woudl use foreach for bulk integration    
            var cust1 = new Customer()
            {
                Id = 0,
                Name = "name 1",
                Email = "1@email.com"
            };
        }
    }


    class UsersClass
    {
        private int Id, x = 0;
        private string Name;
        private bool banned;
        public string userID {
            get { return Name; }
            set { Name = value; }
        }
        public int Banned
        {
            get
            {
                if (banned == true)
                {
                    x = 1;
                } else
                {
                    x = 0;
                }
                return x;
            }
            set {
                if (value == 1)
                {
                    banned = true;
                } else
                {
                    banned = false;
                }
            }
        }
        static void main(string[] args)
        {
            List<int> listofInts = new List<int>();
            listofInts.Add(1);
            listofInts.Add(11);
            listofInts.Add(11);
            listofInts.Add(11);
            listofInts.Add(11);
            listofInts.Add(11);
            listofInts.Add(11);

            foreach(var item in listofInts)
            {

            }

        }

    }
}
