using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MesClasses;
namespace MesClasses
{
    public class Visiteur :ForceDeVente
    {
        private DirecteurRegional UnDirecteur;
        private Secteur unSecteur;
        //Evaluation 

        public Visiteur()
        {

        }
        public Visiteur(string nom, int numero):base(nom, numero)
        {

        }
        public Visiteur(string nom, Dictionary<int, string> Evaluations):base(nom, Evaluations)
        {

        }
        public Visiteur(DirecteurRegional UnDirecteur,Secteur unSecteur, string dateEmbauche, string dateNaissance, string laSituationFamiliale, int nbEnfantsAcharge, string nom, int numero):base(dateEmbauche, dateNaissance, laSituationFamiliale, nbEnfantsAcharge, nom, numero)
        {
            this.UnDirecteur = UnDirecteur;
            this.unSecteur = unSecteur;

        }
        //sans le secteur
        public Visiteur(DirecteurRegional UnDirecteur, string dateEmbauche, string dateNaissance, string laSituationFamiliale, int nbEnfantsAcharge, string nom, int numero) : base(dateEmbauche, dateNaissance, laSituationFamiliale, nbEnfantsAcharge, nom, numero)
        {
            this.UnDirecteur = UnDirecteur;
            

        }
        //Construceur sans le directeur/secteur
        public Visiteur(string dateEmbauche, string dateNaissance, string laSituationFamiliale, int nbEnfantsAcharge, string nom, int numero) : base(dateEmbauche, dateNaissance, laSituationFamiliale, nbEnfantsAcharge, nom, numero)
        {

        }
        public string getInfoMonDirecteurRegional()
        {
            return this.UnDirecteur.getNom();
        }

        public int getNumDirecteur()
        {
            return this.UnDirecteur.getNumDirecteur();
        }

        public DirecteurRegional getDirecteurRegional()
        {
            return this.UnDirecteur;
        }
        public string getNomMonSecteur()
        {
            return this.unSecteur.getnomSecteur();
        }
        
        public Secteur getSecteur()
        {
            return this.unSecteur;
        }

        public int getNumSecteur()
        {
            try {
                return this.unSecteur.getnumSecteur(); 
            }
            catch
            {
                return 0;
            }            
        }

        public void setSecteur(Secteur unS)
        {
            this.unSecteur = unS;
        }

        public void setDirecteur(DirecteurRegional unD)
        {
            this.UnDirecteur = unD;
        }

       public override string toString()
       {
            string CA = base.toString() + "Nom Du Directeur Regionale : " + this.UnDirecteur.getNom();
            CA = CA + "Nom du Secteur : " + this.unSecteur.getnomSecteur();
            return CA;
       }

        
    }
}
