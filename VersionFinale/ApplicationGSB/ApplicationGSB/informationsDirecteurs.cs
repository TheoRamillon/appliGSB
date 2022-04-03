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
    public partial class frmInformationsDirecteurs : Form
    {
        BindingSource bdsRegion = new BindingSource();
        BindingSource bdsSecteur = new BindingSource();
        BindingSource bdsVisiteur = new BindingSource();
        BindingSource bdsDirecteur = new BindingSource();

        public frmInformationsDirecteurs()
        {
            InitializeComponent();
        }

        private void frmMesInformations_Load(object sender, EventArgs e)
        {

            //Gestion combo directeur
            bdsDirecteur.DataSource = Passerelle2.getListDirecteur();
            cbbDirecteur.DataSource = bdsDirecteur;
            cbbDirecteur.DisplayMember = "nom";
            cbbDirecteur.SelectedItem = (MesClasses.DirecteurRegional)bdsDirecteur.Current;

            DirecteurRegional directeurSelectionner = (MesClasses.DirecteurRegional)bdsDirecteur[cbbDirecteur.SelectedIndex];
            //Affichage Age
            txtAge.Text = directeurSelectionner.getAge().ToString();
            //Affichage Region
            try
            {
                txtRegion.Text = directeurSelectionner.getNomRegion();
            }
            catch
            {
                txtRegion.Text = "Ce directeur ne supervise aucune région.";
            }

            //Gestion list secteurs
            List<Secteur> lesSecteurs = directeurSelectionner.getRegion().getSecteurs();
            bdsSecteur.DataSource = lesSecteurs;
            ltbSecteurs.DataSource = bdsSecteur;
            ltbSecteurs.DisplayMember = "nomSecteur";

            //Gestion visiteurs

            List<Visiteur> lesVisteurs = Passerelle2.getListVisiteur();
            List<Visiteur> lesVisteursDeRegion = new List<Visiteur>();

            foreach (Visiteur v in lesVisteurs)
            {
                if (v.getNumDirecteur() == directeurSelectionner.getNumDirecteur())
                {
                    lesVisteursDeRegion.Add(v);
                }
            }

            bdsVisiteur.DataSource = lesVisteursDeRegion;
            ltbVisiteurs.DataSource = bdsVisiteur;
            ltbVisiteurs.DisplayMember = "nom";



        }

        private void cbbDirecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirecteurRegional directeurSelectionner = (MesClasses.DirecteurRegional)bdsDirecteur[cbbDirecteur.SelectedIndex];
            List<MesClasses.Region> lesRegions = Passerelle2.getListRegion();

            foreach (MesClasses.Region r in lesRegions)
            {
                if (r.getNumDirecteurRegion() == directeurSelectionner.getNumDirecteur())
                    directeurSelectionner.setRegion(r);
            }
            //Affichage Age
            txtAge.Text = directeurSelectionner.getAge().ToString();
            //Affichage Region
            try
            {
                txtRegion.Text = directeurSelectionner.getNomRegion();
            }
            catch
            {
                txtRegion.Text = "Ce directeur ne supervise aucune région.";
            }


            //Gestion list secteurs
            try 
            {
                List<Secteur>lesSecteurs = directeurSelectionner.getRegion().getSecteurs();
                bdsSecteur.DataSource = lesSecteurs;
                ltbSecteurs.DataSource = bdsSecteur;
                ltbSecteurs.DisplayMember = "nomSecteur";
            }
            catch
            {
                List<Secteur> lesSecteurs = new List<Secteur>();
                bdsSecteur.DataSource = lesSecteurs;
                ltbSecteurs.DataSource = bdsSecteur;
                ltbSecteurs.DisplayMember = "nomSecteur";
            }
            

            //Gestion visiteurs

            List<Visiteur> lesVisteurs = Passerelle2.getListVisiteur();
            List<Visiteur> lesVisteursDeRegion = new List<Visiteur>();

            foreach (Visiteur v in lesVisteurs)
            {
                if (v.getNumDirecteur() == directeurSelectionner.getNumDirecteur())
                {
                    lesVisteursDeRegion.Add(v);
                }
            }

            bdsVisiteur.DataSource = lesVisteursDeRegion;
            ltbVisiteurs.DataSource = bdsVisiteur;
            ltbVisiteurs.DisplayMember = "nom";
        }
    }
}
