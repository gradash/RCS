namespace PetShop
{
    partial class petlistForm
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
            this.addPet = new System.Windows.Forms.Button();
            this.sellPet = new System.Windows.Forms.Button();
            this.petListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // addPet
            // 
            this.addPet.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.addPet.Location = new System.Drawing.Point(360, 87);
            this.addPet.Name = "addPet";
            this.addPet.Size = new System.Drawing.Size(113, 23);
            this.addPet.TabIndex = 1;
            this.addPet.Text = "Add Pet";
            this.addPet.UseVisualStyleBackColor = true;
            this.addPet.Click += new System.EventHandler(this.addPet_Click);
            // 
            // sellPet
            // 
            this.sellPet.Location = new System.Drawing.Point(360, 130);
            this.sellPet.Name = "sellPet";
            this.sellPet.Size = new System.Drawing.Size(113, 23);
            this.sellPet.TabIndex = 2;
            this.sellPet.Text = "Sell Pet";
            this.sellPet.UseVisualStyleBackColor = true;
            this.sellPet.Click += new System.EventHandler(this.sellPet_Click);
            // 
            // petListView
            // 
            this.petListView.HideSelection = false;
            this.petListView.Location = new System.Drawing.Point(12, 12);
            this.petListView.Name = "petListView";
            this.petListView.Size = new System.Drawing.Size(305, 314);
            this.petListView.TabIndex = 3;
            this.petListView.UseCompatibleStateImageBehavior = false;
            // 
            // petlistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 338);
            this.Controls.Add(this.petListView);
            this.Controls.Add(this.sellPet);
            this.Controls.Add(this.addPet);
            this.Name = "petlistForm";
            this.Text = "Pet List";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addPet;
        private System.Windows.Forms.Button sellPet;
        private System.Windows.Forms.ListView petListView;
    }
}