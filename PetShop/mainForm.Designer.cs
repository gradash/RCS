namespace PetShop
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.addSellPetsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.soldPetsButton = new System.Windows.Forms.Button();
            this.addPet = new System.Windows.Forms.Button();
            this.sellPet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addSellPetsButton
            // 
            this.addSellPetsButton.Location = new System.Drawing.Point(45, 63);
            this.addSellPetsButton.Name = "addSellPetsButton";
            this.addSellPetsButton.Size = new System.Drawing.Size(90, 23);
            this.addSellPetsButton.TabIndex = 0;
            this.addSellPetsButton.Text = "Pet List";
            this.addSellPetsButton.UseVisualStyleBackColor = true;
            this.addSellPetsButton.Click += new System.EventHandler(this.showPets_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pet Shop";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // soldPetsButton
            // 
            this.soldPetsButton.Location = new System.Drawing.Point(379, 63);
            this.soldPetsButton.Name = "soldPetsButton";
            this.soldPetsButton.Size = new System.Drawing.Size(75, 23);
            this.soldPetsButton.TabIndex = 5;
            this.soldPetsButton.Text = "Sold Pets";
            this.soldPetsButton.UseVisualStyleBackColor = true;
            this.soldPetsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // addPet
            // 
            this.addPet.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.addPet.Location = new System.Drawing.Point(141, 63);
            this.addPet.Name = "addPet";
            this.addPet.Size = new System.Drawing.Size(113, 23);
            this.addPet.TabIndex = 6;
            this.addPet.Text = "Add Pet";
            this.addPet.UseVisualStyleBackColor = true;
            this.addPet.Click += new System.EventHandler(this.addPet_Click);
            // 
            // sellPet
            // 
            this.sellPet.Location = new System.Drawing.Point(260, 63);
            this.sellPet.Name = "sellPet";
            this.sellPet.Size = new System.Drawing.Size(113, 23);
            this.sellPet.TabIndex = 7;
            this.sellPet.Text = "Sell Pet";
            this.sellPet.UseVisualStyleBackColor = true;
            this.sellPet.Click += new System.EventHandler(this.sellPet_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 305);
            this.Controls.Add(this.sellPet);
            this.Controls.Add(this.addPet);
            this.Controls.Add(this.soldPetsButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addSellPetsButton);
            this.Name = "mainForm";
            this.Text = "Pet Shop";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addSellPetsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button soldPetsButton;
        private System.Windows.Forms.Button addPet;
        private System.Windows.Forms.Button sellPet;
    }
}

