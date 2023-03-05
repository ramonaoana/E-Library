namespace Biblioteca
{
    partial class FormImprumuturi
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
            this.listViewCititori = new System.Windows.Forms.ListView();
            this.columnHeaderIdCititor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNumeCititor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAdresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCNP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewCarti = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAutor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEditura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNrPagini = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxNrCarti = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxIdCititor = new System.Windows.Forms.TextBox();
            this.textBoxIdImprumut = new System.Windows.Forms.TextBox();
            this.labelNrCarti = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewCititori
            // 
            this.listViewCititori.AllowDrop = true;
            this.listViewCititori.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderIdCititor,
            this.columnHeaderNumeCititor,
            this.columnHeaderAdresa,
            this.columnHeaderEmail,
            this.columnHeaderCNP});
            this.listViewCititori.FullRowSelect = true;
            this.listViewCititori.GridLines = true;
            this.listViewCititori.HideSelection = false;
            this.listViewCititori.Location = new System.Drawing.Point(12, 95);
            this.listViewCititori.Name = "listViewCititori";
            this.listViewCititori.Size = new System.Drawing.Size(516, 417);
            this.listViewCititori.TabIndex = 0;
            this.listViewCititori.UseCompatibleStateImageBehavior = false;
            this.listViewCititori.View = System.Windows.Forms.View.Details;
            this.listViewCititori.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewCititori_MouseDown);
            // 
            // columnHeaderIdCititor
            // 
            this.columnHeaderIdCititor.Text = "ID Cititor";
            this.columnHeaderIdCititor.Width = 115;
            // 
            // columnHeaderNumeCititor
            // 
            this.columnHeaderNumeCititor.Text = "NumeCititor";
            this.columnHeaderNumeCititor.Width = 138;
            // 
            // columnHeaderAdresa
            // 
            this.columnHeaderAdresa.Text = "Adresa";
            this.columnHeaderAdresa.Width = 128;
            // 
            // columnHeaderEmail
            // 
            this.columnHeaderEmail.Text = "Email";
            this.columnHeaderEmail.Width = 133;
            // 
            // columnHeaderCNP
            // 
            this.columnHeaderCNP.Text = "CNP";
            this.columnHeaderCNP.Width = 133;
            // 
            // listViewCarti
            // 
            this.listViewCarti.AllowDrop = true;
            this.listViewCarti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderNume,
            this.columnHeaderAutor,
            this.columnHeaderEditura,
            this.columnHeaderPret,
            this.columnHeaderNrPagini,
            this.columnHeaderTip});
            this.listViewCarti.FullRowSelect = true;
            this.listViewCarti.GridLines = true;
            this.listViewCarti.HideSelection = false;
            this.listViewCarti.Location = new System.Drawing.Point(548, 95);
            this.listViewCarti.Name = "listViewCarti";
            this.listViewCarti.Size = new System.Drawing.Size(457, 417);
            this.listViewCarti.TabIndex = 2;
            this.listViewCarti.UseCompatibleStateImageBehavior = false;
            this.listViewCarti.View = System.Windows.Forms.View.Details;
            this.listViewCarti.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewCarti_MouseDown);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID Carte";
            this.columnHeaderID.Width = 77;
            // 
            // columnHeaderNume
            // 
            this.columnHeaderNume.Text = "NumeCarte";
            this.columnHeaderNume.Width = 114;
            // 
            // columnHeaderAutor
            // 
            this.columnHeaderAutor.Text = "Autor";
            this.columnHeaderAutor.Width = 101;
            // 
            // columnHeaderEditura
            // 
            this.columnHeaderEditura.Text = "Editura";
            this.columnHeaderEditura.Width = 53;
            // 
            // columnHeaderPret
            // 
            this.columnHeaderPret.Text = "Pret";
            this.columnHeaderPret.Width = 94;
            // 
            // columnHeaderNrPagini
            // 
            this.columnHeaderNrPagini.Text = "NrPagini";
            this.columnHeaderNrPagini.Width = 130;
            // 
            // columnHeaderTip
            // 
            this.columnHeaderTip.Text = "TipCarte";
            this.columnHeaderTip.Width = 130;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(205, 558);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(614, 309);
            this.treeView1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.textBoxNrCarti);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.textBoxIdCititor);
            this.panel1.Controls.Add(this.textBoxIdImprumut);
            this.panel1.Controls.Add(this.labelNrCarti);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1102, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 984);
            this.panel1.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(41, 116);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 35);
            this.button3.TabIndex = 22;
            this.button3.Text = "Printeaza Fisa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 842);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 47);
            this.button1.TabIndex = 21;
            this.button1.Text = "Adauga";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(50, 625);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(654, 142);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
            this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IdCarte";
            this.columnHeader1.Width = 97;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NumeCarte";
            this.columnHeader2.Width = 117;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Autor";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Editura";
            this.columnHeader4.Width = 88;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Pret";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "NrPagini";
            this.columnHeader6.Width = 103;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tip";
            // 
            // textBoxNrCarti
            // 
            this.textBoxNrCarti.Location = new System.Drawing.Point(296, 528);
            this.textBoxNrCarti.Multiline = true;
            this.textBoxNrCarti.Name = "textBoxNrCarti";
            this.textBoxNrCarti.Size = new System.Drawing.Size(47, 27);
            this.textBoxNrCarti.TabIndex = 19;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(284, 461);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(288, 22);
            this.dateTimePicker2.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(284, 396);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(288, 22);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // textBoxIdCititor
            // 
            this.textBoxIdCititor.AllowDrop = true;
            this.textBoxIdCititor.Location = new System.Drawing.Point(284, 333);
            this.textBoxIdCititor.Multiline = true;
            this.textBoxIdCititor.Name = "textBoxIdCititor";
            this.textBoxIdCititor.Size = new System.Drawing.Size(289, 27);
            this.textBoxIdCititor.TabIndex = 16;
            this.textBoxIdCititor.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxIdCititor_DragDrop);
            this.textBoxIdCititor.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxIdCititor_DragEnter);
            // 
            // textBoxIdImprumut
            // 
            this.textBoxIdImprumut.Location = new System.Drawing.Point(284, 274);
            this.textBoxIdImprumut.Multiline = true;
            this.textBoxIdImprumut.Name = "textBoxIdImprumut";
            this.textBoxIdImprumut.Size = new System.Drawing.Size(289, 27);
            this.textBoxIdImprumut.TabIndex = 15;
            this.textBoxIdImprumut.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxIdImprumut_Validating);
            this.textBoxIdImprumut.Validated += new System.EventHandler(this.textBoxIdImprumut_Validated);
            // 
            // labelNrCarti
            // 
            this.labelNrCarti.BackColor = System.Drawing.Color.Orange;
            this.labelNrCarti.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNrCarti.Location = new System.Drawing.Point(67, 528);
            this.labelNrCarti.Name = "labelNrCarti";
            this.labelNrCarti.Size = new System.Drawing.Size(185, 27);
            this.labelNrCarti.TabIndex = 14;
            this.labelNrCarti.Text = "NR CARTI:";
            this.labelNrCarti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Orange;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 27);
            this.label4.TabIndex = 13;
            this.label4.Text = "DATA RESTITUIRE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Orange;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "DATA IMPRUMUT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID CITITOR";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID IMPRUMUT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(182, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(412, 53);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fisa de lectura";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 558);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 53);
            this.button2.TabIndex = 5;
            this.button2.Text = "Vezi Imprumuturi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FormImprumuturi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1855, 984);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listViewCarti);
            this.Controls.Add(this.listViewCititori);
            this.Name = "FormImprumuturi";
            this.Text = "FormImprumturi";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormImprumuturi_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewCititori;
        private System.Windows.Forms.ListView listViewCarti;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderNume;
        private System.Windows.Forms.ColumnHeader columnHeaderAutor;
        private System.Windows.Forms.ColumnHeader columnHeaderTip;
        private System.Windows.Forms.ColumnHeader columnHeaderIdCititor;
        private System.Windows.Forms.ColumnHeader columnHeaderNumeCititor;
        private System.Windows.Forms.ColumnHeader columnHeaderCNP;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ColumnHeader columnHeaderAdresa;
        private System.Windows.Forms.ColumnHeader columnHeaderEmail;
        private System.Windows.Forms.ColumnHeader columnHeaderEditura;
        private System.Windows.Forms.ColumnHeader columnHeaderPret;
        private System.Windows.Forms.ColumnHeader columnHeaderNrPagini;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelNrCarti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxNrCarti;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox textBoxIdCititor;
        public System.Windows.Forms.TextBox textBoxIdImprumut;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}