namespace PetShop
{
    partial class addPet
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
            this.button1 = new System.Windows.Forms.Button();
            this.petnameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.petTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // petnameTextbox
            // 
            this.petnameTextbox.Location = new System.Drawing.Point(28, 79);
            this.petnameTextbox.Name = "petnameTextbox";
            this.petnameTextbox.Size = new System.Drawing.Size(100, 20);
            this.petnameTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pet Name";
            // 
            // petTypeComboBox
            // 
            this.petTypeComboBox.FormattingEnabled = true;
            this.petTypeComboBox.Location = new System.Drawing.Point(149, 79);
            this.petTypeComboBox.Name = "petTypeComboBox";
            this.petTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.petTypeComboBox.TabIndex = 3;
            this.petTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pet Type";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // addedLabel
            // 
            this.addedLabel.AutoSize = true;
            this.addedLabel.Location = new System.Drawing.Point(120, 195);
            this.addedLabel.Name = "addedLabel";
            this.addedLabel.Size = new System.Drawing.Size(0, 13);
            this.addedLabel.TabIndex = 5;
            // 
            // addPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 237);
            this.Controls.Add(this.addedLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.petTypeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.petnameTextbox);
            this.Controls.Add(this.button1);
            this.Name = "addPet";
            this.Text = "Add Pet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox petnameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox petTypeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label addedLabel;
    }
}