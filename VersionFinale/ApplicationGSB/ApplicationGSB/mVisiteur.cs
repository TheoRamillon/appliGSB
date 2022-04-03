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
    public partial class frmMVisiteur : Form
    {
        BindingSource bdsVisiteur = new BindingSource();
        public frmMVisiteur()
        {
            InitializeComponent();
        }

        private void mVisiteur_Load(object sender, EventArgs e)
        {
            //Gestion combo directeur
            bdsVisiteur.DataSource = Passerelle2.getListVisiteur();
            cbbVisiteur.DataSource = bdsVisiteur;
            cbbVisiteur.DisplayMember = "nom";
            cbbVisiteur.SelectedItem = (MesClasses.Visiteur)bdsVisiteur.Current;

            Visiteur visiteurSelectionner = (MesClasses.Visiteur)bdsVisiteur[cbbVisiteur.SelectedIndex];

            //Nom
            txtNom.Text = visiteurSelectionner.getNom();
            //Enfant
            nudEnfantsCharge.Text = visiteurSelectionner.getnNEnfantsAcharge().ToString();
            //Situation familiale
            cbbSituation.Text = visiteurSelectionner.getLaSituationFamiliale();
            //date de naissance
            dtpDateNaissanceMedecin.Text = visiteurSelectionner.getDateNaissance();
            //date embauche
            dtpDateEmbaucheMedecin.Text = visiteurSelectionner.getDateEmbauche();
            //Affichage Directeur
            lblDirecteurA.Text = visiteurSelectionner.getDirecteurRegional().getNom();
        }

        private void cbbVisiteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            Visiteur visiteurSelectionner = (MesClasses.Visiteur)bdsVisiteur[cbbVisiteur.SelectedIndex];

            //Nom
            txtNom.Text = visiteurSelectionner.getNom();
            //Enfant
            nudEnfantsCharge.Text = visiteurSelectionner.getnNEnfantsAcharge().ToString();
            //Situation familiale
            cbbSituation.Text = visiteurSelectionner.getLaSituationFamiliale();
            //date de naissance
            dtpDateNaissanceMedecin.Text = visiteurSelectionner.getDateNaissance();
            //date embauche
            dtpDateEmbaucheMedecin.Text = visiteurSelectionner.getDateEmbauche();
            //Affichage Directeur
            lblDirecteurA.Text = visiteurSelectionner.getDirecteurRegional().getNom();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            btnValider.Visible = true;
            btnModifier.Visible = false;
            cbbVisiteur.Enabled = false;
            cbbSituation.Items.Clear();
            cbbSituation.Items.Add("Marié");
            cbbSituation.Items.Add("Pacsé");
            cbbSituation.Items.Add("Divorcé");
            cbbSituation.Items.Add("Séparé");
            cbbSituation.Items.Add("Célibataire");
            cbbSituation.Items.Add("Veuf");

            //Nom
            txtNom.Enabled = true;
            //Enfant
            nudEnfantsCharge.Enabled = true;
            //Situation familiale
            cbbSituation.Enabled = true;
            //date de naissance
            dtpDateNaissanceMedecin.Enabled = true;
            //date embauche
            dtpDateEmbaucheMedecin.Enabled = true;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Visiteur updateVisiteur = new Visiteur();
            Visiteur visiteurSelect = (MesClasses.Visiteur)bdsVisiteur[cbbVisiteur.SelectedIndex];

            updateVisiteur.setNumero(visiteurSelect.getNumero());
            updateVisiteur.setDateEmbauche(dtpDateEmbaucheMedecin.Text);
            updateVisiteur.setDateNaissance(dtpDateNaissanceMedecin.Text);
            updateVisiteur.setLaSituationFamiliale(cbbSituation.Text);
            updateVisiteur.setnbEnfantACharge(int.Parse(nudEnfantsCharge.Value.ToString()));
            updateVisiteur.setNom(txtNom.Text);

            Passerelle2.updateVisiteur(updateVisiteur);
            Passerelle2.reloadList();
            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            pnlValidation.Visible = true;
            cbbVisiteur.Enabled = false;
        }

        private void btnNon_Click(object sender, EventArgs e)
        {
            pnlValidation.Visible = false;
            cbbVisiteur.Enabled = true;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Visiteur visiteurSelect = (MesClasses.Visiteur)bdsVisiteur[cbbVisiteur.SelectedIndex];
            Passerelle2.deleteVisiteur(visiteurSelect);
            Passerelle2.reloadList();
            this.Close();
        }
    }
}
