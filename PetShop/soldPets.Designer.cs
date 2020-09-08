namespace PetShop
{
    partial class soldPets
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
            this.soldPetslist = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // soldPetslist
            // 
            this.soldPetslist.HideSelection = false;
            this.soldPetslist.Location = new System.Drawing.Point(12, 12);
            this.soldPetslist.Name = "soldPetslist";
            this.soldPetslist.Size = new System.Drawing.Size(330, 377);
            this.soldPetslist.TabIndex = 0;
            this.soldPetslist.UseCompatibleStateImageBehavior = false;
            // 
            // soldPets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 401);
            this.Controls.Add(this.soldPetslist);
            this.Name = "soldPets";
            this.RightToLeftLayout = true;
            this.Text = "Sold Pets";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView soldPetslist;
    }
}