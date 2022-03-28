using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses
{
    class Secteur
    {
        private string nomSecteur;
        private int numSecteur;
        private Visiteur unVisiteur;

        public Secteur(Visiteur unVisiteur, string nomSecteur, int numSecteur)
        {
            this.unVisiteur = unVisiteur;
            this.nomSecteur = nomSecteur;
            this.numSecteur = numSecteur;
        }
        public int getnumSecteur()
        {
            return this.numSecteur;
        }
        public string getnomSecteur()
        {
            return this.nomSecteur;
        }
        public void setnumSecteur(int numSecteur)
        {
            this.numSecteur = numSecteur;
        }
        public void setnomSecteur(string nomSecteur)
        {
            this.nomSecteur = nomSecteur;
        }
        public string DonneInfoSecteur()
        {
            string contenuDesAttribut = "Nom Visiteur : " + this.unVisiteur.getNom() + " " + "\n" + "\n";
            contenuDesAttribut = contenuDesAttribut + "Nom Du Secteur : " + this.nomSecteur+ " " + "\n";
            contenuDesAttribut = contenuDesAttribut + "Numéro Du Secteur : " + this.numSecteur + " " + "\n";
            
            return contenuDesAttribut;
        }

    }
}
