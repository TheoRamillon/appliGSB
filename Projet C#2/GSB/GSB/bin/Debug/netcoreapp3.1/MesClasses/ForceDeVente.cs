using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses
{
    class ForceDeVente
    {
           protected DateTime dateEmbauche;
            protected DateTime dateNaissance;
            protected string laSituationFamiliale;
            protected int nbEnfantsAcharge;
            protected string nom;
            protected int numero;

             public ForceDeVente()
             {

             }
            public ForceDeVente(DateTime dateEmbauche, DateTime dateNaissance, string laSituationFamiliale, int nbEnfantsAcharge, string nom, int numero)
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
            public DateTime getDateEmbauche()
            {
                return this.dateEmbauche;
            }
            public DateTime getDateNaissance()
            {
                return this.dateEmbauche;
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

            public void setDateEmbauche(DateTime dateEmbauche)
            {
                this.dateEmbauche = dateEmbauche;
            }
            public void setDateNaissance(DateTime dateNaissance)
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
