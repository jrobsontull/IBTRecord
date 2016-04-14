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
    public partial class PrintOptions : Form
    {
        public static ListView raw = new ListView();

        public PrintOptions(ListView rawData)
        {
            InitializeComponent();

            raw = rawData;
        }

        // DEEP COPY METHOD - needed for ListViewPrinter
        private ListView generateEmptyClone(ListView toClone)
        {
            ListView newCopy = new ListView();

            //foreach (ColumnHeader head in toClone.Columns)
            //{
            //    newCopy.Columns.Add((ColumnHeader)head.Clone());
            //}
            foreach (var propToClone in toClone.GetType().GetProperties())
            {
                PropertyInfo propInfo = newCopy.GetType().GetProperty(propToClone.Name);
                if (propInfo.CanWrite)
                    propInfo.SetValue(newCopy, propToClone.GetValue(toClone, null));
            }

            return newCopy;
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
            ListView result = generateEmptyClone(raw);
            result.Items.Clear();
            
            for (int i = 0; i < raw.Items.Count; i++)
            {
                if (raw.Items[i].SubItems[0].Text.ToUpper() == "COLLECTED")
                {
                    result.Items.Add((ListViewItem)raw.Items[i].Clone()); // generating erros
                }
            }
            MessageBox.Show(result.Items.Count.ToString());
            //printUsingLView(result);
        }

        
    }
}
