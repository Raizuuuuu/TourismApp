using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    class Cart : TourCollection
    {
        private bool isPaid;
        public Cart(bool lockState) : base(lockState)
        {
            isPaid = false;
        }
        public bool PaymentDone
        {
            get { return isPaid; } //this property should not be editable by other objects
        }
        public string getReceipt()
        {
            string receipt = string.Empty;
            foreach (Tour t in this)
            {
                receipt += t.getDetails()+"\n";
            }
            receipt += "Total Payable Fees\t\t" + getSum();
            return receipt;
        }
        public double getSum()
        {
            double total = 0;
            foreach (Tour t in this)
            {
                total += t.Price;
            }
            return total;
        }
        public Transaction checkOut(string userID)
        {
            Transaction record = new Transaction(userID, this); //TODO: pass parameters
            //if constructor completes without errors/exceptions
            //proceed to mark as paid and make cart read only
            IsReadOnly = true;
            return record;
        }
    }
}
