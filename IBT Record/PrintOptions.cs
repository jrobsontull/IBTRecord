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
using System.IO;

namespace IBT_Record
{
    public partial class PrintOptions : Form
    {
        private ListView raw = new ListView();
        MainWindow.Config config = new MainWindow.Config();

        public PrintOptions(ListView rawData, MainWindow.Config c)
        {
            InitializeComponent();

            raw = rawData;
            config = c;

            fromDate.Value = toDate.Value = DateTime.Now;
        }

        private void printUsingLView(ListView toPrint)
        {
            ListViewPrinter lPrinter = new ListViewPrinter();
            lPrinter.ListView = toPrint;

            // Formatting
            lPrinter.DefaultPageSettings.Landscape = true;
            lPrinter.Header = lPrinter.DocumentName = String.Format("IBT Record ({0}) - {1}", 
                config.storeNumber,
                DateTime.Now.ToShortDateString());
            lPrinter.Footer = String.Format("Page {0}", (lPrinter.PageNumber + 1));

            lPrinter.HeaderFormat.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Regular);
            lPrinter.HeaderFormat.BackgroundColor = Color.White;
            lPrinter.HeaderFormat.TextColor = Color.Black;
            lPrinter.ListGridColor = Color.Gray;

            if (printPreviewCheckBox.Checked)
                lPrinter.PrintPreview();
            else
                lPrinter.PrintWithDialog();
        }

        // DEBUGGING
        private void propPrinter(string fileLoc, ListView l)
        {
            string s = String.Empty;
            foreach (var prop in l.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public))
            {
                if (prop.Name != "TopItem")
                {
                    if (prop.GetValue(l, null) != null)
                        s += (prop.Name + " = " + prop.GetValue(l, null).ToString() + Environment.NewLine);
                }
            }
            using (StreamWriter sWr = new StreamWriter(fileLoc))
            {
                sWr.Write(s);
            }
        }

        // DEEP COPY METHOD - needed for ListViewPrinter
        private ListView generateEmptyClone(ListView toClone)
        {
            ListView newCopy = new ListView();
            
            // Creates strange errors
            //foreach (var propToClone in toClone.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public))
            //{
            //    PropertyInfo propInfo = newCopy.GetType().GetProperty(propToClone.Name);
            //    if (propInfo.CanWrite && propInfo.Name != "TopItem") // TopItem causing problems
            //        propInfo.SetValue(newCopy, propToClone.GetValue(toClone, null));
            //}

            newCopy.Alignment = ListViewAlignment.Top;
            newCopy.BorderStyle = BorderStyle.Fixed3D;
            newCopy.BackgroundImageTiled = false;
            newCopy.Font = new Font("Mircosoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, (byte)(0));
            newCopy.ForeColor = SystemColors.MenuText;
            newCopy.GridLines = true;
            newCopy.Margin = new Padding(3, 2, 3, 2);
            newCopy.Name = "EmptyListView";
            newCopy.Scrollable = true;
            newCopy.ShowGroups = false;
            newCopy.ShowItemToolTips = true;
            newCopy.Size = new Size(691, 493);
            newCopy.TabIndex = 0;
            newCopy.View = View.Details;


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
            using (ListView result = generateEmptyClone(raw))
            {
                for (int i = 0; i < raw.Items.Count; i++)
                {
                    if (raw.Items[i].SubItems[0].Text.ToUpper() == "COLLECTED")
                    {
                        result.Items.Add((ListViewItem)raw.Items[i].Clone());
                    }
                }

                printUsingLView(result);
            }
        }

        private void printUncompleteBtn_Click(object sender, EventArgs e)
        {
            using (ListView result = generateEmptyClone(raw))
            {

                for (int i = 0; i < raw.Items.Count; i++)
                {
                    if (raw.Items[i].SubItems[0].Text.ToUpper() != "COLLECTED")
                    {
                        result.Items.Add((ListViewItem)raw.Items[i].Clone());
                    }
                }

                printUsingLView(result);
            }
        }

        private void printDateBtn_Click(object sender, EventArgs e)
        {
            if (fromDate.Value <= toDate.Value)
            {
                using (ListView result = generateEmptyClone(raw))
                {
                    for (int i = 0; i < raw.Items.Count; i++)
                    {
                        if (DateTime.Parse(raw.Items[i].SubItems[3].Text).Date >= fromDate.Value.Date
                            && DateTime.Parse(raw.Items[i].SubItems[3].Text).Date <= toDate.Value.Date)
                        {
                            result.Items.Add((ListViewItem)raw.Items[i].Clone());
                        }
                    }

                    printUsingLView(result);
                }
            }
            else
            {
                MessageBox.Show("The from date must before or equal to the to date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        
    }
}
