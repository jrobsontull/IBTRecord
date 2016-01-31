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
    public partial class AddNoteForm : Form
    {
        public AddNoteForm(string prevNote)
        {
            InitializeComponent();
            noteTxtBox.Text = prevNote;
        }

        public string note
        {
            get;
            set;
        }
        public bool notePresent
        {
            get;
            set;
        }

        private void okayBtn_Click(object sender, EventArgs e)
        {
            if (noteTxtBox.Text != String.Empty)
            {
                notePresent = true;
                note = noteTxtBox.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void delNoteBtn_Click(object sender, EventArgs e)
        {
            notePresent = false;
            this.DialogResult = DialogResult.OK;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
