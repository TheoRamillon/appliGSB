using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses
{
    class Region
    {
        private string nomRegion;
        private int numRegion;
        private List<Secteur> lesSecteurs = new List<Secteur>();
        private DirecteurRegional leDirecteurDeRegion;

        //Constructeur

        public Region(string nomRegion, int numRegion, DirecteurRegional leDirecteurDeRegion)
        {
            this.nomRegion = nomRegion;
            this.numRegion = numRegion;
            this.leDirecteurDeRegion = leDirecteurDeRegion;

        }
        //Methodes

        public string getNomRegion()
        {
            return this.nomRegion;

        }
        public int getNumRegion()
        {
            return this.numRegion;
        }
        public string getInfoRegionNomDirecteur()
        {
            return this.leDirecteurDeRegion.getNom();
        }
        public void setNomRegion(string nomRegion)
        {
            this.nomRegion = nomRegion;
        }
        public void setNumRegion(int numRegion)
        {
            this.numRegion = numRegion;
        }

        public string DonneInfoRegion()
        {
            string contenuDesAttribut = "Nom de la Region : " + this.nomRegion + " " + "\n" + "\n";
            contenuDesAttribut = contenuDesAttribut + "Numero de la Region : " + this.numRegion + " " + "\n";
            contenuDesAttribut = contenuDesAttribut + "Numéro Du Directeur De Region : " + this.leDirecteurDeRegion.getNom() + " " + "\n";
            return contenuDesAttribut;
        }
    }
}
