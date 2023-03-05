namespace Biblioteca
{
    partial class FormRaport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRaport));
            this.buttonAfiseazaAutori = new System.Windows.Forms.Button();
            this.buttonAfiseazaTip = new System.Windows.Forms.Button();
            this.buttonAfiseazaPret = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAfiseazaAutori
            // 
            this.buttonAfiseazaAutori.BackColor = System.Drawing.Color.Thistle;
            this.buttonAfiseazaAutori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfiseazaAutori.Location = new System.Drawing.Point(826, 173);
            this.buttonAfiseazaAutori.Name = "buttonAfiseazaAutori";
            this.buttonAfiseazaAutori.Size = new System.Drawing.Size(326, 71);
            this.buttonAfiseazaAutori.TabIndex = 0;
            this.buttonAfiseazaAutori.Text = "Clasificarea cartilor dupa autor";
            this.buttonAfiseazaAutori.UseVisualStyleBackColor = false;
            this.buttonAfiseazaAutori.Click += new System.EventHandler(this.buttonAfiseazaAutori_Click);
            // 
            // buttonAfiseazaTip
            // 
            this.buttonAfiseazaTip.BackColor = System.Drawing.Color.Thistle;
            this.buttonAfiseazaTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfiseazaTip.Location = new System.Drawing.Point(826, 289);
            this.buttonAfiseazaTip.Name = "buttonAfiseazaTip";
            this.buttonAfiseazaTip.Size = new System.Drawing.Size(326, 67);
            this.buttonAfiseazaTip.TabIndex = 1;
            this.buttonAfiseazaTip.Text = "Clasificarea cartilor dupa tip";
            this.buttonAfiseazaTip.UseVisualStyleBackColor = false;
            this.buttonAfiseazaTip.Click += new System.EventHandler(this.buttonAfiseazaTip_Click);
            // 
            // buttonAfiseazaPret
            // 
            this.buttonAfiseazaPret.BackColor = System.Drawing.Color.Thistle;
            this.buttonAfiseazaPret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfiseazaPret.Location = new System.Drawing.Point(826, 391);
            this.buttonAfiseazaPret.Name = "buttonAfiseazaPret";
            this.buttonAfiseazaPret.Size = new System.Drawing.Size(326, 67);
            this.buttonAfiseazaPret.TabIndex = 2;
            this.buttonAfiseazaPret.Text = "Clasificarea cartilor dupa pret";
            this.buttonAfiseazaPret.UseVisualStyleBackColor = false;
            this.buttonAfiseazaPret.Click += new System.EventHandler(this.buttonAfiseazaPret_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MistyRose;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(48, 162);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(736, 584);
            this.textBox1.TabIndex = 3;
            // 
            // FormRaport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1164, 707);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonAfiseazaPret);
            this.Controls.Add(this.buttonAfiseazaTip);
            this.Controls.Add(this.buttonAfiseazaAutori);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormRaport";
            this.Text = "FormRaport";
            this.Load += new System.EventHandler(this.FormRaport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAfiseazaAutori;
        private System.Windows.Forms.Button buttonAfiseazaTip;
        private System.Windows.Forms.Button buttonAfiseazaPret;
        private System.Windows.Forms.TextBox textBox1;
    }
}