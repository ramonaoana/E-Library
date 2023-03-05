using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Biblioteca
{
    public partial class FormCititor : Form
    {
        int id;
        string stringConexiune = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = DB_PROIECT; Integrated Security = True";

        public FormCititor()
        {
            InitializeComponent();
        }

        private void FormCititor_Load(object sender, EventArgs e)
        {
            incarcaDate();

        }
        public void incarcaDate()
        {
            // TODO: This line of code loads data into the 'dB_PROIECTDataSet.Cititori' table. You can move, or remove it, as needed.
            this.cititoriTableAdapter.Fill(this.dB_PROIECTDataSet.Cititori);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void adaugaUnCititorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            textBoxIdCititor.Visible = true;
            textBoxNumeCititor.Visible = true;
            textBoxAdresaCititor.Visible = true;
            textBoxEmail.Visible = true;
            textBoxCNP.Visible = true;
            buttonSalveaza.Visible = true;
            buttonModifica.Visible = false;
          
            textBoxIdCititor.Text = "";
            textBoxNumeCititor.Text = "";
            textBoxAdresaCititor.Text = "";
            textBoxEmail.Text = "";
            textBoxCNP.Text = "";

        }

        private void buttonSalveaza_Click(object sender, EventArgs e)
        {

            SqlConnection conexiune = new SqlConnection(stringConexiune);
            SqlCommand comanda = new SqlCommand();
            comanda.Connection = conexiune;


            try
            {
                conexiune.Open();

                comanda.CommandText = "INSERT into Cititori VALUES(@Id, @NumeCititor, @AdresaCititor,@MailCititor,@Cnp)";
                comanda.Parameters.Add("@Id", SqlDbType.Int).Value = Convert.ToInt32(textBoxIdCititor.Text);
                comanda.Parameters.Add("@NumeCititor", SqlDbType.VarChar).Value = textBoxNumeCititor.Text.ToString();
                comanda.Parameters.Add("@AdresaCititor", SqlDbType.VarChar).Value = textBoxAdresaCititor.Text.ToString();
                comanda.Parameters.Add("@MailCititor", SqlDbType.VarChar).Value = textBoxEmail.Text.ToString();
                comanda.Parameters.Add("@Cnp", SqlDbType.VarChar).Value = textBoxCNP.Text;



                comanda.ExecuteNonQuery();

                errorProvider1.Clear();
                MessageBox.Show("Cititorul a fost inserat!");
                incarcaDate();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conexiune.Close();
                textBoxIdCititor.Text = "";
                textBoxNumeCititor.Text = "";
                textBoxAdresaCititor.Text = "";
                textBoxEmail.Text = "";
                textBoxCNP.Text = "";
                errorProvider1.Clear();

            }
        }

        private void modificaUnCititorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            textBoxIdCititor.Visible = true;
            textBoxNumeCititor.Visible = true;
            textBoxAdresaCititor.Visible = true;
            textBoxEmail.Visible = true;
            textBoxCNP.Visible = true;
            buttonSalveaza.Visible = false;
            buttonModifica.Visible = true;
            textBoxIdCititor.Text = "";
            textBoxNumeCititor.Text = "";
            textBoxAdresaCititor.Text = "";
            textBoxEmail.Text = "";
            textBoxCNP.Text = "";


            if (dataGridView1.SelectedRows.Count>0)
            {
                id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                textBoxIdCititor.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBoxNumeCititor.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBoxAdresaCititor.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBoxEmail.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBoxCNP.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }

        }

        private void buttonModifica_Click(object sender, EventArgs e)
        {
            SqlConnection conexiune = new SqlConnection(stringConexiune);
            SqlCommand comanda = new SqlCommand();
            comanda.Connection = conexiune;


            try
            {
                conexiune.Open();

                comanda.CommandText = "UPDATE Cititori SET NumeCititor=@NumeCititor, AdresaCititor=@AdresaCititor, MailCititor=@MailCititor, Cnp=@Cnp " +
                    "WHERE Id=" + id;
             
                comanda.Parameters.Add("@NumeCititor", SqlDbType.VarChar).Value = textBoxNumeCititor.Text.ToString();
                comanda.Parameters.Add("@AdresaCititor", SqlDbType.VarChar).Value = textBoxAdresaCititor.Text.ToString();
                comanda.Parameters.Add("@MailCititor", SqlDbType.VarChar).Value = textBoxEmail.Text.ToString();
                comanda.Parameters.Add("@Cnp", SqlDbType.VarChar).Value = textBoxCNP.Text;



                comanda.ExecuteNonQuery();

                errorProvider1.Clear();
                MessageBox.Show("Cititorul a fost modificat!");
                incarcaDate();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conexiune.Close();
                textBoxIdCititor.Text = "";
                textBoxNumeCititor.Text = "";
                textBoxAdresaCititor.Text = "";
                textBoxEmail.Text = "";
                textBoxCNP.Text = "";

            }
        }

        private void stergeUnCititorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            textBoxIdCititor.Visible = false;
            textBoxNumeCititor.Visible = false;
            textBoxAdresaCititor.Visible = false;
            textBoxEmail.Visible = false;
            textBoxCNP.Visible = false;
            buttonSalveaza.Visible = false;
            buttonModifica.Visible = false;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                DialogResult rez = MessageBox.Show(" Sigur doriti sa stergeti cititorul cu id-ul "+id+"?", "Confirmare stergere", MessageBoxButtons.YesNo);
                if (rez == DialogResult.Yes)
                {
                    SqlConnection conexiune = new SqlConnection(stringConexiune);
                    SqlCommand comanda = new SqlCommand();
                    comanda.Connection = conexiune;


                    try
                    {
                        conexiune.Open();

                        comanda.CommandText = "DELETE FROM Cititori WHERE id=" + id;
                        comanda.ExecuteNonQuery();
                        MessageBox.Show("Cititorul a fost sters!");
                        incarcaDate();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    finally
                    {
                        conexiune.Close();
                    }
                }
            }


        }

        private void textBoxIdCititor_Validating(object sender, CancelEventArgs e)
        {
            bool a = int.TryParse(textBoxIdCititor.Text, out int id);
            if (string.IsNullOrWhiteSpace(textBoxIdCititor.Text) || string.IsNullOrEmpty(textBoxIdCititor.Text) ||
                a == false)
            {
                errorProvider1.SetError(textBoxIdCititor, "Eroare-Nu ati completat corect id-ul");
                e.Cancel = true;
            }
        }

        private void textBoxIdCititor_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxIdCititor, "");
        }

        private void textBoxNumeCititor_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNumeCititor.Text) || string.IsNullOrEmpty(textBoxNumeCititor.Text) ||
                textBoxNumeCititor.Text.Length < 2)
            {
                errorProvider1.SetError(textBoxNumeCititor, "Eroare-Nu ati completat corect numele cititorului");
                e.Cancel = true;
            }
        }

        private void textBoxNumeCititor_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxNumeCititor, "");
        }

        private void textBoxAdresaCititor_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAdresaCititor.Text) || string.IsNullOrEmpty(textBoxAdresaCititor.Text) ||
                textBoxAdresaCititor.Text.Length < 2)
            {
                errorProvider1.SetError(textBoxAdresaCititor, "Eroare-Nu ati completat corect adresa cititorului");
                e.Cancel = true;
            }
        }

        private void textBoxAdresaCititor_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxAdresaCititor, "");
        }

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text) || string.IsNullOrEmpty(textBoxEmail.Text) ||
                textBoxEmail.Text.Length < 2)
            {
                errorProvider1.SetError(textBoxEmail, "Eroare-Nu ati completat corect adresa de mail a cititorului");
                e.Cancel = true;
            }
        }

        private void textBoxEmail_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxEmail, "");
        }

        private void textBoxCNP_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCNP.Text) || string.IsNullOrEmpty(textBoxCNP.Text) ||
                textBoxCNP.Text.Length <13)
            {
                errorProvider1.SetError(textBoxCNP, "Eroare-Nu ati completat corect CNP-ul cititorului");
                e.Cancel = true;
            }
        }

        private void textBoxCNP_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxCNP, "");
        }
    }
}
