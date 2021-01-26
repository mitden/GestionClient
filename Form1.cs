using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionClient
{
    public partial class Form1 : Form
    {
        ClientContext _context;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _context = new ClientContext();
            _context.Clients.Load();
            this.dataGridView1.DataSource = _context.Clients.Local.ToBindingList();
            dataGridView1.Columns.Add(new DataGridViewButtonColumn()
            {
                Text = "Modifier",
                Tag = (Action<Client>)ClickModifierHandler,
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            });

            dataGridView1.Columns.Add(new DataGridViewButtonColumn()
            {
                Text = "Supprimer",
                Tag = (Action<Client>)ClickSupprimerHandler,
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            });
        }

        private void AddClientBTN_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm(new Client());
            
            clientForm.ShowDialog();
            if (clientForm.Success)
            {

                this._context.Clients.Local.Add(clientForm.Client);

                this._context.SaveChanges();


            }
        }


        public void ClickModifierHandler(Client client)
        {
            Console.WriteLine("Modifier  : " + client.Nom + " " + client.Prenom);

            ClientForm clientForm = new ClientForm(client);
            clientForm.ShowDialog();
            if (clientForm.Success)
            {

                this._context.Clients.Local.Add(clientForm.Client);
                this._context.Entry(clientForm.Client).State = System.Data.Entity.EntityState.Modified;
                this._context.SaveChanges();

              

            }
        }

        public void ClickSupprimerHandler(Client client)
        {
            Console.WriteLine("Supprimer  : " + client.Nom + " " + client.Prenom);
            this._context.Clients.Local.Remove(client);
            this._context.SaveChanges();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this._context.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (e.RowIndex < 0)
            {
                //They clicked the header column, do nothing
                return;
            }

            if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                var clickHandler = (Action<Client>)grid.Columns[e.ColumnIndex].Tag;
                var client = (Client)grid.Rows[e.RowIndex].DataBoundItem;

                clickHandler(client);

            }
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            if (this.SearchTerm.TextLength > 0)
            {
                this.dataGridView1.DataSource = _context.Clients.Local.Where(c => c.Prenom.Contains(SearchTerm.Text) || c.Nom.Contains(SearchTerm.Text)).ToList();
                this.button1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SearchTerm.ResetText();
            this.dataGridView1.DataSource = _context.Clients.Local.ToBindingList();
            this.button1.Visible = false;
        }
    }
}
