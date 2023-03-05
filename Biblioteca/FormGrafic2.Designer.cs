namespace Biblioteca
{
    partial class FormGrafic2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPieChart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(147, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 478);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonPieChart
            // 
            this.buttonPieChart.Location = new System.Drawing.Point(944, 283);
            this.buttonPieChart.Name = "buttonPieChart";
            this.buttonPieChart.Size = new System.Drawing.Size(97, 31);
            this.buttonPieChart.TabIndex = 1;
            this.buttonPieChart.Text = "Pie Chart";
            this.buttonPieChart.UseVisualStyleBackColor = true;
            this.buttonPieChart.Click += new System.EventHandler(this.buttonPieChart_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(847, 68);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pie Chart - Carti pe Categorii";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(42, 55);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 120);
            this.textBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Legenda";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(562, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 227);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkBlue;
            this.panel3.Location = new System.Drawing.Point(10, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(26, 14);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Yellow;
            this.panel4.Location = new System.Drawing.Point(10, 90);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(26, 15);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightPink;
            this.panel5.Location = new System.Drawing.Point(10, 111);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(26, 14);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Purple;
            this.panel6.Location = new System.Drawing.Point(10, 131);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(26, 14);
            this.panel6.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Orange;
            this.panel7.Location = new System.Drawing.Point(10, 151);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(26, 14);
            this.panel7.TabIndex = 6;
            // 
            // FormGrafic2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1192, 641);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPieChart);
            this.Controls.Add(this.panel1);
            this.Name = "FormGrafic2";
            this.Text = "FormGrafic2";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPieChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}