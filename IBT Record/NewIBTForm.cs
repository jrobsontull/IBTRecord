using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBT_Record
{
    public partial class NewIBTForm : Form
    {
        public NewIBTForm()
        {
            InitializeComponent();
        }

        // Variables to pass to main form
        public string name
        {
            get { return nameTxtBox.Text; }
        }
        public string contactNum
        {
            get { return contactNumTxtBox.Text; }
        }
        public string refNum
        {
            get { return skuTxtBox.Text; }
        }
        public string description
        {
            get { return descriptionTxtBox.Text; }
        }


        private void createBtn_Click(object sender, EventArgs e)
        {
            // Validating of data
            if (nameTxtBox.Text == String.Empty || contactNumTxtBox.Text == String.Empty || skuTxtBox.Text == String.Empty || descriptionTxtBox.Text == String.Empty) {
                MessageBox.Show("You have not filled out all the required information.", 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            else
            {
                // Tell MainWindow that user finished
                this.DialogResult = DialogResult.OK;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
