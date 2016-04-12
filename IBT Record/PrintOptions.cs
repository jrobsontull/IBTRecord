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
    public partial class PrintOptions : Form
    {
        ListView raw;

        public PrintOptions(ListView rawData)
        {
            InitializeComponent();
            raw = rawData;
        }

        private void printAllBtn_Click(object sender, EventArgs e)
        {
            printUsingLView(raw);
        }

        private void printUsingLView(ListView toPrint)
        {
            ListViewPrinter lPrinter = new ListViewPrinter();
            lPrinter.ListView = toPrint;
            // Formatting
            lPrinter.DefaultPageSettings.Landscape = true;
            lPrinter.Header = "IBT Record - " + DateTime.Now.ToShortDateString();
            lPrinter.HeaderFormat.BackgroundColor = Color.White;
            lPrinter.HeaderFormat.TextColor = Color.Black;
            lPrinter.ListGridColor = Color.Gray;
            lPrinter.PrintWithDialog();
        }

        private void printCompletedBtn_Click(object sender, EventArgs e)
        {
            ListView result = new ListView();
            for (int i = 0; i < raw.Items.Count; i++)
            {
                if (raw.Items[i].SubItems[0].Text.ToUpper() == "COLLECTED")
                {
                }
            }
            printUsingLView(result);
        }
    }
}
