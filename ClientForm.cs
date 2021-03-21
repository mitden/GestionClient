using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionClient
{
    public partial class ClientForm : Form
    {
        ClientContext _context;

        public Client Client { get; set; }
        public bool Success { get; set; }

        public ClientForm(Client model)
        {

            this.Client = model;
             _context = new ClientContext();

            InitializeComponent();
            remplirForm();

        }


        private void remplirForm() {

             this.NomTB.Text =  this.Client.Nom;
             this.PrenomTB.Text = this.Client.Prenom;
             this.TelephoneTB.Text = this.Client.Telephone;

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

                if (this.FormIsValid()) { 
                
                
                this.Success = true;
                this.Close();


                }
                else
                {
                    this.Success = false;
                    MessageBox.Show("Erreur:  Le formulaire est incomplet!");
                }
               
                //if(Client.Code != 0)
                //{
                
                //}
                //else
                //{
                //    this._context.Clients.Local.Add(Client);
                //}
                //this._context.SaveChanges();


            }
            catch
            {
                this.Success = false;
                MessageBox.Show("Erreur: Le formulaire est incorrect!");
            }
        
        }


        private bool FormIsValid()
        {
           if(this.Client.Nom == null|| this.Client.Nom.Trim().Equals("")|| this.Client.Prenom == null || this.Client.Prenom.Trim().Equals("")|| this.Client.Telephone == null || this.Client.Telephone.Trim().Equals("")|| !Regex.IsMatch(this.Client.Telephone.Trim(), @"^\d+$"))
            {
                return false;
            }
            return true;
        }

        private void NomTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
