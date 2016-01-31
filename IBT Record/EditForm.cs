using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace IBT_Record
{
    public partial class EditForm : Form
    {
        public EditForm(Customer customer)
        {
            InitializeComponent();

            // Load in details
            statusTxtBox.Text = customer.status;
            nameTxtBox.Text = customer.customerName;
            contactNumTxtBox.Text = customer.phoneNumber;
            dateStartTxtBox.Text = customer.dateStarted;
            skuTxtBox.Text = customer.sku;
            descriptionTxtBox.Text = customer.description;

            if (customer.requestedFrom != null && customer.requestedFrom != String.Empty)
                requestedTxtBox.Text = customer.requestedFrom;
            if (customer.ibtNumber != null && customer.ibtNumber != String.Empty)
                ibtNumTxtBox.Text = customer.ibtNumber;

            if (customer.customerCalled != null && customer.customerCalled != String.Empty)
            {
                if (Regex.IsMatch(customer.customerCalled, "YES", RegexOptions.IgnoreCase))
                {
                    calledCheckBox.Checked = true;
                    if (Regex.Match(customer.customerCalled, @"\d{2}(/|-)\d{2}(/|-)(\d{4}|\d{2})").Success)
                    {
                        calledDateTxtBox.Text = Regex.Match(customer.customerCalled, @"\d{2}(/|-)\d{2}(/|-)(\d{4}|\d{2})").Value;
                        calledCheckBox.Checked = true;
                    }
                    else
                    {
                        MessageBox.Show("The call date field is not written in the correct form.\nExample of how it should be written: Yes - dd/mm/year",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        calledDateTxtBox.Text = customer.customerCalled;
                    }
                }
                else
                {
                    MessageBox.Show("The call date field is not written in the correct form.\nExample of how it should be written: Yes - dd/mm/year",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    calledDateTxtBox.Text = customer.customerCalled;
                }
            }

            if (customer.collected != null && customer.collected != String.Empty)
            {
                if (Regex.IsMatch(customer.collected, "COLLECTED", RegexOptions.IgnoreCase))
                {
                    collectedCheckBox.Checked = true;
                    if (Regex.Match(customer.collected, @"\d{2}(/|-)\d{2}(/|-)(\d{4}|\d{2})").Success)
                    {
                        collectedDateTxtBox.Text = Regex.Match(customer.collected, @"\d{2}(/|-)\d{2}(/|-)(\d{4}|\d{2})").Value;
                    }
                    else
                    {
                        MessageBox.Show("The collected field is not written in the correct format.\nExample of how it should be written: Collected - dd/mm/year",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        collectedDateTxtBox.Text = customer.collected;
                    }
                }
                else
                {
                    MessageBox.Show("The collected field is not written in the correct format.\nExample of how it should be written: Collected - dd/mm/year",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    collectedDateTxtBox.Text = customer.collected;
                }
            }
        }

        // Variables to pass to main form
        public string status
        {
            get { return statusTxtBox.Text; }
        }
        public string name
        {
            get { return nameTxtBox.Text; }
        }
        public string contactNum
        {
            get { return contactNumTxtBox.Text; }
        }
        public string dateStarted
        {
            get { return dateStartTxtBox.Text; }
        }
        public string refNum
        {
            get { return skuTxtBox.Text; }
        }
        public string description
        {
            get { return descriptionTxtBox.Text; }
        }
        public string requested
        {
            get { return requestedTxtBox.Text; }
        }
        public string ibtNum
        {
            get { return ibtNumTxtBox.Text; }
        }
        public string called
        {
            get 
            {
                if (calledCheckBox.Checked && calledDateTxtBox.Text != String.Empty && calledDateTxtBox.Text != null)
                    return "Yes - " + calledDateTxtBox.Text;
                else
                    return String.Empty;
            }
        }
        public string collected
        {
            get
            {
                if (collectedCheckBox.Checked && collectedDateTxtBox.Text != String.Empty && collectedDateTxtBox.Text != null)
                    return "Collected - " + collectedDateTxtBox.Text;
                else
                    return String.Empty;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Tell MainWindow that user finished
            this.DialogResult = DialogResult.OK;

            // validate forms first!!!!
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
