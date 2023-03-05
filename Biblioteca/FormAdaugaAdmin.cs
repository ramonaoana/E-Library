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
    public partial class FormAdaugaAdmin : Form
    {
        string stringConexiune = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = DB_PROIECT; Integrated Security = True";
        public FormAdaugaAdmin()
        {
            InitializeComponent();
            
        }

        private void buttonSalveaza_Click(object sender, EventArgs e)
        {
            salveazaInBD();
        }

        private void textBoxNume_Validating(object sender, CancelEventArgs e)
        {
            if(String.IsNullOrEmpty(textBoxNume.Text) ||String.IsNullOrWhiteSpace(textBoxNume.Text))
            {
                errorProvider1.SetError(textBoxNume, "Eroare-Nu ati completat corect username-ul");
                e.Cancel = true;
            }
        }

        private void textBoxNume_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxNume, "");
        }

        private void textBoxParola_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxParola.Text) || String.IsNullOrWhiteSpace(textBoxParola.Text) ||
                textBoxParola.Text.Length<1)
            {
                errorProvider1.SetError(textBoxParola, "Eroare-Nu ati completat corect parola");
                e.Cancel = true;
            }
        }

        private void textBoxParola_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxParola, "");
        }

        private void textBoxReintrParola_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxReintrParola.Text) || String.IsNullOrWhiteSpace(textBoxReintrParola.Text) ||
                 textBoxReintrParola.Text.Length < 1 )
            {
                errorProvider1.SetError(textBoxReintrParola, "Eroare-Nu ati reintrodus parola corect");
                e.Cancel = true;
            }
            if (textBoxParola.Text.Trim() != textBoxReintrParola.Text.Trim())
            {
                errorProvider1.SetError(textBoxReintrParola, "Eroare-Cele doua erori nu coincid");
                e.Cancel = true;
            }
            
        }

        private void textBoxReintrParola_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxReintrParola, "");
        }

        public void salveazaInBD()
        {
            SqlConnection conexiune = new SqlConnection(stringConexiune);
            SqlCommand comanda = new SqlCommand();
            comanda.Connection = conexiune;


            try
            {
                conexiune.Open();

                comanda.CommandText = "INSERT into Utilizatori (Id, Utilizator, Parola)" +
                     "VALUES( @Id,@Utilizator, @Parola)";
                comanda.Parameters.Add("@Id", SqlDbType.Int).Value = Convert.ToInt32(textBoxId.Text);
                comanda.Parameters.Add("@Utilizator", SqlDbType.VarChar).Value = textBoxNume.Text;
                comanda.Parameters.Add("@Parola", SqlDbType.VarChar).Value = textBoxParola.Text;
     


                comanda.ExecuteNonQuery();

                errorProvider1.Clear();
                MessageBox.Show("Utilizatorul a fost inserat!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conexiune.Close();
                textBoxId.Text = "";
                textBoxNume.Text = "";
                textBoxParola.Text = "";
                textBoxReintrParola.Text = "";
             

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}