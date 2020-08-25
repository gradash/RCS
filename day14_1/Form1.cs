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

        public Form1()
        {

            InitializeComponent();

            List<string> studentlist = FileIO.ReadStudentLst("test.txt");

            foreach (var std in studentlist)
            {
                listView1.Items.Add(std);
            }
       

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            Student st = new Student(textBox1.Text,textBox2.Text,Convert.ToInt32(textBox3.Text));


            string student = st.name + "," + st.surename + "," + st.course;


            FileIO.WriteStudentToFile(student, "test.txt");

            listView1.Items.Add(student);

        }
    }
}
