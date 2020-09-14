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
            this.petListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // petListView
            // 
            this.petListView.HideSelection = false;
            this.petListView.Location = new System.Drawing.Point(12, 12);
            this.petListView.Name = "petListView";
            this.petListView.Size = new System.Drawing.Size(225, 314);
            this.petListView.TabIndex = 3;
            this.petListView.UseCompatibleStateImageBehavior = false;
            this.petListView.View = System.Windows.Forms.View.List;
            this.petListView.SelectedIndexChanged += new System.EventHandler(this.petListView_SelectedIndexChanged);
            // 
            // petlistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 338);
            this.Controls.Add(this.petListView);
            this.Name = "petlistForm";
            this.Text = "Pet List";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView petListView;
    }
}