using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;


namespace AppLoto
{
    public partial class Accueil : Form
    {


        public Accueil()
        {
            InitializeComponent();
            ShowMenu();
            createTirageUserTable();
            createTirageTable();
            createTableGainTable();
            createTableResultatTable();
            createTableStatTable();
        }


        string currentUser = Start.currentUser;

        private void ShowMenu()
        {
            labelCurrentUser.Text = currentUser;
        }





        // **************** Creation des tables du programme

        private void createTirageUserTable()
        {
            string connStr = "server=localhost;user=root;database=gigaloto;port=3306;password=mysql";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "create table if not exists tirageuser(" +
                "id_tirage       int primary key NOT NULL AUTO_INCREMENT," +
                "userName    varchar(25) NOT NULL," +
                "nombreParticipant  int NOT NULL," +
                "miseTotal     int NOT NULL," +
                "jourTirage     varchar(25) NOT NULL," +
               "numeroGagnantUser     int NOT NULL," +
               "gainJoueur     varchar(25) NOT NULL," +
               "gagnantSix     int NOT NULL," +
               "gagnantCinq     int NOT NULL," +
               "gagnantQuatre     int NOT NULL," +
               "gagnantTrois     int NOT NULL," +
               "gagnantDeux     int NOT NULL," +
               "numeroUn     int NOT NULL," +
               "numeroDeux     int NOT NULL," +
               "numeroTrois     int NOT NULL," +
               "numeroQuatre     int NOT NULL," +
               "numeroCinq     int NOT NULL," +
               "numeroSix     int NOT NULL," +
               "numJoueurUn     int NOT NULL," +
               "numJoueurDeux     int NOT NULL," +
               "numJoueurTrois     int NOT NULL," +
               "numJoueurQuatre     int NOT NULL," +
               "numJoueurCinq    int NOT NULL," +
                "numJoueurSix     int NOT NULL" +
                ")";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }


        private void createTirageTable()
        {
            string connStr = "server=localhost;user=root;database=gigaloto;port=3306;password=mysql";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "create table if not exists tirage(" +
                "id_tirage       int primary key NOT NULL AUTO_INCREMENT," +
                "id_dateTirage    int NOT NULL," +
                "miseTotal  int NOT NULL," +
                "nombreParticipant     int NOT NULL" +         
                ")";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }



        private void createTableGainTable()
        {
            string connStr = "server=localhost;user=root;database=gigaloto;port=3306;password=mysql";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "create table if not exists gaintirage(" +
                "id_gain       int primary key NOT NULL AUTO_INCREMENT," +
                "id_tirage    int NOT NULL," +
                "gainSix  varchar(25) NOT NULL," +
                "gainCinq  varchar(25) NOT NULL," +
                "gainQuatre  varchar(25) NOT NULL," +
                "gainTrois  varchar(25) NOT NULL," +
                "gainDeux  varchar(25) NOT NULL" +
                ")";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }



        private void createTableResultatTable()
        {
            string connStr = "server=localhost;user=root;database=gigaloto;port=3306;password=mysql";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "create table if not exists resultattirage(" +
                "id_resultat       int primary key NOT NULL AUTO_INCREMENT," +
                "tirage_id    int NOT NULL," +
               "numUn    int NOT NULL," +
               "numDeux    int NOT NULL," +
               "numTrois    int NOT NULL," +
               "numQuatre    int NOT NULL," +
               "numCinq    int NOT NULL," +
               "numSix    int NOT NULL" +
                ")";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }


        private void createTableStatTable()
        {
            string connStr = "server=localhost;user=root;database=gigaloto;port=3306;password=mysql";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "create table if not exists tiragestat(" +
                "id_tiragestat       int primary key NOT NULL AUTO_INCREMENT," +
                "id_tirage    int NOT NULL," +
               "gagnantSix    int NOT NULL," +
               "gagnantCinq    int NOT NULL," +
               "gagnantQuatre    int NOT NULL," +
               "gagnantTrois    int NOT NULL," +
               "gagnantDeux    int NOT NULL" +
                ")";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }





        // *************** Bouton

        private void liveButton_Click(object sender, EventArgs e)
        {
            Form live = new Live();
            live.ShowDialog();
        }

        private void buttonSimulateur_Click(object sender, EventArgs e)
        {
            Form simulateur = new Simulateur();
            simulateur.ShowDialog();
        }


        private void buttonHistorique_Click(object sender, EventArgs e)
        {
            Form resultat = new resultat();
            resultat.ShowDialog();
        }

        private void buttonCaché_Click(object sender, EventArgs e)
        {
            Form credits = new credits();
            credits.ShowDialog();
        }

        private void Accueil_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message =
          "Etes vous sur de vouloir quitter l'application ?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
