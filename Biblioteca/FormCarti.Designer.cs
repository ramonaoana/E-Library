namespace Biblioteca
{
    partial class FormCarti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarti));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderIdCarte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAutor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEditura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNrPagini = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adaugaCarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaOCarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeOCarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaInFisierXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.restaurareFisierXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderIdCarte,
            this.columnHeaderNume,
            this.columnHeaderAutor,
            this.columnHeaderEditura,
            this.columnHeaderPret,
            this.columnHeaderNrPagini,
            this.columnHeaderTip});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(308, 268);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1160, 519);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView1_ItemChecked);
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            // 
            // columnHeaderIdCarte
            // 
            this.columnHeaderIdCarte.Text = "Id Carte";
            this.columnHeaderIdCarte.Width = 92;
            // 
            // columnHeaderNume
            // 
            this.columnHeaderNume.Text = "Nume Carte";
            this.columnHeaderNume.Width = 181;
            // 
            // columnHeaderAutor
            // 
            this.columnHeaderAutor.Text = "Autor";
            this.columnHeaderAutor.Width = 172;
            // 
            // columnHeaderEditura
            // 
            this.columnHeaderEditura.Text = "Editura";
            this.columnHeaderEditura.Width = 118;
            // 
            // columnHeaderPret
            // 
            this.columnHeaderPret.Text = "Pret";
            // 
            // columnHeaderNrPagini
            // 
            this.columnHeaderNrPagini.Text = "NrPagini";
            this.columnHeaderNrPagini.Width = 93;
            // 
            // columnHeaderTip
            // 
            this.columnHeaderTip.Text = "Tip Carte";
            this.columnHeaderTip.Width = 131;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaCarteToolStripMenuItem,
            this.modificaOCarteToolStripMenuItem,
            this.stergeOCarteToolStripMenuItem,
            this.salveazaInFisierXMLToolStripMenuItem,
            this.restaurareFisierXMLToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(222, 152);
            // 
            // adaugaCarteToolStripMenuItem
            // 
            this.adaugaCarteToolStripMenuItem.Name = "adaugaCarteToolStripMenuItem";
            this.adaugaCarteToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.adaugaCarteToolStripMenuItem.Text = "Adauga o carte";
            this.adaugaCarteToolStripMenuItem.Click += new System.EventHandler(this.adaugaCarteToolStripMenuItem_Click);
            // 
            // modificaOCarteToolStripMenuItem
            // 
            this.modificaOCarteToolStripMenuItem.Name = "modificaOCarteToolStripMenuItem";
            this.modificaOCarteToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.modificaOCarteToolStripMenuItem.Text = "Modifica o carte";
            this.modificaOCarteToolStripMenuItem.Click += new System.EventHandler(this.modificaOCarteToolStripMenuItem_Click);
            // 
            // stergeOCarteToolStripMenuItem
            // 
            this.stergeOCarteToolStripMenuItem.Name = "stergeOCarteToolStripMenuItem";
            this.stergeOCarteToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.stergeOCarteToolStripMenuItem.Text = "Sterge o carte";
            this.stergeOCarteToolStripMenuItem.Click += new System.EventHandler(this.stergeOCarteToolStripMenuItem_Click);
            // 
            // salveazaInFisierXMLToolStripMenuItem
            // 
            this.salveazaInFisierXMLToolStripMenuItem.Name = "salveazaInFisierXMLToolStripMenuItem";
            this.salveazaInFisierXMLToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.salveazaInFisierXMLToolStripMenuItem.Text = "Salveaza in fisier XML";
            this.salveazaInFisierXMLToolStripMenuItem.Click += new System.EventHandler(this.salveazaInFisierXMLToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(494, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(775, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de carti din biblioteca Sky";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // restaurareFisierXMLToolStripMenuItem
            // 
            this.restaurareFisierXMLToolStripMenuItem.Name = "restaurareFisierXMLToolStripMenuItem";
            this.restaurareFisierXMLToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.restaurareFisierXMLToolStripMenuItem.Text = "Restaurare fisier XML";
            this.restaurareFisierXMLToolStripMenuItem.Click += new System.EventHandler(this.restaurareFisierXMLToolStripMenuItem_Click);
            // 
            // FormCarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1586, 751);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "FormCarti";
            this.Text = "FormCarti";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeaderIdCarte;
        private System.Windows.Forms.ColumnHeader columnHeaderNume;
        private System.Windows.Forms.ColumnHeader columnHeaderAutor;
        private System.Windows.Forms.ColumnHeader columnHeaderEditura;
        private System.Windows.Forms.ColumnHeader columnHeaderPret;
        private System.Windows.Forms.ColumnHeader columnHeaderNrPagini;
        private System.Windows.Forms.ColumnHeader columnHeaderTip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adaugaCarteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaOCarteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeOCarteToolStripMenuItem;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripMenuItem salveazaInFisierXMLToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem restaurareFisierXMLToolStripMenuItem;
    }
}