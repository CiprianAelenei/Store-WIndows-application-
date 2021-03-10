using ProjectPAW.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPAW
{
    public partial class Main : Form
    {
        private readonly IClientService _ClientService;
        private readonly IProductService _ProductService;
        public Main(IClientService clientService, IProductService productService)
        {
            _ClientService = clientService;
            _ProductService = productService;
            InitializeComponent();
        }


        private void btn_main_cumpara_Click(object sender, EventArgs e)
        {
            Cumpara frm = new Cumpara();
            frm.Show();
        }

        private void btn_main_adgprod_Click(object sender, EventArgs e)
        {
            AddProdus frm = new AddProdus(_ProductService);
            frm.Show();
        }

        private void btn_main_adgcl_Click(object sender, EventArgs e)
        {
            AddClient frm = new AddClient(_ClientService);
            frm.Show();
        }

        private void ttn_main_despre_Click(object sender, EventArgs e)
        {
            AboutBox1 frm = new AboutBox1();
            frm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
