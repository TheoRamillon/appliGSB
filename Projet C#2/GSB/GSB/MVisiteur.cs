using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MesClasses;
using MySql.Data.MySqlClient;

namespace GSB
{
    public partial class frmMvisiteur : Form
    {
        public static Secteur UnSecteur = new Secteur("THESECTEUR", 1);
        public static DirecteurRegional UnDirecteurRegional = new DirecteurRegional("23/12/17", "15/09/02", "Célibataire", 0, "LEBIGBOSS", 14);
        public static Visiteur UnVisiteur = new Visiteur(UnDirecteurRegional,UnSecteur,"23/12/17", "15/09/02", "Célibataire", 0, "SHEEESH", 14);
        public frmMvisiteur()
        {
            InitializeComponent();
            txtNom.Text = UnVisiteur.getNom();
            txtLaSituationFamilialeV.Text = UnVisiteur.getLaSituationFamiliale();
            txtDateNaissanceV.Text = UnVisiteur.getDateNaissance();
            txtNbEnfantsAChargeV.Text = UnVisiteur.getnNEnfantsAcharge().ToString();
            txtNomDirecteurV.Text = UnVisiteur.GetInfoMonDirecteurRegional();
            txtSecteurV.Text = UnVisiteur.GetNomMonSecteur();
            txtDateEmbaucheV.Text = UnVisiteur.getDateEmbauche();

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnModifierV_Click(object sender, EventArgs e)
        {
            UnVisiteur.setNom(txtNom.Text);
            UnVisiteur.setnbEnfantACharge(int.Parse(txtNbEnfantsAChargeV.Text));
            UnVisiteur.setLaSituationFamiliale(txtLaSituationFamilialeV.Text);
            UnVisiteur.setDateNaissance(txtDateNaissanceV.Text);
        }
        public static void ModifVisiteur()
        {
          
        }

        private void frmMvisiteur_Load(object sender, EventArgs e)
        {

        }
    }
}
