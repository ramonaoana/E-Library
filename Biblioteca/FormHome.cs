using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Biblioteca
{
    
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();

            customizeDesign();
            openChildForm(new FormWelcome());
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }
        private void customizeDesign()
        {
            panelSubMenu1.Visible = false;
            panelSubMenuCititori.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelSubMenu1.Visible == true)
                panelSubMenu1.Visible = false;
            if (panelSubMenuCititori.Visible == true)
                panelSubMenuCititori.Visible = false;
        }
        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else submenu.Visible = false;
        }





        private void button4_Click(object sender, EventArgs e)
        {

            openChildForm(new FormGrafic2());

        }

      

        private void buttonMenuCarti_Click(object sender, EventArgs e)
        {
            //showSubMenu(panelSubMenu1);
            panelSubMenu1.Visible = true;
        }

        private void buttonCititori_Click(object sender, EventArgs e)
        {
            //showSubMenu(panelSubMenuCititori);
            panelSubMenuCititori.Visible = true;
        }

        private Form activeForm = null;
        private void openChildForm(Form child)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panelForm.Controls.Add(child);
            panelForm.Tag = child;
            child.BringToFront();
            child.Show();
            
        }


        private void buttonListaCarti_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCarti());
            
        }


        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            openChildForm(new FormWelcome());
            panelSubMenu1.Visible = false;
            panelSubMenuCititori.Visible = false;
            panelImpr.Visible = false;
        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonRaportCarti_Click(object sender, EventArgs e)
        {
            openChildForm(new FormRaport());

        }

        private void buttonListaCititori_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCititor());
        }

        private void buttonImprumuturi_Click(object sender, EventArgs e)
        {
            panelImpr.Visible = true;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new FormPieChartCititori());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new FormImprumuturi());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGraficImprumuturi());
   
        }

        private void buttonAdaugaAdmin_Click(object sender, EventArgs e)
        {
            //FormAdaugaAdmin f=new FormAdaugaAdmin();
            //f.ShowDialog();

            openChildForm(new FormAdaugaAdmin());

        }
    }
}
