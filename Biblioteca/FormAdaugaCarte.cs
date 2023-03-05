using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
   
    public partial class FormAdaugaCarte : Form
    {
        
        public Carte carte = new Carte();
        public FormCarti parinte;
    
        public FormAdaugaCarte()
        {
            InitializeComponent();
        }
        public FormAdaugaCarte(Carte c)
        {
            InitializeComponent();
            carte = c;
        }
        public void Actualizeaza()
        {

                textBoxIdCarte.Text = carte.IdCarte.ToString();
                textBoxNumeCarte.Text = carte.NumeCarte;
                textBoxAutor.Text = carte.Autor;
                textBoxEditura.Text = carte.Editura;
                textBoxPret.Text = carte.Pret.ToString();
                textBoxNrPagini.Text = carte.NrPagini.ToString();
                comboBoxTipCarte.Text = carte.Tip;

        }

        private void FormAdaugaCarte_Load(object sender, EventArgs e)
        {

        }

        public void buttonSalveaza_Click(object sender, EventArgs e)
        {
            
            carte.IdCarte = Convert.ToInt32(textBoxIdCarte.Text);
            carte.NumeCarte = textBoxNumeCarte.Text;
            carte.Autor = textBoxAutor.Text;
            carte.Editura = textBoxEditura.Text;
            carte.Pret = float.Parse(textBoxPret.Text);
            carte.NrPagini = double.Parse(textBoxNrPagini.Text);
            carte.Tip = comboBoxTipCarte.Text;


            
        }
    

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            bool a = int.TryParse(textBoxIdCarte.Text, out int id);
            if (string.IsNullOrWhiteSpace(textBoxIdCarte.Text) || string.IsNullOrEmpty(textBoxIdCarte.Text) ||
                a == false)
            {
                errorProvider1.SetError(textBoxIdCarte, "Eroare-Nu ati completat corect id-ul");
                e.Cancel = true;
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxIdCarte, "");
        }

        private void textBoxNumeCarte_Validating(object sender, CancelEventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(textBoxNumeCarte.Text) || string.IsNullOrEmpty(textBoxNumeCarte.Text) ||
                textBoxNumeCarte.Text.Length<2)
            {
                errorProvider1.SetError(textBoxNumeCarte, "Eroare-Nu ati completat corect numele cartii");
                e.Cancel = true;
            }
        }

        private void textBoxNumeCarte_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxNumeCarte, "");
        }

        private void textBoxAutor_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAutor.Text) || string.IsNullOrEmpty(textBoxAutor.Text) ||
                textBoxAutor.Text.Length < 2)
            {
                errorProvider1.SetError(textBoxAutor, "Eroare-Nu ati completat corect numele cartii");
                e.Cancel = true;
            }
        }

        private void textBoxAutor_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxAutor, "");
        }

        private void textBoxEditura_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEditura.Text) || string.IsNullOrEmpty(textBoxEditura.Text) ||
                textBoxEditura.Text.Length < 2)
            {
                errorProvider1.SetError(textBoxEditura, "Eroare-Nu ati completat corect autorul cartii");
                e.Cancel = true;
            }
        }

        private void textBoxEditura_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxEditura, "");
        }

        private void textBoxPret_Validating(object sender, CancelEventArgs e)
        {
            bool a = float.TryParse(textBoxPret.Text, out float id);
            if (string.IsNullOrWhiteSpace(textBoxPret.Text) || string.IsNullOrEmpty(textBoxPret.Text) ||
                a == false)
            {
                errorProvider1.SetError(textBoxPret, "Eroare-Nu ati completat corect pretul");
                e.Cancel = true;
            }
        }

        private void textBoxPret_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxPret, "");
        }

        private void textBoxNrPagini_Validating(object sender, CancelEventArgs e)
        {
            bool a = double.TryParse(textBoxNrPagini.Text, out double id);
            if (string.IsNullOrWhiteSpace(textBoxNrPagini.Text) || string.IsNullOrEmpty(textBoxNrPagini.Text) ||
                a == false)
            {
                errorProvider1.SetError(textBoxNrPagini, "Eroare-Nu ati completat corect numarul de pagini");
                e.Cancel = true;
            }
        }

        private void textBoxNrPagini_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxIdCarte, "");
        }

        private void comboBoxTipCarte_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(comboBoxTipCarte.Text) || string.IsNullOrEmpty(comboBoxTipCarte.Text))
            {
                errorProvider1.SetError(comboBoxTipCarte, "Eroare-Nu ati completat corect tipul cartii");
                e.Cancel = true;
            }
        }

        private void comboBoxTipCarte_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(comboBoxTipCarte, "");
        }

        private void buttonRenuntaCarte_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
