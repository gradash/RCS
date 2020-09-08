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

            string server = "34.89.62.152";
            string database = "petshop";
            string uid = "root";
            string password = "pollux";
            var connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT CONCAT(name,' ',surename) AS seller FROM employees";
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

        private void sellPet_Load(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
