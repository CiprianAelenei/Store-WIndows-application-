using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjectPAW.Services;

namespace ProjectPAW
{
    public partial class AddProdus : Form
    {
        private readonly IProductService _ProductService;
        private List<Product> _Products = new List<Product>();

        public AddProdus(IProductService productService)
        {
            _ProductService = productService;
            InitializeComponent();
        }

        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 frm = new AboutBox1();
            frm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void adaugaClientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //AddClient frm = new AddClient();
            //frm.Show();
        }

        private void meniuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cumpara frm = new Cumpara();
            frm.Show();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //in frm = new Main();
            //m.Show();
        }

        private void btn_incarca_Click(object sender, EventArgs e)
        {
            _LoadProducts();
        }

        private void _LoadProducts()
        {
            _Products = _ProductService.GetAllProducts();
            dtgProducts.DataSource = _Products;
        }

        private void btn_addprd_Click(object sender, EventArgs e)
        {
            Product newP = new Product(0, textBox1.Text, Convert.ToDecimal(textBox5.Text), Convert.ToInt32(textBox7.Text));
            _ProductService.SaveProduct(newP);
            _LoadProducts();
        }

        private void AddProdus_Load(object sender, EventArgs e)
        {
            _LoadProducts();
        }
    }
}
