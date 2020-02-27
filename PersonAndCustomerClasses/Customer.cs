using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAndCustomerClasses
{
    //creates a derived class named Customer from base class Person
    class Customer : Person
    {
        //declare variable fields
        int customerNumber;
        bool mailingList;

        //declare CustomerNumber property associated with customerNumber field
        public int CustomerNumber
        {
            get { return customerNumber; } //returns value of variable customerNumber
            set { customerNumber = value; } //assigns value of variable customerNumber
        }

        //declare Mailinglist property associated with mailingList field
        public bool MailingList
        {
            get { return mailingList; } //returns value of variable mailingList
            set { mailingList = value; } //assigns value of variable mailingList
        }
    }
}
