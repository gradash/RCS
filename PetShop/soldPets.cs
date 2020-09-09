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
    public partial class soldPets : Form
    {
        public soldPets()
        {
            InitializeComponent();

            fillSoldPetsList();
        }

        private void soldPetslist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void fillSoldPetsList()
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
                var query = "SELECT CONCAT(pets.name,' ',employees.name,' ',employees.surename,' ',clients.name,' ',clients.surename) AS soldpet FROM pets, employees, clients WHERE pets.isSold = 1 AND pets.clientID = clients.id AND pets.employeeID = employees.id";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            soldPetslist.Items.Add(reader.GetString("soldpet"));

                        }
                    }
                }
            }
        }
    }
}
