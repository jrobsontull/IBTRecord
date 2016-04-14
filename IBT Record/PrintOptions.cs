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
//using System.IO;

namespace IBT_Record
{
    public partial class PrintOptions : Form
    {
        private ListView raw = new ListView();

        public PrintOptions(ListView rawData)
        {
            InitializeComponent();

            raw = rawData;
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

        // DEBUGGING
        //private void propPrinter(string fileLoc, ListView l)
        //{
        //    string s = String.Empty;
        //    foreach (var prop in l.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public))
        //    {
        //        if (prop.GetValue(l, null) != null)
        //            s += (prop.Name + " = " + prop.GetValue(l, null).ToString() + Environment.NewLine);
        //    }
        //    using (StreamWriter sWr = new StreamWriter(fileLoc))
        //    {
        //        sWr.Write(s);
        //    }
        //}

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
            //lPrinter.PrintWithDialog(); - introduce print dialog tick
            lPrinter.PrintPreview();
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

        
    }
}
