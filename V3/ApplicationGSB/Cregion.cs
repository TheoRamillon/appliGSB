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
    public partial class frmCRegion : Form
    {
        
        public frmCRegion()
        {
            InitializeComponent();
        }

        private void frmRegion_Load(object sender, EventArgs e)
        {
            List<DirecteurRegional> DirecteurSansRegion = new List<DirecteurRegional>();
            foreach (DirecteurRegional d in Passerelle2.getListDirecteur())
            {
                try
                {
                    string nom = d.getRegion().getNomRegion();

                }
                catch
                {
                    DirecteurSansRegion.Add(d);
                }

            }

            if (DirecteurSansRegion.Count() == 0)
            {
                ckbDirecteur.Visible = false;
                cbbDirecteur.Visible = false;
                lblZeroDirecteur.Visible = true;
            }
            else
            {
                BindingSource bdsDirecteur = new BindingSource();
                bdsDirecteur.DataSource = DirecteurSansRegion;
                cbbDirecteur.DataSource = bdsDirecteur;
                cbbDirecteur.DisplayMember = "nom";
                cbbDirecteur.SelectedItem = (MesClasses.DirecteurRegional)bdsDirecteur.Current;
            }


        }

        private void lblNomRegion_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouterSecteur_Click(object sender, EventArgs e)
        {
            try
            { 
                MesClasses.Region uneRegion = new MesClasses.Region(txtNomRegion.Text, (MesClasses.DirecteurRegional)cbbDirecteur.SelectedItem);
                Passerelle2.createRegion(uneRegion);
                //clear
                MessageBox.Show("Une nouvelle région à bien été créé");
                Passerelle2.reloadList();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Veuillez bien renseigner toutes les informations !");
            }
        }

        private void ckbDirecteur_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbDirecteur.Checked)
            {
                cbbDirecteur.Visible = true;
                lblNomDIrecteur.Visible = true;
            }
            else
            {
                lblNomDIrecteur.Visible = false;
                cbbDirecteur.Visible = false;
            }
                

        }

        private void lblZeroDirecteur_Click(object sender, EventArgs e)
        {

        }
    }
}
