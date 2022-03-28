using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses
{
    class Evaluation
    {
        private Dictionary<DateTime, string> Evaluations = new Dictionary<DateTime, string>();
        private string valeur;
        private DateTime year;
        
        //Constructeur
        public Evaluation(string valeur, DateTime year)
        {
            this.valeur = valeur;
            this.year = year;

        }
        //Methodes
        public string getValeur()
        {
            return this.valeur;
        }
        public void setValeur(string valeur)
        {
            this.valeur = valeur;
        }
        public void AddEvaluationDictionary()
        {
            this.Evaluations.Add(this.year, this.valeur);
        }
       
        public string toString()
        {
            string contenuDesAttribut = "l'année : " + this.year + " " + "\n";
            contenuDesAttribut = contenuDesAttribut + "valeur : " + this.valeur + " " + "\n";
            
            return contenuDesAttribut;
        }
    }
}
