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
    public partial class AddIBTNumForm : Form
    {
        public AddIBTNumForm()
        {
            InitializeComponent();
        }

        public string ibtNum
        {
            get;
            set;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (ibtNumTxtBox.Text != String.Empty && Regex.Match(ibtNumTxtBox.Text, @"^(\d{4}|\d{2}|\d{1})(/|-)?\d{1}(/|-)?(\d{4}|\d{3}|\d{2})$").Success)
            {
                ibtNum = ibtNumTxtBox.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("You must enter the IBT number in the correct format:\n00/00/0000 OR 00/00/000", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
