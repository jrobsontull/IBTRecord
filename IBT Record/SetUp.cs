using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace IBT_Record
{
    public partial class SetUp : Form
    {
        // GLOBALS
        public int storeNumber;
        public string initials;
        public string ver = Assembly.GetEntryAssembly().GetName().Version.ToString().Substring(0, 3);

        public SetUp()
        {
            InitializeComponent();
            versionTxt.Text = ver;
        }

        
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            // Error checking
            if (initialsTxtBox.Text == String.Empty || initialsTxtBox.Text == null)
            {
                MessageBox.Show("You need to fill in the initials of the person who is setting up this application.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                // Confirmation
                DialogResult dRes = MessageBox.Show("Are you sure that the details are correct?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (dRes == DialogResult.OK)
                {
                    storeNumber = Convert.ToInt16(storeNum.Value);
                    initials = initialsTxtBox.Text;
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
