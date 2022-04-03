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

        public frmMenu()
        {
            InitializeComponent();
            txtConnexionMotDePasse.PasswordChar = '\u25CF';
            gpbConnexionUtilisateur.Visible = true;
        }

        private void menu_Load(object sender, EventArgs e)
        {
            mspMenu.Visible = false;
        }

        private void btnConnexionUtilisateur_Click(object sender, EventArgs e)
        {
            if (Passerelle2.checkLog(txtConnexionNomUtilisateur.Text, txtConnexionMotDePasse.Text) == false)
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect !");
                txtConnexionMotDePasse.Clear();
                txtConnexionNomUtilisateur.Clear();

            }
            else
            {
                Passerelle2.setUserCo(txtConnexionNomUtilisateur.Text, txtConnexionMotDePasse.Text);
                MessageBox.Show("Connexion réussis !");

                //Gestion des vues
                gpbConnexionUtilisateur.Visible = false;
                mspMenu.Visible = true;

                //Grade 0 => user
                if(Passerelle2.getGrade() == 0)
                {
                    smiCreation.Visible = false;
                    smiMesVisiteurs.Visible = false;
                    smiEmploye.Visible = false;
                }
                else
                {
                    //Grade 3 => Visiteur
                    if(Passerelle2.getGrade() == 3)
                    {
                        Passerelle2.setConnecter();
                        smiCreation.Visible = false;
                        smiMesVisiteurs.Visible = false;
                        smiEmploye.Visible = false;
                    }
                    else
                    {
                        //Grade 2 => Directeur
                        if (Passerelle2.getGrade() == 2)
                        {
                            Passerelle2.setConnecter();
                            smiCreation.Visible = false;
                            smiEmploye.Visible = false;
                        }
                        else
                        {
                            //Grade 1 => RH
                            if (Passerelle2.getGrade() == 1)
                            {
                                smiMesVisiteurs.Visible = false;
                            }
                            else
                                mspMenu.Visible = false;
                        }
                    }
                }


                this.WindowState = FormWindowState.Maximized;


            }
        }

        private void llbSansConnexion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gpbConnexionUtilisateur.Visible = false;
            mspMenu.Visible = true;
            Passerelle2.setGrade(0);
            smiCreation.Visible = false;
            smiMesVisiteurs.Visible = false;
            smiEmploye.Visible = false;
            this.WindowState = FormWindowState.Maximized;

        }


        private void directeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmCdirecteur uneF = new frmCdirecteur();
            uneF.MdiParent = this;
            uneF.WindowState = FormWindowState.Maximized;
            uneF.Show();
        }

        private void visiteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmCVisiteur uneF = new frmCVisiteur();
            uneF.MdiParent = this;
            uneF.WindowState = FormWindowState.Maximized;
            uneF.Show();
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
            this.Close();
        }

        private void informationsVisiteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmInformationsVisiteurs uneF = new frmInformationsVisiteurs();
            uneF.MdiParent = this;
            uneF.WindowState = FormWindowState.Maximized;
            uneF.Show();
        }

        private void informationsSecteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmInformationsSecteurs uneF = new frmInformationsSecteurs();
            uneF.MdiParent = this;
            uneF.WindowState = FormWindowState.Maximized;
            uneF.Show();
        }

        private void informationsRegionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmInfoRegion uneF = new frmInfoRegion();
            uneF.MdiParent = this;
            uneF.WindowState = FormWindowState.Maximized;
            uneF.Show();
        }

        private void informationsDirecteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmInformationsDirecteurs uneF = new frmInformationsDirecteurs();
            uneF.MdiParent = this;
            uneF.WindowState = FormWindowState.Maximized;
            uneF.Show();
        }

        private void régionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
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

        private void directeurToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmMDirecteur uneF = new frmMDirecteur();
            uneF.MdiParent = this;
            uneF.WindowState = FormWindowState.Maximized;
            uneF.Show();
        }

        private void visiteurToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmMVisiteur uneF = new frmMVisiteur();
            uneF.MdiParent = this;
            uneF.WindowState = FormWindowState.Maximized;
            uneF.Show();
        }

        private void mspMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void évaluationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmAjoutEvaluation uneF = new frmAjoutEvaluation();
            uneF.MdiParent = this;
            uneF.WindowState = FormWindowState.Maximized;
            uneF.Show();
        }

        private void secteurToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmGestionVisiteurs uneF = new frmGestionVisiteurs();
            uneF.MdiParent = this;
            uneF.WindowState = FormWindowState.Maximized;
            uneF.Show();
        }
    }
}
