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
    public partial class frmCdrh : Form
    {

        public frmCdrh()
        {
            InitializeComponent();
        }

        private void btnAjouterMedecin_Click(object sender, EventArgs e)
        {

        }

        private void frmCResponsable_Load(object sender, EventArgs e)
        {
            //createDirecteurRH(txtNomMedecin.Text, nudEnfantsCharge.Value, situtationFamilliale.Text, dtpDateNaissanceMedecin.Value, dtpDateEmbaucheMedecin.Value);
        }
    }
}
