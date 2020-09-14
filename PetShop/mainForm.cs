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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void showPets_Click(object sender, EventArgs e)
        {
            petlistForm petList = new petlistForm();
            petList.ShowDialog(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            soldPets soldList = new soldPets();
            soldList.ShowDialog();
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
    }
}
