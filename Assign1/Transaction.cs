using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    class Transaction
    {
        private DateTime timeOfTransaction;
        private string userID;
        private Cart paidCart;
        public Transaction(string customerID, Cart paidCart)
        {
            timeOfTransaction = DateTime.Now;
            userID = customerID;
            this.paidCart = paidCart;
        }
        public DateTime TransactionTime
        {
            get { return timeOfTransaction; }
        }
        public string CustomerID
        {
            get { return userID; }
        }
        public Cart TransactionCart
        {
            get { return paidCart; }
        }

    }
}
