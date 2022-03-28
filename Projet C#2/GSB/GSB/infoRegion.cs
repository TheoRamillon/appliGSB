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
    public partial class frmInfoRegion : Form
    {

        BindingSource bdsRegion = new BindingSource();
        BindingSource bdsSecteur = new BindingSource();

        public frmInfoRegion()
        {
            InitializeComponent();
        }

        

        private void frmInfoRegion_Load(object sender, EventArgs e)
        {
            
            bdsRegion.DataSource = Passerelle2.getListRegion();
            cbbRegion.DataSource = bdsRegion;
            cbbRegion.DisplayMember = "nomRegion";
            cbbRegion.SelectedItem = (MesClasses.Region)bdsRegion.Current;

            //Gestion label directeur
            DirecteurRegional directeurDeLaRegion = Passerelle2.getDirecteurDeLaRegion((MesClasses.Region)bdsRegion.Current) ;
            lblNomDirecteur.Text = directeurDeLaRegion.getNom();

            //Gestion cbb secteur
            bdsSecteur.DataSource = Passerelle2.getSecteursDeRegions((MesClasses.Region)bdsRegion.Current);
            cbbSecteur.DataSource = bdsSecteur;
            cbbSecteur.DisplayMember = "nomSecteur";
            cbbSecteur.SelectedItem = (MesClasses.Secteur)bdsSecteur.Current;



            //List<Secteur> lesSecteurs = new List<Secteur>(Passerelle2.getSecteursDeRegions((MesClasses.Region)bdsRegion.Current));
            //foreach(Secteur secteur in lesSecteurs)
            //{
            //    cbbSecteur.Items.Add(secteur);
            //    cbbRegion.DisplayMember = "nomRegion";
            //}

        }

        private void cbbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {

            DirecteurRegional directeurDeLaRegion = Passerelle2.getDirecteurDeLaRegion((MesClasses.Region)bdsRegion[cbbRegion.SelectedIndex]);
            lblNomDirecteur.Text = directeurDeLaRegion.getNom();

        }

    }
}
