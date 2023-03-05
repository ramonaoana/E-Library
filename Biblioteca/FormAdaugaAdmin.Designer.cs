namespace Biblioteca
{
    partial class FormAdaugaAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdaugaAdmin));
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.textBoxReintrParola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSalveaza = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(432, 314);
            this.textBoxNume.Multiline = true;
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(279, 42);
            this.textBoxNume.TabIndex = 0;
            this.textBoxNume.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNume_Validating);
            this.textBoxNume.Validated += new System.EventHandler(this.textBoxNume_Validated);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nume Utilizator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(241, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(354, 55);
            this.label4.TabIndex = 6;
            this.label4.Text = "Adauga Admin";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxParola
            // 
            this.textBoxParola.Location = new System.Drawing.Point(432, 401);
            this.textBoxParola.Multiline = true;
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.Size = new System.Drawing.Size(279, 42);
            this.textBoxParola.TabIndex = 7;
            this.textBoxParola.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxParola_Validating);
            this.textBoxParola.Validated += new System.EventHandler(this.textBoxParola_Validated);
            // 
            // textBoxReintrParola
            // 
            this.textBoxReintrParola.Location = new System.Drawing.Point(432, 474);
            this.textBoxReintrParola.Multiline = true;
            this.textBoxReintrParola.Name = "textBoxReintrParola";
            this.textBoxReintrParola.Size = new System.Drawing.Size(279, 42);
            this.textBoxReintrParola.TabIndex = 8;
            this.textBoxReintrParola.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxReintrParola_Validating);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 42);
            this.label2.TabIndex = 9;
            this.label2.Text = "Parola";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 42);
            this.label3.TabIndex = 10;
            this.label3.Text = "Reintroduceti Parola";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSalveaza
            // 
            this.buttonSalveaza.Location = new System.Drawing.Point(394, 574);
            this.buttonSalveaza.Name = "buttonSalveaza";
            this.buttonSalveaza.Size = new System.Drawing.Size(162, 37);
            this.buttonSalveaza.TabIndex = 11;
            this.buttonSalveaza.Text = "Salveaza";
            this.buttonSalveaza.UseVisualStyleBackColor = true;
            this.buttonSalveaza.Click += new System.EventHandler(this.buttonSalveaza_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 42);
            this.label5.TabIndex = 13;
            this.label5.Text = "Id Utilizator";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(432, 224);
            this.textBoxId.Multiline = true;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(279, 42);
            this.textBoxId.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(685, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 104);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormAdaugaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1338, 819);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonSalveaza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxReintrParola);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNume);
            this.Name = "FormAdaugaAdmin";
            this.Text = "FormAdaugaAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.TextBox textBoxReintrParola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSalveaza;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}