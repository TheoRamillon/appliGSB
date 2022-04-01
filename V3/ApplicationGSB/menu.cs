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
    public partial class frmMenu : Form
    {
        private MySqlConnection connexion = new MySqlConnection("database=gsbextranetappc; server=localhost; user id=root; pwd=");

        public frmMenu()
        {
            InitializeComponent();
            //nudNumGradeMedecin.Value = 1;
            //gpbCreationMedecin.Visible = false;
            txtConnexionMotDePasse.PasswordChar = '\u25CF';
            //btnDeconnexion.Visible = false;
            gpbConnexionUtilisateur.Visible = true;
            //btnCreationMedecin.Visible = false;
            //lblDateDuJour.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //dtpDateNaissanceMedecin.Format = DateTimePickerFormat.Custom;
            //dtpDateNaissanceMedecin.CustomFormat = "yyyy";
            //dtpDateNaissanceMedecin.ShowUpDown = true;
            //grbVisiteurCreation.Visible = false;
            //lblVoirDirecteurRegional.Visible = false;
            //lblSecteurVisiteur.Visible = false;
        }

        private void menu_Load(object sender, EventArgs e)
        {
            mspMenu.Visible = false;
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
                //MessageBox.Show("Connexion réussis !");
                gpbConnexionUtilisateur.Visible = false;
                

            }
        }

        public bool testUtilisateur()
        {
            bool ok = true;
           /*
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
                            lblSecteurVisiteur.Text = "Secteur : " + $"{rdr.GetString(14),1}";
                            rdr.Close();
                            connexion.Close();
                            mspMenu.Visible = true;
                            drhToolStripMenuItem.Visible = false;
                            directeurToolStripMenuItem.Visible = false;

                            this.WindowState = FormWindowState.Maximized;
                            break;
                        }
                        else
                        {
                            if (int.Parse($"{rdr.GetString(11),1}") == 2)
                            {
                                lblSecteurVisiteur.Text = "Secteur : " + $"{rdr.GetString(14),1}";
                                lblDirecteurVisiteur.Visible = false;
                                rdr.Close();
                                connexion.Close();
                                mspMenu.Visible = true;
                                directeurToolStripMenuItem.Visible = true;
                                drhToolStripMenuItem.Visible = true;

                                this.WindowState = FormWindowState.Maximized;
                                break;
                            }
                            else
                            {
                                lblSecteurVisiteur.Text = "Secteur : " + $"{rdr.GetString(14),1}";
                                lblDirecteurVisiteur.Text = "Supérieur attitré : " + $"{rdr.GetString(13),1}";
                                rdr.Close();
                                connexion.Close();*/
                                mspMenu.Visible = true;
                                créationToolStripMenuItem.Visible = true;
                             
                                this.WindowState = FormWindowState.Maximized;
                                /*break;
                            }
                        }
                    }
                }
            }
            catch (MySqlException connexionEchouee)
            {
                MessageBox.Show(connexionEchouee.ToString());
                MessageBox.Show("Connexion échouée !");
            }*/
            return ok;
        }

        private void directeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCdirecteur uneF = new frmCdirecteur();
            uneF.MdiParent = this;
            uneF.WindowState = FormWindowState.Maximized;
            uneF.Show();
        }

        private void visiteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCVisiteur uneF = new frmCVisiteur();
            uneF.MdiParent = this;
            uneF.WindowState = FormWindowState.Maximized;
            uneF.Show();
        }

        private void créationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mspMenu.Visible = false;
            gpbConnexionUtilisateur.Visible = true;
            txtConnexionNomUtilisateur.Text = "";
            txtConnexionMotDePasse.Text = "";
            lblSecteurVisiteur.Text = "";
            lblDirecteurVisiteur.Text = "";
            this.WindowState = FormWindowState.Normal;
            connexion.Close();
        }
        private void AjoutEvaluationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjoutEvaluation uneF = new frmAjoutEvaluation();
            uneF.MdiParent = this;
            uneF.WindowState = FormWindowState.Maximized;
            uneF.Show();
        }

        private void deconnexionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            mspMenu.Visible = false;
            gpbConnexionUtilisateur.Visible = true;
            txtConnexionNomUtilisateur.Text = "";
            txtConnexionMotDePasse.Text = "";
            lblSecteurVisiteur.Text = "";
            lblDirecteurVisiteur.Text = "";
            this.WindowState = FormWindowState.Normal;
            connexion.Close();
            this.Close();
        }

        private void llbSansConnexion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
                //MessageBox.Show("Connexion réussis !");
                gpbConnexionUtilisateur.Visible = false;
                créationToolStripMenuItem.Visible = true;
            }
        }

        private void informationsVisiteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInformationsVisiteurs uneF = new frmInformationsVisiteurs();
            uneF.MdiParent = this;
            uneF.WindowState = FormWindowState.Maximized;
            uneF.Show();
        }

        private void informationsSecteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInformationsSecteurs uneF = new frmInformationsSecteurs();
            uneF.MdiParent = this;
            uneF.WindowState = FormWindowState.Maximized;
            uneF.Show();
        }

        private void informationsRegionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInfoRegion uneF = new frmInfoRegion();
            uneF.MdiParent = this;
            uneF.WindowState = FormWindowState.Maximized;
            uneF.Show();
        }

        private void informationsDirecteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInformationsDirecteurs uneF = new frmInformationsDirecteurs();
            uneF.MdiParent = this;
            uneF.WindowState = FormWindowState.Maximized;
            uneF.Show();
        }

        private void régionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRegion uneF = new frmCRegion();
            uneF.MdiParent = this;
            uneF.WindowState = FormWindowState.Maximized;
            uneF.Show();
        }

        private void secteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCSecteur uneF = new frmCSecteur();
            uneF.MdiParent = this;
            uneF.WindowState = FormWindowState.Maximized;
            uneF.Show();
        }
    }
}
