using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class Program
    {
        static void Main(string[] args)
        {            
            int custid, i=0;
            CustomerArray ca = new CustomerArray();
            do
            {
                Console.WriteLine("Enter you option\n1. Add Customer\n2. Show All Customers\n3. Get Customer by ID\nEnter your option");
                int opt=Convert.ToInt32(Console.ReadLine());
                switch(opt)
                {
                    case 1:
                        Customer c = new Customer();                        
                        Console.WriteLine("Enter name");
                        c.NAME  = Console.ReadLine();
                        Console.WriteLine("Enter address");
                        c.ADDRESS = Console.ReadLine();
                        Console.WriteLine("Enter phone");
                        c.PHONE = Console.ReadLine();
                        Console.WriteLine("Enter city");
                        c.CITY = Console.ReadLine();
                        Console.WriteLine("Enter state");
                        c.STATE = Console.ReadLine();
                        Console.WriteLine("Enter pincode");
                        c.PINCODE = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter email");
                        c.EMAIL = Console.ReadLine();
                        ca.addCustomer(c);
                        i++;
                        break;

                    case 2:
                        //for (int j = 0; j < i; j++)
                        //{
                            ca.showAllCustomers();
                       // }
                        break;

                    case 3:
                        Customer c2 = new Customer();
                        Console.WriteLine("Enter customer Id:");
                        custid = Convert.ToInt32(Console.ReadLine());                        
                        c2 = ca[custid-1];
                        Console.WriteLine("Id: " + custid);
                        Console.WriteLine("Name: "+c2.NAME);
                        Console.WriteLine("Address: " + c2.ADDRESS);
                        Console.WriteLine("Phone: " + c2.PHONE);
                        Console.WriteLine("City: " + c2.CITY);
                        Console.WriteLine("State: " + c2.STATE);
                        Console.WriteLine("Pincode: " + c2.PINCODE);
                        Console.WriteLine("Email: " + c2.EMAIL);
                        Console.WriteLine("\n");
                        break;
                }
            } while (true);
        }
    }
}
