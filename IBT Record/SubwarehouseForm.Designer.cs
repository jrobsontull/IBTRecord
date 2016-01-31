namespace IBT_Record
{
    partial class SubwarehouseForm
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
            this.initialsTxtBox = new System.Windows.Forms.TextBox();
            this.initialsLabel = new System.Windows.Forms.Label();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.passLabel = new System.Windows.Forms.Label();
            this.passTxtBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // initialsTxtBox
            // 
            this.initialsTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialsTxtBox.Location = new System.Drawing.Point(109, 11);
            this.initialsTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.initialsTxtBox.Name = "initialsTxtBox";
            this.initialsTxtBox.Size = new System.Drawing.Size(247, 24);
            this.initialsTxtBox.TabIndex = 0;
            // 
            // initialsLabel
            // 
            this.initialsLabel.AutoSize = true;
            this.initialsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialsLabel.Location = new System.Drawing.Point(41, 11);
            this.initialsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.initialsLabel.Name = "initialsLabel";
            this.initialsLabel.Size = new System.Drawing.Size(52, 18);
            this.initialsLabel.TabIndex = 4;
            this.initialsLabel.Text = "Initials:";
            // 
            // acceptBtn
            // 
            this.acceptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptBtn.Location = new System.Drawing.Point(65, 74);
            this.acceptBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(116, 37);
            this.acceptBtn.TabIndex = 2;
            this.acceptBtn.Text = "Confirm";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(16, 41);
            this.passLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(79, 18);
            this.passLabel.TabIndex = 5;
            this.passLabel.Text = "Password:";
            // 
            // passTxtBox
            // 
            this.passTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTxtBox.Location = new System.Drawing.Point(109, 41);
            this.passTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passTxtBox.Name = "passTxtBox";
            this.passTxtBox.PasswordChar = '*';
            this.passTxtBox.Size = new System.Drawing.Size(247, 24);
            this.passTxtBox.TabIndex = 1;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(189, 74);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(116, 37);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // SubwarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 118);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.passTxtBox);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.initialsLabel);
            this.Controls.Add(this.initialsTxtBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SubwarehouseForm";
            this.Text = "Subwarehouse Check";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox initialsTxtBox;
        private System.Windows.Forms.Label initialsLabel;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox passTxtBox;
        private System.Windows.Forms.Button cancelBtn;
    }
}