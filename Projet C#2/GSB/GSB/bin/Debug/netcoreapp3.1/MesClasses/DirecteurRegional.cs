using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses
{
    class DirecteurRegional :ForceDeVente
    {
        private Visiteur visiteur;
        private Region region;

        //CONSTRUCTEURS
        public DirecteurRegional(Visiteur visiteur, Region region, DateTime dateEmbauche, DateTime dateNaissance, string laSituationFamiliale, int nbEnfantsAcharge, string nom, int numero) :base(dateEmbauche, dateNaissance, laSituationFamiliale, nbEnfantsAcharge, nom, numero)
        {
            this.visiteur = visiteur;
            this.region = region;
            
        }
        //Sans le visiteur et la région
        public DirecteurRegional(DateTime dateEmbauche, DateTime dateNaissance, string laSituationFamiliale, int nbEnfantsAcharge, string nom, int numero) : base(dateEmbauche, dateNaissance, laSituationFamiliale, nbEnfantsAcharge, nom, numero)
        {

        }

        //Methodes
        public string getDirecteurRegionalNomRegion()
        {
            return this.region.getNomRegion();
        }
        public string getDirecteurRegionalNomVisiteur()
        {
            return this.visiteur.getNom();
        }
        public override string toString()
        {
            string CA = base.toString() + "Nom de la region :  " + this.region.getNomRegion();
            CA = CA + "Nom du visiteur en charge : " + this.visiteur.getNom();
            return CA;
        }

    }
}
