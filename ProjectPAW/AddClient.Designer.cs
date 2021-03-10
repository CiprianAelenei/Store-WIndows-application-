namespace ProjectPAW
{
    partial class AddClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mENIUToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cumparaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afisajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schimbaCuloareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schimbaFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.chkCardFidelitate = new System.Windows.Forms.CheckBox();
            this.cmbCategorieClient = new System.Windows.Forms.ComboBox();
            this.lstClients = new System.Windows.Forms.ListView();
            this.clmn_IDclient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmn_Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmn_Prenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmn_CardFidel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmn_Categorie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adaugare client nou in baza de date KipBYTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Numar Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(113, 182);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(201, 20);
            this.txtNume.TabIndex = 7;
            this.txtNume.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(113, 230);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(125, 20);
            this.txtTelefon.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(113, 256);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(125, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniuToolStripMenuItem,
            this.afisajToolStripMenuItem,
            this.despreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(936, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniuToolStripMenuItem
            // 
            this.meniuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENIUToolStripMenuItem1,
            this.adaugaClientToolStripMenuItem,
            this.cumparaToolStripMenuItem});
            this.meniuToolStripMenuItem.Name = "meniuToolStripMenuItem";
            this.meniuToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.meniuToolStripMenuItem.Text = "Meniu";
            // 
            // mENIUToolStripMenuItem1
            // 
            this.mENIUToolStripMenuItem1.Name = "mENIUToolStripMenuItem1";
            this.mENIUToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.mENIUToolStripMenuItem1.Text = "HOME";
            this.mENIUToolStripMenuItem1.Click += new System.EventHandler(this.mENIUToolStripMenuItem1_Click);
            // 
            // adaugaClientToolStripMenuItem
            // 
            this.adaugaClientToolStripMenuItem.Name = "adaugaClientToolStripMenuItem";
            this.adaugaClientToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.adaugaClientToolStripMenuItem.Text = "Adauga produs";
            //this.adaugaClientToolStripMenuItem.Click += new System.EventHandler(this.adaugaClientToolStripMenuItem_Click);
            // 
            // cumparaToolStripMenuItem
            // 
            this.cumparaToolStripMenuItem.Name = "cumparaToolStripMenuItem";
            this.cumparaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.cumparaToolStripMenuItem.Text = "Cumpara!";
            this.cumparaToolStripMenuItem.Click += new System.EventHandler(this.cumparaToolStripMenuItem_Click);
            // 
            // afisajToolStripMenuItem
            // 
            this.afisajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schimbaCuloareToolStripMenuItem,
            this.schimbaFontToolStripMenuItem});
            this.afisajToolStripMenuItem.Name = "afisajToolStripMenuItem";
            this.afisajToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.afisajToolStripMenuItem.Text = "Afisaj";
            // 
            // schimbaCuloareToolStripMenuItem
            // 
            this.schimbaCuloareToolStripMenuItem.Name = "schimbaCuloareToolStripMenuItem";
            this.schimbaCuloareToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.schimbaCuloareToolStripMenuItem.Text = "Schimba culoare";
            this.schimbaCuloareToolStripMenuItem.Click += new System.EventHandler(this.schimbaCuloareToolStripMenuItem_Click);
            // 
            // schimbaFontToolStripMenuItem
            // 
            this.schimbaFontToolStripMenuItem.Name = "schimbaFontToolStripMenuItem";
            this.schimbaFontToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.schimbaFontToolStripMenuItem.Text = "Schimba font";
            this.schimbaFontToolStripMenuItem.Click += new System.EventHandler(this.schimbaFontToolStripMenuItem_Click_1);
            // 
            // despreToolStripMenuItem
            // 
            this.despreToolStripMenuItem.Name = "despreToolStripMenuItem";
            this.despreToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.despreToolStripMenuItem.Text = "Despre";
            this.despreToolStripMenuItem.Click += new System.EventHandler(this.despreToolStripMenuItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Categorie client";
            // 
            // chkCardFidelitate
            // 
            this.chkCardFidelitate.AutoSize = true;
            this.chkCardFidelitate.Location = new System.Drawing.Point(113, 285);
            this.chkCardFidelitate.Name = "chkCardFidelitate";
            this.chkCardFidelitate.Size = new System.Drawing.Size(93, 17);
            this.chkCardFidelitate.TabIndex = 19;
            this.chkCardFidelitate.Text = "Card Fidelitate";
            this.chkCardFidelitate.UseVisualStyleBackColor = true;
            // 
            // cmbCategorieClient
            // 
            this.cmbCategorieClient.FormattingEnabled = true;
            this.cmbCategorieClient.Items.AddRange(new object[] {
            "normal ",
            "bronze ",
            "silver ",
            "gold"});
            this.cmbCategorieClient.Location = new System.Drawing.Point(113, 308);
            this.cmbCategorieClient.Name = "cmbCategorieClient";
            this.cmbCategorieClient.Size = new System.Drawing.Size(125, 21);
            this.cmbCategorieClient.TabIndex = 20;
            // 
            // lstClients
            // 
            this.lstClients.BackColor = System.Drawing.Color.Gainsboro;
            this.lstClients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmn_IDclient,
            this.clmn_Nume,
            this.clmn_Prenume,
            this.clmn_CardFidel,
            this.clmn_Categorie});
            this.lstClients.GridLines = true;
            this.lstClients.HideSelection = false;
            this.lstClients.Location = new System.Drawing.Point(345, 182);
            this.lstClients.Name = "lstClients";
            this.lstClients.Size = new System.Drawing.Size(580, 260);
            this.lstClients.TabIndex = 21;
            this.lstClients.UseCompatibleStateImageBehavior = false;
            this.lstClients.View = System.Windows.Forms.View.Details;
            // 
            // clmn_IDclient
            // 
            this.clmn_IDclient.Text = "IDclient";
            this.clmn_IDclient.Width = 50;
            // 
            // clmn_Nume
            // 
            this.clmn_Nume.Text = "Nume";
            this.clmn_Nume.Width = 143;
            // 
            // clmn_Prenume
            // 
            this.clmn_Prenume.Text = "Telefon";
            this.clmn_Prenume.Width = 132;
            // 
            // clmn_CardFidel
            // 
            this.clmn_CardFidel.Text = "CardFidel";
            this.clmn_CardFidel.Width = 150;
            // 
            // clmn_Categorie
            // 
            this.clmn_Categorie.Text = "Categorie";
            this.clmn_Categorie.Width = 134;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(113, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 47);
            this.button1.TabIndex = 23;
            this.button1.Text = "Adauga client";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Britannic Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(345, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 35);
            this.button2.TabIndex = 24;
            this.button2.Text = "Salveaza lista intr-un fisier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddClient
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(936, 547);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstClients);
            this.Controls.Add(this.cmbCategorieClient);
            this.Controls.Add(this.chkCardFidelitate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddClient";
            this.Text = "AddClient";
            this.Load += new System.EventHandler(this.AddClient_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem afisajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schimbaCuloareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schimbaFontToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkCardFidelitate;
        private System.Windows.Forms.ComboBox cmbCategorieClient;
        private System.Windows.Forms.ListView lstClients;
        private System.Windows.Forms.ColumnHeader clmn_IDclient;
        private System.Windows.Forms.ColumnHeader clmn_Nume;
        private System.Windows.Forms.ColumnHeader clmn_Prenume;
        private System.Windows.Forms.ColumnHeader clmn_CardFidel;
        private System.Windows.Forms.ColumnHeader clmn_Categorie;
        private System.Windows.Forms.ToolStripMenuItem meniuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cumparaToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem despreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mENIUToolStripMenuItem1;
    }
}