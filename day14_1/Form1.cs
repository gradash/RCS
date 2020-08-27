using day11_1_student_files;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day14_1
{
    public partial class Form1 : Form
    {
        private static readonly String filename = "C:\\Users\\matvejevs\\Source\\Repos\\RCS\\day14_1\\bin\\Debug\\test.txt";
        public Form1()
        {

            InitializeComponent();

            List<string> studentlist = FileIO.ReadStudentLst(filename);

            foreach (var std in studentlist)
            {
                listView.Items.Add(std);
            }
       

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            Student st = new Student(textBox_name.Text,textBox_surename.Text,Convert.ToInt32(textBox_course.Text));


            string student = st.name + "," + st.surename + "," + st.course;

            if (textBox_name != null && textBox_surename != null && textBox_course != null)
            {
                listView.Items.Add(st.name+" "+st.surename+" "+st.course);
            }

            UpdateFile();




        }

        private void button_remove_Click(object sender, EventArgs e)
        {

            if (listView.SelectedItems.Count == 0)
            {
                listView.Items.RemoveAt(listView.Items.Count - 1);
            } 
            else
            {
                foreach (ListViewItem item in listView.SelectedItems)
                {
                    item.Remove();
                }
            }

            UpdateFile();


        }

        private void UpdateFile()
        {
            FileIO.WriteStudentToFile(listView, filename);
        }
    }
}
