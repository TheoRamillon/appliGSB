using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses
{
    public class Secteur
    {
        private string nomSecteur;
        private int numSecteur;
        private Region  RegionDuSecteur;

        public string NomSecteur { get => nomSecteur; set => nomSecteur = value; }
        public int NumSecteur { get => numSecteur; set => numSecteur = value; }
        public Region RegionDuSecteur1 { get => RegionDuSecteur; set => RegionDuSecteur = value; }

        public Secteur()
        {

        }

        public Secteur(string nomSecteur, Region uneR)
        {
            this.nomSecteur = nomSecteur;
            this.RegionDuSecteur = uneR;
        }

        public Secteur(string nomSecteur, int numSecteur)
        {
            
            this.nomSecteur = nomSecteur;
            this.numSecteur = numSecteur;
        }
            

        public Secteur(int numSecteur, string nomSecteur, Region uneR)
        {

            this.nomSecteur = nomSecteur;
            this.numSecteur = numSecteur;
            this.RegionDuSecteur = uneR;
        }

        public int getnumSecteur()
        {
            return this.numSecteur;
        }
        public string getnomSecteur()
        {
            return this.nomSecteur;
        }

        public Region getRegion()
        {
            return this.RegionDuSecteur;
        }

        public DirecteurRegional getDirecteurSecteur()
        {
            return this.RegionDuSecteur.GetDirecteur();
        }

        public int getNumRegion()
        {
            return this.RegionDuSecteur.getNumRegion();
        }

        public void setnumSecteur(int numSecteur)
        {
            this.numSecteur = numSecteur;
        }
        public void setnomSecteur(string nomSecteur)
        {
            this.nomSecteur = nomSecteur;
        }

        public void setRegionSecteur(Region uneRegion)
        {
            this.RegionDuSecteur = uneRegion;
        }

        public string DonneInfoSecteur()
        {
            
           String contenuDesAttribut ="Nom Du Secteur : " + this.nomSecteur+ " " + "\n";
            contenuDesAttribut = contenuDesAttribut + "Numéro Du Secteur : " + this.numSecteur + " " + "\n";
            
            return contenuDesAttribut;
        }

    }
}
