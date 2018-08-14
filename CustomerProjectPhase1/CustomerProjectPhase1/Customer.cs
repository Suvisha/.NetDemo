using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleLayer
{
    public class CustomerBase
    {
        public string CustomerName { get; set; }
        public string PhoneName { get; set; }
        public decimal BillAmount { get; set; }
        public DateTime BillDate { get; set; }
        public string address { get; set; }
        public virtual void validate()
        {
            throw Exception("Not Implemented");
        }

        private Exception Exception(string p)
        {
            throw new NotImplementedException();
        }
    }

    public class Customer : CustomerBase
    {
        public override void validate()
        {
            if(CustomerName.Length==0)
            {
                throw Exception("Customer Name is required");
            }
            if (PhoneName.Length== 0)
            {
                throw Exception("Customer Name is required");
            } 
            if (BillAmount == 0)
            {
                throw Exception("Customer Name is required");
            } 
            if (BillDate>= DateTime.Now)
            {
                throw Exception("Customer Name is required");
            }
            if (address.Length== 0)
            {
                throw Exception("Customer Name is required");
            }
        }

        private Exception Exception(string p)
        {
            throw new NotImplementedException();
        }
        
    }
    public class Lead : CustomerBase
    {
        public override void validate()
        {
            if (CustomerName.Length == 0)
            {
                throw Exception("Customer Name is required");
            }
            if (PhoneName.Length == 0)
            {
                throw Exception("Customer Name is required");
            } 
        }

        private Exception Exception(string p)
        {
            throw new NotImplementedException();
        } 
    }

}
