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
    public partial class sellPet : Form
    {
        public sellPet()
        {
            InitializeComponent();

            sellerbox();
            clientbox();
            petbox();
            


        }

        private void sellPet_Load(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        public void sellerbox()
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
                var query = "SELECT CONCAT(name,' ',surename) AS seller, id FROM employees";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            
                            sellerComboBox.Items.Add(reader.GetString("seller"));

                        }
                    }
                }
            }
        }
        public void clientbox()
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
                var query = "SELECT CONCAT(name,' ',surename) AS client FROM clients";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            clientComboBox.Items.Add(reader.GetString("client"));

                        }
                    }
                }
            }
        }

        public void petbox()
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
                var query = "SELECT CONCAT(pets.name,' ',petType.type) AS pets FROM pets, petType WHERE pets.pettypeID = petType.id AND isSold = 0";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            petboxlist.Items.Add(reader.GetString("pets"));

                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
                var queryID = "SELECT id FROM petType WHERE petType.type = @getpettypeID";
                MySqlCommand command2 = new MySqlCommand(queryID, connection);
                command2.Parameters.AddWithValue("@getpettypeID", petboxlist.Text.Split(' ')[1]);
                using (var reader = command2.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        pettypeID = reader.GetInt32("id");

                    }
                }
            var sellerID = 0;
            var querysellerID = "SELECT id FROM employees WHERE employees.name = @employeesname AND employees.surename = @employeessurename";
            MySqlCommand command3 = new MySqlCommand(querysellerID, connection);
            command3.Parameters.AddWithValue("@employeesname", sellerComboBox.Text.Split(' ')[0]);
            command3.Parameters.AddWithValue("@employeessurename", sellerComboBox.Text.Split(' ')[1]);
            using (var reader = command3.ExecuteReader())
            {

                while (reader.Read())
                {
                    sellerID = reader.GetInt32("id");

                }
            }
            var clientID = 0;
            var queryclientID = "SELECT id FROM clients WHERE clients.name = @clientsname AND clients.surename = @clientssurename";
            MySqlCommand command4 = new MySqlCommand(queryclientID, connection);
            command4.Parameters.AddWithValue("@clientsname", clientComboBox.Text.Split(' ')[0]);
            command4.Parameters.AddWithValue("@clientssurename", clientComboBox.Text.Split(' ')[1]);
            using (var reader = command4.ExecuteReader())
            {

                while (reader.Read())
                {
                    clientID = reader.GetInt32("id");

                }
            }

            string name = petboxlist.Text.Split(' ')[0];
            string query = "UPDATE pets SET isSold = 1, employeeID ='"+ sellerID + "', clientID = '"+ clientID + "'  WHERE name = '" +name+  "' AND pettypeID = '" +pettypeID+ "';";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            soldLabel.Text = "Sold!";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void petbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
