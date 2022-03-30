using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MesClasses
{
    public static class Passerelle
    {
        private static List<Region> lesRegions = new List<Region>();
        private static DirecteurRegional unDirlo = new DirecteurRegional();
        private static List<Visiteur> lesVisiteur = new List<Visiteur>();
        


        public static List<Region> getListRegion()
        {
            return lesRegions;
        }

        public static List<Visiteur> getListVisiteur()
        {
            return lesVisiteur;
        }


        public static void initList()
        {
            //(Paris-Centre, Sud, Nord, Ouest, Est, DTOM Caraïbes-Amériques, DTOM Asie-Afrique
            lesRegions.Add(new Region("Paris-centre", 1, unDirlo));
            lesRegions.Add(new Region("Sud", 2, unDirlo));
            lesRegions.Add(new Region("Nord", 3, unDirlo));
            lesRegions.Add(new Region("Ouest", 4, unDirlo));
            lesRegions.Add(new Region("Est", 5, unDirlo));
            lesRegions.Add(new Region("DTOM Caraïbes-Amériques", 6, unDirlo));
            lesRegions.Add(new Region("DTOM Asie-Afrique", 7, unDirlo));
            //Création liste visiteur : 
           Dictionary<int, string> evaluation1 = new Dictionary<int, string>();
            Dictionary<int, string> evaluations = new Dictionary<int, string>();
            lesVisiteur.Add(new Visiteur("UnVisiteur", evaluations));
            evaluation1.Add(2002, "bonne");
            evaluation1.Add(2003, "mauvais");
            evaluation1.Add(2004, "bonne");
            lesVisiteur.Add(new Visiteur("DeVisiteur", evaluation1));
            Dictionary<int, string> evaluation2= new Dictionary<int, string>();
            evaluation2.Add(2021, " TR7S bonne");
            lesVisiteur.Add(new Visiteur("TrVisiteur", evaluation2));
           




        }



        




    }
}
