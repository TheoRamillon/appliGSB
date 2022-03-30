using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MesClasses;

namespace GSB
{
    public partial class frmRegion : Form
    {
        BindingSource bdsDirecteur = new BindingSource();
        public frmRegion()
        {
            InitializeComponent();
        }

        private void frmRegion_Load(object sender, EventArgs e)
        {
            bdsDirecteur.DataSource = Passerelle2.getListDirecteur();
            cbbDirecteur.DataSource = bdsDirecteur;
            cbbDirecteur.DisplayMember = "nom";


            cbbDirecteur.SelectedItem = (MesClasses.DirecteurRegional)bdsDirecteur.Current;

           
        }

        private void lblNomRegion_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouterSecteur_Click(object sender, EventArgs e)
        {
            MesClasses.Region uneRegion = new MesClasses.Region(txtNomRegion.Text, (MesClasses.DirecteurRegional)cbbDirecteur.SelectedItem);
            Passerelle2.createRegion(uneRegion);
            //clear
            MessageBox.Show("Une nouvelle région à bien été créé");
            this.Close();
        }
    }
}
