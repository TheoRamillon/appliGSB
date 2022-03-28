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
    public partial class frmCdirecteur : Form
    {
        public frmCdirecteur()
        {
            InitializeComponent();
        }

        private void btnAjouterMedecin_Click(object sender, EventArgs e)
        {

            DirecteurRegional newDirecteur = new DirecteurRegional();
            string resultat, resultat2;


            resultat = dtpDateEmbaucheMedecin.Text;
            resultat2 = dtpDateNaissanceMedecin.Text;
            //MessageBox.Show(resultat.ToString() + "-" + resultat2.ToString());

            newDirecteur.setDateEmbauche(resultat);
            newDirecteur.setDateNaissance(resultat2);
            newDirecteur.setLaSituationFamiliale(dudSituationFamilliale.Text);
            newDirecteur.setnbEnfantACharge(int.Parse(nudEnfantsCharge.Value.ToString()));
            newDirecteur.setNom(txtNomMedecin.Text);

            //MessageBox.Show(nudEnfantsCharge.Value.ToString());
            Passerelle2.createDirecteur(newDirecteur);

            //clear
            MessageBox.Show("Un nouveau directeur regional à bien été créé");
            this.Close();
        }

        private void gpbCreationMedecin_Enter(object sender, EventArgs e)
        {

        }

        private void frmCdirecteur_Load(object sender, EventArgs e)
        {
            dudSituationFamilliale.Items.Clear();
            dudSituationFamilliale.Items.Add("Marié");
            dudSituationFamilliale.Items.Add("Pacsé");
            dudSituationFamilliale.Items.Add("Divorcé");
            dudSituationFamilliale.Items.Add("Séparé");
            dudSituationFamilliale.Items.Add("Célibataire");
            dudSituationFamilliale.Items.Add("Veuf");
        }

        private void dtpDateNaissanceMedecin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateNaissanceMedecin_Click(object sender, EventArgs e)
        {

        }
    }
}
