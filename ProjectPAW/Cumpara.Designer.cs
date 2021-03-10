namespace ProjectPAW
{
    partial class Cumpara
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cumpara));
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radiohardware = new System.Windows.Forms.RadioButton();
            this.radiosoftware = new System.Windows.Forms.RadioButton();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.btn_adaugaprodus = new System.Windows.Forms.Button();
            this.txtprod = new System.Windows.Forms.Label();
            this.txtsubtotal = new System.Windows.Forms.Label();
            this.box_subtotal = new System.Windows.Forms.TextBox();
            this.txtdiscount = new System.Windows.Forms.Label();
            this.box_net = new System.Windows.Forms.TextBox();
            this.txtnet = new System.Windows.Forms.Label();
            this.box_incasat = new System.Windows.Forms.TextBox();
            this.txtplatit = new System.Windows.Forms.Label();
            this.box_balanta = new System.Windows.Forms.TextBox();
            this.txtrest = new System.Windows.Forms.Label();
            this.btn_cumpara = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.schimbaCuloareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adaugaClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meniuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaClientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.afisajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schimbaCuloareaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.schimbaFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtQuantity = new System.Windows.Forms.NumericUpDown();
            this.acces_to_AddClient = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSetClient = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listCumpara = new System.Windows.Forms.ListView();
            this.columnCodProdus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPretProd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCantitate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPretTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_delete = new System.Windows.Forms.Button();
            this.box_discount = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_discount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Location = new System.Drawing.Point(203, 154);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(489, 21);
            this.cmb1.TabIndex = 3;
            this.cmb1.Text = " ";
            this.cmb1.SelectedIndexChanged += new System.EventHandler(this.cmb1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 60);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selecteaza\r\nProdusul";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radiohardware
            // 
            this.radiohardware.AutoSize = true;
            this.radiohardware.Checked = true;
            this.radiohardware.Location = new System.Drawing.Point(203, 123);
            this.radiohardware.Name = "radiohardware";
            this.radiohardware.Size = new System.Drawing.Size(89, 17);
            this.radiohardware.TabIndex = 5;
            this.radiohardware.TabStop = true;
            this.radiohardware.Text = "HARDWARE";
            this.radiohardware.UseVisualStyleBackColor = true;
            this.radiohardware.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radiosoftware
            // 
            this.radiosoftware.AutoSize = true;
            this.radiosoftware.Location = new System.Drawing.Point(298, 123);
            this.radiosoftware.Name = "radiosoftware";
            this.radiosoftware.Size = new System.Drawing.Size(86, 17);
            this.radiosoftware.TabIndex = 6;
            this.radiosoftware.TabStop = true;
            this.radiosoftware.Text = "SOFTWARE";
            this.radiosoftware.UseVisualStyleBackColor = true;
            this.radiosoftware.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(203, 219);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(108, 20);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPret_KeyPress);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(200, 203);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(29, 13);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Pret:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(387, 203);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(52, 13);
            this.lblQuantity.TabIndex = 11;
            this.lblQuantity.Text = "Cantitate:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(581, 203);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(52, 13);
            this.lblTotalPrice.TabIndex = 13;
            this.lblTotalPrice.Text = "Pret total:";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(584, 222);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(108, 20);
            this.txtTotalPrice.TabIndex = 12;
            this.txtTotalPrice.TextChanged += new System.EventHandler(this.txtTotalPrice_TextChanged);
            // 
            // btn_adaugaprodus
            // 
            this.btn_adaugaprodus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_adaugaprodus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adaugaprodus.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_adaugaprodus.Location = new System.Drawing.Point(725, 154);
            this.btn_adaugaprodus.Name = "btn_adaugaprodus";
            this.btn_adaugaprodus.Size = new System.Drawing.Size(127, 88);
            this.btn_adaugaprodus.TabIndex = 14;
            this.btn_adaugaprodus.Text = "Adauga Produs in cos";
            this.btn_adaugaprodus.UseVisualStyleBackColor = false;
            this.btn_adaugaprodus.Click += new System.EventHandler(this.btn_adaugaprodus_Click);
            // 
            // txtprod
            // 
            this.txtprod.AutoSize = true;
            this.txtprod.Font = new System.Drawing.Font("NSimSun", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprod.ForeColor = System.Drawing.Color.DarkMagenta;
            this.txtprod.Location = new System.Drawing.Point(323, 36);
            this.txtprod.Name = "txtprod";
            this.txtprod.Size = new System.Drawing.Size(292, 64);
            this.txtprod.TabIndex = 16;
            this.txtprod.Text = "Cumpara!";
            this.txtprod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.AutoSize = true;
            this.txtsubtotal.Location = new System.Drawing.Point(21, 555);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(56, 13);
            this.txtsubtotal.TabIndex = 17;
            this.txtsubtotal.Text = "Sub Total:";
            // 
            // box_subtotal
            // 
            this.box_subtotal.Location = new System.Drawing.Point(83, 553);
            this.box_subtotal.Name = "box_subtotal";
            this.box_subtotal.ReadOnly = true;
            this.box_subtotal.Size = new System.Drawing.Size(100, 20);
            this.box_subtotal.TabIndex = 18;
            // 
            // txtdiscount
            // 
            this.txtdiscount.AutoSize = true;
            this.txtdiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscount.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtdiscount.Location = new System.Drawing.Point(238, 553);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(99, 16);
            this.txtdiscount.TabIndex = 19;
            this.txtdiscount.Text = "Discount (%):";
            this.txtdiscount.Click += new System.EventHandler(this.txtdiscount_Click);
            // 
            // box_net
            // 
            this.box_net.Location = new System.Drawing.Point(493, 551);
            this.box_net.Name = "box_net";
            this.box_net.ReadOnly = true;
            this.box_net.Size = new System.Drawing.Size(100, 20);
            this.box_net.TabIndex = 22;
            this.box_net.TextChanged += new System.EventHandler(this.box_net_TextChanged);
            // 
            // txtnet
            // 
            this.txtnet.AutoSize = true;
            this.txtnet.Location = new System.Drawing.Point(460, 558);
            this.txtnet.Name = "txtnet";
            this.txtnet.Size = new System.Drawing.Size(27, 13);
            this.txtnet.TabIndex = 21;
            this.txtnet.Text = "Net:";
            // 
            // box_incasat
            // 
            this.box_incasat.Location = new System.Drawing.Point(493, 577);
            this.box_incasat.Name = "box_incasat";
            this.box_incasat.Size = new System.Drawing.Size(100, 20);
            this.box_incasat.TabIndex = 24;
            this.box_incasat.TextChanged += new System.EventHandler(this.box_incasat_TextChanged);
            this.box_incasat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIncasat_KeyPress);
            // 
            // txtplatit
            // 
            this.txtplatit.AutoSize = true;
            this.txtplatit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtplatit.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtplatit.Location = new System.Drawing.Point(425, 582);
            this.txtplatit.Name = "txtplatit";
            this.txtplatit.Size = new System.Drawing.Size(62, 16);
            this.txtplatit.TabIndex = 23;
            this.txtplatit.Text = "Incasat:";
            this.txtplatit.Click += new System.EventHandler(this.txtplatit_Click);
            // 
            // box_balanta
            // 
            this.box_balanta.Location = new System.Drawing.Point(493, 603);
            this.box_balanta.Name = "box_balanta";
            this.box_balanta.ReadOnly = true;
            this.box_balanta.Size = new System.Drawing.Size(100, 20);
            this.box_balanta.TabIndex = 26;
            this.box_balanta.TextChanged += new System.EventHandler(this.box_balanta_TextChanged);
            // 
            // txtrest
            // 
            this.txtrest.AutoSize = true;
            this.txtrest.Location = new System.Drawing.Point(400, 610);
            this.txtrest.Name = "txtrest";
            this.txtrest.Size = new System.Drawing.Size(87, 13);
            this.txtrest.TabIndex = 25;
            this.txtrest.Text = "Rest de inapoiat:";
            // 
            // btn_cumpara
            // 
            this.btn_cumpara.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_cumpara.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cumpara.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_cumpara.Location = new System.Drawing.Point(678, 603);
            this.btn_cumpara.Name = "btn_cumpara";
            this.btn_cumpara.Size = new System.Drawing.Size(224, 73);
            this.btn_cumpara.TabIndex = 27;
            this.btn_cumpara.Text = "Cumpara";
            this.btn_cumpara.UseVisualStyleBackColor = false;
            this.btn_cumpara.Click += new System.EventHandler(this.btn_cumpara_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schimbaCuloareaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 26);
            // 
            // schimbaCuloareaToolStripMenuItem
            // 
            this.schimbaCuloareaToolStripMenuItem.Name = "schimbaCuloareaToolStripMenuItem";
            this.schimbaCuloareaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.schimbaCuloareaToolStripMenuItem.Text = "Schimba culoarea";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaClientToolStripMenuItem,
            this.afisajToolStripMenuItem,
            this.despreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(914, 24);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // adaugaClientToolStripMenuItem
            // 
            this.adaugaClientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.meniuToolStripMenuItem,
            this.adaugaClientToolStripMenuItem1});
            this.adaugaClientToolStripMenuItem.Name = "adaugaClientToolStripMenuItem";
            this.adaugaClientToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.adaugaClientToolStripMenuItem.Text = "Meniu";
            this.adaugaClientToolStripMenuItem.Click += new System.EventHandler(this.adaugaClientToolStripMenuItem_Click);
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.hOMEToolStripMenuItem.Text = "HOME";
            this.hOMEToolStripMenuItem.Click += new System.EventHandler(this.hOMEToolStripMenuItem_Click);
            // 
            // meniuToolStripMenuItem
            // 
            this.meniuToolStripMenuItem.Name = "meniuToolStripMenuItem";
            this.meniuToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.meniuToolStripMenuItem.Text = "Adauga produs";
            this.meniuToolStripMenuItem.Click += new System.EventHandler(this.meniuToolStripMenuItem_Click);
            // 
            // adaugaClientToolStripMenuItem1
            // 
            this.adaugaClientToolStripMenuItem1.Name = "adaugaClientToolStripMenuItem1";
            this.adaugaClientToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.adaugaClientToolStripMenuItem1.Text = "Adauga client";
            this.adaugaClientToolStripMenuItem1.Click += new System.EventHandler(this.adaugaClientToolStripMenuItem1_Click);
            // 
            // afisajToolStripMenuItem
            // 
            this.afisajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schimbaCuloareaToolStripMenuItem1,
            this.schimbaFontToolStripMenuItem});
            this.afisajToolStripMenuItem.Name = "afisajToolStripMenuItem";
            this.afisajToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.afisajToolStripMenuItem.Text = "Afisaj";
            // 
            // schimbaCuloareaToolStripMenuItem1
            // 
            this.schimbaCuloareaToolStripMenuItem1.Name = "schimbaCuloareaToolStripMenuItem1";
            this.schimbaCuloareaToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.schimbaCuloareaToolStripMenuItem1.Text = "Schimba culoarea";
            this.schimbaCuloareaToolStripMenuItem1.Click += new System.EventHandler(this.schimbaCuloareaToolStripMenuItem1_Click);
            // 
            // schimbaFontToolStripMenuItem
            // 
            this.schimbaFontToolStripMenuItem.Name = "schimbaFontToolStripMenuItem";
            this.schimbaFontToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.schimbaFontToolStripMenuItem.Text = "Schimba font";
            this.schimbaFontToolStripMenuItem.Click += new System.EventHandler(this.schimbaFontToolStripMenuItem_Click);
            // 
            // despreToolStripMenuItem
            // 
            this.despreToolStripMenuItem.Name = "despreToolStripMenuItem";
            this.despreToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.despreToolStripMenuItem.Text = "Despre";
            this.despreToolStripMenuItem.Click += new System.EventHandler(this.despreToolStripMenuItem_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtQuantity.Location = new System.Drawing.Point(390, 223);
            this.txtQuantity.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(120, 20);
            this.txtQuantity.TabIndex = 32;
            this.txtQuantity.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // acces_to_AddClient
            // 
            this.acces_to_AddClient.Location = new System.Drawing.Point(256, 582);
            this.acces_to_AddClient.Name = "acces_to_AddClient";
            this.acces_to_AddClient.Size = new System.Drawing.Size(138, 23);
            this.acces_to_AddClient.TabIndex = 33;
            this.acces_to_AddClient.Text = "Adauga Client";
            this.acces_to_AddClient.UseVisualStyleBackColor = true;
            this.acces_to_AddClient.Click += new System.EventHandler(this.acces_to_AddClient_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSetClient
            // 
            this.btnSetClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetClient.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnSetClient.Location = new System.Drawing.Point(256, 611);
            this.btnSetClient.Name = "btnSetClient";
            this.btnSetClient.Size = new System.Drawing.Size(138, 102);
            this.btnSetClient.TabIndex = 35;
            this.btnSetClient.Text = "Seteaza client";
            this.btnSetClient.UseVisualStyleBackColor = true;
            this.btnSetClient.Click += new System.EventHandler(this.btnSetClient_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 646);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 32);
            this.button1.TabIndex = 36;
            this.button1.Text = "Salveaza lista intr-un fisier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listCumpara
            // 
            this.listCumpara.CheckBoxes = true;
            this.listCumpara.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCodProdus,
            this.columnNume,
            this.columnPretProd,
            this.columnCantitate,
            this.columnPretTotal});
            this.listCumpara.FullRowSelect = true;
            this.listCumpara.GridLines = true;
            this.listCumpara.HideSelection = false;
            this.listCumpara.Location = new System.Drawing.Point(67, 249);
            this.listCumpara.Name = "listCumpara";
            this.listCumpara.Size = new System.Drawing.Size(798, 297);
            this.listCumpara.TabIndex = 37;
            this.listCumpara.UseCompatibleStateImageBehavior = false;
            this.listCumpara.View = System.Windows.Forms.View.Details;
            this.listCumpara.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listCumpara_ItemChecked);
            this.listCumpara.SelectedIndexChanged += new System.EventHandler(this.listCumpara_SelectedIndexChanged);
            // 
            // columnCodProdus
            // 
            this.columnCodProdus.Text = "Cod Produs";
            this.columnCodProdus.Width = 138;
            // 
            // columnNume
            // 
            this.columnNume.Text = "Nume Produs";
            this.columnNume.Width = 247;
            // 
            // columnPretProd
            // 
            this.columnPretProd.Text = "Pret produs";
            this.columnPretProd.Width = 170;
            // 
            // columnCantitate
            // 
            this.columnCantitate.Text = "Cantitate";
            this.columnCantitate.Width = 113;
            // 
            // columnPretTotal
            // 
            this.columnPretTotal.Text = "Pret total";
            this.columnPretTotal.Width = 128;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Turquoise;
            this.btn_delete.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_delete.Location = new System.Drawing.Point(678, 555);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(224, 28);
            this.btn_delete.TabIndex = 38;
            this.btn_delete.Text = "Sterge coloana selectata";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // box_discount
            // 
            this.box_discount.Location = new System.Drawing.Point(343, 553);
            this.box_discount.Name = "box_discount";
            this.box_discount.Size = new System.Drawing.Size(64, 20);
            this.box_discount.TabIndex = 39;
            this.box_discount.Tag = "%";
            this.box_discount.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nume,
            this.Prenume});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 582);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(238, 131);
            this.listView1.TabIndex = 40;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 108;
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            this.Nume.Width = 124;
            // 
            // Prenume
            // 
            this.Prenume.Text = "Prenume";
            this.Prenume.Width = 91;
            // 
            // Cumpara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(914, 725);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.box_discount);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.listCumpara);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSetClient);
            this.Controls.Add(this.acces_to_AddClient);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_cumpara);
            this.Controls.Add(this.box_balanta);
            this.Controls.Add(this.txtrest);
            this.Controls.Add(this.box_incasat);
            this.Controls.Add(this.txtplatit);
            this.Controls.Add(this.box_net);
            this.Controls.Add(this.txtnet);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.box_subtotal);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.txtprod);
            this.Controls.Add(this.btn_adaugaprodus);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.radiosoftware);
            this.Controls.Add(this.radiohardware);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Cumpara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestiune Vanzari";
            this.Load += new System.EventHandler(this.Cumpara_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_discount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radiohardware;
        private System.Windows.Forms.RadioButton radiosoftware;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Button btn_adaugaprodus;
        private System.Windows.Forms.Label txtprod;
        private System.Windows.Forms.Label txtsubtotal;
        private System.Windows.Forms.TextBox box_subtotal;
        private System.Windows.Forms.Label txtdiscount;
        private System.Windows.Forms.TextBox box_net;
        private System.Windows.Forms.Label txtnet;
        private System.Windows.Forms.TextBox box_incasat;
        private System.Windows.Forms.Label txtplatit;
        private System.Windows.Forms.TextBox box_balanta;
        private System.Windows.Forms.Label txtrest;
        private System.Windows.Forms.Button btn_cumpara;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem schimbaCuloareaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem afisajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schimbaCuloareaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem schimbaFontToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown txtQuantity;
        private System.Windows.Forms.Button acces_to_AddClient;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem adaugaClientToolStripMenuItem;
        private System.Windows.Forms.Button btnSetClient;
        private System.Windows.Forms.ToolStripMenuItem meniuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaClientToolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listCumpara;
        private System.Windows.Forms.ColumnHeader columnCodProdus;
        private System.Windows.Forms.ColumnHeader columnNume;
        private System.Windows.Forms.ColumnHeader columnPretProd;
        private System.Windows.Forms.ColumnHeader columnCantitate;
        private System.Windows.Forms.ColumnHeader columnPretTotal;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.NumericUpDown box_discount;
        private System.Windows.Forms.ToolStripMenuItem despreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Prenume;
    }
}

