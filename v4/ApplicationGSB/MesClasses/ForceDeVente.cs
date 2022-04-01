using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses
{
    public class ForceDeVente
    {
            
           
            protected string dateEmbauche;
            protected string dateNaissance;
            protected string laSituationFamiliale;
            protected int nbEnfantsAcharge;
            private string nom;
            protected int numero;
            protected Dictionary<int, string> Evaluations = new Dictionary<int, string>();

        public string Nom { get => nom; set => nom = value; }

        public ForceDeVente()
             {

             }
             public ForceDeVente(string nom, Dictionary<int, string> Evaluations)
             {
              this.nom = nom;
              this.Evaluations = Evaluations;
             }
            public ForceDeVente(string nom, int numero)
            {
              this.nom = nom;
              this.numero = numero;
            }
            public ForceDeVente(string dateEmbauche, string dateNaissance, string laSituationFamiliale, int nbEnfantsAcharge, string nom, int numero)
            {
                this.dateEmbauche = dateEmbauche;
                this.dateNaissance = dateNaissance;
                this.laSituationFamiliale = laSituationFamiliale;
                this.nbEnfantsAcharge = nbEnfantsAcharge;
                this.nom = nom;
                this.numero = numero;


            }
          
        
        public string getNom()
            {
                return this.nom;
            }
            public string getDateEmbauche()
            {
                return this.dateEmbauche;
            }
            public string getDateNaissance()
            {
                return this.dateNaissance;
            }
            public string getLaSituationFamiliale()
            {
                return this.laSituationFamiliale;
            }
            public int getnNEnfantsAcharge()
            {
                return this.nbEnfantsAcharge;
            }
            public int getNumero()
            {
                return this.numero;
            }
           public Dictionary<int, string> AddEvaluationDictionary(int year, string valeur)
           {
            
            this.Evaluations.Add(year, valeur);
            return Evaluations;

           }
           public  string VoirMesEvaluations()
           {
            string mesEvaluations = "";
            
             foreach (var KeyValuePair in Evaluations)
             {
                mesEvaluations = mesEvaluations + KeyValuePair.Key + " - " + KeyValuePair.Value;
                
             }
            return mesEvaluations;
           }
            public void setDateEmbauche(string dateEmbauche)
            {
                this.dateEmbauche = dateEmbauche;
            }
            public void setDateNaissance(string dateNaissance)
            {
                this.dateNaissance = dateNaissance;
            }
            public void setLaSituationFamiliale(string laSituationFamiliale)
            {
                this.laSituationFamiliale = laSituationFamiliale;
            }
            public void setnbEnfantACharge(int nbEnfantACharge)
            {
                this.nbEnfantsAcharge = nbEnfantACharge;
            }

            public void setNom(string nom)
            {
                this.nom = nom;
            }

            public void setNumero(int numero)
            {
                this.numero = numero;
            }

            public virtual string toString()
            {
                string contenuDesAttribut = "Date d'embauche : " + this.dateEmbauche + " " + "\n" + "\n";
                contenuDesAttribut = contenuDesAttribut + "Date de Naissance : " + this.dateNaissance + " " + "\n";
                contenuDesAttribut = contenuDesAttribut + "La situation Familiale : " + this.laSituationFamiliale + " " + "\n";
                contenuDesAttribut = contenuDesAttribut + "Nombre d'enfants à charge : " + this.nbEnfantsAcharge + " " + "\n";
                contenuDesAttribut = contenuDesAttribut + "Nom : " + this.nom + " " + "\n";
                contenuDesAttribut = contenuDesAttribut + "Numero : " + this.numero + " " + "\n";
                return contenuDesAttribut;
            }
    }
}
