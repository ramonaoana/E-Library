namespace Biblioteca
{
    partial class FormCititor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCititor));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeCititorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaCititorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailCititorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adaugaUnCititorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaUnCititorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeUnCititorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cititoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_PROIECTDataSet = new Biblioteca.DB_PROIECTDataSet();
            this.cititoriTableAdapter = new Biblioteca.DB_PROIECTDataSetTableAdapters.CititoriTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdCititor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNumeCititor = new System.Windows.Forms.TextBox();
            this.textBoxAdresaCititor = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxCNP = new System.Windows.Forms.TextBox();
            this.buttonSalveaza = new System.Windows.Forms.Button();
            this.buttonModifica = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cititoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PROIECTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numeCititorDataGridViewTextBoxColumn,
            this.adresaCititorDataGridViewTextBoxColumn,
            this.mailCititorDataGridViewTextBoxColumn,
            this.cnpDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.cititoriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(500, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1230, 270);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // numeCititorDataGridViewTextBoxColumn
            // 
            this.numeCititorDataGridViewTextBoxColumn.DataPropertyName = "NumeCititor";
            this.numeCititorDataGridViewTextBoxColumn.HeaderText = "NumeCititor";
            this.numeCititorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeCititorDataGridViewTextBoxColumn.Name = "numeCititorDataGridViewTextBoxColumn";
            // 
            // adresaCititorDataGridViewTextBoxColumn
            // 
            this.adresaCititorDataGridViewTextBoxColumn.DataPropertyName = "AdresaCititor";
            this.adresaCititorDataGridViewTextBoxColumn.HeaderText = "AdresaCititor";
            this.adresaCititorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresaCititorDataGridViewTextBoxColumn.Name = "adresaCititorDataGridViewTextBoxColumn";
            // 
            // mailCititorDataGridViewTextBoxColumn
            // 
            this.mailCititorDataGridViewTextBoxColumn.DataPropertyName = "MailCititor";
            this.mailCititorDataGridViewTextBoxColumn.HeaderText = "MailCititor";
            this.mailCititorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mailCititorDataGridViewTextBoxColumn.Name = "mailCititorDataGridViewTextBoxColumn";
            // 
            // cnpDataGridViewTextBoxColumn
            // 
            this.cnpDataGridViewTextBoxColumn.DataPropertyName = "Cnp";
            this.cnpDataGridViewTextBoxColumn.HeaderText = "Cnp";
            this.cnpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cnpDataGridViewTextBoxColumn.Name = "cnpDataGridViewTextBoxColumn";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaUnCititorToolStripMenuItem,
            this.modificaUnCititorToolStripMenuItem,
            this.stergeUnCititorToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(256, 76);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // adaugaUnCititorToolStripMenuItem
            // 
            this.adaugaUnCititorToolStripMenuItem.Name = "adaugaUnCititorToolStripMenuItem";
            this.adaugaUnCititorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.adaugaUnCititorToolStripMenuItem.Size = new System.Drawing.Size(255, 24);
            this.adaugaUnCititorToolStripMenuItem.Text = "Adauga un cititor";
            this.adaugaUnCititorToolStripMenuItem.Click += new System.EventHandler(this.adaugaUnCititorToolStripMenuItem_Click);
            // 
            // modificaUnCititorToolStripMenuItem
            // 
            this.modificaUnCititorToolStripMenuItem.Name = "modificaUnCititorToolStripMenuItem";
            this.modificaUnCititorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.modificaUnCititorToolStripMenuItem.Size = new System.Drawing.Size(255, 24);
            this.modificaUnCititorToolStripMenuItem.Text = "Modifica un cititor";
            this.modificaUnCititorToolStripMenuItem.Click += new System.EventHandler(this.modificaUnCititorToolStripMenuItem_Click);
            // 
            // stergeUnCititorToolStripMenuItem
            // 
            this.stergeUnCititorToolStripMenuItem.Name = "stergeUnCititorToolStripMenuItem";
            this.stergeUnCititorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.stergeUnCititorToolStripMenuItem.Size = new System.Drawing.Size(255, 24);
            this.stergeUnCititorToolStripMenuItem.Text = "Sterge un cititor";
            this.stergeUnCititorToolStripMenuItem.Click += new System.EventHandler(this.stergeUnCititorToolStripMenuItem_Click);
            // 
            // cititoriBindingSource
            // 
            this.cititoriBindingSource.DataMember = "Cititori";
            this.cititoriBindingSource.DataSource = this.dB_PROIECTDataSet;
            // 
            // dB_PROIECTDataSet
            // 
            this.dB_PROIECTDataSet.DataSetName = "DB_PROIECTDataSet";
            this.dB_PROIECTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cititoriTableAdapter
            // 
            this.cititoriTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(475, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID CITITOR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Visible = false;
            // 
            // textBoxIdCititor
            // 
            this.textBoxIdCititor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdCititor.Location = new System.Drawing.Point(701, 508);
            this.textBoxIdCititor.Multiline = true;
            this.textBoxIdCititor.Name = "textBoxIdCititor";
            this.textBoxIdCititor.Size = new System.Drawing.Size(284, 40);
            this.textBoxIdCititor.TabIndex = 2;
            this.textBoxIdCititor.Visible = false;
            this.textBoxIdCititor.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxIdCititor_Validating);
            this.textBoxIdCititor.Validated += new System.EventHandler(this.textBoxIdCititor_Validated);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(475, 565);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "NUME CITITOR";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(475, 620);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "ADRESA CITITOR";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(475, 681);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 40);
            this.label4.TabIndex = 5;
            this.label4.Text = "EMAIL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(475, 735);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 40);
            this.label5.TabIndex = 6;
            this.label5.Text = "CNP";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Visible = false;
            // 
            // textBoxNumeCititor
            // 
            this.textBoxNumeCititor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeCititor.Location = new System.Drawing.Point(701, 563);
            this.textBoxNumeCititor.Multiline = true;
            this.textBoxNumeCititor.Name = "textBoxNumeCititor";
            this.textBoxNumeCititor.Size = new System.Drawing.Size(284, 40);
            this.textBoxNumeCititor.TabIndex = 7;
            this.textBoxNumeCititor.Visible = false;
            this.textBoxNumeCititor.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNumeCititor_Validating);
            this.textBoxNumeCititor.Validated += new System.EventHandler(this.textBoxNumeCititor_Validated);
            // 
            // textBoxAdresaCititor
            // 
            this.textBoxAdresaCititor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdresaCititor.Location = new System.Drawing.Point(701, 620);
            this.textBoxAdresaCititor.Multiline = true;
            this.textBoxAdresaCititor.Name = "textBoxAdresaCititor";
            this.textBoxAdresaCititor.Size = new System.Drawing.Size(284, 40);
            this.textBoxAdresaCititor.TabIndex = 8;
            this.textBoxAdresaCititor.Visible = false;
            this.textBoxAdresaCititor.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAdresaCititor_Validating);
            this.textBoxAdresaCititor.Validated += new System.EventHandler(this.textBoxAdresaCititor_Validated);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(701, 681);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(284, 43);
            this.textBoxEmail.TabIndex = 9;
            this.textBoxEmail.Visible = false;
            this.textBoxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmail_Validating);
            this.textBoxEmail.Validated += new System.EventHandler(this.textBoxEmail_Validated);
            // 
            // textBoxCNP
            // 
            this.textBoxCNP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCNP.Location = new System.Drawing.Point(701, 735);
            this.textBoxCNP.Multiline = true;
            this.textBoxCNP.Name = "textBoxCNP";
            this.textBoxCNP.Size = new System.Drawing.Size(284, 40);
            this.textBoxCNP.TabIndex = 10;
            this.textBoxCNP.Visible = false;
            this.textBoxCNP.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCNP_Validating);
            this.textBoxCNP.Validated += new System.EventHandler(this.textBoxCNP_Validated);
            // 
            // buttonSalveaza
            // 
            this.buttonSalveaza.Location = new System.Drawing.Point(1095, 518);
            this.buttonSalveaza.Name = "buttonSalveaza";
            this.buttonSalveaza.Size = new System.Drawing.Size(150, 30);
            this.buttonSalveaza.TabIndex = 11;
            this.buttonSalveaza.Text = "Salveaza";
            this.buttonSalveaza.UseVisualStyleBackColor = true;
            this.buttonSalveaza.Visible = false;
            this.buttonSalveaza.Click += new System.EventHandler(this.buttonSalveaza_Click);
            // 
            // buttonModifica
            // 
            this.buttonModifica.Location = new System.Drawing.Point(1095, 574);
            this.buttonModifica.Name = "buttonModifica";
            this.buttonModifica.Size = new System.Drawing.Size(150, 29);
            this.buttonModifica.TabIndex = 12;
            this.buttonModifica.Text = "Modifica";
            this.buttonModifica.UseVisualStyleBackColor = true;
            this.buttonModifica.Visible = false;
            this.buttonModifica.Click += new System.EventHandler(this.buttonModifica_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormCititor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1655, 839);
            this.Controls.Add(this.buttonModifica);
            this.Controls.Add(this.buttonSalveaza);
            this.Controls.Add(this.textBoxCNP);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxAdresaCititor);
            this.Controls.Add(this.textBoxNumeCititor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIdCititor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormCititor";
            this.Text = "FormCititor";
            this.Load += new System.EventHandler(this.FormCititor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cititoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PROIECTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_PROIECTDataSet dB_PROIECTDataSet;
        private System.Windows.Forms.BindingSource cititoriBindingSource;
        private DB_PROIECTDataSetTableAdapters.CititoriTableAdapter cititoriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeCititorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaCititorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailCititorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdCititor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNumeCititor;
        private System.Windows.Forms.TextBox textBoxAdresaCititor;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxCNP;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adaugaUnCititorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaUnCititorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeUnCititorToolStripMenuItem;
        private System.Windows.Forms.Button buttonSalveaza;
        private System.Windows.Forms.Button buttonModifica;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}