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
    public partial class petlistForm : Form
    {
        public petlistForm()
        {
            InitializeComponent();

            fillPetListForm();



        }

        private void addPet_Click(object sender, EventArgs e)
        {
            addPet addPet = new addPet();
            addPet.ShowDialog();
        }

        private void sellPet_Click(object sender, EventArgs e)
        {
            sellPet sellPet = new sellPet();
            sellPet.ShowDialog();
        }

        private void petListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public void fillPetListForm()
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
                var query = "SELECT CONCAT(pets.name,'  ',petType.type,'    ',petType.description) AS petlist FROM pets, petType WHERE petType.id = pets.pettypeID";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            petListView.Items.Add(reader.GetString("petlist"));

                        }
                    }
                }
            }
        }
    }
}
