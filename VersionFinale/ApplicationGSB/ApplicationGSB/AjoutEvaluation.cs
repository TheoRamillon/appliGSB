using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MesClasses;

namespace GSB
{
    public partial class frmAjoutEvaluation : Form
    {
        private int annee;
        private string valeur;
        List<Visiteur> MesVisiteurs = new List<Visiteur>();
        DirecteurRegional directeurCo = Passerelle2.getDirecteurCo();

        BindingSource bdsVisiteur = new BindingSource();
        BindingSource bdsEvaluation = new BindingSource();




        public frmAjoutEvaluation()
        {
            InitializeComponent();
        }

        private void AjoutEvaluation_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> evaluations = new Dictionary<int, string>();
            //Gestion combo visiteurs

            foreach (Visiteur unV in Passerelle2.getListVisiteur())
            {
                if (unV.getNumDirecteur() == directeurCo.getNumero())
                {
                    MesVisiteurs.Add(unV);
                }
            }

            bdsVisiteur.DataSource = Passerelle2.getListVisiteur();
            cbbVisiteurs.DataSource = bdsVisiteur;
            cbbVisiteurs.DisplayMember = "nom";
            cbbVisiteurs.SelectedItem = (MesClasses.Visiteur)bdsVisiteur.Current;

            //Gestion dictionnaire
            evaluations.Clear();
            Visiteur leVisiteur = (MesClasses.Visiteur)bdsVisiteur[cbbVisiteurs.SelectedIndex];
            foreach (Evaluation uneE in Passerelle2.getListEval())
            {
                if(uneE.getIdFDV() == leVisiteur.getNumero())
                {
                    evaluations.Add(uneE.getYear(), uneE.getValeur());
                }
            }

            bdsEvaluation.DataSource = evaluations;
            lstbMesEvaluations.DataSource = bdsEvaluation;
            lstbMesEvaluations.DisplayMember = "valeur";

        }


        private void btnlistedico_Click(object sender, EventArgs e)
        {

            Visiteur unVisiteur = (MesClasses.Visiteur)bdsVisiteur[cbbVisiteurs.SelectedIndex];
            annee = int.Parse(DateTime.Now.ToString("yyyy"));
            valeur = txtEvaluation.Text;
            Evaluation uneEvaluation = new Evaluation(unVisiteur.getNumero(), valeur, annee);
            //Ajout au dictionnaire
            Passerelle2.createEval(uneEvaluation);
            Passerelle2.reloadList();
            this.Close();


        }

        private void cbbNomVisiteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<int, string> evaluations = new Dictionary<int, string>();
            bool evalExiste = false;
            //Gestion dictionnaire
            BindingSource bdsEvaluation = new BindingSource();
            evaluations.Clear();
            Visiteur leVisiteur = (MesClasses.Visiteur)bdsVisiteur[cbbVisiteurs.SelectedIndex];
            foreach (Evaluation uneE in Passerelle2.getListEval())
            {
                if (uneE.getIdFDV() == leVisiteur.getNumero())
                {
                    evaluations.Add(uneE.getYear(), uneE.getValeur());
                    if(uneE.getYear() == int.Parse(DateTime.Now.ToString("yyyy")))
                    {
                        evalExiste = true;
                    }
                }
            }
            if(evalExiste == true)
            {
                lblEvaluation.Visible = false;
                txtEvaluation.Visible = false;
                btnlistedico.Visible = false;
            }
            else
            {
                lblEvaluation.Visible = true;
                txtEvaluation.Visible = true;
                btnlistedico.Visible = true;
            }
            bdsEvaluation.DataSource = evaluations;
            lstbMesEvaluations.DataSource = bdsEvaluation;
            lstbMesEvaluations.DisplayMember = "valeur";


        }
    }
}
