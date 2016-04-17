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
        private ListView raw = new ListView();

        public PrintOptions(ListView rawData)
        {
            InitializeComponent();

            raw = rawData;

            fromDate.Value = toDate.Value = DateTime.Now;
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
            //lPrinter.PrintWithDialog(); - introduce print dialog tick
            lPrinter.PrintPreview();
        }

        // DEEP COPY METHOD - needed for ListViewPrinter
        private ListView generateEmptyClone(ListView toClone)
        {
            ListView newCopy = new ListView();
   
            foreach (var propToClone in toClone.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public))
            {
                PropertyInfo propInfo = newCopy.GetType().GetProperty(propToClone.Name);
                if (propInfo.CanWrite && propInfo.Name != "TopItem") // TopItem causing problems
                    propInfo.SetValue(newCopy, propToClone.GetValue(toClone, null));
            }

            foreach (ColumnHeader head in toClone.Columns)
            {
                newCopy.Columns.Add((ColumnHeader)head.Clone());
            }

            return newCopy;
        }

        private void printAllBtn_Click(object sender, EventArgs e)
        {
            printUsingLView(raw);
        }

        private void printCompletedBtn_Click(object sender, EventArgs e)
        {
            ListView result = generateEmptyClone(raw);
            
            for (int i = 0; i < raw.Items.Count; i++)
            {
                if (raw.Items[i].SubItems[0].Text.ToUpper() == "COLLECTED")
                {
                    result.Items.Add((ListViewItem)raw.Items[i].Clone());
                }
            }

            printUsingLView(result);
            result.Dispose(); // speeds up app exit
        }

        private void printUncompleteBtn_Click(object sender, EventArgs e)
        {
            ListView result = generateEmptyClone(raw);

            for (int i = 0; i < raw.Items.Count; i++)
            {
                if (raw.Items[i].SubItems[0].Text.ToUpper() != "COLLECTED")
                {
                    result.Items.Add((ListViewItem)raw.Items[i].Clone());
                }
            }

            printUsingLView(result);
            result.Dispose(); // speeds up app exit
        }

        private void printDateBtn_Click(object sender, EventArgs e)
        {
            if (fromDate.Value <= toDate.Value)
            {
                ListView result = generateEmptyClone(raw);

                for (int i = 0; i < raw.Items.Count; i++)
                {
                    if (DateTime.Parse(raw.Items[i].SubItems[3].Text).Date >= fromDate.Value.Date
                        && DateTime.Parse(raw.Items[i].SubItems[3].Text).Date <= toDate.Value.Date)
                    {
                        result.Items.Add((ListViewItem)raw.Items[i].Clone());
                    }
                }

                printUsingLView(result);
                result.Dispose();
            }
            else
            {
                MessageBox.Show("The from date must before or equal to the to date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        
    }
}
