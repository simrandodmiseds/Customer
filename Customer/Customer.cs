using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class Customer:CustomerArray
    {
        public int cusid;
        //,pincode;
        //protected string name, Address, phone,city,state,email;

        public int CUSTID
        {
            set
            {
                cusid = value;
            }

            get
            {
                return cusid;
            }
        }
        public string NAME { set; get; }
        public string ADDRESS { set; get; }
        public string PHONE { set; get; }
        public string CITY { set; get; }
        public string STATE { set; get; }
        public int PINCODE { set; get; }
        public string EMAIL { set; get; }
        
    }
}
