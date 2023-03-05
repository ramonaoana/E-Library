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
    public partial class FormPieChartCititori : Form
    {
        Graphics g;
        Bitmap bmp;
        string stringConexiune;
        public FormPieChartCititori()
        {
            InitializeComponent();
            bmp = new Bitmap(panel1.Width, panel1.Height);
            g = Graphics.FromImage(bmp);
            stringConexiune = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = DB_PROIECT; Integrated Security = True";
            AfiseazaPieChart();
        }
        public void AfiseazaPieChart()
        {
            SqlConnection conexiune = new SqlConnection(stringConexiune);
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM Cititori ", conexiune);


            DataSet ds = new DataSet();
            adaptor.Fill(ds, "Cititori");

            DataTable tabela = ds.Tables["Cititori"];
            int nrBarbati = 0;

            DataRow[] rows1 = tabela.Select("Cnp LIKE '1%'  ", "NumeCititor");
            foreach (DataRow linie in rows1)
            {
                nrBarbati++;
            }
            DataRow[] rows2 = tabela.Select("Cnp LIKE '3%'  ", "NumeCititor");
            foreach (DataRow linie in rows2)
            {
                nrBarbati++;
            }
            DataRow[] rows3 = tabela.Select("Cnp LIKE '5%'  ", "NumeCititor");
            foreach (DataRow linie in rows3)
            {
                nrBarbati++;
            }
            DataRow[] rows4 = tabela.Select("Cnp LIKE '7%'  ", "NumeCititor");
            foreach (DataRow linie in rows4)
            {
                nrBarbati++;
            }

            int nrFemei = 0;
            DataRow[] rows5 = tabela.Select("Cnp LIKE '2%'", "NumeCititor");
            
            foreach (DataRow linie in rows5)
            {
                nrFemei++;
            }
            DataRow[] rows6 = tabela.Select("Cnp LIKE '4%'", "NumeCititor");

            foreach (DataRow linie in rows6)
            {
                nrFemei++;
            }
            DataRow[] rows7 = tabela.Select("Cnp LIKE '6%'", "NumeCititor");

            foreach (DataRow linie in rows7)
            {
                nrFemei++;
            }
            DataRow[] rows8 = tabela.Select("Cnp LIKE '8%'", "NumeCititor");

            foreach (DataRow linie in rows8)
            {
                nrFemei++;
            }



            int total = nrBarbati + nrFemei;

            float yB = (360 * nrBarbati) / total;
            float yF = (360 * nrFemei) / total;
            

            Pen pen = new Pen(Color.Black, 2);
            Rectangle rectangle = new Rectangle(40, 40, 300, 300);
            Brush br1 = new SolidBrush(Color.LightPink);
            Brush br2 = new SolidBrush(Color.DarkBlue);
           
            g.DrawEllipse(pen, rectangle);

            g.FillPie(br1, rectangle, 0, yB);
            g.FillPie(br2, rectangle, yB, yF);
            

            g.DrawString("Femei", new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold),
               new SolidBrush(Color.Black), new Point(240, 250));

            g.DrawString("Barbati", new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold),
               new SolidBrush(Color.Black), new Point(240, 120));

            
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
    
}
