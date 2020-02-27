using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonAndCustomerClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void subscriptionCreate_Click(object sender, EventArgs e)
        {
            //creating the object for Customer as said in instructions
            Customer displayCustomer = new Customer();

            //assign properties
            showInfo(displayCustomer);

            //display user input with the Object values
            nameOutputLabel.Text = displayCustomer.PersonName;
            addressOutputLabel.Text = displayCustomer.Address;
            phoneNumOutputLabel.Text = displayCustomer.PhoneNumber;
            customerNumOutputLabel.Text = displayCustomer.CustomerNumber.ToString();
            mailingListOutputLabel.Text = displayCustomer.MailingList.ToString();
        }

        private void showInfo (Customer displayCustomer)
        {
            
                //create local variables
                int customerNumber;
                bool mailingList;

                //checks if name textbox is empty
                if (nameTextBox.Text == null)
                    MessageBox.Show("Please enter a name");
                else
                {
                    //if name isn't empty, assigns nameTextBox to Customer Object name value
                    displayCustomer.PersonName = nameTextBox.Text;
                }

                //checks if address textbox is empty
                if (addressTextBox.Text == null)
                    MessageBox.Show("Please enter an address");
                else
                {
                    //if address isn't empty, assigns addressTextBox to Customer Object address value
                    displayCustomer.Address = addressTextBox.Text;
                }

                //checks if phone number textbox is empty
                if (phoneNumTextBox.Text == null)
                    MessageBox.Show("Please enter a phone number");
                else
                {
                    //if phone number isn't empty, assigns phoneNumTextBox to Customer Object phone number value 
                    displayCustomer.PhoneNumber = phoneNumTextBox.Text;
                }

                //checks if the customer number is an int or not
                if (int.TryParse(customerNumTextBox.Text, out customerNumber))
                {
                    //if it is an int, assigns customerNumber to Customer Object customer number value
                    displayCustomer.CustomerNumber = customerNumber;
                }
                else
                {
                    MessageBox.Show("Please enter a numeric number or input a number please");
                }

            //checks if mailing check box is checked or not and displays the according bool in Customer Object mailing list value
            if (bool.TryParse(mailingCheckBox.Checked.ToString(), out mailingList))
            {
                displayCustomer.MailingList = mailingList;
            }           

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }
    }
}
