namespace day14_1
{
    partial class Form1
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
            this.listView = new System.Windows.Forms.ListView();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_surename = new System.Windows.Forms.TextBox();
            this.textBox_course = new System.Windows.Forms.TextBox();
            this.label_surename = new System.Windows.Forms.Label();
            this.label_course = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.button_remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 60);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(260, 308);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(299, 81);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_name.TabIndex = 1;
            // 
            // textBox_surename
            // 
            this.textBox_surename.Location = new System.Drawing.Point(406, 80);
            this.textBox_surename.Name = "textBox_surename";
            this.textBox_surename.Size = new System.Drawing.Size(100, 20);
            this.textBox_surename.TabIndex = 2;
            // 
            // textBox_course
            // 
            this.textBox_course.Location = new System.Drawing.Point(513, 80);
            this.textBox_course.Name = "textBox_course";
            this.textBox_course.Size = new System.Drawing.Size(100, 20);
            this.textBox_course.TabIndex = 3;
            // 
            // label_surename
            // 
            this.label_surename.AutoSize = true;
            this.label_surename.Location = new System.Drawing.Point(430, 60);
            this.label_surename.Name = "label_surename";
            this.label_surename.Size = new System.Drawing.Size(55, 13);
            this.label_surename.TabIndex = 5;
            this.label_surename.Text = "Surename";
            this.label_surename.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_course
            // 
            this.label_course.AutoSize = true;
            this.label_course.Location = new System.Drawing.Point(543, 60);
            this.label_course.Name = "label_course";
            this.label_course.Size = new System.Drawing.Size(40, 13);
            this.label_course.TabIndex = 6;
            this.label_course.Text = "Course";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(410, 131);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 7;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(336, 59);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 13);
            this.label_name.TabIndex = 8;
            this.label_name.Text = "Name";
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(410, 172);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(75, 23);
            this.button_remove.TabIndex = 9;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 437);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label_course);
            this.Controls.Add(this.label_surename);
            this.Controls.Add(this.textBox_course);
            this.Controls.Add(this.textBox_surename);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.listView);
            this.Name = "Form1";
            this.Text = "Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_surename;
        private System.Windows.Forms.TextBox textBox_course;
        private System.Windows.Forms.Label label_surename;
        private System.Windows.Forms.Label label_course;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button button_remove;
    }
}

