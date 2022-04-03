using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace MesClasses
{
    public static class Passerelle2
    {

        private static MySqlConnection connexion = new MySqlConnection("database=gsbap2; server=localhost; user id=root; pwd=");
        //scrtoou
        private static List<Region> lesRegions = new List<Region>();
        private static List<Visiteur> lesVisiteurs = new List<Visiteur>();
        private static List<DirecteurRegional> lesDirecteurs = new List<DirecteurRegional>();
        private static List<Evaluation> lesEvaluations = new List<Evaluation>();
        private static List<Secteur> lesSecteurs = new List<Secteur>();
        private static int gradeUser, numeroUser;
        private static DirecteurRegional directeurCo;
        private static Visiteur visiteurCo;
        public static void initList()
        {

            //List Directeurs

            connexion.Open();

            var sql3 = "SELECT * FROM directeurregional INNER JOIN forcedevente ON numero=idForceDeVente;";
            MySqlDataReader rdr3 = new MySqlCommand(sql3, connexion).ExecuteReader();

            while (rdr3.Read())
            {
                lesDirecteurs.Add(new DirecteurRegional(rdr3["dateEmbauche"].ToString(), rdr3["dateNaissance"].ToString(),
                    rdr3["laSituationFamiliale"].ToString(), int.Parse(rdr3["nbEnfantsACharge"].ToString()), rdr3["nom"].ToString(), int.Parse(rdr3["numero"].ToString())));
            }

            connexion.Close();


            //List des regions

            connexion.Open();
            var sql = "SELECT idRegion,nomRegion, leDirecteurDeRegion FROM region;";
            
            MySqlDataReader rdr = new MySqlCommand(sql, connexion).ExecuteReader();
            List<Secteur> lesSecteursDeRegion = new List<Secteur>();

            while (rdr.Read())
            {
                string idDirecteur = rdr["leDirecteurDeRegion"].ToString();

                if (idDirecteur == "")
                {
                    idDirecteur = "null";
                    lesRegions.Add(new Region(rdr["nomRegion"].ToString(), int.Parse(rdr["idRegion"].ToString())));
                }
                else
                {
                    DirecteurRegional leDirecteurDeRegion = new DirecteurRegional();
                    foreach (DirecteurRegional leDirecteur in lesDirecteurs)
                    {
                        if (leDirecteur.getNumero().ToString() == idDirecteur)
                        {
                            leDirecteurDeRegion = leDirecteur;
                        }
                    }


                    lesRegions.Add(new Region(rdr["nomRegion"].ToString(), int.Parse(rdr["idRegion"].ToString()), leDirecteurDeRegion, lesSecteursDeRegion));
                }
            }
            connexion.Close();



            //List des Secteurs

            connexion.Open();
            var sqlSecteurs = "SELECT * FROM secteur;";

            MySqlDataReader rdrSecteurs = new MySqlCommand(sqlSecteurs, connexion).ExecuteReader();
            while (rdrSecteurs.Read())
            {
                string idRegion = rdrSecteurs["laRegion"].ToString();

                if (idRegion == "")
                {
                    idRegion = "null";
                    lesSecteurs.Add(new Secteur(rdrSecteurs["labelleSecteur"].ToString(), int.Parse(rdrSecteurs["idRegion"].ToString())));
                }
                else
                {
                    Region laRegionDuSecteur = new Region();
                    foreach (Region laRegion in lesRegions)
                    {
                        if(laRegion.getNumRegion().ToString() == idRegion)
                        {
                            laRegionDuSecteur = laRegion;
                        }
                    }

                    lesSecteurs.Add(new Secteur(int.Parse(rdrSecteurs["idSecteur"].ToString()), rdrSecteurs["labelleSecteur"].ToString(), laRegionDuSecteur));

                }
            }
            connexion.Close();

            //Insère les secteurs de la région

            
            foreach (Region laRegion in lesRegions)
            {
                List<Secteur> setLesSecteursDeRegion = new List<Secteur>();
                foreach (Secteur secteur in lesSecteurs)
                {      
                    if (laRegion.getNumRegion() == secteur.getNumRegion())
                    {

                        setLesSecteursDeRegion.Add(secteur);
                    }
                }

                laRegion.setSecteurs(setLesSecteursDeRegion);
                
            }

            //Insère les regions des directeurs
            foreach (Region laRegion in lesRegions)
            {
                foreach (DirecteurRegional d in lesDirecteurs)
                {
                    if (d.getNumDirecteur() == laRegion.getNumDirecteurRegion())
                        d.setRegion(laRegion);

                }
            }


            //List des visiteurs

            connexion.Open();

            var sql2 = "SELECT * FROM visiteur INNER JOIN forcedevente ON numero=idForceDeVente;";
            MySqlDataReader rdr2 = new MySqlCommand(sql2, connexion).ExecuteReader();
            Secteur unSTest = new Secteur();
            DirecteurRegional unDTest = new DirecteurRegional();

            while (rdr2.Read())
            {
                string idSecteur = rdr2["leSecteur"].ToString();
                string idDirecteur = rdr2["leDirecteurRegional"].ToString();

                DirecteurRegional leDirecteurRegional = new DirecteurRegional();
                foreach (DirecteurRegional leDirecteur in lesDirecteurs)
                {
                    if (leDirecteur.getNumero().ToString() == idDirecteur)
                    {
                        leDirecteurRegional = leDirecteur;
                    }
                }

                if (idSecteur == "")
                {
                    idSecteur = "null";
                    lesVisiteurs.Add(new Visiteur(leDirecteurRegional, rdr2["dateEmbauche"].ToString(), rdr2["dateNaissance"].ToString(),
                    rdr2["laSituationFamiliale"].ToString(), int.Parse(rdr2["nbEnfantsACharge"].ToString()), rdr2["nom"].ToString(), int.Parse(rdr2["numero"].ToString())));
                }
                else
                {
                    

                    Secteur secteurVisiteur = new Secteur();
                    foreach (Secteur leS in lesSecteurs)
                    {
                        if (leS.getnumSecteur().ToString() == idSecteur)
                        {
                            secteurVisiteur = leS;
                        }
                    }


                    lesVisiteurs.Add(new Visiteur(leDirecteurRegional, secteurVisiteur, rdr2["dateEmbauche"].ToString(), rdr2["dateNaissance"].ToString(),
                    rdr2["laSituationFamiliale"].ToString(), int.Parse(rdr2["nbEnfantsACharge"].ToString()), rdr2["nom"].ToString(), int.Parse(rdr2["numero"].ToString())));
                }
            }

            connexion.Close();

            //List évaluations

            connexion.Open();

            var sql6 = "SELECT * FROM evaluation;";
            MySqlDataReader rdr6 = new MySqlCommand(sql6, connexion).ExecuteReader();

            while (rdr6.Read())
            {
                lesEvaluations.Add(new Evaluation(int.Parse(rdr6["idEval"].ToString()), int.Parse(rdr6["idForceDeVente"].ToString()),
                    rdr6["valeur"].ToString(), int.Parse(rdr6["Annee"].ToString())));
            }

            connexion.Close();



        }

        public static void reloadList()
        {
            lesDirecteurs.Clear();
            lesRegions.Clear();
            lesSecteurs.Clear();
            lesVisiteurs.Clear();
            lesEvaluations.Clear();

            initList();
        }

        /////////////////////////////////////       Récupéré les Listes

        //Récupère la liste des regions
        public static List<Region> getListRegion()
        {
            return lesRegions;
        }

        //Récupère la liste des Secteurs
        public static List<Secteur> getListSecteur()
        {
            return lesSecteurs;
        }


        //Récupère la liste des visiteurs
        public static List<Visiteur> getListVisiteur()
        {
            return lesVisiteurs;
        }

        public static List<Evaluation> getListEval()
        {
            return lesEvaluations;
        }

        //Récupère la liste des directeurs
        public static List<DirecteurRegional> getListDirecteur()
        {
            return lesDirecteurs;
        }


        /////////////////////////////////////       LES CRÉATIONS
        //Création d'un directeur
        public static void createDirecteur(DirecteurRegional unD)
        {
            connexion.Open();
            try
            {
                Region regionTest = unD.getRegion();
               var sql = "INSERT INTO forcedevente VALUES (null,'" + unD.getNom() + "'," + unD.getnNEnfantsAcharge() + ", '" + unD.getLaSituationFamiliale() + "', '" +
                unD.getDateNaissance().ToString() + "', '" + unD.getDateEmbauche().ToString() + "', 2); INSERT INTO directeurregional VALUES((SELECT MAX(numero) FROM forceDeVente)); " +
                "UPDATE region SET leDirecteurDeRegion = (SELECT MAX(numero) FROM forceDeVente) WHERE idRegion = " + unD.getRegion().getNumRegion() + " ;";
                MySqlDataReader rdr = new MySqlCommand(sql, connexion).ExecuteReader();
                connexion.Close();
            }
            catch
            {
                var sql = "INSERT INTO forcedevente VALUES (null,'" + unD.getNom() + "'," + unD.getnNEnfantsAcharge() + ", '" + unD.getLaSituationFamiliale() + "', '" +
                unD.getDateNaissance().ToString() + "', '" + unD.getDateEmbauche().ToString() + "', 2); INSERT INTO directeurregional VALUES((SELECT MAX(numero) FROM forceDeVente)); ";
                MySqlDataReader rdr = new MySqlCommand(sql, connexion).ExecuteReader();
                connexion.Close();
            }
            
        }

        //Création d'un visiteur
        public static void createVisiteur(Visiteur unV)
        {
            connexion.Open();
            var sql = "INSERT INTO forcedevente VALUES (null,'" + unV.getNom() + "'," + unV.getnNEnfantsAcharge() + ", '" + unV.getLaSituationFamiliale() + "', '" +
                unV.getDateNaissance().ToString() + "', '" + unV.getDateEmbauche().ToString() + "', 3); INSERT INTO visiteur VALUES((SELECT MAX(numero) FROM forceDeVente)," +
                " null , " + unV.getNumDirecteur().ToString() + ");";
            MySqlDataReader rdr = new MySqlCommand(sql, connexion).ExecuteReader();
            connexion.Close();
        }

        //Création d'une region
        public static void createRegion(Region uneR)
        {
            connexion.Open();
            var sql = "INSERT INTO region VALUES(null, '" + uneR.getNomRegion() + "', " + uneR.getNumDirecteurRegion().ToString() + ");";
            MySqlDataReader rdr = new MySqlCommand(sql, connexion).ExecuteReader();
            connexion.Close();
        }

        //Création d'un secteur
        public static void createSecteur(Secteur unS)
        {
            connexion.Open();
            var sql = "INSERT INTO secteur VALUES(null, '" + unS.getnomSecteur() + "', " + unS.getNumRegion() + ");";
            MySqlDataReader rdr = new MySqlCommand(sql, connexion).ExecuteReader();
            connexion.Close();
        }
        public static void createEval(Evaluation uneE)
        {
            connexion.Open();
            var sql = "INSERT INTO evaluation VALUES(null, " + uneE.getIdFDV() + ", '" + uneE.getValeur() + "', '" + uneE.getYear() + "');";
            MySqlDataReader rdr = new MySqlCommand(sql, connexion).ExecuteReader();
            connexion.Close();
        }


        //Création d'une évaluation


        /////////////////////////////////////       LES UPDATES
        ///
        //Update d'un directeur
        public static void updateDirecteur(DirecteurRegional unD)
        {
            connexion.Open();
            var sql = "UPDATE forcedevente SET nom ='" + unD.getNom() + "', nbEnfantsACharge =" + unD.getnNEnfantsAcharge() + ", laSituationFamiliale ='" + unD.getLaSituationFamiliale() +
                "',dateNaissance = '" + unD.getDateNaissance().ToString() + "', dateEmbauche = '" + unD.getDateEmbauche().ToString() + "' WHERE numero = " + unD.getNumero() +";"; 
             MySqlDataReader rdr = new MySqlCommand(sql, connexion).ExecuteReader();
            connexion.Close();
        }

        //Update d'un directeur
        public static void updateVisiteur(Visiteur unV)
        {
            connexion.Open();
            var sql = "UPDATE forcedevente SET nom ='" + unV.getNom() + "', nbEnfantsACharge =" + unV.getnNEnfantsAcharge() + ", laSituationFamiliale ='" + unV.getLaSituationFamiliale() +
                "',dateNaissance = '" + unV.getDateNaissance().ToString() + "', dateEmbauche = '" + unV.getDateEmbauche().ToString() + "' WHERE numero = " + unV.getNumero() + ";";
            MySqlDataReader rdr = new MySqlCommand(sql, connexion).ExecuteReader();
            connexion.Close();
        }

        //Update secteur d'un visiteur
        public static void updateSecteurDuVisiteur(Secteur unS, Visiteur unV)
        {
            connexion.Open();
            var sql = "UPDATE visiteur SET leSecteur = " + unS.getnumSecteur() + " WHERE idForceDeVente = " + unV.getNumero() + ";";
            MySqlDataReader rdr = new MySqlCommand(sql, connexion).ExecuteReader();
            connexion.Close();
        }

        /////////////////////////////////////       LES DELETE

        public static void deleteVisiteur(Visiteur unV)
        {
            connexion.Open();
            var sql = " DELETE FROM forcedevente WHERE forcedevente.numero = " + unV.getNumero() + ";";
            MySqlDataReader rdr = new MySqlCommand(sql, connexion).ExecuteReader();
            connexion.Close();
        }

        public static void deleteDirecteur(DirecteurRegional unD)
        {
            connexion.Open();
            var sql = " DELETE FROM forcedevente WHERE forcedevente.numero = " + unD.getNumero() + ";";
            MySqlDataReader rdr = new MySqlCommand(sql, connexion).ExecuteReader();
            connexion.Close();
        }


        /////////////////////////////////////       AUTRES FONCTIONS

        //Vérifie log connexion
        public static bool checkLog(string nomDeCompte, string motDePasse)
        {
            connexion.Open();
            bool ok = false;
            var sql = "SELECT * FROM forcedevente";
            var cmd = new MySqlCommand(sql, connexion);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read() && ok != true)
            {
                if (rdr["login"].ToString() == nomDeCompte && rdr["pwd"].ToString() == motDePasse)
                {
                    ok = true;
                }
            }
            connexion.Close();
            return ok;

        }


        // set user connecté

        public static void setUserCo(string nomDeCompte, string motDePasse)
        {
            connexion.Open();
            var sql = "SELECT numero, idGrade FROM forcedevente WHERE login = '" + nomDeCompte + "' AND pwd = '" + motDePasse + "';";
            MySqlDataReader rdr = new MySqlCommand(sql, connexion).ExecuteReader();
            rdr.Read();
            gradeUser = int.Parse(rdr["idGrade"].ToString());
            numeroUser = int.Parse(rdr["numero"].ToString());
            connexion.Close();
        }

        //Get user userConnecté
        public static void setConnecter()
        {
            if(gradeUser == 2)
            {
                foreach(DirecteurRegional unD in lesDirecteurs)
                {
                    if(numeroUser == unD.getNumero())
                    {
                        directeurCo = unD;
                    }
                }
            }
            else
            {
                if(gradeUser == 3)
                {
                    foreach(Visiteur unV in lesVisiteurs)
                    {
                        if(numeroUser == unV.getNumero())
                        {
                            visiteurCo = unV;
                        }
                    }
                }
            }
        }
        //récup l'user

        public static DirecteurRegional getDirecteurCo()
        {
            return directeurCo;
        }
        public static Visiteur getVisiteurCo()
        {
            return visiteurCo;
        }

        //get du grade
        public static int getGrade()
        {
            return gradeUser;
        }
        public static void setGrade(int grade)
        {
            gradeUser = grade;
        }

        //fermeture connexion erreur
        public static void closeConnexion()
        {
            connexion.Close();
        }









    }
}
