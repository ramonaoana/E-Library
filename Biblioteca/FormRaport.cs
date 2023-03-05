using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FormRaport : Form
    {
        string stringConexiune = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = DB_PROIECT; Integrated Security = True";
        public FormRaport()
        {
            InitializeComponent();
        }

        private void buttonAfiseazaAutori_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            SqlConnection conexiune = new SqlConnection(stringConexiune);
         

            SqlDataAdapter adaptor2= new SqlDataAdapter("SELECT Distinct Autor FROM carti", conexiune);
            DataSet dataSet2 = new DataSet();
            adaptor2.Fill(dataSet2, "Carti");

            string numeAutor;
            DataTable tabela = dataSet2.Tables["Carti"];
            

            foreach (DataRow row in tabela.Rows)
            {
                numeAutor= row["Autor"].ToString();

                
                textBox1.Text += "----Cartile scrise de autorul "+numeAutor + Environment.NewLine;

                
                SqlDataAdapter adaptor3 = new SqlDataAdapter();
                SqlCommand comanda = new SqlCommand("SELECT * FROM carti WHERE Autor=@numeAutor",conexiune);
                comanda.Parameters.AddWithValue("@numeAutor", SqlDbType.VarChar).Value = numeAutor;
                adaptor3.SelectCommand = comanda;

                DataSet dataSet3 = new DataSet();
                adaptor3.Fill(dataSet3, "Carti");


                DataTable tabela3 = dataSet3.Tables["Carti"];

                foreach (DataRow linie in tabela3.Rows)
                    textBox1.Text += linie["NumeCarte"] + " " + Environment.NewLine;

                textBox1.Text += Environment.NewLine;

            }









        }

        private void buttonAfiseazaTip_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            SqlConnection conexiune = new SqlConnection(stringConexiune);


            SqlDataAdapter adaptor2 = new SqlDataAdapter("SELECT Distinct TipCarte FROM carti", conexiune);
            DataSet dataSet2 = new DataSet();
            adaptor2.Fill(dataSet2, "Carti");

            string tip;
            DataTable tabela = dataSet2.Tables["Carti"];


            foreach (DataRow row in tabela.Rows)
            {
                tip = row["TipCarte"].ToString();


                textBox1.Text += "----Cartile care fac parte din categoria " + tip + Environment.NewLine;


                SqlDataAdapter adaptor3 = new SqlDataAdapter();
                SqlCommand comanda = new SqlCommand("SELECT * FROM carti WHERE TipCarte=@TipCarte", conexiune);
                comanda.Parameters.AddWithValue("@TipCarte", SqlDbType.VarChar).Value = tip;
                adaptor3.SelectCommand = comanda;

                DataSet dataSet3 = new DataSet();
                adaptor3.Fill(dataSet3, "Carti");


                DataTable tabela3 = dataSet3.Tables["Carti"];

                foreach (DataRow linie in tabela3.Rows)
                    textBox1.Text += linie["NumeCarte"] + " "+ linie["Autor"] + Environment.NewLine;

                textBox1.Text += Environment.NewLine;
                conexiune.Close();

            }
        }

        private void buttonAfiseazaPret_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            SqlConnection conexiune = new SqlConnection(stringConexiune);


            SqlDataAdapter adaptor2 = new SqlDataAdapter("SELECT * FROM carti WHERE Pret<20", conexiune);
            DataSet dataSet2 = new DataSet();
            adaptor2.Fill(dataSet2, "Carti");
            DataTable tabela = dataSet2.Tables["Carti"];


            textBox1.Text += "Cartile care au pretul mai mic decat 20 sunt: " + Environment.NewLine;

            
            foreach (DataRow linie in tabela.Rows)
                textBox1.Text += linie["NumeCarte"] + " " + linie["Autor"] + Environment.NewLine;

            textBox1.Text += Environment.NewLine;
            

            textBox1.Text += "Cartile care au pretul mai mare decat 20 sunt: " + Environment.NewLine;

            SqlDataAdapter adaptor3 = new SqlDataAdapter("SELECT * FROM carti WHERE Pret>20", conexiune);
            DataSet dataSet3 = new DataSet();
            adaptor3.Fill(dataSet3, "Carti");
            DataTable tabela3 = dataSet3.Tables["Carti"];
            foreach (DataRow linie in tabela3.Rows)
                textBox1.Text += linie["NumeCarte"] + " " + linie["Autor"] + Environment.NewLine;

            conexiune.Close();

        }

        private void FormRaport_Load(object sender, EventArgs e)
        {

        }
    }
}
