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
    public partial class TirageLive : Form
    {

        // On recupere les variables du form précédent

        string currentUser = Start.currentUser;

        int[] nombreUtilisateur = new int[6];

        int[] nombreTirage = new int[6];

        int nombreGagnant = 0;

        int nombreParieur = Live.nombreParieur;

        int jourTirage = Live.jourTirage;

        decimal miseTotal;

        decimal gainJoueur;

        // Création de variable pour y stocker le nombre de gagnant au fur et à mesure

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


        public TirageLive()
        {
            InitializeComponent();
            LoadData();
            afficherNombreUser();
            CalculMiseTotal();
            buttonRejouer.Hide();
            labelGain.Hide();
        }





        private void LoadData()
        {
            for (int i = 0; i < 6; i++)
            {
                nombreUtilisateur[i] = Live.nombreCocheUser[i];
                nombreTirage[i] = Live.resultatTirage[i];
            }
            labelNombreJoueur.Text = "Nombre de joueur : " + nombreParieur.ToString();
        }





        private void afficherNombreUser()
        {
            labelUserNombre1.Text = nombreUtilisateur[0].ToString();
            labelUserNombre2.Text = nombreUtilisateur[1].ToString();
            labelUserNombre3.Text = nombreUtilisateur[2].ToString();
            labelUserNombre4.Text = nombreUtilisateur[3].ToString();
            labelUserNombre5.Text = nombreUtilisateur[4].ToString();
            labelUserNombre6.Text = nombreUtilisateur[5].ToString();
        }



        // Affiche les nombres un par un avec un timer entre chaque
        private void afficherNombreTirage()
        {
            labelResultatNombre1.Text = nombreTirage[0].ToString();
            wait(1500);

            labelResultatNombre2.Text = nombreTirage[1].ToString();
            wait(1500);

            labelResultatNombre3.Text = nombreTirage[2].ToString();
            wait(1500);

            labelResultatNombre4.Text = nombreTirage[3].ToString();
            wait(1500);

            labelResultatNombre5.Text = nombreTirage[4].ToString();
            wait(1500);

            labelResultatNombre6.Text = nombreTirage[5].ToString();
        }









        //************** METHODE POUR L'USER ***************************************



        // Verifier si un nombre est gagnant

        private int verifyNumber(int number)
        {
            int tmpNombreGagnant = 0;

            for (int i = 0; i < 6; i++)
            {
                if (nombreUtilisateur[i] == number)
                {
                    tmpNombreGagnant++;
                }
            }
            return tmpNombreGagnant;
        }




        // Calcul du nombre de nombre gagnant de l'user

        private void CalculNombreGagnant()
        {
            for (int i = 0; i < 6; i++)
            {
                nombreGagnant += verifyNumber(nombreTirage[i]);
            }



            if (nombreGagnant == 6)
            {
                gagnantSix++;
            }
            else if (nombreGagnant == 5)
            {
                gagnantCinq++;
            }
            else if (nombreGagnant == 4)
            {
                gagnantQuatre++;
            }
            else if (nombreGagnant == 3)
            {
                gagnantTrois++;
            }
            else if (nombreGagnant == 2)
            {
                gagnantDeux++;
            }
        }




        int[] tableauGrilleParieur = new int[6];


        private void generateGrilleParieur()
        {
            List<int> tmpListeGrille = new List<int>();

            Random rnd = new Random();

            for (int i = 0; i < 6; i++)
            {
                int tmpRandomNombre = rnd.Next(1, 30);
                tmpListeGrille.Add(tmpRandomNombre);                // Ajout du nombre dans la liste
            }

            tableauGrilleParieur = tmpListeGrille.ToArray();      // Conversion de la liste en array
        }


        private int verifyNumberParieur(int number)
        {
            int tmpNombreGagnant = 0;

            for (int i = 0; i < 6; i++)
            {
                if (tableauGrilleParieur[i] == number)
                {
                    tmpNombreGagnant++;
                }
            }
            return tmpNombreGagnant;
        }


        private void CalculNombreGagnantParieur()
        {
            for (int p = 0; p < nombreParieur; p++)        // Boucle avec le nombre de parieur
            {
                generateGrilleParieur();

                int tmpNombreGagnant = 0;

                for (int i = 0; i < 6; i++)
                {
                    tmpNombreGagnant += verifyNumberParieur(nombreTirage[i]);
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
            }

        }







        //*************** CALCUL DES GAINS 



        // Calcul de la mise total de ce tirage en fonction du nombre de parieur et du jour de tirage

        private void CalculMiseTotal()
        {
            int tmpMiseTotal = nombreParieur * jourTirage;      // Multiplication du nombre de parieur par le prix du tirage en fonction du jour
            tmpMiseTotal += jourTirage;                         // Ajout de notre mise personnelle
            miseTotal = tmpMiseTotal;

            labelMiseTotal.Text = "Mise Total : " + miseTotal;
        }




        private void CalculGainTotal()
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

            gainRangUn = (miseTotal * 50) / 100;


            if (gagnantSix != 0)
            {
                rangUnParJoueur = gainRangUn / gagnantSix;
                six = true;
            }


            // Rang 2

            gainRangDeux = (miseTotal * 25) / 100;


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

            gainRangTrois = (miseTotal * 15) / 100;


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

            gainRangQuatre = (miseTotal * 5) / 100;


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

            gainRangCinq = (miseTotal * 5) / 100;


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




            // Affichage a l'user de son gain 

            if (nombreGagnant == 6)
            {
                gainJoueur = decimal.Round(rangUnParJoueur, 2);
                labelGain.Text = "Vous avez gagné " + gainJoueur + " €";
            }
            if (nombreGagnant == 5)
            {
                gainJoueur = decimal.Round(rangDeuxParJoueur, 2);
                labelGain.Text = "Vous avez gagné " + gainJoueur + " €";
            }
            if (nombreGagnant == 4)
            {
                gainJoueur = decimal.Round(rangTroisParJoueur, 2);
                labelGain.Text = "Vous avez gagné " + gainJoueur + " €";
            }
            if (nombreGagnant == 3)
            {
                gainJoueur = decimal.Round(rangQuatreParJoueur, 2);
                labelGain.Text = "Vous avez gagné " + gainJoueur + " €";
            }
            if (nombreGagnant == 2)
            {
                gainJoueur = decimal.Round(rangCinqParJoueur, 2);
                labelGain.Text = "Vous avez gagné " + gainJoueur + " €";
            }
            if (nombreGagnant == 1 || nombreGagnant == 0)
            {
                labelGain.Text = "Vous avez perdu ! ";
            }


            labelGain.Show();


            // test gagnant par rang
            /*
            labelGagnant6.Text = "nombre 6 : " + gagnantSix;
            labelGagnant5.Text = "nombre 5 : " + gagnantCinq;
            labelGagnant4.Text = "nombre 4 : " + gagnantQuatre;
            labelGagnant3.Text = "nombre 3 : " + gagnantTrois;
            labelGagnant2.Text = "nombre 2 : " + gagnantDeux;
            */

        }








        // Ajoute dans une table special les infos du tirage actuel (je n'ai pas le temps de raccorder le systeme live au reste donc j'ai creer une table regroupant toute les infos)

        private void InsertDataUser()
        {
            string connStr = "server=localhost;user=root;database=gigaloto;port=3306;password=mysql";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "INSERT INTO tirageuser (`userName`, `nombreParticipant`, `miseTotal`, `jourTirage`, `numeroGagnantUser`, `gainJoueur`, `gagnantSix`, `gagnantCinq`, `gagnantQuatre`, `gagnantTrois`, `gagnantDeux`, `numeroUn`, `numeroDeux`, `numeroTrois`, `numeroQuatre`, `numeroCinq`, `numeroSix`, `numJoueurUn`, `numJoueurDeux`, `numJoueurTrois`, `numJoueurQuatre`, `numJoueurCinq`, `numJoueurSix`) VALUES ('" + currentUser + "', '" + nombreParieur + "' , '" + miseTotal + "' , '" + jourTirage + "' , '" + nombreGagnant + "' , '" + gainJoueur.ToString() + "', '" + gagnantSix + "' , '" + gagnantCinq + "' , '" + gagnantQuatre + "' , '" + gagnantTrois + "' , '" + gagnantDeux + "' , '" + nombreTirage[0] + "' , '" + nombreTirage[1] + "' , '" + nombreTirage[2] + "' , '" + nombreTirage[3] + "' , '" + nombreTirage[4] + "' , '" + nombreTirage[5] + "', '" + nombreUtilisateur[0] + "', '" + nombreUtilisateur[1] + "', '" + nombreUtilisateur[2] + "', '" + nombreUtilisateur[3] + "', '" + nombreUtilisateur[4] + "', '" + nombreUtilisateur[5] + "')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();

        }






        // Permet de mettre un timer entre les instructions
        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }







        // *******************Boutton 


        private void buttonLancerTirage_Click(object sender, EventArgs e)
        {
            buttonLancerTirage.Hide();
            afficherNombreTirage();
            CalculNombreGagnant();
            CalculNombreGagnantParieur();
            CalculGainTotal();
            InsertDataUser();
            buttonRejouer.Show();
        }

        private void buttonRejouer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
