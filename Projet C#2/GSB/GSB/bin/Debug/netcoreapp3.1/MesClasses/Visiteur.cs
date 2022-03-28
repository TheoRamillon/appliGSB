using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MesClasses;
namespace MesClasses
{
    class Visiteur :ForceDeVente
    {
        private DirecteurRegional UnDirecteur;
        private Secteur unSecteur;
        //Evaluation 

        public Visiteur(DirecteurRegional UnDirecteur,Secteur unSecteur, DateTime dateEmbauche, DateTime dateNaissance, string laSituationFamiliale, int nbEnfantsAcharge, string nom, int numero):base(dateEmbauche, dateNaissance, laSituationFamiliale, nbEnfantsAcharge, nom, numero)
        {
            this.UnDirecteur = UnDirecteur;
            this.unSecteur = unSecteur;

        }
        //Construceur sans le directeur/secteur
        public Visiteur(DateTime dateEmbauche, DateTime dateNaissance, string laSituationFamiliale, int nbEnfantsAcharge, string nom, int numero) : base(dateEmbauche, dateNaissance, laSituationFamiliale, nbEnfantsAcharge, nom, numero)
        {

        }
        public string GetInfoSecteurDirecteurRegional()
        {
            return this.UnDirecteur.getNom();
        }
        public string GetInfoMonSecteur()
        {
            return this.unSecteur.DonneInfoSecteur();
        }
       public override string toString()
       {
            string CA = base.toString() + "Nom Du Directeur Regionale : " + this.UnDirecteur.getNom();
            CA = CA + "Nom du Secteur : " + this.unSecteur.getnomSecteur();
            return CA;
       }

        
    }
}
