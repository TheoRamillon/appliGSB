using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MesClasses;
using System.Collections.Generic;

namespace TestUnitaireGSB
{
    [TestClass]
    public class TestUnitaireGSB
    {
        [TestMethod]
        public void VisiteurConsulteDirecteur()
        {
           
            DirecteurRegional unDirecteur = new DirecteurRegional(new DateTime(2007, 04, 13), new DateTime(2001, 05, 13), "En Couple", 2, "ChewD", 1);
            Visiteur unVisiteur = new Visiteur(unDirecteur, new DateTime(2009, 06, 13), new DateTime(2002, 05, 13), "Celibataire", 0, "Chow", 0);
            string RA = "ChewD";
            string RO = unVisiteur.GetInfoMonDirecteurRegional();
            Assert.AreEqual(RA, RO);
        }
        [TestMethod]
        public void VisiteurConsulteSecteur()
        {
            DirecteurRegional unDirecteur = new DirecteurRegional(new DateTime(2007, 04, 13), new DateTime(2001, 05, 13), "En Couple", 2, "ChewD", 1);
            Secteur unSecteur = new Secteur("Medecine", 0);
            Visiteur unVisiteur = new Visiteur(unDirecteur,unSecteur, new DateTime(2009, 06, 13), new DateTime(2002, 05, 13), "Celibataire", 0, "Chow", 0);
            string RA = "Medecine";
            string RO = unVisiteur.GetInfoMonSecteur();
            Assert.AreEqual(RA, RO);
        }
        [TestMethod]
        public void AjoutEvaluationDictionnaire()
        {
            DirecteurRegional unDirecteur = new DirecteurRegional(new DateTime(2007, 04, 13), new DateTime(2001, 05, 13), "En Couple", 2, "ChewD", 1);
            Secteur unSecteur = new Secteur("Medecine", 0);
            Visiteur unVisiteur = new Visiteur(unDirecteur, unSecteur, new DateTime(2009, 06, 13), new DateTime(2002, 05, 13), "Celibataire", 0, "Chow", 0);
            Evaluation uneEvaluation = new Evaluation(2007, "Bonne");
            
            Dictionary<int, string> evaluations = new Dictionary<int, string>();
           evaluations = unVisiteur.AddEvaluationDictionary(uneEvaluation.getYear(), uneEvaluation.getValeur());
            
            
            string RA = uneEvaluation.getYear() +" - " +uneEvaluation.getValeur();
            string RO = "";
            foreach (var KeyValuePair in evaluations)
            {
                RO = KeyValuePair.Key +" - " +KeyValuePair.Value;
            }
            Assert.AreEqual(RA, RO);
        }
        [TestMethod]
        public void VisiteurConsulteEvaluation()
        {
            DirecteurRegional unDirecteur = new DirecteurRegional(new DateTime(2007, 04, 13), new DateTime(2001, 05, 13), "En Couple", 2, "ChewD", 1);
            Secteur unSecteur = new Secteur("Medecine", 0);
            Visiteur unVisiteur = new Visiteur(unDirecteur, unSecteur, new DateTime(2009, 06, 13), new DateTime(2002, 05, 13), "Celibataire", 0, "Chow", 0);
            Evaluation uneEvaluation = new Evaluation(2007, "Bonne");

            Dictionary<int, string> evaluations = new Dictionary<int, string>();
            evaluations.Add(2010, "mauvaise");
            evaluations.Add(2011, "bonne");
            evaluations.Add(2012, "Assez bonne");
            string RO = unVisiteur.VoirMesEvaluations(evaluations);
            string RA = "2010" + " - " + "mauvaise" + "2011" + " - " + "bonne" + "2012" + " - " + "Assez bonne" ;
            
            Assert.AreEqual(RA, RO);

        }
    }
}
