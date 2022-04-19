using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AppLoto
{
    public partial class resultatSimulateur : Form
    {

        // On recupère la liste des tirages
        static List<int> tirageList = Simulateur.tirageList;

        int idCurrentTirage; // Stock l'idOrdre du tirage de la table "dateTirages"

        int tmpTarifTirage;  // Stock le prix du tirage

        static int parieurNombre = Simulateur.nombreParieur;



        int[] testTableau2 = new int[6];

        // Pour y stock temporairement les resultats du tirage actuel pour les mettre en bdd
        List<int> tmpResultatTirage = new List<int>();

        // creation de tableau pour stocker les differentes grilles de parieur
        int[] GrilleParieur = new int[6];
        int[][] tableauGrilleParieur = new int[parieurNombre][];


        int gagnantSix = 0;
        int gagnantCinq = 0;
        int gagnantQuatre = 0;
        int gagnantTrois = 0;
        int gagnantDeux = 0;

        decimal gainRangUn;
        decimal gainRangDeux;
        decimal gainRangTrois;
        decimal gainRangQuatre;
        decimal gainRangCinq;

        decimal rangUnParJoueur;
        decimal rangDeuxParJoueur;
        decimal rangTroisParJoueur;
        decimal rangQuatreParJoueur;
        decimal rangCinqParJoueur;


        int miseTotalPari = 0;


        // Pour stocker l'id du tirage dans la base et l'inserer dans les autres tables
        long lastId;

        public resultatSimulateur()
        {
            InitializeComponent();
            CalculResultatInsertBdd();
        }



        // On lance le tirage de 6 nombres à mettre dans un tableau pour le resultat qui est bouclé sur le nombre de tirage necessaire en empechant les doublons
        private void lancementTirage()
        {
            List<int> tmpResultatList = new List<int>();

            for (int i = 0; i < 6; i++)
            {
                Random rnd = new Random();
                int tmpRandomNombre = rnd.Next(1, 30);

                if (tmpResultatList.Contains(tmpRandomNombre))            // Evite les doublons
                {
                    tmpRandomNombre = rnd.Next(1, 30);
                    tmpResultatList.Add(tmpRandomNombre);
                    //     testTableau[p,i] = tmpRandomNombre;
                    testTableau2[i] = tmpRandomNombre;
                }
                else
                {
                    tmpResultatList.Add(tmpRandomNombre);
                    //  MessageBox.Show(tmpRandomNombre.ToString() + tirageList.Count);
                    //   testTableau[p,i] = tmpRandomNombre;
                    testTableau2[i] = tmpRandomNombre;
                }
            }
        }



        // Genere une grille de 6 nombre pour un parieur en evitant les doublons
        private int[] generateGrilleParieur()
        {
            List<int> tmpListeGrille = new List<int>();

            Random rnd = new Random();

            for (int i = 0; i < 6; i++)
            {
                int tmpRandomNombre = rnd.Next(1, 30);

                if (tmpListeGrille.Contains(tmpRandomNombre))
                {
                    tmpRandomNombre = rnd.Next(1, 30);
                    tmpListeGrille.Add(tmpRandomNombre);
                }
                else
                {
                    tmpListeGrille.Add(tmpRandomNombre);
                }
            }

            return GrilleParieur = tmpListeGrille.ToArray();      // Conversion de la liste en array
        }


        private int verifyNumberParieur(int number)
        {
            int tmpNombreGagnant = 0;

            for (int i = 0; i < 6; i++)
            {
                if (GrilleParieur[i] == number)
                {
                    tmpNombreGagnant++;
                }
            }
            return tmpNombreGagnant;
        }



        private void CalculResultatInsertBdd()
        {

            //debut boucle tirage
            for (int o = 0; o < tirageList.Count; o++)        // Boucle pour réaliser la generation d'une grille parieur + verifier les resultats avec le tirage actuel +
                                                              // voir le nombre de gagnant par rang.
            {
                lancementTirage();

                // Reset des valeurs pour chaque nouveau tirage
                gagnantSix = 0;
                gagnantCinq = 0;
                gagnantQuatre = 0;
                gagnantTrois = 0;
                gagnantDeux = 0;

                tmpResultatTirage.Clear();


                idCurrentTirage = tirageList[o];  // Stock l'id du tirage

                // debut boucle parieur
                for (int p = 0; p < parieurNombre; p++)        // Boucle avec le nombre de parieur
                {
                    tableauGrilleParieur[p] = generateGrilleParieur();

                    int tmpNombreGagnant = 0;

                    for (int i = 0; i < 6; i++)             // Boucle pour verifier le nombre de nombre gagnant
                    {
                        tmpNombreGagnant += verifyNumberParieur(testTableau2[i]);

                        tmpResultatTirage.Add(testTableau2[i]);  // On stock les 6 
                    }

                    if (tmpNombreGagnant == 6)
                    {
                        gagnantSix++;
                    }
                    else if (tmpNombreGagnant == 5)
                    {
                        gagnantCinq++;
                    }
                    else if (tmpNombreGagnant == 4)
                    {
                        gagnantQuatre++;
                    }
                    else if (tmpNombreGagnant == 3)
                    {
                        gagnantTrois++;
                    }
                    else if (tmpNombreGagnant == 2)
                    {
                        gagnantDeux++;
                    }


                    // Calcul de la mise total de ce tirage  en recuperant le prix du tirage en bdd

                    string connStr = "server=localhost;user=root;database=gigaloto;port=3306;password=mysql";
                    MySqlConnection conn = new MySqlConnection(connStr);

                    try
                    {
                        conn.Open();

                        string sql = "SELECT * FROM datetirages WHERE idOrdre =" + tirageList[o];
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        MySqlDataReader rdr = cmd.ExecuteReader();

                        while (rdr.Read())
                        {

                            tmpTarifTirage = int.Parse(rdr.GetString(4));

                        }
                        rdr.Close();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    conn.Close();


                }   // Fin boucle parieur



                // ********* Calcul de la mise total

                int tmpMiseTotal = parieurNombre * tmpTarifTirage;      // Multiplication du nombre de parieur par le prix du tirage en fonction du jour

                miseTotalPari = tmpMiseTotal;


                // ********* Calcul des gains par rang

                // Calcul du gain de chaque rang
                CalculGainParRang();

                // Insertion des data de tirage en bdd
                InsertDataTirage(idCurrentTirage, miseTotalPari, parieurNombre);

                // Insertion des autres data dans les tables "resultatTirage" et "tirageStat"
                InsertDataInfo(gagnantSix, gagnantCinq, gagnantQuatre, gagnantTrois, gagnantDeux, tmpResultatTirage[0], tmpResultatTirage[1], tmpResultatTirage[2], tmpResultatTirage[3], tmpResultatTirage[4], tmpResultatTirage[5], rangUnParJoueur.ToString(), rangDeuxParJoueur.ToString(), rangTroisParJoueur.ToString(), rangQuatreParJoueur.ToString(), rangCinqParJoueur.ToString());

                // Remplir le data grid view avec les infos
                remplirDataGridView(tirageList[o], miseTotalPari, parieurNombre, testTableau2[0], testTableau2[1], testTableau2[2], testTableau2[3], testTableau2[4], testTableau2[5], gagnantSix, gagnantCinq, gagnantQuatre, gagnantTrois, gagnantDeux, rangUnParJoueur.ToString() + "€", rangDeuxParJoueur.ToString() + "€", rangTroisParJoueur.ToString() + "€", rangQuatreParJoueur.ToString() + "€", rangCinqParJoueur.ToString() + "€");


            }   // Fin boucle tirage
        }







        private void CalculGainParRang()
        {
            // Reset de chaque variable pour chaque nouveau tirage
            bool six = false;
            bool cinq = false;
            bool quatre = false;
            bool trois = false;

            rangUnParJoueur = 0;
            rangDeuxParJoueur = 0;
            rangTroisParJoueur = 0;
            rangQuatreParJoueur = 0;
            rangCinqParJoueur = 0;



            // Rang 1

            gainRangUn = (miseTotalPari * 50) / 100;


            if (gagnantSix != 0)
            {
                rangUnParJoueur = gainRangUn / gagnantSix;
                six = true;
            }


            // Rang 2

            gainRangDeux = (miseTotalPari * 25) / 100;


            if (gagnantCinq != 0 & six)
            {
                rangDeuxParJoueur = gainRangDeux / gagnantCinq;
                cinq = true;
            }
            else if (gagnantCinq != 0 & !six)
            {
                gainRangDeux += gainRangUn;
                rangDeuxParJoueur = gainRangDeux / gagnantCinq;
                cinq = true;
            }



            // Rang 3

            gainRangTrois = (miseTotalPari * 15) / 100;


            if (gagnantQuatre != 0 & cinq)
            {
                rangTroisParJoueur = gainRangTrois / gagnantQuatre;
                quatre = true;
            }
            else if (gagnantQuatre != 0 & !cinq & six)
            {
                gainRangTrois += gainRangDeux;
                rangTroisParJoueur = gainRangTrois / gagnantQuatre;
                quatre = true;
            }
            else if (gagnantQuatre != 0 & !cinq & !six)
            {
                gainRangTrois += gainRangUn + gainRangDeux;
                rangTroisParJoueur = gainRangTrois / gagnantQuatre;

                quatre = true;
            }



            // Rang 4

            gainRangQuatre = (miseTotalPari * 5) / 100;


            if (gagnantTrois != 0 & quatre)
            {

                rangQuatreParJoueur = gainRangQuatre / gagnantTrois;

                trois = true;
            }
            else if (gagnantTrois != 0 & !quatre & cinq & six)
            {
                gainRangQuatre += gainRangTrois;
                rangQuatreParJoueur = gainRangQuatre / gagnantTrois;
                trois = true;
            }
            else if (gagnantTrois != 0 & !quatre & !cinq & six)
            {
                gainRangQuatre += gainRangTrois + gainRangDeux;
                rangQuatreParJoueur = gainRangQuatre / gagnantTrois;
                trois = true;
            }
            else if (gagnantTrois != 0 & !quatre & !cinq & !six)
            {
                gainRangQuatre += gainRangTrois + gainRangDeux + gainRangUn;
                rangQuatreParJoueur = gainRangQuatre / gagnantTrois;
                trois = true;
            }


            // Rang 5

            gainRangCinq = (miseTotalPari * 5) / 100;


            if (gagnantDeux != 0 & trois)
            {
                rangCinqParJoueur = gainRangCinq / gagnantDeux;
            }
            else if (gagnantDeux != 0 & !trois & quatre & cinq & six)
            {
                gainRangCinq += gainRangQuatre;
                rangCinqParJoueur = gainRangCinq / gagnantDeux;
            }
            else if (gagnantDeux != 0 & !trois & !quatre & cinq & six)
            {
                gainRangCinq += gainRangQuatre + gainRangTrois;
                rangCinqParJoueur = gainRangCinq / gagnantDeux;
            }
            else if (gagnantDeux != 0 & !trois & !quatre & !cinq & six)
            {
                gainRangCinq += gainRangQuatre + gainRangTrois + gainRangDeux;
                rangCinqParJoueur = gainRangCinq / gagnantDeux;
            }
            else if (gagnantDeux != 0 & !trois & !quatre & !cinq & !six)
            {
                gainRangCinq += gainRangQuatre + gainRangTrois + gainRangDeux + gainRangUn;
                rangCinqParJoueur = gainRangCinq / gagnantDeux;
            }



            //On arrondie les resultats a deux chiffre apres la virgule

            rangUnParJoueur = decimal.Round(rangUnParJoueur, 2);
            rangDeuxParJoueur = decimal.Round(rangDeuxParJoueur, 2);
            rangTroisParJoueur = decimal.Round(rangTroisParJoueur, 2);
            rangQuatreParJoueur = decimal.Round(rangQuatreParJoueur, 2);
            rangCinqParJoueur = decimal.Round(rangCinqParJoueur, 2);

        }




        // Ajoute en table les info de base du tirage et stock l'id du tirage en variable
        private void InsertDataTirage(int idDateTirage, int prixMiseTotal, int nbParticipant)
        {
            string connStr = "server=localhost;user=root;database=gigaloto;port=3306;password=mysql";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {

                conn.Open();


                string sql = "INSERT INTO tirage (`id_dateTirage`, `miseTotal`, `nombreParticipant`) VALUES ('" + idDateTirage + "','" + prixMiseTotal + "', '" + nbParticipant + "')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                lastId = cmd.LastInsertedId;
                //   MessageBox.Show(lastId.ToString()); affiche l'id autoincrement de tirage pour l'ajouter dans les autres tables

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
        }

        // Ajoute en table les autres info du tirage en utilisant l'id du tirage en cours
        private void InsertDataInfo(int cmbGagnantSix, int cmbGagnantCinq, int cmbGagnantQuatre, int cmbGagnantTrois, int cmbGagnantDeux, int numUn, int numDeux, int numTrois, int numQuatre, int numCinq, int numSix, string gainSix, string gainCinq, string gainQuatre, string gainTrois, string gainDeux)
        {

            string connStr = "server=localhost;user=root;database=gigaloto;port=3306;password=mysql";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {

                conn.Open();

                string sql = "BEGIN; " +
                    "INSERT INTO tiragestat (`id_tirage`, `gagnantSix`, `gagnantCinq`, `gagnantQuatre`, `gagnantTrois`, `gagnantDeux`) VALUES ('" + lastId + "', '" + cmbGagnantSix + "', '" + cmbGagnantCinq + "','" + cmbGagnantQuatre + "', '" + cmbGagnantTrois + "', '" + cmbGagnantDeux + "');" +
                    "INSERT INTO resultattirage (`tirage_id`, `numUn`, `numDeux`, `numTrois`, `numQuatre`, `numCinq`, `numSix`) VALUES ('" + lastId + "','" + numUn + "', '" + numDeux + "', '" + numTrois + "', '" + numQuatre + "', '" + numCinq + "', '" + numSix + "');" +
                   "INSERT INTO gaintirage (`id_tirage`, `gainSix`, `gainCinq`, `gainQuatre`, `gainTrois`, `gainDeux`) VALUES ('" + lastId + "','" + gainSix + "', '" + gainCinq + "', '" + gainQuatre + "', '" + gainTrois + "', '" + gainDeux + "');" +
                    "COMMIT;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();




        }


        // Affiche dans le dataGridView les infos des tirages effectué 
        private void remplirDataGridView(int id_date, int miseTotal, int nombreParieur, int resultat1, int resultat2, int resultat3, int resultat4, int resultat5, int resultat6, int nbTrouve6, int nbTrouve5, int nbTrouve4, int nbTrouve3, int nbTrouve2, string rangUn, string rangDeux, string rangTrois, string rangQuatre, string rangCinq)
        {
            string tmpJour = "";
            string tmpJourNb = "";
            string tmpMois = "";


            string connStr = "server=localhost;user=root;database=gigaloto;port=3306;password=mysql";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                string sql = "SELECT * FROM datetirages WHERE idOrdre =" + id_date;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    tmpJour = rdr.GetString(2);
                    tmpJourNb = rdr.GetString(3);
                    tmpMois = rdr.GetString(1);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            string dateFormat = tmpJour + " " + tmpJourNb + " " + tmpMois + " 2022";
            conn.Close();

            dataGridViewResultat.Rows.Add(dateFormat, miseTotal + "€", nombreParieur, resultat1 + "," + resultat2 + "," + resultat3 + "," + resultat4 + "," + resultat5 + "," + resultat6, nbTrouve6, nbTrouve5, nbTrouve4, nbTrouve3, nbTrouve2, rangUn, rangDeux, rangTrois, rangQuatre, rangCinq);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }





}
