using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Member
    {
        public string membername;
        public string memberID;
        public List<Book> booksbought = new List<Book>();
        public int numberofboughtbooks;
        public double balance;
        public double amountspent;
        public Member(string membername, string memberID, int number, float balance, float amountspent)
        {
            this.membername = membername;
            this.memberID = memberID;
            this.numberofboughtbooks = number;
            this.balance = balance;
            this.amountspent = amountspent;
        }
        public string memberDetails()
        {
            return $" {membername} \t {memberID} \t\t {numberofboughtbooks} \t\t {balance} \t\t\t {amountspent}";
        }
        public bool editmember(string name, string ID)
        {
            membername = name;
            memberID = ID;
            return true;
        }
        public bool purchasebooks(Book purchasedbook, int qty)
        {
            if (qty <= purchasedbook.stock)
            {
                double discountedprice = 0;
                double total = 0;
                if (memberID != "0")
                {
                    discountedprice = purchasedbook.price - (purchasedbook.price * 0.05);
                    total = discountedprice * qty;
                    if (total <= balance)
                    {
                        booksbought.Add(purchasedbook);
                        numberofboughtbooks += qty;
                        balance -= total;
                        amountspent += total;
                        purchasedbook.stock -= qty;
                        return true;
                    }
                        return false;
                }
                else if (memberID == "0")
                {
                    total = purchasedbook.price * qty;
                    if (total <= balance)
                    {
                        booksbought.Add(purchasedbook);
                        numberofboughtbooks += qty;
                        balance -= total;
                        amountspent += total;
                        purchasedbook.stock -= qty;
                        return true;
                    }
                        return false;
                }
            }
            return false;
        }
    }
}

