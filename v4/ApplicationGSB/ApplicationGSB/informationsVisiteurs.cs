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
    public partial class frmInformationsVisiteurs : Form
    {
        BindingSource bdsRegion = new BindingSource();
        BindingSource bdsSecteur = new BindingSource();
        BindingSource bdsVisiteur = new BindingSource();
        BindingSource bdsDirecteur = new BindingSource();
        public frmInformationsVisiteurs()
        {
            InitializeComponent();
        }

        private void frmMesInformations_Load(object sender, EventArgs e)
        {
            //Gestion combo visiteurs
            bdsVisiteur.DataSource = Passerelle2.getListVisiteur();
            cbbVisiteurs.DataSource = bdsVisiteur;
            cbbVisiteurs.DisplayMember = "nom";
            cbbVisiteurs.SelectedItem = (MesClasses.Visiteur)bdsVisiteur.Current;

            Visiteur leVisiteur = (MesClasses.Visiteur)bdsVisiteur[cbbVisiteurs.SelectedIndex];

            //Affichage âge

            //Affichage region
            txtRegion.Text = leVisiteur.getDirecteurRegional().getRegion().getNomRegion();

            //Affichage directeur
            txtDirecteur.Text = leVisiteur.getDirecteurRegional().getNom();

            //affichage secteur
            try
            {
                txtSecteur.Text = leVisiteur.getNomMonSecteur();
            }
            catch
            {
                txtSecteur.Text = "Le visiteur n'a pas de secteur.";
            }
            
        }

        private void cbbVisiteurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Visiteur leVisiteur = (MesClasses.Visiteur)bdsVisiteur[cbbVisiteurs.SelectedIndex];

            //Affichage âge

            //Affichage region
            txtRegion.Text = leVisiteur.getDirecteurRegional().getRegion().getNomRegion();

            //Affichage directeur
            txtDirecteur.Text = leVisiteur.getDirecteurRegional().getNom();

            //affichage secteur
            try
            {
                txtSecteur.Text = leVisiteur.getNomMonSecteur();
            }
            catch
            {
                txtSecteur.Text = "Le visiteur n'a pas de secteur.";
            }
        }

        private void txtSecteur_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDirecteur_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
