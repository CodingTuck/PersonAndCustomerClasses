using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAndCustomerClasses
{
    class Person
    {
        //declare variable fields
        string personName;
        string address;
        string phoneNumber;

        //declare PersonName property associated with personName field
        public string PersonName
        {
            get { return personName; } //returns value of variable name
            set { personName = value; } //assigns value to name variable
        }
        //declare Address property associated with address field
        public string Address
        {
            get { return address; } //returns value of variable address
            set { address = value; } //assigns value to address variable
        }
        //declare PhoneNumber associated with phoneNumber field
        public string PhoneNumber
        {
            get { return phoneNumber; } //returns value of variable phoneNumber
            set { phoneNumber = value; } //assigns value to phoneNumber variable
        }
    }
}
