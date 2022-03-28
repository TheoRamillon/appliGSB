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
    public partial class frmMesInformations : Form
    {
        private MySqlConnection connexion = new MySqlConnection("database=gsbextranetappc; server=localhost; user id=root; pwd=");
        public frmMesInformations()
        {
            InitializeComponent();
        }


    }
}
