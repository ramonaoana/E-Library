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
    public partial class FormGraficImprumuturi : Form
    {

        int nrBel = 0;
        int nrFic = 0;
        int nrIst = 0;
        int nrCopii = 0;
        int nrStiinte = 0;
        int nrColoane = 5;
        string[] categorii;
        float[] nrCarti;
        DateTime dateTime1;
        String stringConexiune = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = DB_PROIECT; Integrated Security = True";
        public FormGraficImprumuturi()
        {
            InitializeComponent();
            categorii = new string[5];
            categorii[0] = "Beletristica";
            categorii[1] = "Istorie";
            categorii[2] = "Fictiune";
            categorii[3] = "Copii";
            categorii[4] = "Stiinte";
           
            


        }
        public void determinareNrCarti()
        {

            nrBel = 0;
            nrFic = 0;
            nrIst = 0;
            nrCopii = 0;
            nrStiinte = 0;
            string b = "Beletristica";
            string c = "Copii";
            string f = "Fictiune";
            string i = "Istorie";
            string st = "stiinte";
            dateTime1 = Convert.ToDateTime(dateTimePicker1.Value);
          

            SqlConnection conexiune = new SqlConnection(stringConexiune);
            SqlCommand comanda = new SqlCommand("SELECT * FROM Imprumuturi WHERE DataImprumut<@Data1", conexiune);
            comanda.Parameters.Add("@Data1", dateTime1);
            DataSet dt = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(comanda);
            adp.Fill(dt, "Imprumuturi");



            DataTable tab = dt.Tables["Imprumuturi"];
            int id;
            string s;
            foreach (DataRow row in tab.Rows)
            {
                s = row["Id"].ToString();
                id = Convert.ToInt32(s);


                //


                SqlDataAdapter adaptor = new SqlDataAdapter();
                SqlCommand comanda2 = new SqlCommand("SELECT * FROM ImprumuturiCarti Where IdImprumut=@IdImprumut", conexiune);
                comanda2.Parameters.AddWithValue("@IdImprumut", Convert.ToInt32(id));
                adaptor.SelectCommand = comanda2;

                DataSet dataSet = new DataSet();
                adaptor.Fill(dataSet, "ImprumuturiCarti");

                DataTable tabela = dataSet.Tables["ImprumuturiCarti"];
                string idCarte;
                foreach (DataRow line in tabela.Rows)
                {
                    idCarte = line["IdCarte"].ToString();


                    SqlDataAdapter adaptor3 = new SqlDataAdapter();
                    SqlCommand comanda3 = new SqlCommand("SELECT * FROM Carti Where Id=@IdCarte", conexiune);
                    comanda3.Parameters.AddWithValue("@IdCarte", Convert.ToInt32(idCarte));
                    adaptor3.SelectCommand = comanda3;

                    DataSet dataSet3 = new DataSet();
                    adaptor3.Fill(dataSet3, "Carti");

                    DataTable tabela3 = dataSet3.Tables["Carti"];
                    string tip;
                    string final;
                    foreach (DataRow linie in tabela3.Rows)
                    {
                        tip=linie["TipCarte"].ToString();
                        final = tip.ToString();
                        if(final.Contains(b))
                        {
                            nrBel++;
                        }
                        else if(final.Contains(c))
                        {
                            nrCopii++;
                        }
                        else if(final.Contains(f))
                        {
                            nrFic++;
                        }
                        else if(final.Contains(i))
                        {
                            nrIst++;
                        }    
                        else if(final.Contains(st))
                        { 
                            nrStiinte++;
                        }
                        


                    }
                    


                }

            }
            //MessageBox.Show(nrBel.ToString()+"-"+nrFic.ToString()+"-"+nrIst.ToString()+"-"+nrCopii.ToString()+"-"+nrStiinte.ToString());
         


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
                Graphics g = e.Graphics;

                Rectangle zonaClient = e.ClipRectangle;
                Brush fundal = new SolidBrush(Color.White);
                g.FillRectangle(fundal, zonaClient);

                textBox1.Clear();
                zonaClient.X += 20;
                zonaClient.Y += 20;

                zonaClient.Height -= 40;
                zonaClient.Width -= 40;

                Pen creionRosu = new Pen(Color.DarkGreen, 2);
                g.DrawRectangle(creionRosu, zonaClient);


                int vl = zonaClient.Left;
                int vr = zonaClient.Right;
                int vt = zonaClient.Top;
                int vb = zonaClient.Bottom;


                float rap_dist_latime = 0.1f;
                float max;
                int latime;
                int distanta;
                string denx = "";

                SolidBrush[] pensule = new SolidBrush[]
                {
                new SolidBrush(Color.Green),
                new SolidBrush(Color.Orange),
                new SolidBrush(Color.Red),
                new SolidBrush(Color.Blue),
                new SolidBrush(Color.Pink),
                new SolidBrush(Color.Purple)
                };

                SolidBrush pensulaCurenta;
                Pen creionCurent;

                int i;
                max = nrCarti[0];
                for (i = 0; i < nrColoane; i++)
                {
                    if (max < nrCarti[i]) max = nrCarti[i];
                }
                latime = (vr - vl) / (int)((nrColoane + 1) * rap_dist_latime+ nrColoane);

                distanta = (int)(latime * rap_dist_latime);
                latime = latime - 2;


                creionCurent = new Pen(Color.DarkMagenta);
                g.DrawLine(creionCurent, vl, vt, vl, vb);
                g.DrawLine(creionCurent, vl, vb, vr, vb);

                creionCurent = new Pen(Color.Fuchsia);
                for (i = 0; i < nrColoane; i++)
                {
                    pensulaCurenta = pensule[(i + 2) % 6];
                    PointF pnt = new PointF(
                        vl + distanta + i * (latime + distanta),
                        vb - nrCarti[i] * (vb - vt) / max
                        );

                    SizeF sz = new SizeF(latime, nrCarti[i] * (vb - vt) / max);
                    g.FillRectangle(pensulaCurenta, new RectangleF(pnt, sz));

                    textBox1.Text += "\r\n(" + Math.Round(pnt.X, 2)
                        + "," + Math.Round(pnt.Y, 2)
                        + ")==>" + Math.Round(sz.Width, 2)
                        + ", " + Math.Round(sz.Height, 2);

                    denx = categorii[i].ToString();
                    g.DrawString(denx, new Font("Times New Roman",11), pensulaCurenta, vl + distanta + i * (latime + distanta) + latime / 2, vb + 5);
                }
            
           
        }

        private void panel2_Resize(object sender, EventArgs e)
        {
            panel2.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel2.Invalidate();
            determinareNrCarti();
            nrCarti = new float[] { nrBel, nrCopii, nrFic, nrIst, nrStiinte };

            string s = "";
            for (int i = 0; i < nrColoane; i++)
            {
                s += nrCarti[i].ToString() + " - " + categorii[i].ToString() + Environment.NewLine;

            }
            textBox2.Text = s;
           

        }
    }
}
