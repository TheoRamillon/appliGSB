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
    public partial class Accueil : Form
    {
        private MySqlConnection connexion = new MySqlConnection("database=gsbextranetappc; server=localhost; user id=root; pwd=");
        
        public Accueil()
        {
            InitializeComponent();
            nudNumGradeMedecin.Value = 1;
            gpbCreationMedecin.Visible = false;
            txtConnexionMotDePasse.PasswordChar = '\u25CF';
            btnDeconnexion.Visible = false;
            gpbConnexionUtilisateur.Visible = true;
            btnCreationMedecin.Visible = false;
            lblDateDuJour.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dtpDateNaissanceMedecin.Format = DateTimePickerFormat.Custom;
            dtpDateNaissanceMedecin.CustomFormat = "yyyy";
            dtpDateNaissanceMedecin.ShowUpDown = true;
            grbVisiteurCreation.Visible = false;
            lblVoirDirecteurRegional.Visible = false;
            lblSecteurVisiteur.Visible = false;



        }

       

        private void btnConnexionUtilisateur_Click(object sender, EventArgs e)
        {
            if (testUtilisateur() == false)
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect !");
                txtConnexionMotDePasse.Clear();
                txtConnexionNomUtilisateur.Clear();
                connexion.Close();
            }
            else
            {
                MessageBox.Show("Connexion réussis !");
                gpbConnexionUtilisateur.Visible = false;
                btnDeconnexion.Visible = true;
                
            }
        }

        private void btnAjouterMedecin_Click(object sender, EventArgs e)
        {
            connexion.Open();
            if (txtPremierMotDePasseMedecin.Text != txtConfirmationMotDePasseMedecin.Text)
            {
                MessageBox.Show("Mot de passe différents, veuillez réésayez !");
            }
            else
            {
                string insertQuery = "INSERT INTO medecin(nom, prenom, mail, dateNaissance, motDePasse, dateCreation, numGrade, Region, NomDirecteurEnCharge, Secteur) VALUES " +
                "('" + txtNomMedecin.Text + "','" + txtPrenomMedecin.Text + "', '" + txtMailMedecin.Text + "' , '" + dtpDateNaissanceMedecin.Value.Year + "' , '" + txtConfirmationMotDePasseMedecin.Text + "' , '" + DateTime.Now.ToString("yyyy'-'dd'-'MM HH:mm:ss") + "' , '" + nudNumGradeMedecin.Value + "' , '"+ nudRegionCreation.Text + "' , '" + txtNomDirecteurRegional.Text+"' , '" + txtSecteur.Text + "')";
                
                MySqlCommand cmd = new MySqlCommand(insertQuery, connexion);
                



                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Les données ont était sauvegarder dans la base de donnée !");
                        txtNomMedecin.Text = "";
                        txtPrenomMedecin.Text = "";
                        txtMailMedecin.Text = "";
                        dtpDateNaissanceMedecin.Value = DateTime.Now;
                        dtpDateNaissanceMedecin.Format = DateTimePickerFormat.Custom;
                        dtpDateNaissanceMedecin.CustomFormat = "yyyy";
                        dtpDateNaissanceMedecin.ShowUpDown = true;
                        txtPremierMotDePasseMedecin.Text = "";
                        txtConfirmationMotDePasseMedecin.Text = "";
                        nudNumGradeMedecin.Value = 1;
                        nudRegionCreation.Text = "";
                        txtNomDirecteurRegional.Text = "";
                        txtSecteur.Text = "";
                        gpbCreationMedecin.Visible = false;
                        
                    }
                    else
                    {
                        MessageBox.Show("Les données n'ont pas était sauvegarder dans la base de donnée !");
                    }
                }
                catch (MySqlException excepton)
                {
                    MessageBox.Show(excepton.ToString());
                }
                connexion.Close();
            }
        }

        public bool testUtilisateur()
        {
            bool ok = false;

            try
            {
                connexion.Open();
                var sql = "SELECT * FROM medecin";
                var cmd = new MySqlCommand(sql, connexion);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read() && ok != true)
                {
                    if ($"{rdr.GetString(1),-4}" == txtConnexionNomUtilisateur.Text && $"{rdr.GetString(5),-4}" == txtConnexionMotDePasse.Text)
                    {
                        ok = true;
                        if (int.Parse($"{rdr.GetInt32(11),1}") == 1)
                        {
                            lblModeConnexionUtilisateur.Text = "Connecté en mode : Admistrateur";
                            btnCreationMedecin.Visible = true;
                            rdr.Close();
                            connexion.Close();
                            lblVoirDirecteurRegional.Visible = false;
                            lblSecteurVisiteur.Visible = false;
                            AfficheNomDirecteurEnCharge(txtConnexionNomUtilisateur.Text, txtConnexionMotDePasse.Text);
                            AfficheNomSecteurVisiteur(txtConnexionNomUtilisateur.Text, txtConnexionMotDePasse.Text);
                            break;
                        }
                        else
                        {
                            if (int.Parse($"{rdr.GetString(11),1}") == 2)
                            {
                                lblModeConnexionUtilisateur.Text = "Connecté en mode : Responsable";
                                btnCreationMedecin.Visible = false;
                                rdr.Close();
                                connexion.Close();
                                lblVoirDirecteurRegional.Visible = false;
                                lblSecteurVisiteur.Visible = false;
                                AfficheNomDirecteurEnCharge(txtConnexionNomUtilisateur.Text, txtConnexionMotDePasse.Text);
                                AfficheNomSecteurVisiteur(txtConnexionNomUtilisateur.Text, txtConnexionMotDePasse.Text);
                                break;
                            }
                            else
                            {
                                lblModeConnexionUtilisateur.Text = "Connecté en mode : Visiteur";
                                btnCreationMedecin.Visible = false;
                                lblVoirDirecteurRegional.Visible = true;
                                lblSecteurVisiteur.Visible = true;
                                rdr.Close();
                                connexion.Close();
                                AfficheNomDirecteurEnCharge(txtConnexionNomUtilisateur.Text, txtConnexionMotDePasse.Text);
                                AfficheNomSecteurVisiteur(txtConnexionNomUtilisateur.Text, txtConnexionMotDePasse.Text);
                                break;
                            }
                        }
                    }
                }
            }
            catch (MySqlException connexionEchouee)
            {
                MessageBox.Show(connexionEchouee.ToString());
                MessageBox.Show("Connexion échouée !");
            }
            return ok;
        }
       
        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            gpbConnexionUtilisateur.Visible = true;
            btnDeconnexion.Visible = false;
            lblModeConnexionUtilisateur.Text = "";
            txtConnexionNomUtilisateur.Text = "";
            txtConnexionMotDePasse.Text = "";
            btnCreationMedecin.Visible = false;
            lblVoirDirecteurRegional.Visible = false;
            lblSecteurVisiteur.Visible = false;
            connexion.Close();
        }

        private void btnCreationMedecin_Click(object sender, EventArgs e)
        {
            gpbCreationMedecin.Visible = true;
        }
        

        private void ckbVisiteur_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbVisiteur.Checked == true)
            {
                grbVisiteurCreation.Visible = true;
            }
            else
            {
                grbVisiteurCreation.Visible = false;
            }
        }

        
        public void AfficheNomDirecteurEnCharge(string nomUtilisateur, string mdpUtilisateur)
        {
            bool ok = false;
            connexion.Open();
            MySqlCommand Sql = new MySqlCommand("SELECT * FROM medecin WHERE nom = '" + nomUtilisateur + "' AND motDePasse = '" + mdpUtilisateur + "' ", connexion);
            MySqlDataReader dr;
            dr = Sql.ExecuteReader();
            while (dr.Read() && ok == false)
            {
                ok = true;
                lblVoirDirecteurRegional.Text = "Directeur général à charge : " + $"{dr.GetString(13),-4}" + "";
            }
            connexion.Close();
            dr.Close();
        }
        public void AfficheNomSecteurVisiteur(string nomUtilisateur, string mdpUtilisateur)
        {
            bool ok = false;
            connexion.Open();
            MySqlCommand Sql = new MySqlCommand("SELECT * FROM medecin WHERE nom = '" + nomUtilisateur + "' AND motDePasse = '" + mdpUtilisateur + "' ", connexion);
            MySqlDataReader dr;
            dr = Sql.ExecuteReader();
            while (dr.Read() && ok == false)
            {
                ok = true;
                lblSecteurVisiteur.Text = "Votre Secteur : " + $"{dr.GetString(14),-4}" + "";
            }
            connexion.Close();
            dr.Close();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }
    }
}
