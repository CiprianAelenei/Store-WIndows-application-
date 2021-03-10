using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Data;
using System.Text;

namespace ProjectPAW
{
    public partial class Cumpara : Form
    {
        private Cart _Cart = new Cart();

        public Cumpara()
        {
            InitializeComponent();
            cmb1.DisplayMember = "Name";
           // connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = client.accdb";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radiohardware.ForeColor = Color.Red;
            radiosoftware.ForeColor = Color.Black;

            var products = _LoadProducts(ProductEnum.Hardware);
            cmb1.Items.Clear();
            cmb1.Items.AddRange(products.ToArray());
            cmb1.SelectedIndex = products.Count > 0 ? 0 : -1;
        }

        private List<Product> _LoadProducts(ProductEnum filter)
        {
            List<Product> result = new List<Product>();
            if (filter.Equals(ProductEnum.Software))
            {
                result = new List<Product>() {
                new Product(7, "aaa", Convert.ToDecimal(6.8), 3),
                new Product(9, "bbb", 5, 100)
            };
            }
            if (filter.Equals(ProductEnum.Hardware))
            {
                result = new List<Product>() {
                    new Product(1, "cccc", Convert.ToDecimal(6.7), 6),
                    new Product(2, "dddd", 5, 6)
                 };
            }
            //aici este locul unde apelezi ceva functie care iti incarca din baza de date produsele de tipul enum-ului
            return result;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radiosoftware.ForeColor = Color.Red;
            radiohardware.ForeColor = Color.Black;
            List<Product> products = _LoadProducts(ProductEnum.Software);
            cmb1.Items.Clear();
            cmb1.Items.AddRange(products.ToArray());
            cmb1.SelectedIndex = products.Count > 0 ? 0 : -1;
        }

        private void tbPret_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }


        private void tbCantitate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbSubTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }


        private void tbIncasat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Product selectedProduct = cmb1.SelectedItem as Product;
            txtPrice.Text = selectedProduct.Price.ToString();
            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                errorProvider1.SetError(box_incasat, "Introdu un numar");
            }
            if (!decimal.TryParse(txtQuantity.Value.ToString(), out decimal quantity))
            {
                errorProvider1.SetError(box_incasat, "Introdu o cantitate");
            }

            txtTotalPrice.Text = Convert.ToDecimal(Convert.ToDecimal(price) * quantity).ToString();
        }

        private void btn_cumpara_Click(object sender, EventArgs e)
        {
            if (box_incasat.Text == "")
            {
                errorProvider1.SetError(box_incasat, "Introduceti suma de bani incasata !!!");
                MessageBox.Show("Introduceti suma de bani incasata!!!");
            }
            else

            if (_Cart.Client == null)
            {
                errorProvider1.SetError(listView1, "Selectati un client !!!");
                MessageBox.Show("Selectati un client !!!");
            }
            else
            if (_Cart.Items.Count == 0)
            {
                MessageBox.Show("Nu aveti produse in cos!", "Empty cart!", MessageBoxButtons.OK);
            }
            //aici mai trebuie facute alte validari de cos de cumparaturi
        }

        private void schimbaCuloareaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                this.BackColor = dlg.Color;
        }

        private void schimbaFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                this.Font = dlg.Font;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {


            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                errorProvider1.SetError(box_incasat, "Introdu un numar");
            }
            if (!decimal.TryParse(txtQuantity.Value.ToString(), out decimal quantity))
            {
                errorProvider1.SetError(box_incasat, "Introdu o cantitate");
            }

            txtTotalPrice.Text = Convert.ToDecimal(price * quantity).ToString();

        }

        private void acces_to_AddClient_Click(object sender, EventArgs e)
        {
            //AddClient frm = new AddClient();
            //frm.Show();
        }

        DataTable table = new DataTable();

        private void btn_adaugaprodus_Click(object sender, EventArgs e)
        {

            Product selectedProduct = cmb1.SelectedItem as Product;
            if (!int.TryParse(txtQuantity.Text, out int quantity))
            {
                errorProvider1.SetError(box_incasat, "Introdu o cantitate!");
            }

            _Cart.AddProduct(selectedProduct, quantity);

            listCumpara.Items.Add(new ListViewItem(new string[]
             {
                selectedProduct.Id.ToString(),
                selectedProduct.Name,
                txtQuantity.Text,
                txtPrice.Text,
                txtTotalPrice.Text
                 // Convert.ToInt32(txtQuantity) * Convert.ToDecimal(txtTotalPrice)



             }));

            box_subtotal.Text = (Convert.ToDecimal(box_subtotal.Text) + Convert.ToDecimal(txtTotalPrice.Text)).ToString();

            //aici trebuie sa fac update la subtotal si ce mai am pe sub tabelul ala

        }

        private void listProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ar fi frumos aici ca sa il autoselectez in dropdown-ul de mai sus ca omul sa poata schimba cantitatea selectata
        }


        private void adaugaClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSetClient_Click(object sender, EventArgs e)
        {
            //aici trebuie sa setez proprietate Client din Cart
        }

        private void Cumpara_Load(object sender, EventArgs e)
        {
            var products = _LoadProducts(ProductEnum.Hardware);
            cmb1.Items.Clear();
            cmb1.Items.AddRange(products.ToArray());
            cmb1.SelectedIndex = products.Count > 0 ? 0 : -1;
            box_subtotal.Text = (0).ToString();
            box_discount.Text = (0).ToString();
        }

        private void txtplatit_Click(object sender, EventArgs e)
        {

        }
        private void txtdiscount_Click(object sender, EventArgs e)
        {

        }

        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void meniuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AddProdus frm = new AddProdus();
            //frm.Show();
        }

        private void adaugaClientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           // AddClient frm = new AddClient();
            //frm.Show();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //List<Tranzactii> list = new List<Tranzactii> ;

            //foreach (p in)
            //{

            //}



            //using (SaveFileDialog dlg = new SaveFileDialog() { Filter = "Text documents|*.txt", ValidateNames = true })
            //{
            //    if (dlg.ShowDialog() == DialogResult.OK)
            //    {
            //        using (TextWriter tw = new StreamWriter(new FileStream(dlg.FileName, FileMode.Create), Encoding.UTF8))
            //        {
            //            foreach (ListView item in listCumpara.Items)
            //            {
            //                await tw.WriteLineAsync(item.SubItems[0].Text + "\t" + item.SubItems[1])
            //            }
            //        }
            //    }

            //}




        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listCumpara.Items)
                if (itm.Checked)
                {
                    itm.Remove();
                    box_subtotal.Text = (Convert.ToDecimal(box_subtotal.Text) - Convert.ToDecimal(txtTotalPrice.Text)).ToString();
                }

        }

        private void listCumpara_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
                e.Item.BackColor = Color.Gray;
        }

        private void box_net_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            if (box_net != null)
            {
                box_net.Text = (Convert.ToDecimal(box_subtotal.Text) - Convert.ToDecimal(box_discount.Value) / 100 * Convert.ToDecimal(box_subtotal.Text)).ToString();
            }

        }

        private void lstClients_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void box_balanta_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_incasat_TextChanged(object sender, EventArgs e)
        {
            
            if (box_incasat.Text == "")
            {
                MessageBox.Show("Completati suma incasata!");
                box_incasat.Text = (0).ToString() ;



            }
            box_balanta.Text = (Convert.ToDecimal(box_incasat.Text) - Convert.ToDecimal(box_net.Text)).ToString();
        }

        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 frm = new AboutBox1();
            frm.Show();
        }

        private void listCumpara_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Main frm = new Main();
            //frm.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
