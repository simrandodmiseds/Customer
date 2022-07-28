using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class CustomerArray
    {
        Customer[] custarr = new Customer[10];
        int i = 0;
        int cusid=0;
        
        public void addCustomer(Customer c)
        {
            c.cusid++;
            c.CUSTID++;
            //for (int i = 0; i < custarr.Length; i++)
            //{
                custarr[i] =  c;
            i++;
            //break;
            //}
            ////Customer []c = new CustomerArray[10];
            ////for(int i=0;i<c.Length;i++)
            ////{
            ////    c[i].custid++;
            ////    break;
            ////}

        }
        
        public Customer this[int index]
        {
            set
            {
                custarr[index] = value;
            }
            get
            {
                return custarr[index];
            }
        }
        public void showAllCustomers()
        {
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine("Id:" + (j+1));
                Console.WriteLine("Name:" + custarr[j].NAME);
                Console.WriteLine("Address:" + custarr[j].ADDRESS);
                Console.WriteLine("Phone:" + custarr[j].PHONE);
                Console.WriteLine("City:" + custarr[j].CITY);
                Console.WriteLine("State:" + custarr[j].STATE);
                Console.WriteLine("Pincode:" + custarr[j].PINCODE);
                Console.WriteLine("Email:" + custarr[j].EMAIL);
                Console.WriteLine("\n");
            }
        }
    }
}
