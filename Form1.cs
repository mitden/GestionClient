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
;
        }
        
        private void AddClientBTN_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            clientForm.Client = new Client();
            clientForm.ShowDialog();
            if (clientForm.Success)
            {
                _context.Clients.Load();
            }          
        }

     
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this._context.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
