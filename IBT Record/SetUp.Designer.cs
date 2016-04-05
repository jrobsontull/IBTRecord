namespace IBT_Record
{
    partial class SetUp
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
            this.descriptionTxt = new System.Windows.Forms.Label();
            this.storeNumLabel = new System.Windows.Forms.Label();
            this.storeNum = new System.Windows.Forms.NumericUpDown();
            this.versionLabel = new System.Windows.Forms.Label();
            this.versionTxt = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.initialsLabel = new System.Windows.Forms.Label();
            this.initialsTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.storeNum)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.AutoSize = true;
            this.descriptionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTxt.Location = new System.Drawing.Point(15, 18);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(280, 90);
            this.descriptionTxt.TabIndex = 0;
            this.descriptionTxt.Text = "This is the initial set-up window.\r\n\r\nHere you must select your store number \r\nas" +
    " this will then be used as the password \r\nto delete an IBT from the system.";
            this.descriptionTxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // storeNumLabel
            // 
            this.storeNumLabel.AutoSize = true;
            this.storeNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeNumLabel.Location = new System.Drawing.Point(58, 132);
            this.storeNumLabel.Name = "storeNumLabel";
            this.storeNumLabel.Size = new System.Drawing.Size(105, 18);
            this.storeNumLabel.TabIndex = 1;
            this.storeNumLabel.Text = "Store Number:";
            // 
            // storeNum
            // 
            this.storeNum.Location = new System.Drawing.Point(169, 130);
            this.storeNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.storeNum.Name = "storeNum";
            this.storeNum.Size = new System.Drawing.Size(71, 24);
            this.storeNum.TabIndex = 2;
            this.storeNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.storeNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.Location = new System.Drawing.Point(75, 196);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(119, 18);
            this.versionLabel.TabIndex = 3;
            this.versionLabel.Text = "Version Number:";
            // 
            // versionTxt
            // 
            this.versionTxt.AutoSize = true;
            this.versionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionTxt.Location = new System.Drawing.Point(196, 196);
            this.versionTxt.Name = "versionTxt";
            this.versionTxt.Size = new System.Drawing.Size(28, 18);
            this.versionTxt.TabIndex = 4;
            this.versionTxt.Text = "1.0";
            this.versionTxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(84, 235);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(135, 37);
            this.confirmBtn.TabIndex = 5;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // initialsLabel
            // 
            this.initialsLabel.AutoSize = true;
            this.initialsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialsLabel.Location = new System.Drawing.Point(71, 164);
            this.initialsLabel.Name = "initialsLabel";
            this.initialsLabel.Size = new System.Drawing.Size(52, 18);
            this.initialsLabel.TabIndex = 6;
            this.initialsLabel.Text = "Initials:";
            // 
            // initialsTxtBox
            // 
            this.initialsTxtBox.Location = new System.Drawing.Point(129, 164);
            this.initialsTxtBox.Name = "initialsTxtBox";
            this.initialsTxtBox.Size = new System.Drawing.Size(99, 24);
            this.initialsTxtBox.TabIndex = 7;
            this.initialsTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SetUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 284);
            this.Controls.Add(this.initialsTxtBox);
            this.Controls.Add(this.initialsLabel);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.versionTxt);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.storeNum);
            this.Controls.Add(this.storeNumLabel);
            this.Controls.Add(this.descriptionTxt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetUp";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Initial Set-Up";
            ((System.ComponentModel.ISupportInitialize)(this.storeNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descriptionTxt;
        private System.Windows.Forms.Label storeNumLabel;
        private System.Windows.Forms.NumericUpDown storeNum;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label versionTxt;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label initialsLabel;
        private System.Windows.Forms.TextBox initialsTxtBox;
    }
}