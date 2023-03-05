using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Biblioteca
{
    public partial class UserControl1 : UserControl
    {
        private string connString = null;
        private string tabela = null;
        public bool validare=false;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conexiune = new SqlConnection(connString);
            SqlCommand comanda = new SqlCommand();
            comanda.Connection = conexiune;
            try
            {
                conexiune.Open();
                comanda.CommandText = "SELECT COUNT(*) FROM " + tabela + " WHERE Utilizator='" + textBoxUsername.Text + "' AND Parola='" + textBoxParola.Text + "'";
                int nr = Convert.ToInt32(comanda.ExecuteScalar());
                if (nr > 0)
                {

                    validare = true;
                    DialogResult rez = MessageBox.Show(textBoxUsername.Text + " s-a logat!", "Confirmare logare", MessageBoxButtons.OK);
                    if (rez == DialogResult.OK)
                    {
                        
                        FormHome form1 = new FormHome();
                        form1.ShowDialog();
                        Application.ExitThread();
                    }

                }
                else
                    MessageBox.Show("Utilizator neinregistrat!");
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
        public string ConnString
        {
            set
            {
                if (value != null)
                    connString = value;
            }
        }

        public string Tabela
        {
            set
            {
                if (value != null)
                    tabela = value;
            }
        }
    }
}
