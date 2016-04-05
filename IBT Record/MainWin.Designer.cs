namespace IBT_Record
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.TableDisplay = new System.Windows.Forms.ListView();
            this.statusHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contactNumHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.skuHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.requestDetailsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ibtNumHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ibtCheckHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerCallHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.collectedHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newIBTBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.requestedBtn = new System.Windows.Forms.Button();
            this.addIBTNumBtn = new System.Windows.Forms.Button();
            this.customerCalledBtn = new System.Windows.Forms.Button();
            this.collectedBtn = new System.Windows.Forms.Button();
            this.subwarehouseBtn = new System.Windows.Forms.Button();
            this.manageLabel = new System.Windows.Forms.Label();
            this.printBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.deleteIBTBtn = new System.Windows.Forms.Button();
            this.addNoteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TableDisplay
            // 
            this.TableDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.statusHeader,
            this.nameHeader,
            this.contactNumHeader,
            this.dateHeader,
            this.skuHeader,
            this.descriptionHeader,
            this.requestDetailsHeader,
            this.ibtNumHeader,
            this.ibtCheckHeader,
            this.customerCallHeader,
            this.collectedHeader});
            this.TableDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableDisplay.ForeColor = System.Drawing.SystemColors.MenuText;
            this.TableDisplay.FullRowSelect = true;
            this.TableDisplay.GridLines = true;
            this.TableDisplay.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.TableDisplay.Location = new System.Drawing.Point(168, 12);
            this.TableDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TableDisplay.MultiSelect = false;
            this.TableDisplay.Name = "TableDisplay";
            this.TableDisplay.ShowGroups = false;
            this.TableDisplay.ShowItemToolTips = true;
            this.TableDisplay.Size = new System.Drawing.Size(920, 606);
            this.TableDisplay.TabIndex = 0;
            this.TableDisplay.UseCompatibleStateImageBehavior = false;
            this.TableDisplay.View = System.Windows.Forms.View.Details;
            this.TableDisplay.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.TableDisplay_ItemSelectionChanged);
            // 
            // statusHeader
            // 
            this.statusHeader.Text = "Status";
            this.statusHeader.Width = 111;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Name";
            this.nameHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameHeader.Width = 171;
            // 
            // contactNumHeader
            // 
            this.contactNumHeader.Text = "Contact No.";
            this.contactNumHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.contactNumHeader.Width = 137;
            // 
            // dateHeader
            // 
            this.dateHeader.Text = "Date Started";
            this.dateHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateHeader.Width = 123;
            // 
            // skuHeader
            // 
            this.skuHeader.Text = "SKU";
            this.skuHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skuHeader.Width = 95;
            // 
            // descriptionHeader
            // 
            this.descriptionHeader.Text = "Description";
            this.descriptionHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.descriptionHeader.Width = 199;
            // 
            // requestDetailsHeader
            // 
            this.requestDetailsHeader.Text = "Requested From";
            this.requestDetailsHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.requestDetailsHeader.Width = 141;
            // 
            // ibtNumHeader
            // 
            this.ibtNumHeader.Text = "IBT No";
            this.ibtNumHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ibtNumHeader.Width = 91;
            // 
            // ibtCheckHeader
            // 
            this.ibtCheckHeader.Text = "Subwarehouse";
            this.ibtCheckHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ibtCheckHeader.Width = 115;
            // 
            // customerCallHeader
            // 
            this.customerCallHeader.Text = "Customer Called?";
            this.customerCallHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.customerCallHeader.Width = 156;
            // 
            // collectedHeader
            // 
            this.collectedHeader.Text = "Collected?";
            this.collectedHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.collectedHeader.Width = 130;
            // 
            // newIBTBtn
            // 
            this.newIBTBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newIBTBtn.Location = new System.Drawing.Point(12, 12);
            this.newIBTBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newIBTBtn.Name = "newIBTBtn";
            this.newIBTBtn.Size = new System.Drawing.Size(149, 46);
            this.newIBTBtn.TabIndex = 2;
            this.newIBTBtn.Text = "New IBT";
            this.newIBTBtn.UseVisualStyleBackColor = true;
            this.newIBTBtn.Click += new System.EventHandler(this.newIBTBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Enabled = false;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.Location = new System.Drawing.Point(11, 404);
            this.editBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(149, 46);
            this.editBtn.TabIndex = 3;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // requestedBtn
            // 
            this.requestedBtn.Enabled = false;
            this.requestedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestedBtn.Location = new System.Drawing.Point(12, 64);
            this.requestedBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.requestedBtn.Name = "requestedBtn";
            this.requestedBtn.Size = new System.Drawing.Size(149, 46);
            this.requestedBtn.TabIndex = 4;
            this.requestedBtn.Text = "Requested";
            this.requestedBtn.UseVisualStyleBackColor = true;
            this.requestedBtn.Click += new System.EventHandler(this.requestedBtn_Click);
            // 
            // addIBTNumBtn
            // 
            this.addIBTNumBtn.Enabled = false;
            this.addIBTNumBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIBTNumBtn.Location = new System.Drawing.Point(12, 116);
            this.addIBTNumBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addIBTNumBtn.Name = "addIBTNumBtn";
            this.addIBTNumBtn.Size = new System.Drawing.Size(149, 46);
            this.addIBTNumBtn.TabIndex = 5;
            this.addIBTNumBtn.Text = "Add IBT Number";
            this.addIBTNumBtn.UseVisualStyleBackColor = true;
            this.addIBTNumBtn.Click += new System.EventHandler(this.addIBTNumBtn_Click);
            // 
            // customerCalledBtn
            // 
            this.customerCalledBtn.Enabled = false;
            this.customerCalledBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerCalledBtn.Location = new System.Drawing.Point(12, 167);
            this.customerCalledBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerCalledBtn.Name = "customerCalledBtn";
            this.customerCalledBtn.Size = new System.Drawing.Size(149, 46);
            this.customerCalledBtn.TabIndex = 6;
            this.customerCalledBtn.Text = "Customer Called";
            this.customerCalledBtn.UseVisualStyleBackColor = true;
            this.customerCalledBtn.Click += new System.EventHandler(this.customerCalledBtn_Click);
            // 
            // collectedBtn
            // 
            this.collectedBtn.Enabled = false;
            this.collectedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectedBtn.Location = new System.Drawing.Point(12, 220);
            this.collectedBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.collectedBtn.Name = "collectedBtn";
            this.collectedBtn.Size = new System.Drawing.Size(149, 66);
            this.collectedBtn.TabIndex = 7;
            this.collectedBtn.Text = "Mark as Collected";
            this.collectedBtn.UseVisualStyleBackColor = true;
            this.collectedBtn.Click += new System.EventHandler(this.collectedBtn_Click);
            // 
            // subwarehouseBtn
            // 
            this.subwarehouseBtn.Enabled = false;
            this.subwarehouseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subwarehouseBtn.Location = new System.Drawing.Point(12, 506);
            this.subwarehouseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subwarehouseBtn.Name = "subwarehouseBtn";
            this.subwarehouseBtn.Size = new System.Drawing.Size(149, 59);
            this.subwarehouseBtn.TabIndex = 8;
            this.subwarehouseBtn.Text = "Subwarehouse Check";
            this.subwarehouseBtn.UseVisualStyleBackColor = true;
            this.subwarehouseBtn.Click += new System.EventHandler(this.subwarehouseBtn_Click);
            // 
            // manageLabel
            // 
            this.manageLabel.AutoSize = true;
            this.manageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageLabel.Location = new System.Drawing.Point(11, 383);
            this.manageLabel.Name = "manageLabel";
            this.manageLabel.Size = new System.Drawing.Size(98, 18);
            this.manageLabel.TabIndex = 10;
            this.manageLabel.Text = "Management:";
            // 
            // printBtn
            // 
            this.printBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBtn.Location = new System.Drawing.Point(11, 455);
            this.printBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(149, 46);
            this.printBtn.TabIndex = 11;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(15, -5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(202, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // deleteIBTBtn
            // 
            this.deleteIBTBtn.Enabled = false;
            this.deleteIBTBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteIBTBtn.Location = new System.Drawing.Point(12, 572);
            this.deleteIBTBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteIBTBtn.Name = "deleteIBTBtn";
            this.deleteIBTBtn.Size = new System.Drawing.Size(149, 46);
            this.deleteIBTBtn.TabIndex = 13;
            this.deleteIBTBtn.Text = "Delete IBT";
            this.deleteIBTBtn.UseVisualStyleBackColor = true;
            this.deleteIBTBtn.Click += new System.EventHandler(this.deleteIBTBtn_Click);
            // 
            // addNoteBtn
            // 
            this.addNoteBtn.Enabled = false;
            this.addNoteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNoteBtn.Location = new System.Drawing.Point(12, 292);
            this.addNoteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addNoteBtn.Name = "addNoteBtn";
            this.addNoteBtn.Size = new System.Drawing.Size(149, 46);
            this.addNoteBtn.TabIndex = 14;
            this.addNoteBtn.Text = "Add/Edit Note";
            this.addNoteBtn.UseVisualStyleBackColor = true;
            this.addNoteBtn.Click += new System.EventHandler(this.addNoteBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1100, 630);
            this.Controls.Add(this.addNoteBtn);
            this.Controls.Add(this.deleteIBTBtn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.manageLabel);
            this.Controls.Add(this.subwarehouseBtn);
            this.Controls.Add(this.collectedBtn);
            this.Controls.Add(this.customerCalledBtn);
            this.Controls.Add(this.addIBTNumBtn);
            this.Controls.Add(this.requestedBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.newIBTBtn);
            this.Controls.Add(this.TableDisplay);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "IBT Record";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView TableDisplay;
        private System.Windows.Forms.ColumnHeader statusHeader;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader contactNumHeader;
        private System.Windows.Forms.ColumnHeader skuHeader;
        private System.Windows.Forms.ColumnHeader descriptionHeader;
        private System.Windows.Forms.ColumnHeader requestDetailsHeader;
        private System.Windows.Forms.ColumnHeader ibtNumHeader;
        private System.Windows.Forms.ColumnHeader customerCallHeader;
        private System.Windows.Forms.ColumnHeader collectedHeader;
        private System.Windows.Forms.ColumnHeader ibtCheckHeader;
        private System.Windows.Forms.Button newIBTBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button requestedBtn;
        private System.Windows.Forms.Button addIBTNumBtn;
        private System.Windows.Forms.Button customerCalledBtn;
        private System.Windows.Forms.Button collectedBtn;
        private System.Windows.Forms.Button subwarehouseBtn;
        private System.Windows.Forms.Label manageLabel;
        private System.Windows.Forms.ColumnHeader dateHeader;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button deleteIBTBtn;
        private System.Windows.Forms.Button addNoteBtn;
    }
}

