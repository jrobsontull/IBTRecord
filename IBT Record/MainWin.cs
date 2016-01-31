using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace IBT_Record
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // GLOBALS
        string fileLocation = AppDomain.CurrentDomain.BaseDirectory + "Database_IBT.xml";
        

        // Load in table data
        private void MainWindow_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(fileLocation)) 
                {
                    XRead();
                }
                else
                {                  
                    XmlTextWriter xWrite = new XmlTextWriter(fileLocation, Encoding.UTF8);
                    xWrite.WriteStartElement("IBTRecord");
                    xWrite.WriteEndElement();
                    xWrite.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // XML FUNCTIONS
        private void XUpdate()
        {
            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(fileLocation);

                // Clear data before
                XmlNode xNode = xDoc.SelectSingleNode("IBTRecord");
                xNode.RemoveAll();

                foreach (ListViewItem iEntry in TableDisplay.Items)
                {
                    XmlNode xTop = xDoc.CreateElement("IBT");
                    XmlNode xStatus = xDoc.CreateElement("Status");
                    XmlNode xName = xDoc.CreateElement("Name");
                    XmlNode xNum = xDoc.CreateElement("ContactNumber");
                    XmlNode xDateStart = xDoc.CreateElement("DateStarted");
                    XmlNode xSKU = xDoc.CreateElement("SKU");
                    XmlNode xDescrip = xDoc.CreateElement("Description");
                    XmlNode xRequested = xDoc.CreateElement("RequestedFrom");
                    XmlNode xIBTNum = xDoc.CreateElement("IBTNumber");
                    XmlNode xChecked = xDoc.CreateElement("IBTChecked");
                    XmlNode xCalled = xDoc.CreateElement("CustomerCalled");
                    XmlNode xCollected = xDoc.CreateElement("Collected"); 
                    XmlNode xNote = xDoc.CreateElement("Note");

                    xStatus.InnerText = iEntry.Text;
                    xName.InnerText = iEntry.SubItems[1].Text;
                    xNum.InnerText = iEntry.SubItems[2].Text;
                    xDateStart.InnerText = iEntry.SubItems[3].Text;
                    xSKU.InnerText = iEntry.SubItems[4].Text;
                    xDescrip.InnerText = iEntry.SubItems[5].Text;
                    if (iEntry.SubItems.Count > 6)
                        xRequested.InnerText = iEntry.SubItems[6].Text;
                    if (iEntry.SubItems.Count > 7)
                        xIBTNum.InnerText = iEntry.SubItems[7].Text;
                    if (iEntry.SubItems.Count > 8)
                        xChecked.InnerText = iEntry.SubItems[8].Text;
                    if (iEntry.SubItems.Count > 9)
                        xCalled.InnerText = iEntry.SubItems[9].Text;
                    if (iEntry.SubItems.Count > 10)
                        xCollected.InnerText = iEntry.SubItems[10].Text;
                    

                    xNote.InnerText = iEntry.ToolTipText;

                    xTop.AppendChild(xStatus);
                    xTop.AppendChild(xName);
                    xTop.AppendChild(xNum);
                    xTop.AppendChild(xDateStart);
                    xTop.AppendChild(xSKU);
                    xTop.AppendChild(xDescrip);
                    xTop.AppendChild(xRequested);
                    xTop.AppendChild(xIBTNum);
                    xTop.AppendChild(xChecked);
                    xTop.AppendChild(xCalled);
                    xTop.AppendChild(xCollected);
                    xTop.AppendChild(xNote);
                    xDoc.DocumentElement.AppendChild(xTop);
                }

                xDoc.Save(fileLocation);
                  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void XRead()
        {
            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(fileLocation);

                foreach (XmlNode xNode in xDoc.SelectNodes("IBTRecord/IBT"))
                {
                    string[] ibtToReadIn = {xNode.SelectSingleNode("Status").InnerText,
                                           xNode.SelectSingleNode("Name").InnerText,
                                           xNode.SelectSingleNode("ContactNumber").InnerText,
                                           xNode.SelectSingleNode("DateStarted").InnerText,
                                           xNode.SelectSingleNode("SKU").InnerText,
                                           xNode.SelectSingleNode("Description").InnerText,
                                           xNode.SelectSingleNode("RequestedFrom").InnerText,
                                           xNode.SelectSingleNode("IBTNumber").InnerText,
                                           xNode.SelectSingleNode("IBTChecked").InnerText,
                                           xNode.SelectSingleNode("CustomerCalled").InnerText,
                                           xNode.SelectSingleNode("Collected").InnerText};
                    var listItem = new ListViewItem(ibtToReadIn);

                    listItem.ToolTipText = xNode.SelectSingleNode("Note").InnerText;

                    listItem.Font = new Font(listItem.Font.ToString(), 9.0F, FontStyle.Regular);
                    TableDisplay.Items.Add(listItem);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.ToUpper() == "ROOT ELEMENT IS MISSING.")
                {
                    XmlTextWriter xWrite = new XmlTextWriter(fileLocation, Encoding.UTF8);
                    xWrite.WriteStartElement("IBTRecord");
                    xWrite.WriteEndElement();
                    xWrite.Close();

                    XRead(); // retry
                }
                else
                {
                    MessageBox.Show(ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // BUTTONS
        // New IBT Button
        private void newIBTBtn_Click(object sender, EventArgs e)
        {
            string customerName = String.Empty;
            string contactNum = String.Empty;
            string date = DateTime.Now.ToShortDateString();
            string SKU = String.Empty;
            string itemDescription = String.Empty;

            using (NewIBTForm ibtForm = new NewIBTForm())
            {
                DialogResult dResult = ibtForm.ShowDialog();
                if (dResult == DialogResult.OK)
                {
                    // Grab data from NewIBTForm
                    customerName = ibtForm.name;
                    contactNum = ibtForm.contactNum;
                    SKU = ibtForm.refNum;
                    itemDescription = ibtForm.description;

                    // Add item to TableDisplay (list view)
                    string emp = String.Empty; // workaround
                    string[] customerToAdd = { "To IBT", customerName, contactNum, date, SKU, itemDescription,
                                                 emp, emp, emp, emp, emp};
                    var listViewItem = new ListViewItem(customerToAdd);
                    listViewItem.Font = new Font(listViewItem.Font, FontStyle.Regular);
                    TableDisplay.Items.Insert(0, listViewItem); // use of insert function to put to top of list
                }
            }

            XUpdate();
            TableDisplay.Items[0].Selected = true; // select new IBT
            TableDisplay.Select();
        }

        // Edit Entry Button
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (TableDisplay.SelectedItems.Count > 0)
            {
                // Parse data to customer class
                Customer selectedIBT = new Customer();
                ListViewItem rowSelected = TableDisplay.SelectedItems[0]; // for less typing
                selectedIBT.status = rowSelected.Text;
                selectedIBT.customerName = rowSelected.SubItems[1].Text;
                selectedIBT.phoneNumber = rowSelected.SubItems[2].Text;
                selectedIBT.dateStarted = rowSelected.SubItems[3].Text;
                selectedIBT.sku = rowSelected.SubItems[4].Text;
                selectedIBT.description = rowSelected.SubItems[5].Text;

                if (rowSelected.SubItems.Count > 6)
                {
                    selectedIBT.requestedFrom = rowSelected.SubItems[6].Text;
                    if (rowSelected.SubItems.Count > 7)
                    {
                        selectedIBT.ibtNumber = rowSelected.SubItems[7].Text;
                        if (rowSelected.SubItems.Count > 8)
                        {
                            selectedIBT.ibtChecked = rowSelected.SubItems[8].Text;
                            if (rowSelected.SubItems.Count > 9)
                            {
                                selectedIBT.customerCalled = rowSelected.SubItems[9].Text;
                                if (rowSelected.SubItems.Count > 10)
                                    selectedIBT.collected = rowSelected.SubItems[10].Text;
                            }
                        }
                    }
                }

                // Open new form
                using (EditForm newEditForm = new EditForm(selectedIBT))
                {
                    DialogResult dResult = newEditForm.ShowDialog();
                    if (dResult == DialogResult.OK)
                    {
                        rowSelected.Text = newEditForm.status;
                        rowSelected.SubItems[1].Text = newEditForm.name;
                        rowSelected.SubItems[2].Text = newEditForm.contactNum;
                        rowSelected.SubItems[3].Text = newEditForm.dateStarted;
                        rowSelected.SubItems[4].Text = newEditForm.refNum;
                        rowSelected.SubItems[5].Text = newEditForm.description;
                        rowSelected.SubItems[6].Text = newEditForm.requested;
                        rowSelected.SubItems[7].Text = newEditForm.ibtNum;
                        rowSelected.SubItems[9].Text = newEditForm.called;
                        rowSelected.SubItems[10].Text = newEditForm.collected;
                    }
                }

                XUpdate();
                refreshButtonStates();
                TableDisplay.Select();
            }
            else
            {
                MessageBox.Show("You first need to select an IBT to edit.", 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
        }

        // Print Button
        private void printBtn_Click(object sender, EventArgs e)
        {
            ListViewPrinter lPrinter = new ListViewPrinter();
            lPrinter.ListView = TableDisplay;
            // Formatting
            lPrinter.DefaultPageSettings.Landscape = true;
            lPrinter.Header = "IBT Record - " + DateTime.Now.ToShortDateString();
            lPrinter.HeaderFormat.BackgroundColor = Color.White;
            lPrinter.HeaderFormat.TextColor = Color.Black;
            lPrinter.ListGridColor = Color.Gray;
            lPrinter.PrintWithDialog();
        }

        // Button Access Control
        private void TableDisplay_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                editBtn.Enabled = true;
                deleteIBTBtn.Enabled = true;
                addNoteBtn.Enabled = true;
                subwarehouseBtn.Enabled = true;

                // Reset button states
                requestedBtn.Enabled = false;
                addIBTNumBtn.Enabled = false;
                customerCalledBtn.Enabled = false;
                collectedBtn.Enabled = false;

                if (e.IsSelected) // stops firing twice
                {
                    ListViewItem rowSelected = TableDisplay.SelectedItems[0];
                    if (rowSelected.SubItems.Count > 5 && rowSelected.SubItems[6].Text == null || rowSelected.SubItems[6].Text == String.Empty)
                            requestedBtn.Enabled = true;
                    if (rowSelected.SubItems.Count > 6 && rowSelected.SubItems[7].Text == null || rowSelected.SubItems[7].Text == String.Empty)
                            addIBTNumBtn.Enabled = true;
                    // ignore ibtCheckedBtn as always true
                    if (rowSelected.SubItems.Count > 8 && rowSelected.SubItems[9].Text == null || rowSelected.SubItems[9].Text == String.Empty)
                        customerCalledBtn.Enabled = true;
                    if (rowSelected.SubItems.Count > 9 && rowSelected.SubItems[10].Text == null || rowSelected.SubItems[10].Text == String.Empty)
                        collectedBtn.Enabled = true;
                }
                else if (TableDisplay.SelectedItems.Count == 0)
                {
                    editBtn.Enabled = false;
                    deleteIBTBtn.Enabled = false;
                    addNoteBtn.Enabled = false;
                    subwarehouseBtn.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Refresh Button States - MANUAL (USE WITH CARE)
        private void refreshButtonStates()
        {
            try
            {
                editBtn.Enabled = true;
                deleteIBTBtn.Enabled = true;
                addNoteBtn.Enabled = true;
                subwarehouseBtn.Enabled = true;

                // Reset button states
                requestedBtn.Enabled = false;
                addIBTNumBtn.Enabled = false;
                customerCalledBtn.Enabled = false;
                collectedBtn.Enabled = false;

                
                ListViewItem rowSelected = TableDisplay.SelectedItems[0];
                if (rowSelected.SubItems.Count > 5 && rowSelected.SubItems[6].Text == null || rowSelected.SubItems[6].Text == String.Empty)
                    requestedBtn.Enabled = true;
                if (rowSelected.SubItems.Count > 6 && rowSelected.SubItems[7].Text == null || rowSelected.SubItems[7].Text == String.Empty)
                    addIBTNumBtn.Enabled = true;
                // miss out ibtChecked column as always on if selected
                if (rowSelected.SubItems.Count > 8 && rowSelected.SubItems[9].Text == null || rowSelected.SubItems[9].Text == String.Empty)
                    customerCalledBtn.Enabled = true;
                if (rowSelected.SubItems.Count > 9 && rowSelected.SubItems[10].Text == null || rowSelected.SubItems[10].Text == String.Empty)
                    collectedBtn.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Requested Button
        private void requestedBtn_Click(object sender, EventArgs e)
        {
            using (RequestedForm rForm = new RequestedForm())
            {
                DialogResult dResult = rForm.ShowDialog();
                if (dResult == DialogResult.OK)
                {
                    TableDisplay.SelectedItems[0].SubItems[6].Text = rForm.requestedFrom;
                    TableDisplay.SelectedItems[0].Text = "In Transit";
                    XUpdate();
                    refreshButtonStates();
                    TableDisplay.Select(); // select table to highlight selectedItem
                }
            }
        }

        // Add IBT Number Button
        private void addIBTNumBtn_Click(object sender, EventArgs e)
        {
            using (AddIBTNumForm ibtNumForm = new AddIBTNumForm())
            {
                DialogResult dResult = ibtNumForm.ShowDialog();
                if (dResult == DialogResult.OK)
                {
                    TableDisplay.SelectedItems[0].SubItems[7].Text = ibtNumForm.ibtNum;
                    TableDisplay.SelectedItems[0].Text = "To Call";
                    XUpdate();
                    refreshButtonStates();
                    TableDisplay.Select();
                }
            }
        }

        // Customer Called Button
        private void customerCalledBtn_Click(object sender, EventArgs e)
        {
            TableDisplay.SelectedItems[0].SubItems[9].Text = "Yes - " + DateTime.Now.ToShortDateString();
            TableDisplay.SelectedItems[0].Text = "Awaiting Collection";
            XUpdate();
            refreshButtonStates();
            TableDisplay.Select();
        }

        // Collected Button
        private void collectedBtn_Click(object sender, EventArgs e)
        {
            TableDisplay.SelectedItems[0].SubItems[10].Text = "Collected - " + DateTime.Now.ToShortDateString();
            TableDisplay.SelectedItems[0].Text = "Collected";
            XUpdate();
            refreshButtonStates();
            TableDisplay.Select();
        }

        // IBT Checked Button
        private void subwarehouseBtn_Click(object sender, EventArgs e)
        {
            using (SubwarehouseForm sForm = new SubwarehouseForm(TableDisplay.SelectedItems[0].SubItems[8].Text))
            {
                DialogResult dResult = sForm.ShowDialog();
                if (dResult == DialogResult.OK)
                {
                    TableDisplay.SelectedItems[0].SubItems[8].Text = sForm.initials;

                    XUpdate();
                    refreshButtonStates();
                    TableDisplay.Select();
                }
            }
        }

        // Delete IBT Button
        private void deleteIBTBtn_Click(object sender, EventArgs e)
        {
            using (DeleteIBT delIBTForm = new DeleteIBT())
            {
                DialogResult dResult1 = delIBTForm.ShowDialog();
                if (dResult1 == DialogResult.OK)
                {
                    DialogResult dResult2 = MessageBox.Show("Are you sure that you want to delete the selected IBT?", 
                        "Delete IBT Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dResult2 == DialogResult.OK)
                    {
                        TableDisplay.SelectedItems[0].Remove();
                        XUpdate();
                    }
                }
            }
        }

        private void addNoteBtn_Click(object sender, EventArgs e)
        {
            using (AddNoteForm noteForm = new AddNoteForm(TableDisplay.SelectedItems[0].ToolTipText))
            {
                DialogResult dResult = noteForm.ShowDialog();
                if (dResult == DialogResult.OK)
                {
                    if (noteForm.notePresent)
                    {
                        TableDisplay.SelectedItems[0].ToolTipText = noteForm.note;
                    }
                    else
                    {
                        // Delete note
                        TableDisplay.SelectedItems[0].ToolTipText = String.Empty;
                    }

                    XUpdate();
                    refreshButtonStates();
                    TableDisplay.Select();
                }
            }
        }

        

        
    }
}
