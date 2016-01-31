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
    public partial class RequestedForm : Form
    {
        public RequestedForm()
        {
            InitializeComponent();
            dateTimePicker.Value = DateTime.Now;
        }

        public string requestedFrom
        {
            get;
            set;
        }

        private void isRequestedBtn_Click(object sender, EventArgs e)
        {
            if (storeListCombo.Text != String.Empty)
            {
                requestedFrom = storeListCombo.Text + " - " + dateTimePicker.Value.ToShortDateString();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("You must enter in a store name.", "Hold Your Horses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
