using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using ProjectPAW.Services;

namespace ProjectPAW
{
    public partial class AddClient : Form
    {
        private List<Client> _Clients = new List<Client>();
        private readonly IClientService _ClientService;
        public AddClient(IClientService clientService)
        {
            _ClientService = clientService;
            InitializeComponent();
        }

        private void schimbaCuloareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                this.BackColor = dlg.Color;
        }

        private void schimbaFontToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                this.Font = dlg.Font;
        }

        //private void adaugaClientToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    AddProdus frm = new AddProdus();
        //    frm.Show();
        //}

        private void cumparaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cumpara frm = new Cumpara();
            frm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            SaveFileDialog dlg = new SaveFileDialog
            {
                Filter = "(*.txt)|*.txt"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var c in _Clients)
                {
                    sb.AppendLine(c.ToString());
                }
                File.WriteAllText(dlg.FileName, sb.ToString());
                MessageBox.Show($"Lista de clienti a fost salvata in {dlg.FileName}");
            }
        }

        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 frm = new AboutBox1();
            frm.Show();
        }

        private void mENIUToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Main frm = new Main();
            //frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client newC = new Client(0, txtNume.Text, txtEmail.Text, txtTelefon.Text, chkCardFidelitate.Checked, null);
            _ClientService.SaveClient(newC);
            _LoadClients();
            
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            _LoadClients();
        }

        private void _LoadClients()
        {
            lstClients.Items.Clear();
            lstClients.View = View.Details;

            GetAllClients();
            
            foreach (var c in _Clients)
            {
                lstClients.Items.Add(new ListViewItem(new string[] { c.Id.ToString(), c.Nume, c.NrTel }));
            }
        }

        private void GetAllClients()
        {
            _Clients = _ClientService.GetAllClients();
        }
    }
}
