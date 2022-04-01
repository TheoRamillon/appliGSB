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
        private static List<Secteur> lesSecteurs = new List<Secteur>();

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

            

        }

        public static void reloadList()
        {
            lesDirecteurs.Clear();
            lesRegions.Clear();
            lesSecteurs.Clear();
            lesVisiteurs.Clear();

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
            var sql = "INSERT INTO forcedevente VALUES (null,'" + unD.getNom() + "'," + unD.getnNEnfantsAcharge() + ", '" + unD.getLaSituationFamiliale() + "', '" +
                unD.getDateNaissance().ToString() + "', '" + unD.getDateEmbauche().ToString() + "', 2); INSERT INTO directeurregional VALUES((SELECT MAX(numero) FROM forceDeVente)); " +
                "UPDATE region SET leDirecteurDeRegion = (SELECT MAX(numero) FROM forceDeVente) WHERE idRegion = " + unD.getRegion().getNumRegion() + " ;";
            MySqlDataReader rdr = new MySqlCommand(sql, connexion).ExecuteReader();
            connexion.Close();
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

        /////////////////////////////////////       LES UPDATES
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


        //Recupération de l'id de l'utilisateur

        public static int recupIdUser(string nomDeCompte, string motDePasse)
        {
            connexion.Open();
            var sql = "SELECT numero FROM forcedevente WHERE nomDeCompte = " + nomDeCompte + "AND motDePasse = " + motDePasse + ";";
            MySqlDataReader rdr = new MySqlCommand(sql, connexion).ExecuteReader();
            rdr.Read();
            int numero = int.Parse(rdr["numero"].ToString());
            connexion.Close();
            return numero;
        }










    }
}
