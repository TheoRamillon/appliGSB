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
    public partial class menu : Form
    {
        private MySqlConnection connexion = new MySqlConnection("database=gsbextranetappc; server=localhost; user id=root; pwd=");

        public menu()
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

        private void responsableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCdrh uneF = new frmCdrh();
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

        private void mesInformationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMesInformations uneF = new frmMesInformations();
            uneF.MdiParent = this;
            uneF.WindowState = FormWindowState.Maximized;
            uneF.Show();
        }

        private void mspMenu_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void informationRégionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInfoRegion uneF = new frmInfoRegion();
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

        private void régionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegion uneRegion = new frmRegion();
            uneRegion.MdiParent = this;
            uneRegion.WindowState = FormWindowState.Maximized;
            uneRegion.Show();
        }

        private void secteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSecteur unSecteur = new frmSecteur();
            unSecteur.MdiParent = this;
            unSecteur.WindowState = FormWindowState.Maximized;
            unSecteur.Show();
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

        private void visiteurToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMvisiteur unVisiteurVue = new frmMvisiteur();
            unVisiteurVue.MdiParent = this;
            unVisiteurVue.WindowState = FormWindowState.Maximized;
            unVisiteurVue.Show();
        }
    }
}
