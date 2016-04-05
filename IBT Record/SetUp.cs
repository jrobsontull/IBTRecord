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
            storeNumber = Convert.ToInt16(storeNum.Value);
            initials = initialsTxtBox.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
