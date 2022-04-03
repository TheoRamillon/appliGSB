using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MesClasses;

namespace GSB
{
    public partial class frmGestionVisiteurs : Form
    {
        BindingSource bdsVisiteur = new BindingSource();
        BindingSource bdsSecteur = new BindingSource();
        List<Visiteur> MesVisiteurs = new List<Visiteur>();   
        DirecteurRegional directeurCo = Passerelle2.getDirecteurCo();
        public frmGestionVisiteurs()
        {
            InitializeComponent();
        }

        private void cbbVisiteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            //texte secteur
            lblAttribuerSecteur.Visible = false;
            cbbSecteur.Visible = false;
            try
            {
                Visiteur visiteurSelect = (MesClasses.Visiteur)bdsVisiteur[cbbVisiteur.SelectedIndex];
                lblAfficheSecteur.Text = visiteurSelect.getSecteur().getnomSecteur();
            }
            catch
            {
                lblAttribuerSecteur.Visible = true;
                cbbSecteur.Visible = true;
                btnAttribuer.Visible = true;
                lblAfficheSecteur.Text = "Ce visiteur n'est affecté à aucun secteur.";
            }
        }

        private void gestionVisiteurs_Load(object sender, EventArgs e)
        { 

            foreach (Visiteur unV in Passerelle2.getListVisiteur())
            {
                if (unV.getNumDirecteur() == directeurCo.getNumero())
                {
                    MesVisiteurs.Add(unV);
                }
            }

            bool verifSecteur = true;
            List<Secteur> secteursSansVisiteur = new List<Secteur>();

            foreach (Secteur unS in Passerelle2.getListSecteur())
            {
                if (unS.getDirecteurSecteur().getNumero() == directeurCo.getNumero())
                {
                    foreach (Visiteur unV in MesVisiteurs)
                    {
                        if(unV.getNumSecteur() == unS.getnumSecteur())
                        {
                            verifSecteur = false;
                        }
                    }
                    if (verifSecteur == true)
                        secteursSansVisiteur.Add(unS);
                    verifSecteur = true;
                }
            }

            bdsSecteur.DataSource = secteursSansVisiteur;
            cbbSecteur.DataSource = bdsSecteur;
            cbbSecteur.DisplayMember = "nomSecteur";
            cbbSecteur.SelectedItem = (MesClasses.Secteur)bdsSecteur.Current;

            bdsVisiteur.DataSource = MesVisiteurs;
            cbbVisiteur.DataSource = bdsVisiteur;
            cbbVisiteur.DisplayMember = "nom";
            cbbVisiteur.SelectedItem = (MesClasses.Visiteur)bdsVisiteur.Current;
        }

        private void btnAttribuer_Click(object sender, EventArgs e)
        {
            Visiteur unV = (MesClasses.Visiteur)bdsVisiteur[cbbVisiteur.SelectedIndex];
            Secteur unS = (MesClasses.Secteur)bdsSecteur[cbbSecteur.SelectedIndex];

            Passerelle2.updateSecteurDuVisiteur(unS, unV);
            Passerelle2.reloadList();
            this.Close();
        }
    }
}
