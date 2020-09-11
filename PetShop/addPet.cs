using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class addPet : Form
    {
        public addPet()
        {
            InitializeComponent();
            pettypebox();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            buttonAddPet();



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void pettypebox()
        {
            string server = "34.89.62.152";
            string database = "petshop";
            string uid = "root";
            string password = "pollux";
            var connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT type FROM petType";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            petTypeComboBox.Items.Add(reader.GetString("type"));

                        }
                    }
                }
            }
        }
        public void buttonAddPet()
        {
            string server = "34.89.62.152";
            string database = "petshop";
            string uid = "root";
            string password = "pollux";
            var connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();



            var pettypeID = 0;
            var query2 = "SELECT id FROM petType WHERE petType.type = @getpettypeID";
            MySqlCommand command2 = new MySqlCommand(query2, connection);
            command2.Parameters.AddWithValue("@getpettypeID", petTypeComboBox.Text);
            using (var reader = command2.ExecuteReader())
            {

                while (reader.Read())
                {
                    pettypeID = reader.GetInt32("id");

                }
            }

            string name = petnameTextbox.Text;
            int isSold = 0;
            string query = "INSERT INTO pets (name, isSold, pettypeID) VALUES (@name, @isSold, @pettypeID);";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@isSold", isSold);
            command.Parameters.AddWithValue("@pettypeID", pettypeID);
            


            
            command.ExecuteNonQuery();



        }

    }
}
