using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionClient
{
    public partial class ClientForm : Form
    {
        ClientContext _context;

        public Client Client { get; set; }
        public bool Success { get; set; }

        public ClientForm()
        {
             _context = new ClientContext();

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Client.Nom = this.NomTB.Text;
            this.Client.Prenom = this.PrenomTB.Text;
            this.Client.Telephone = this.TelephoneTB.Text;
            try {

                this._context.Clients.Add(Client);
                this._context.SaveChanges();

                this.Success = true;
                this.Close();

            }
            catch
            {
                this.Success = false;
                MessageBox.Show("Erreur");
            }
        
        }

        private void NomTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
