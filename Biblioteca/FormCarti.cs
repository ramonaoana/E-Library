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
    public partial class FormCarti : Form
    {
        string stringConexiune = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = DB_PROIECT; Integrated Security = True";
        public FormCarti()
        {
            InitializeComponent();
            incarcaDate();
        }

        public void incarcaDate()
        {
            SqlConnection conexiune = new SqlConnection(stringConexiune);
            SqlCommand comanda = new SqlCommand("SELECT * FROM Carti ORDER BY id", conexiune);

            try
            {
                conexiune.Open();
                SqlDataReader reader = comanda.ExecuteReader();
                listView1.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem newItem = new ListViewItem(reader["Id"].ToString());

                    newItem.SubItems.Add(reader["NumeCarte"].ToString());
                    newItem.SubItems.Add(reader["Autor"].ToString());
                    newItem.SubItems.Add(reader["Editura"].ToString());
                    newItem.SubItems.Add(reader["Pret"].ToString());
                    newItem.SubItems.Add(reader["NrPagini"].ToString());
                    newItem.SubItems.Add(reader["TipCarte"].ToString());

                    listView1.Items.Add(newItem);

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

        private void adaugaCarteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                Carte c = new Carte();
                FormAdaugaCarte fc = new FormAdaugaCarte(c);
                fc.Text = "Adauga o carte noua";
                fc.buttonSalveaza.Text = "Adauga";
                fc.parinte = this;


                fc.ShowDialog();

                if (fc.DialogResult == DialogResult.OK)
                {
                    SqlConnection conexiune = new SqlConnection(stringConexiune);
                    SqlCommand comanda = new SqlCommand();
                    comanda.Connection = conexiune;
                    conexiune.Open();

                    comanda.CommandText = "INSERT into dbo.Carti VALUES(@Id, @NumeCarte,@Autor, @Editura, @Pret, @NrPagini, @TipCarte)";
                    comanda.Parameters.AddWithValue("@Id", c.IdCarte);
                    comanda.Parameters.AddWithValue("@NumeCarte", c.NumeCarte);
                    comanda.Parameters.AddWithValue("@Autor", c.Autor);
                    comanda.Parameters.AddWithValue("@Editura", c.Editura);
                    comanda.Parameters.AddWithValue("@Pret", c.Pret);
                    comanda.Parameters.AddWithValue("@NrPagini", c.NrPagini);
                    comanda.Parameters.AddWithValue("@TipCarte", c.Tip);

                    int i = comanda.ExecuteNonQuery();
                    conexiune.Close();
                    if (i != 0)
                    {
                        MessageBox.Show("Cartea a fost inserata!");
                        incarcaDate();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void modificaOCarteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carte c2 = new Carte();
            foreach (ListViewItem item in listView1.Items)
            {

                if (item.Checked)
                {
                    c2.IdCarte = Convert.ToInt32(item.SubItems[0].Text);
                    c2.NumeCarte = item.SubItems[1].Text;
                    c2.Autor = item.SubItems[2].Text;
                    c2.Editura = item.SubItems[3].Text;
                    c2.Pret = float.Parse(item.SubItems[4].Text);
                    c2.NrPagini = double.Parse(item.SubItems[5].Text);
                    c2.Tip = item.SubItems[6].Text;
                }
            }

            FormAdaugaCarte fc = new FormAdaugaCarte(c2);
            fc.Text = "Modifica datele unei carti";
            fc.buttonSalveaza.Text = "Modifica";
            fc.Actualizeaza();

            fc.ShowDialog();
            int id = c2.IdCarte;

            if (fc.DialogResult == DialogResult.OK)
                    {
                        SqlConnection conexiune = new SqlConnection(stringConexiune);
                        SqlCommand comanda = new SqlCommand();
                        comanda.Connection = conexiune;
                        conexiune.Open();

                        comanda.CommandText = "UPDATE dbo.Carti SET Id=@Id, NumeCarte=@NumeCarte, Autor=@Autor, Editura=@Editura, Pret=@Pret, NrPagini=@NrPagini, TipCarte=@TipCarte " +
                         "WHERE Id=@id";

                        comanda.Parameters.AddWithValue("@Id", c2.IdCarte);
                        comanda.Parameters.AddWithValue("@NumeCarte", c2.NumeCarte);
                        comanda.Parameters.AddWithValue("@Autor", c2.Autor);
                        comanda.Parameters.AddWithValue("@Editura", c2.Editura);
                        comanda.Parameters.AddWithValue("@Pret", c2.Pret);
                        comanda.Parameters.AddWithValue("@NrPagini", c2.NrPagini);
                        comanda.Parameters.AddWithValue("@TipCarte", c2.Tip);


                        comanda.ExecuteNonQuery();


                        MessageBox.Show("Cartea a fost modificata!");
                        incarcaDate();
             
            }
        }
        

        private void stergeOCarteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rez = MessageBox.Show("Sigur doriti sa stergeti aceasta carte?", "Confirmare stergere", MessageBoxButtons.YesNoCancel);
            if (rez == DialogResult.Yes)
            {
                SqlConnection conexiune = new SqlConnection(stringConexiune);
                SqlCommand comanda = new SqlCommand();
                try
                {
                    conexiune.Open();

                    foreach (ListViewItem item in listView1.Items)
                    {

                        if (item.Checked)
                        {
                            int id = Convert.ToInt32(item.SubItems[0].Text);


                            comanda.CommandText = "DELETE FROM carti WHERE id=" + id;
                            comanda.Connection = conexiune;

                            comanda.ExecuteNonQuery();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    conexiune.Close();
                }


                this.incarcaDate();
            }
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            this.listView1.FullRowSelect = e.Item.Checked;
            if (e.Item.Checked)
            {
                e.Item.Selected = true;
            }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            this.listView1.FullRowSelect = e.Item.Checked;
        }

        private void salveazaInFisierXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream memStream = new MemoryStream();
                XmlTextWriter writer = new XmlTextWriter(memStream, Encoding.UTF8);
                writer.Formatting = Formatting.Indented;

                writer.WriteStartDocument();
                writer.WriteStartElement("Lista-Carti");


                List<Carte> lista2 = new List<Carte>();

                foreach(ListViewItem it in listView1.Items)
                {
                    Carte c = new Carte();
                    c.IdCarte = Convert.ToInt32(it.SubItems[0].Text);
                    c.NumeCarte = it.SubItems[1].Text;
                    c.Autor = it.SubItems[2].Text;
                    c.Editura = it.SubItems[3].Text;
                    c.Pret = float.Parse(it.SubItems[4].Text);
                    c.NrPagini = double.Parse(it.SubItems[5].Text);
                    c.Tip = it.SubItems[6].Text;

                    lista2.Add(c);
                }


                foreach (Carte c in lista2)
                {
                    writer.WriteStartElement("Carte");

                    writer.WriteElementString("ID-CARTE", c.IdCarte.ToString());
                    writer.WriteElementString("NUME-CARTE", c.NumeCarte);
                    writer.WriteElementString("AUTOR", c.Autor);
                    writer.WriteElementString("EDITURA", c.Editura);
                    writer.WriteElementString("PRET", c.Pret.ToString());
                    writer.WriteElementString("NR-PAGINI", c.NrPagini.ToString());
                    writer.WriteElementString("TIP", c.Tip);

                    writer.WriteEndElement();

                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
                string xmlString = Encoding.UTF8.GetString(memStream.ToArray());
                memStream.Close();
                memStream.Dispose();
                StreamWriter sw = new StreamWriter("fisierXMLCarti.xml");
                sw.WriteLine(xmlString);
                sw.Close();
                MessageBox.Show("Datele au fost salvate cu succes");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          

        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.M)
            {
                MessageBox.Show("Ati apasat tasta M pentru modificarea unei carti");
                modificaOCarteToolStripMenuItem_Click(sender, e);
            }
            if(e.KeyCode==Keys.D)
            {
                MessageBox.Show("Ati apasat tasta D pentru stergerea unei carti");
                stergeOCarteToolStripMenuItem_Click(sender, e);
            }
        }

        private void restaurareFisierXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("fisierXMLCarti.xml");
                string str = sr.ReadToEnd();
                List<Carte> lista = new List<Carte>();
                XmlReader reader = XmlReader.Create(new StringReader(str));
                while (reader.Read())
                {
                    if (reader.Name == "Carte" && reader.NodeType == XmlNodeType.Element)
                    {
                        Carte c;
                        while (reader.Read() && reader.Name != "ID-CARTE") { }
                        reader.Read();
                        int id = Convert.ToInt32(reader.Value);

                        while (reader.Read() && reader.Name != "NUME-CARTE") { }
                        reader.Read();
                        string nume = reader.Value.ToString();

                        while (reader.Read() && reader.Name != "AUTOR") { }
                        reader.Read();
                        string autor = reader.Value.ToString();

                        while (reader.Read() && reader.Name != "EDITURA") { }
                        reader.Read();
                        string editura = reader.Value.ToString();

                        while (reader.Read() && reader.Name != "PRET") { }
                        reader.Read();
                        float pret = float.Parse(reader.Value);

                        while (reader.Read() && reader.Name != "NR-PAGINI") { }
                        reader.Read();
                        double nrPagini = double.Parse(reader.Value);

                        while (reader.Read() && reader.Name != "TIP") { }
                        reader.Read();
                        string tip = reader.Value.ToString();

                        c = new Carte(id, nume, autor, editura, pret, nrPagini, tip);
                        lista.Add(c);
                    }
                }
                listView1.Items.Clear();

                foreach (Carte c in lista)
                {
                    ListViewItem lvi = new ListViewItem(c.IdCarte.ToString());
                    lvi.SubItems.Add(c.NumeCarte);
                    lvi.SubItems.Add(c.Autor);
                    lvi.SubItems.Add(c.Editura);
                    lvi.SubItems.Add(c.Pret.ToString());
                    lvi.SubItems.Add(c.NrPagini.ToString());
                    lvi.SubItems.Add(c.Tip);


                    listView1.Items.Add(lvi);
                }
                MessageBox.Show("Restaurare realizata cu succes");
                sr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            

        }
    } 
}
