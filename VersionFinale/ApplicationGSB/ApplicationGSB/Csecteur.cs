using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MesClasses;

namespace GSB
{
    public partial class frmCSecteur : Form
    {
        public frmCSecteur()
        {
            InitializeComponent();
        }

        private void lblNomRegion_Click(object sender, EventArgs e)
        {

        }

        private void frmRegion_Load(object sender, EventArgs e)
        {
            BindingSource bdsRegion = new BindingSource();
            bdsRegion.DataSource = Passerelle2.getListRegion();
            cbbRegion.DataSource = bdsRegion;
            cbbRegion.DisplayMember = "nomRegion";
        }

        private void btnAjouterSecteur_Click(object sender, EventArgs e)
        {
            try
            {
                MesClasses.Secteur unSecteur = new MesClasses.Secteur(txtNomSecteur.Text, (MesClasses.Region)cbbRegion.SelectedItem);
                Passerelle2.createSecteur(unSecteur);
                //clear
                MessageBox.Show("Un nouveau secteur à bien été créé");
                Passerelle2.reloadList();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Veuillez bien renseigner toutes les informations !");
            }
        }
    }
}
