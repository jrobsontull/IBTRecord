namespace IBT_Record
{
    partial class PrintOptions
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
            this.printAllBtn = new System.Windows.Forms.Button();
            this.printCompletedBtn = new System.Windows.Forms.Button();
            this.printUncompleteBtn = new System.Windows.Forms.Button();
            this.dateGroupBox = new System.Windows.Forms.GroupBox();
            this.printDateBtn = new System.Windows.Forms.Button();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.printPreviewCheckBox = new System.Windows.Forms.CheckBox();
            this.dateGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // printAllBtn
            // 
            this.printAllBtn.Location = new System.Drawing.Point(12, 31);
            this.printAllBtn.Name = "printAllBtn";
            this.printAllBtn.Size = new System.Drawing.Size(75, 44);
            this.printAllBtn.TabIndex = 0;
            this.printAllBtn.Text = "Print All";
            this.printAllBtn.UseVisualStyleBackColor = true;
            this.printAllBtn.Click += new System.EventHandler(this.printAllBtn_Click);
            // 
            // printCompletedBtn
            // 
            this.printCompletedBtn.Location = new System.Drawing.Point(93, 31);
            this.printCompletedBtn.Name = "printCompletedBtn";
            this.printCompletedBtn.Size = new System.Drawing.Size(96, 44);
            this.printCompletedBtn.TabIndex = 1;
            this.printCompletedBtn.Text = "Print Completed";
            this.printCompletedBtn.UseVisualStyleBackColor = true;
            this.printCompletedBtn.Click += new System.EventHandler(this.printCompletedBtn_Click);
            // 
            // printUncompleteBtn
            // 
            this.printUncompleteBtn.Location = new System.Drawing.Point(195, 31);
            this.printUncompleteBtn.Name = "printUncompleteBtn";
            this.printUncompleteBtn.Size = new System.Drawing.Size(89, 44);
            this.printUncompleteBtn.TabIndex = 2;
            this.printUncompleteBtn.Text = "Print Uncomplete";
            this.printUncompleteBtn.UseVisualStyleBackColor = true;
            this.printUncompleteBtn.Click += new System.EventHandler(this.printUncompleteBtn_Click);
            // 
            // dateGroupBox
            // 
            this.dateGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.dateGroupBox.Controls.Add(this.printDateBtn);
            this.dateGroupBox.Controls.Add(this.toLabel);
            this.dateGroupBox.Controls.Add(this.fromLabel);
            this.dateGroupBox.Controls.Add(this.toDate);
            this.dateGroupBox.Controls.Add(this.fromDate);
            this.dateGroupBox.Location = new System.Drawing.Point(12, 82);
            this.dateGroupBox.Name = "dateGroupBox";
            this.dateGroupBox.Size = new System.Drawing.Size(272, 108);
            this.dateGroupBox.TabIndex = 3;
            this.dateGroupBox.TabStop = false;
            this.dateGroupBox.Text = "Print Date Range";
            // 
            // printDateBtn
            // 
            this.printDateBtn.Location = new System.Drawing.Point(183, 74);
            this.printDateBtn.Name = "printDateBtn";
            this.printDateBtn.Size = new System.Drawing.Size(83, 28);
            this.printDateBtn.TabIndex = 4;
            this.printDateBtn.Text = "Print";
            this.printDateBtn.UseVisualStyleBackColor = true;
            this.printDateBtn.Click += new System.EventHandler(this.printDateBtn_Click);
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(21, 47);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(24, 15);
            this.toLabel.TabIndex = 3;
            this.toLabel.Text = "To:";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(6, 20);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(39, 15);
            this.fromLabel.TabIndex = 2;
            this.fromLabel.Text = "From:";
            // 
            // toDate
            // 
            this.toDate.Location = new System.Drawing.Point(51, 47);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(215, 21);
            this.toDate.TabIndex = 1;
            // 
            // fromDate
            // 
            this.fromDate.Location = new System.Drawing.Point(51, 20);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(215, 21);
            this.fromDate.TabIndex = 0;
            // 
            // printPreviewCheckBox
            // 
            this.printPreviewCheckBox.AutoSize = true;
            this.printPreviewCheckBox.Location = new System.Drawing.Point(12, 8);
            this.printPreviewCheckBox.Name = "printPreviewCheckBox";
            this.printPreviewCheckBox.Size = new System.Drawing.Size(97, 19);
            this.printPreviewCheckBox.TabIndex = 4;
            this.printPreviewCheckBox.Text = "Print Preview";
            this.printPreviewCheckBox.UseVisualStyleBackColor = true;
            // 
            // PrintOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 202);
            this.Controls.Add(this.printPreviewCheckBox);
            this.Controls.Add(this.dateGroupBox);
            this.Controls.Add(this.printUncompleteBtn);
            this.Controls.Add(this.printCompletedBtn);
            this.Controls.Add(this.printAllBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrintOptions";
            this.ShowIcon = false;
            this.Text = "Print Dialog";
            this.dateGroupBox.ResumeLayout(false);
            this.dateGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button printAllBtn;
        private System.Windows.Forms.Button printCompletedBtn;
        private System.Windows.Forms.Button printUncompleteBtn;
        private System.Windows.Forms.GroupBox dateGroupBox;
        private System.Windows.Forms.Button printDateBtn;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.DateTimePicker fromDate;
        private System.Windows.Forms.CheckBox printPreviewCheckBox;
    }
}