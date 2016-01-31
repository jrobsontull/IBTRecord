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
    public partial class SubwarehouseForm : Form
    {
        public SubwarehouseForm(string initialsForm)
        {
            InitializeComponent();
            initialsTxtBox.Text = initialsForm;
        }

        public string initials
        {
            get;
            set;
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            if (initialsTxtBox.Text != String.Empty && passTxtBox.Text != String.Empty && passTxtBox.Text == "SVEN")
            {
                initials = initialsTxtBox.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("You need to fill in both boxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
