namespace IBT_Record
{
    partial class NewIBTForm
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
            this.createBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.contactNumLabel = new System.Windows.Forms.Label();
            this.contactNumTxtBox = new System.Windows.Forms.TextBox();
            this.skuLabel = new System.Windows.Forms.Label();
            this.skuTxtBox = new System.Windows.Forms.TextBox();
            this.itemDescripLabel = new System.Windows.Forms.Label();
            this.descriptionTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createBtn
            // 
            this.createBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.Location = new System.Drawing.Point(12, 294);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(142, 37);
            this.createBtn.TabIndex = 0;
            this.createBtn.Text = "Create New";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(160, 294);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(112, 37);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxtBox.Location = new System.Drawing.Point(12, 30);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(260, 24);
            this.nameTxtBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(9, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(122, 18);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Customer Name:";
            // 
            // contactNumLabel
            // 
            this.contactNumLabel.AutoSize = true;
            this.contactNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumLabel.Location = new System.Drawing.Point(9, 57);
            this.contactNumLabel.Name = "contactNumLabel";
            this.contactNumLabel.Size = new System.Drawing.Size(121, 18);
            this.contactNumLabel.TabIndex = 4;
            this.contactNumLabel.Text = "Contact Number:";
            // 
            // contactNumTxtBox
            // 
            this.contactNumTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumTxtBox.Location = new System.Drawing.Point(12, 78);
            this.contactNumTxtBox.Name = "contactNumTxtBox";
            this.contactNumTxtBox.Size = new System.Drawing.Size(260, 24);
            this.contactNumTxtBox.TabIndex = 5;
            // 
            // skuLabel
            // 
            this.skuLabel.AutoSize = true;
            this.skuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skuLabel.Location = new System.Drawing.Point(12, 105);
            this.skuLabel.Name = "skuLabel";
            this.skuLabel.Size = new System.Drawing.Size(43, 18);
            this.skuLabel.TabIndex = 6;
            this.skuLabel.Text = "SKU:";
            // 
            // skuTxtBox
            // 
            this.skuTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skuTxtBox.Location = new System.Drawing.Point(12, 126);
            this.skuTxtBox.Name = "skuTxtBox";
            this.skuTxtBox.Size = new System.Drawing.Size(260, 24);
            this.skuTxtBox.TabIndex = 7;
            // 
            // itemDescripLabel
            // 
            this.itemDescripLabel.AutoSize = true;
            this.itemDescripLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemDescripLabel.Location = new System.Drawing.Point(9, 153);
            this.itemDescripLabel.Name = "itemDescripLabel";
            this.itemDescripLabel.Size = new System.Drawing.Size(119, 18);
            this.itemDescripLabel.TabIndex = 8;
            this.itemDescripLabel.Text = "Item Description:";
            // 
            // descriptionTxtBox
            // 
            this.descriptionTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTxtBox.Location = new System.Drawing.Point(12, 174);
            this.descriptionTxtBox.Multiline = true;
            this.descriptionTxtBox.Name = "descriptionTxtBox";
            this.descriptionTxtBox.Size = new System.Drawing.Size(260, 114);
            this.descriptionTxtBox.TabIndex = 9;
            // 
            // NewIBTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 343);
            this.Controls.Add(this.descriptionTxtBox);
            this.Controls.Add(this.itemDescripLabel);
            this.Controls.Add(this.skuTxtBox);
            this.Controls.Add(this.skuLabel);
            this.Controls.Add(this.contactNumTxtBox);
            this.Controls.Add(this.contactNumLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.createBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewIBTForm";
            this.Text = "Add New IBT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label contactNumLabel;
        private System.Windows.Forms.TextBox contactNumTxtBox;
        private System.Windows.Forms.Label skuLabel;
        private System.Windows.Forms.TextBox skuTxtBox;
        private System.Windows.Forms.Label itemDescripLabel;
        private System.Windows.Forms.TextBox descriptionTxtBox;
    }
}