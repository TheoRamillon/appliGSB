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
    public partial class frmCVisiteur : Form
    {
        BindingSource bdsDirecteur = new BindingSource();
        public frmCVisiteur()
        {
            InitializeComponent();
        }

        private void btnAjouterMedecin_Click(object sender, EventArgs e)
        {
            
        }

        private void frmCVisiteur_Load(object sender, EventArgs e)
        {   
            bdsDirecteur.DataSource = Passerelle2.getListDirecteur();
            cbbDirecteur.DataSource = bdsDirecteur;
            cbbDirecteur.DisplayMember = "nom";

            dudSituationFamilliale.Items.Add("Marié");
            dudSituationFamilliale.Items.Add("Pacsé");
            dudSituationFamilliale.Items.Add("Divorcé");
            dudSituationFamilliale.Items.Add("Séparé");
            dudSituationFamilliale.Items.Add("Célibataire");
            dudSituationFamilliale.Items.Add("Veuf");
            dudSituationFamilliale.SelectedIndex = 0;
        }

        private void btnAjouterMedecin_Click_1(object sender, EventArgs e)
        {
            try
            {
                Visiteur newVisiteur = new Visiteur();
                newVisiteur.setDateEmbauche(dtpDateEmbaucheMedecin.Text);
                newVisiteur.setDateNaissance(dtpDateNaissanceMedecin.Text);
                newVisiteur.setLaSituationFamiliale(dudSituationFamilliale.Text);
                newVisiteur.setnbEnfantACharge(int.Parse(nudEnfantsCharge.Value.ToString()));
                newVisiteur.setNom(txtNomMedecin.Text);
                newVisiteur.setDirecteur((MesClasses.DirecteurRegional)bdsDirecteur[cbbDirecteur.SelectedIndex]);

                Passerelle2.createVisiteur(newVisiteur);
                Passerelle2.reloadList();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Veuillez bien renseigner toutes les informations avant d'ajouter un visiteur !");
            }
            
        }




        private void gpbCreationMedecin_Enter(object sender, EventArgs e)
        {

        }
    }
}
