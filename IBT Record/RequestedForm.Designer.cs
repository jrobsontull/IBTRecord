namespace IBT_Record
{
    partial class RequestedForm
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
            this.isRequestedBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.storeListCombo = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.storeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // isRequestedBtn
            // 
            this.isRequestedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isRequestedBtn.Location = new System.Drawing.Point(29, 92);
            this.isRequestedBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.isRequestedBtn.Name = "isRequestedBtn";
            this.isRequestedBtn.Size = new System.Drawing.Size(179, 37);
            this.isRequestedBtn.TabIndex = 0;
            this.isRequestedBtn.Text = "Mark as Requested";
            this.isRequestedBtn.UseVisualStyleBackColor = true;
            this.isRequestedBtn.Click += new System.EventHandler(this.isRequestedBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(216, 92);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(92, 37);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // storeListCombo
            // 
            this.storeListCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeListCombo.FormattingEnabled = true;
            this.storeListCombo.Items.AddRange(new object[] {
            "Alfriston",
            "Battle",
            "Beverly",
            "Bishops Stortford",
            "Bluewater",
            "Brentwood",
            "Brighton",
            "Bournemouth",
            "Bury St Edmunds",
            "Cambridge",
            "Canterbury",
            "Chester",
            "Chichester",
            "Cirencester",
            "Dorchester",
            "Dorking",
            "Eastbourne",
            "Glasgow",
            "Guilford",
            "Harrogate",
            "Heathfield",
            "Hereford",
            "Horsham",
            "Marlow",
            "Nothallerton",
            "Lewes",
            "Lymington",
            "Saffron Walden",
            "Stanford",
            "St Albans",
            "Southhampton",
            "Taunton",
            "Thame",
            "Westerham",
            "Witney"});
            this.storeListCombo.Location = new System.Drawing.Point(85, 17);
            this.storeListCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.storeListCombo.Name = "storeListCombo";
            this.storeListCombo.Size = new System.Drawing.Size(221, 26);
            this.storeListCombo.TabIndex = 2;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(29, 53);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(277, 24);
            this.dateTimePicker.TabIndex = 3;
            // 
            // storeLabel
            // 
            this.storeLabel.AutoSize = true;
            this.storeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeLabel.Location = new System.Drawing.Point(25, 21);
            this.storeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.storeLabel.Name = "storeLabel";
            this.storeLabel.Size = new System.Drawing.Size(48, 18);
            this.storeLabel.TabIndex = 4;
            this.storeLabel.Text = "Store:";
            // 
            // RequestedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 139);
            this.Controls.Add(this.storeLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.storeListCombo);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.isRequestedBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RequestedForm";
            this.Text = "Requested Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button isRequestedBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ComboBox storeListCombo;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label storeLabel;
    }
}