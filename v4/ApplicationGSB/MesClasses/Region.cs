using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses
{
    public class Region
    {
        private string nomRegion;
        private int numRegion;
        private List<Secteur> lesSecteurs = new List<Secteur>();
        private DirecteurRegional leDirecteurDeRegion;

        public string NomRegion { get => nomRegion; set => nomRegion = value; }

        //Constructeur
        public Region(string nomRegion, int numRegion)
        {
            this.nomRegion = nomRegion;
            this.numRegion = numRegion;

        }

        public Region(string nom, DirecteurRegional unDirecteur)
        {
            this.nomRegion = nom;
            this.leDirecteurDeRegion = unDirecteur;
        }

        public Region()
        {

        }
        public Region(string nomRegion, int numRegion, DirecteurRegional leDirecteurDeRegion)
        {
            this.nomRegion = nomRegion;
            this.numRegion = numRegion;
            this.leDirecteurDeRegion = leDirecteurDeRegion;

        }

        public Region(string nomRegion, int numRegion, DirecteurRegional leDirecteurDeRegion, List<Secteur> lesSecteursDeRegion)
        {
            this.nomRegion = nomRegion;
            this.numRegion = numRegion;
            this.leDirecteurDeRegion = leDirecteurDeRegion;
            this.lesSecteurs = lesSecteursDeRegion;

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

        public List<Secteur> getSecteurs()
        {
            return this.lesSecteurs;
        }

        public string getInfoRegionNomDirecteur()
        {
            return this.leDirecteurDeRegion.getNom();
        }

        public DirecteurRegional GetDirecteur()
        {
            return this.leDirecteurDeRegion;
        }
        public int getNumDirecteurRegion()
        {
            try
            { 
                return this.leDirecteurDeRegion.getNumDirecteur();
            }
            catch
            {
                return 0;
            }
            
        }
        public void setNomRegion(string nomRegion)
        {
            this.nomRegion = nomRegion;
        }
        public void setNumRegion(int numRegion)
        {
            this.numRegion = numRegion;
        }

        public void setSecteurs (List<Secteur> secteurs)
        {
            this.lesSecteurs = secteurs;
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
