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
    public partial class FormGrafic2 : Form
    {
        Graphics g;
        Bitmap bmp;
        string stringConexiune;
        public FormGrafic2()
        {
            InitializeComponent();
            bmp = new Bitmap(panel1.Width, panel1.Height);
            g = Graphics.FromImage(bmp);
            stringConexiune = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = DB_PROIECT; Integrated Security = True";
        }

        private void buttonPieChart_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            SqlConnection conexiune = new SqlConnection(stringConexiune);
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM Carti", conexiune);


            DataSet ds = new DataSet();
            adaptor.Fill(ds, "Carti");

            DataTable tabela = ds.Tables["Carti"];

            DataRow[] rows1 = tabela.Select("TipCarte='Beletristica'", "NumeCarte");
            int nrCartiBeletristica = 0;
            foreach (DataRow linie in rows1)
            {
                nrCartiBeletristica++;
            }

            DataRow[] rows2 = tabela.Select("TipCarte='Istorie'", "NumeCarte");
            int nrCartiIstorie = 0;
            foreach (DataRow linie in rows2)
            {
                nrCartiIstorie++;
            }

            DataRow[] rows3 = tabela.Select("TipCarte='Fictiune'", "NumeCarte");
            int nrCartiFictiune = 0;
            foreach (DataRow linie in rows3)
            {
                nrCartiFictiune++;
            }
            DataRow[] rows4 = tabela.Select("TipCarte='Copii'", "NumeCarte");
            int nrCartiCopii = 0;
            foreach (DataRow linie in rows4)
            {
                nrCartiCopii++;
            }
            DataRow[] rows5 = tabela.Select("TipCarte='Stiinte'", "NumeCarte");
            int nrCartiStiinte = 0;
            foreach (DataRow linie in rows5)
            {
                nrCartiStiinte++;
            }
          

            int total = nrCartiCopii + nrCartiBeletristica + nrCartiFictiune + nrCartiIstorie  + nrCartiStiinte;

            float yCopii = (360 * nrCartiCopii) / total;
            float yBel = (360 * nrCartiBeletristica) / total;
            float yFic = (360 * nrCartiFictiune) / total;
            float yIst = (360 * nrCartiIstorie) / total;
            float yStiinte = (360 * nrCartiStiinte) / total;


            Pen pen = new Pen(Color.Black, 2);
            Rectangle rectangle = new Rectangle(40, 40, 300, 300);
            Brush br1 = new SolidBrush(Color.LightPink);
            Brush br2 = new SolidBrush(Color.DarkBlue);
            Brush br3 = new SolidBrush(Color.Yellow);
            Brush br4 = new SolidBrush(Color.Purple);
            Brush br5 = new SolidBrush(Color.Orange);
            g.DrawEllipse(pen, rectangle);

            g.FillPie(br1, rectangle, 0, yCopii);
            g.FillPie(br2, rectangle, yCopii, yBel);
            g.FillPie(br3, rectangle, yBel + yCopii, yFic);
            g.FillPie(br4, rectangle, yBel + yCopii + yFic, yIst);
            g.FillPie(br5, rectangle, yBel + yCopii + yFic + yIst, yStiinte);

            textBox1.Text = "Beletristica" + Environment.NewLine + "Fictiune" + Environment.NewLine + "Copii" +
                Environment.NewLine + "Istorie" + Environment.NewLine + "Stiinte";


            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
