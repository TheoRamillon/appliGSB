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
    public partial class frmMDirecteur : Form
    {
        BindingSource bdsDirecteur = new BindingSource();
        public frmMDirecteur()
        {
            InitializeComponent();
        }

        private void frmMDirecteur_Load(object sender, EventArgs e)
        {
            //Gestion combo directeur
            bdsDirecteur.DataSource = Passerelle2.getListDirecteur();
            cbbDirecteur.DataSource = bdsDirecteur;
            cbbDirecteur.DisplayMember = "nom";
            cbbDirecteur.SelectedItem = (MesClasses.DirecteurRegional)bdsDirecteur.Current;

            DirecteurRegional directeurSelectionner = (MesClasses.DirecteurRegional)bdsDirecteur[cbbDirecteur.SelectedIndex];

            //Nom
            txtNom.Text = directeurSelectionner.getNom();
            //Enfant
            nudEnfantsCharge.Text = directeurSelectionner.getnNEnfantsAcharge().ToString();
            //Situation familiale
            cbbSituation.Text = directeurSelectionner.getLaSituationFamiliale();
            //date de naissance
            dtpDateNaissanceMedecin.Text = directeurSelectionner.getDateNaissance();
            //date embauche
            dtpDateEmbaucheMedecin.Text = directeurSelectionner.getDateEmbauche();
            //Affichage Region
            try
            {
                lblRegion.Text = directeurSelectionner.getNomRegion();
            }
            catch
            {
                lblRegion.Text = "Ce directeur ne supervise aucune région.";
            }
        }

        private void cbbDirecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirecteurRegional directeurSelectionner = (MesClasses.DirecteurRegional)bdsDirecteur[cbbDirecteur.SelectedIndex];

            //Nom
            txtNom.Text = directeurSelectionner.getNom();
            //Enfant
            nudEnfantsCharge.Text = directeurSelectionner.getnNEnfantsAcharge().ToString();
            //Situation familiale
            cbbSituation.Text = directeurSelectionner.getLaSituationFamiliale();
            //date de naissance
            dtpDateNaissanceMedecin.Text = directeurSelectionner.getDateNaissance();
            //date embauche
            dtpDateEmbaucheMedecin.Text = directeurSelectionner.getDateEmbauche();
            //Affichage Region
            try
            {
                lblRegion.Text = directeurSelectionner.getNomRegion();
            }
            catch
            {
                lblRegion.Text = "Ce directeur ne supervise aucune région.";
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            btnValider.Visible = true;
            btnModifier.Visible = false;
            cbbDirecteur.Enabled = false;
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
            DirecteurRegional updateDirecteur = new DirecteurRegional();
            DirecteurRegional directeurSelect = (MesClasses.DirecteurRegional)bdsDirecteur[cbbDirecteur.SelectedIndex];

            updateDirecteur.setNumero(directeurSelect.getNumero());
            updateDirecteur.setDateEmbauche(dtpDateEmbaucheMedecin.Text);
            updateDirecteur.setDateNaissance(dtpDateNaissanceMedecin.Text);
            updateDirecteur.setLaSituationFamiliale(cbbSituation.Text);
            updateDirecteur.setnbEnfantACharge(int.Parse(nudEnfantsCharge.Value.ToString()));
            updateDirecteur.setNom(txtNom.Text);

            Passerelle2.updateDirecteur(updateDirecteur);
            Passerelle2.reloadList();
            this.Close();

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            pnlValidation.Visible = true;
            cbbDirecteur.Enabled = false;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            DirecteurRegional directeurSelect = (MesClasses.DirecteurRegional)bdsDirecteur[cbbDirecteur.SelectedIndex];
            Passerelle2.deleteDirecteur(directeurSelect);
            Passerelle2.reloadList();
            this.Close();
        }

        private void btnNon_Click(object sender, EventArgs e)
        {
            pnlValidation.Visible = false;
            cbbDirecteur.Enabled = true;
        }
    }
}
