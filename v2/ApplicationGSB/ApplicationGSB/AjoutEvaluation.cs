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
        private string mesEvaluations;
        private Dictionary<int, string> evaluations = new Dictionary<int, string>();
        private List<Visiteur> lesVisiteurs = new List<Visiteur>();
        //MySqlConnection connexion;
        //MySqlCommand cmd;
        //MySqlDataAdapter dap;
        //DataSet ds;



        public frmAjoutEvaluation()
        {
            InitializeComponent();
        }

        private void AjoutEvaluation_Load(object sender, EventArgs e)
        {
            /*connexion = new MySqlConnection("database=gsbextranetappc; server=localhost; user id=root; pwd=");
            connexion.Open();

             cmd = new MySqlCommand("SELECT nom FROM medecin WHERE numGrade = 3;", connexion);
            dap = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "medecin");

            foreach(DataRow x in ds.Tables[0].Rows)
            {
                cbbNomVisiteur.Items.Add(x[0].ToString());
            }*/
            BindingSource bdsVisiteur = new BindingSource();
            bdsVisiteur.DataSource = Passerelle.getListVisiteur();
            cbbNomVisiteur.DataSource = bdsVisiteur;
            cbbNomVisiteur.DisplayMember = "nom";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlistedico_Click(object sender, EventArgs e)
        {
            
            Visiteur unVisiteur = new Visiteur(cbbNomVisiteur.Text, evaluations);
            annee = int.Parse(txtAnnee.Text);
            valeur = txtEvaluation.Text;
            Evaluation uneEvaluation = new Evaluation(annee, valeur);
            //Ajout au dictionnaire
            MessageBox.Show(uneEvaluation.toString());
            evaluations = unVisiteur.AddEvaluationDictionary(annee, valeur);

            mesEvaluations = unVisiteur.VoirMesEvaluations();

            MessageBox.Show(unVisiteur.VoirMesEvaluations());
            //ajout liste box
            lstbMesEvaluations.Items.Add(unVisiteur.VoirMesEvaluations());

            //

        }
        private void MajLstDico()
        {
            

        }
        private void lstbMesEvaluations_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void cbbNomVisiteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            Visiteur leV = (Visiteur)cbbNomVisiteur.SelectedItem;
            // MessageBox.Show(leV.getNom());
            mesEvaluations = leV.VoirMesEvaluations();

            lstbMesEvaluations.Items.Clear();
            lstbMesEvaluations.Items.Add(mesEvaluations);
            

        }
    }
}
