using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Login : Form
    {
        public bool valid=false;
        public Login()
        {
            InitializeComponent();
            userControl11.ConnString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog = DB_PROIECT; Integrated Security = True";
            userControl11.Tabela = "Utilizatori";

          

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

   
    }
}
