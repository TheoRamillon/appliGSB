using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses
{
    public class Evaluation
    {
        int idEval;
        int idForceDeVente;
        private string valeur;
        private int year;
        
        //Constructeur
       
        public Evaluation( int year, string valeur)
        {
            this.year = year;
            this.valeur = valeur;
            

        }

        public Evaluation(int idEval, int idForceDeVente, string valeur, int year)
        {
            this.idEval = idEval;
            this.idForceDeVente = idForceDeVente;
            this.year = year;
            this.valeur = valeur;
        }

        public Evaluation(int idForceDeVente, string valeur, int year)
        {
            this.idForceDeVente = idForceDeVente;
            this.year = year;
            this.valeur = valeur;
        }
        //Methodes
        public string getValeur()
        {
            return this.valeur;
        }
        public int getYear()
        {
            return this.year;
        }
        public int getIdEval()
        {
            return this.idEval;
        }
        public int getIdFDV()
        {
            return this.idForceDeVente;
        }
        public void setValeur(string valeur)
        {
            this.valeur = valeur;
        }
       public void setYear(int year)
       {
            this.year = year;
       }
       
        public string toString()
        {
            string contenuDesAttribut = "l'année : " + this.year + " " + "\n";
            contenuDesAttribut = contenuDesAttribut + "valeur : " + this.valeur + " " + "\n";
            
            return contenuDesAttribut;
        }
    }
}
