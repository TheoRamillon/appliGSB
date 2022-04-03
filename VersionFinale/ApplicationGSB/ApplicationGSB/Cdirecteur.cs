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
        BindingSource bdsRegion = new BindingSource();
        public frmCdirecteur()
        {
            InitializeComponent();
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

            List<MesClasses.Region> RegionSansDirecteur = new List<MesClasses.Region>();
            foreach(MesClasses.Region r in Passerelle2.getListRegion())
            {
                try
                {
                    string nom = r.GetDirecteur().getNom();
                        
                }
                catch
                {
                    RegionSansDirecteur.Add(r);
                }
                
            }

            if(RegionSansDirecteur.Count() == 0)
            {
                ckbRegion.Visible = false;
                cbbRegion.Visible = false;
                lblZeroRegion.Visible = true;
            }
            else
            {           
                bdsRegion.DataSource = RegionSansDirecteur;
                cbbRegion.DataSource = bdsRegion;
                cbbRegion.DisplayMember = "nomRegion";
                cbbRegion.SelectedItem = (MesClasses.Region)bdsRegion.Current;
            }
            
        }

        private void ckbRegion_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbRegion.Checked)
                cbbRegion.Visible = true;
            else
                cbbRegion.Visible = false;
        }

        private void btnAjouterMedecin_Click(object sender, EventArgs e)
        {

            DirecteurRegional newDirecteur = new DirecteurRegional();
            string resultat, resultat2;
            try
            {
                resultat = dtpDateEmbaucheMedecin.Text;
                resultat2 = dtpDateNaissanceMedecin.Text;

                newDirecteur.setDateEmbauche(resultat);
                newDirecteur.setDateNaissance(resultat2);
                newDirecteur.setLaSituationFamiliale(dudSituationFamilliale.Text);
                newDirecteur.setnbEnfantACharge(int.Parse(nudEnfantsCharge.Value.ToString()));
                newDirecteur.setNom(txtNomMedecin.Text);
                if (ckbRegion.Checked)
                {
                    MesClasses.Region RegionSelectionner = (MesClasses.Region)bdsRegion[cbbRegion.SelectedIndex];
                    newDirecteur.setRegion(RegionSelectionner);
                }

                //MessageBox.Show(nudEnfantsCharge.Value.ToString());
                Passerelle2.createDirecteur(newDirecteur);

                //clear
                MessageBox.Show("Un nouveau directeur regional à bien été créé");
                Passerelle2.reloadList();
                this.Close();
            }
            catch
            {
                Passerelle2.closeConnexion();
                MessageBox.Show("Veuillez bien renseigner toutes les informations !");
            }

        }
    }
}
