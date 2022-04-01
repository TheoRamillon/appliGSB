using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses
{
    public  class DirecteurRegional :ForceDeVente
    {
        private Region region;
        

        //CONSTRUCTEURS
        public DirecteurRegional(Region region, string dateEmbauche, string dateNaissance, string laSituationFamiliale, int nbEnfantsAcharge, string nom, int numero) :base(dateEmbauche, dateNaissance, laSituationFamiliale, nbEnfantsAcharge, nom, numero)
        {
            this.region = region;
            
        }
        //Sans la région et son num
        public DirecteurRegional(string dateEmbauche, string dateNaissance, string laSituationFamiliale, int nbEnfantsAcharge, string nom, int numero) : base(dateEmbauche, dateNaissance, laSituationFamiliale, nbEnfantsAcharge, nom, numero)
        {

        }

        public DirecteurRegional()
        {

        }


        //Methodes
        public string getNomRegion()
        {
            return this.region.getNomRegion();
        }

        public Region getRegion()
        {
            return this.region;
        }
        

        public int getNumDirecteur()
        {
            return this.getNumero();
        }

        public void setRegion(Region uneR)
        {
            this.region = uneR;
        }



        public override string toString()
        {
            string CA = base.toString() + "Nom de la region :  " + this.region.getNomRegion();
            //CA = CA + "Nom du visiteur en charge : " + this.visiteur.getNom();
            return CA;
        }

    }
}
