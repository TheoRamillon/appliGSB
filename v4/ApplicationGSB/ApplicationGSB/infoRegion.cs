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
    public partial class frmInfoRegion : Form
    {

        BindingSource bdsRegion = new BindingSource();
        BindingSource bdsSecteur = new BindingSource();
        BindingSource bdsVisiteur = new BindingSource();

        public frmInfoRegion()
        {
            InitializeComponent();
        }

        

        private void frmInfoRegion_Load(object sender, EventArgs e)
        {
            
            bdsRegion.DataSource = Passerelle2.getListRegion();
            cbbRegion.DataSource = bdsRegion;
            cbbRegion.DisplayMember = "nomRegion";
            cbbRegion.SelectedItem = (MesClasses.Region)bdsRegion.Current;

            MesClasses.Region regionSelect = (MesClasses.Region)bdsRegion[cbbRegion.SelectedIndex];

            //Gestion label directeur
            DirecteurRegional directeurDeLaRegion = regionSelect.GetDirecteur();
            //DirecteurRegional directeurDeLaRegion = Passerelle2.getDirecteurDeLaRegion((MesClasses.Region)bdsRegion[cbbRegion.SelectedIndex]);
            try
            {
                lblNomDirecteur.Text = directeurDeLaRegion.getNom();
            }
            catch
            {
                lblNomDirecteur.Text = "Cette région ne possède pas de directeur.";
            }

            //Gestion cbb secteur
            List<Secteur> lesSecteurs = regionSelect.getSecteurs();

            //bdsSecteur.DataSource = lesSecteurs;
            //cbbSecteur.DataSource = bdsSecteur;
            //cbbSecteur.DisplayMember = "nomSecteur";
            //cbbSecteur.SelectedItem = (MesClasses.Secteur)bdsSecteur.Current;

            bdsSecteur.DataSource = lesSecteurs;
            lbxSecteur.DataSource = bdsSecteur;
            lbxSecteur.DisplayMember = "nomSecteur";

            //Gestion visiteurs

            List<Visiteur> lesVisteurs = Passerelle2.getListVisiteur();
            List<Visiteur> lesVisteursDeRegion = new List<Visiteur>();

            foreach(Visiteur v in lesVisteurs)
            {
                if(v.getNumDirecteur() == directeurDeLaRegion.getNumDirecteur())
                {
                    lesVisteursDeRegion.Add(v);
                }
            }

            bdsVisiteur.DataSource = lesVisteursDeRegion;
            lbxVisiteur.DataSource = bdsVisiteur;
            lbxVisiteur.DisplayMember = "nom";



        }

        private void cbbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            MesClasses.Region regionSelect = (MesClasses.Region)bdsRegion[cbbRegion.SelectedIndex];
            DirecteurRegional directeurDeLaRegion = regionSelect.GetDirecteur();
            try
            {
                lblNomDirecteur.Text = directeurDeLaRegion.getNom();
            }
            catch
            {
                lblNomDirecteur.Text = "Cette région ne possède pas de directeur.";
            }
            

            //Gestion cbb secteur
            List<Secteur> lesSecteurs = regionSelect.getSecteurs();

            //bdsSecteur.DataSource = lesSecteurs;
            //cbbSecteur.DataSource = bdsSecteur;
            //cbbSecteur.DisplayMember = "nomSecteur";
            //cbbSecteur.SelectedItem = (MesClasses.Secteur)bdsSecteur.Current;

            bdsSecteur.DataSource = lesSecteurs;
            lbxSecteur.DataSource = bdsSecteur;
            lbxSecteur.DisplayMember = "nomSecteur";

            //Gestion visiteurs

            List<Visiteur> lesVisteurs = Passerelle2.getListVisiteur();
            List<Visiteur> lesVisteursDeRegion = new List<Visiteur>();

            foreach (Visiteur v in lesVisteurs)
            {
                try
                {
                    if (v.getNumDirecteur() == directeurDeLaRegion.getNumDirecteur())
                    {
                        lesVisteursDeRegion.Add(v);
                    }
                }
                catch
                {

                }
                
            }

            bdsVisiteur.DataSource = lesVisteursDeRegion;
            lbxVisiteur.DataSource = bdsVisiteur;
            lbxVisiteur.DisplayMember = "nom";

        }

    }
}
