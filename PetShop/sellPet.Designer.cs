namespace PetShop
{
    partial class sellPet
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
            this.sellerComboBox = new System.Windows.Forms.ComboBox();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sellerLabel = new System.Windows.Forms.Label();
            this.clientLabel = new System.Windows.Forms.Label();
            this.soldLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sellerComboBox
            // 
            this.sellerComboBox.FormattingEnabled = true;
            this.sellerComboBox.Location = new System.Drawing.Point(83, 105);
            this.sellerComboBox.Name = "sellerComboBox";
            this.sellerComboBox.Size = new System.Drawing.Size(162, 21);
            this.sellerComboBox.TabIndex = 1;
            this.sellerComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // clientComboBox
            // 
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(83, 158);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(162, 21);
            this.clientComboBox.TabIndex = 2;
            this.clientComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sell";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // sellerLabel
            // 
            this.sellerLabel.AutoSize = true;
            this.sellerLabel.Location = new System.Drawing.Point(83, 86);
            this.sellerLabel.Name = "sellerLabel";
            this.sellerLabel.Size = new System.Drawing.Size(33, 13);
            this.sellerLabel.TabIndex = 5;
            this.sellerLabel.Text = "Seller";
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(83, 139);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(33, 13);
            this.clientLabel.TabIndex = 6;
            this.clientLabel.Text = "Client";
            // 
            // soldLabel
            // 
            this.soldLabel.AutoSize = true;
            this.soldLabel.Location = new System.Drawing.Point(147, 264);
            this.soldLabel.Name = "soldLabel";
            this.soldLabel.Size = new System.Drawing.Size(31, 13);
            this.soldLabel.TabIndex = 7;
            this.soldLabel.Text = "Sold!";
            // 
            // sellPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 312);
            this.Controls.Add(this.soldLabel);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.sellerLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clientComboBox);
            this.Controls.Add(this.sellerComboBox);
            this.Name = "sellPet";
            this.Text = "Sell Pet";
            this.Load += new System.EventHandler(this.sellPet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label sellerLabel;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Label soldLabel;
        private System.Windows.Forms.ComboBox sellerComboBox;
        private System.Windows.Forms.ComboBox clientComboBox;
    }
}