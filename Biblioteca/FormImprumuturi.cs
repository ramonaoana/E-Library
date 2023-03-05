using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Biblioteca
{
    public partial class FormImprumuturi : Form
    {
        int contor = 0;
        string stringConexiune = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = DB_PROIECT; Integrated Security = True";
        public FormImprumuturi()
        {
            InitializeComponent();
            incarcaDateCarti();
            incarcaDateCititori();
        }
        public void incarcaDateCarti()
        {
            SqlConnection conexiune = new SqlConnection(stringConexiune);
            SqlCommand comanda = new SqlCommand("SELECT * FROM Carti", conexiune);

            try
            {
                conexiune.Open();
                SqlDataReader reader = comanda.ExecuteReader();
                listViewCarti.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem newItem = new ListViewItem(reader["Id"].ToString());

                    newItem.SubItems.Add(reader["NumeCarte"].ToString());
                    newItem.SubItems.Add(reader["Autor"].ToString());
                    newItem.SubItems.Add(reader["Editura"].ToString());
                    newItem.SubItems.Add(reader["Pret"].ToString());
                    newItem.SubItems.Add(reader["NrPagini"].ToString());
                    newItem.SubItems.Add(reader["TipCarte"].ToString());

                    listViewCarti.Items.Add(newItem);

                }
                reader.Close();

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
        public void incarcaDateCititori()
        {
            SqlConnection conexiune = new SqlConnection(stringConexiune);
            SqlCommand comanda = new SqlCommand("SELECT * FROM Cititori ORDER BY id", conexiune);

            try
            {
                conexiune.Open();
                SqlDataReader reader = comanda.ExecuteReader();
                listViewCititori.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem newItem = new ListViewItem(reader["Id"].ToString());

                    newItem.SubItems.Add(reader["NumeCititor"].ToString());
                    newItem.SubItems.Add(reader["AdresaCititor"].ToString());
                    newItem.SubItems.Add(reader["MailCititor"].ToString());
                    newItem.SubItems.Add(reader["CNP"].ToString());


                    listViewCititori.Items.Add(newItem);

                }
                reader.Close();

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








        //

        //private void listViewCititori_DragEnter(object sender, DragEventArgs e)
        //{
        //    if (e.Data.GetDataPresent(typeof(ListViewItem)))
        //    {
        //        e.Effect = DragDropEffects.Copy;
        //    }
        //    else
        //    {
        //        e.Effect = DragDropEffects.None;
        //        return;
        //    }
        //}

        //private void listViewCititori_DragDrop(object sender, DragEventArgs e)
        //{
        //    try
        //    {
        //        Carte c = (Carte)((ListViewItem)e.Data.GetData(typeof(ListViewItem))).Tag;
        //        Point px = listViewCititori.PointToClient(new Point(e.X, e.Y));

        //        ListViewItem lv = listViewCititori.GetItemAt(px.X, px.Y);
        //        if (lv != null)
        //        {
        //            Cititor cititor = (Cititor)lv.Tag;

        //            List<Carte> list = new List<Carte>();
        //            list.Add(c);

        //            Imprumut imprumut = new Imprumut(1, cititor, DateTime.Now, DateTime.Now.AddDays(3), list);

        //            FormImprumut fi = new FormImprumut(imprumut);

        //            fi.ShowDialog();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }


        //    if (fi.ShowDialog() == DialogResult.OK)
        //    {
        //        List<TreeNode> listaNoduri = treeView1.Nodes.Cast<TreeNode>().ToList();

        //        TreeNode nodcititor = listaNoduri.Find(x => ((Cititor)x.Tag).Cnp == imprumut.Cititor.Cnp);
        //        TreeNode treenodecarti = nodcititor.Nodes.Add(c.NumeCarte + " " + imprumut.DataRestituire.ToString());
        //        treenodecarti.Tag = imprumut;
        //    }

        //}
        private void listViewCarti_MouseDown(object sender, MouseEventArgs e)
        {
            if (listViewCarti.SelectedItems.Count > 0)
            {
                listViewCarti.DoDragDrop(listViewCarti.SelectedItems[0], DragDropEffects.Copy);
            }
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
                return;
            }
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string id = ((ListViewItem)e.Data.GetData(typeof(ListViewItem))).SubItems[0].Text;
                string numeCarte = ((ListViewItem)e.Data.GetData(typeof(ListViewItem))).SubItems[1].Text;
                string autor = ((ListViewItem)e.Data.GetData(typeof(ListViewItem))).SubItems[2].Text;
                string editura = ((ListViewItem)e.Data.GetData(typeof(ListViewItem))).SubItems[3].Text;
                string pret = ((ListViewItem)e.Data.GetData(typeof(ListViewItem))).SubItems[4].Text;
                string nrPagini = ((ListViewItem)e.Data.GetData(typeof(ListViewItem))).SubItems[5].Text;
                string tip = ((ListViewItem)e.Data.GetData(typeof(ListViewItem))).SubItems[6].Text;



                Point px = listView1.PointToClient(new Point(e.X, e.Y));

                ListViewItem lv = listView1.GetItemAt(px.X, px.Y);


                ListViewItem item = new ListViewItem(id);
                item.SubItems.Add(numeCarte);
                item.SubItems.Add(autor);
                item.SubItems.Add(editura);
                item.SubItems.Add(pret);
                item.SubItems.Add(nrPagini);
                item.SubItems.Add(tip);

                listView1.Items.Add(item);

                contor++;
                textBoxNrCarti.Text = contor.ToString();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void listViewCititori_MouseDown(object sender, MouseEventArgs e)
        {
            if (listViewCititori.SelectedItems.Count > 0)
            {
                listViewCititori.DoDragDrop(listViewCititori.SelectedItems[0], DragDropEffects.Copy);
            }
        }

        private void textBoxIdCititor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
                return;
            }
        }
        private void textBoxIdCititor_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string id = ((ListViewItem)e.Data.GetData(typeof(ListViewItem))).SubItems[0].Text;
                Point px = textBoxIdCititor.PointToClient(new Point(e.X, e.Y));

                textBoxIdCititor.Text = id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            SalveazaImprumuturiBd();
            textBoxIdImprumut.Text = "";
            textBoxIdCititor.Text = "";
            textBoxNrCarti.Text = "";
            contor = 0;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            listView1.Items.Clear();
            button3.Visible = true;

        }
        public void IncarcaDateTreeView()
        {
            SqlConnection conexiune = new SqlConnection(stringConexiune);
            SqlCommand comanda = new SqlCommand("SELECT * FROM Imprumuturi", conexiune);
            DataSet dt = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(comanda);
            adp.Fill(dt, "Imprumuturi");
            treeView1.Nodes.Clear();
           

            DataTable tab = dt.Tables["Imprumuturi"];
            string id;
            treeView1.Nodes.Clear();
            foreach (DataRow row in tab.Rows)
            {
                

                id = row["Id"].ToString();
                TreeNode node = new TreeNode("Imprumut " + id);
                treeView1.Nodes.Add(node);
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
                    string idd;
                    string nume;
                    foreach (DataRow linie in tabela3.Rows)
                    {
                        idd = linie["Id"].ToString();
                        nume= linie["NumeCarte"].ToString();
                        TreeNode copil = new TreeNode(idd + "-" + nume);
                        node.Nodes.Add(copil);
                    }
                    


                }                 

            }
            treeView1.ExpandAll();
        }
        //reader.Close();


        //catch (Exception ex)
        //{
        //    MessageBox.Show(ex.Message);
        //}
        //finally
        //{
        //    conexiune.Close();
        //}
   

        public void SalveazaImprumuturiBd()
        {
            try
            {
                SqlConnection conexiune = new SqlConnection(stringConexiune);
                SqlCommand comanda1 = new SqlCommand();
                

                comanda1.Connection = conexiune;
                conexiune.Open();

                comanda1.CommandText = "INSERT into Imprumuturi (Id, IdCititor, DataImprumut, DataRestituire)" +
                " VALUES(@Id, @IdCititor,@DataImprumut, @DataRestituire)";
                comanda1.Parameters.AddWithValue("@Id", Convert.ToInt32(textBoxIdImprumut.Text));
                comanda1.Parameters.AddWithValue("@IdCititor", Convert.ToInt32(textBoxIdCititor.Text));
                comanda1.Parameters.AddWithValue("@DataImprumut", dateTimePicker1.Value);
                comanda1.Parameters.AddWithValue("@DataRestituire", dateTimePicker2.Value);


                comanda1.ExecuteNonQuery();
                conexiune.Close();

                
                conexiune.Open();

                foreach (ListViewItem it in listView1.Items)
                {
                    SqlCommand comanda2 = new SqlCommand();
                    comanda2.Connection = conexiune;

                    comanda2.CommandText = "INSERT into ImprumuturiCarti (IdImprumut, IdCarte)" +
                    " VALUES(@IdImprumut, @IdCarte)";
                    comanda2.Parameters.AddWithValue("@IdImprumut", Convert.ToInt32(textBoxIdImprumut.Text));
                    comanda2.Parameters.AddWithValue("@IdCarte", Convert.ToInt32(it.SubItems[0].Text));



                    comanda2.ExecuteNonQuery();
                }


                MessageBox.Show("Imprumutul a fost inserat!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            IncarcaDateTreeView();
        }

        private void FormImprumuturi_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void textBoxIdImprumut_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxIdImprumut, "");
        }

        private void textBoxIdImprumut_Validating(object sender, CancelEventArgs e)
        {
            bool a = int.TryParse(textBoxIdImprumut.Text, out int id);
            if (string.IsNullOrWhiteSpace(textBoxIdImprumut.Text) || string.IsNullOrEmpty(textBoxIdImprumut.Text) ||
                a == false)
            {
                errorProvider1.SetError(textBoxIdImprumut, "Eroare-Nu ati completat corect id-ul");
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IncarcaDateTreeView();
        }
        private void doc_print(object sender, PrintPageEventArgs e)
        {

            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
            e.Graphics.DrawImage(bmp, 0, 0);

        }
        private void button3_Click(object sender, EventArgs e)
        {
            //printDocument1.Print();
            button3.Visible = false;
            printDocument1.DefaultPageSettings.Margins = new Margins(100, 50, 25, 25);
            printDocument1.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
            PrintPreviewDialog p = new PrintPreviewDialog();
            p.Document = printDocument1;
            p.ShowDialog();
           
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));


            g.DrawImage(bmp,new Rectangle(new Point(20,20),new Size(800,1100)));



        }
    }
}
