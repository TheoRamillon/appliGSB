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
    public partial class frmInformationsSecteurs : Form
    {

        BindingSource bdsRegion = new BindingSource();
        BindingSource bdsSecteur = new BindingSource();

        List<Visiteur> lesVisiteurs = Passerelle2.getListVisiteur();

        public frmInformationsSecteurs()
        {
            InitializeComponent();
        }

        private void informationsSecteurs_Load(object sender, EventArgs e)
        {
            //Gestion cbb secteur
            bdsSecteur.DataSource = Passerelle2.getListSecteur();
            cbbSecteur.DataSource = bdsSecteur;
            cbbSecteur.DisplayMember = "nomSecteur";
            cbbSecteur.SelectedItem = (MesClasses.Secteur)bdsSecteur.Current;

            //Gestion label Region
            Secteur s = (MesClasses.Secteur)bdsSecteur.Current;
            lblRegion.Text = s.getRegion().getNomRegion().ToString();

            //Gestion label directeur
            DirecteurRegional directeurDeLaRegion = s.getDirecteurSecteur();
            lblNomDirecteur.Text = directeurDeLaRegion.getNom();

            //Gestion label visiteur
            Visiteur leVisiteur = new Visiteur();

            int nbVisiteur = lesVisiteurs.Count();
            bool secteurTrouve = false;

            for(int i = 0; i<nbVisiteur; i++)
            {
                foreach(Visiteur v in lesVisiteurs)
                {
                    if (v.getNumSecteur() == s.getnumSecteur())
                    {
                        leVisiteur = v;
                        secteurTrouve = true;
                        i = nbVisiteur;
                    }
                }
            }

            if (secteurTrouve == true)
                lblVisiteur.Text = leVisiteur.getNom();
            else
                lblVisiteur.Text = "Aucun visiteur ne représente ce secteur.";


        }

        private void cbbSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Gestion label Region
            Secteur s = (MesClasses.Secteur)bdsSecteur[cbbSecteur.SelectedIndex];
            lblRegion.Text = s.getRegion().getNomRegion().ToString();

            //Gestion label directeur
            DirecteurRegional directeurDeLaRegion = s.getDirecteurSecteur();
            lblNomDirecteur.Text = directeurDeLaRegion.getNom();

            //Gestion label visiteur
            Visiteur leVisiteur = new Visiteur();

            int nbVisiteur = lesVisiteurs.Count();
            bool secteurTrouve = false;

            for (int i = 0; i < nbVisiteur; i++)
            {
                foreach (Visiteur v in lesVisiteurs)
                {
                    if (v.getNumSecteur() == s.getnumSecteur())
                    {
                        leVisiteur = v;
                        secteurTrouve = true;
                        i = nbVisiteur;
                    }
                }
            }

            if (secteurTrouve == true)
                lblVisiteur.Text = leVisiteur.getNom();
            else
                lblVisiteur.Text = "Aucun visiteur ne représente ce secteur.";
        }
    }
}
