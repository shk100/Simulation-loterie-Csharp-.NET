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
    public partial class resultat : Form
    {


        public resultat()
        {
            InitializeComponent();
        }




        // Afficher les resultats du simulateur dans le dataGridView
        private void RemplirDataGridViewSimulateur()
        {
            dataGridViewResultat.Rows.Clear();  // On clean le data grid pour eviter les doublons en cliquant plusieurs fois

            string connStr = "server=localhost;user=root;database=gigaloto;port=3306;password=mysql";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                string sql = "SELECT tirage.id_tirage, miseTotal, nombreParticipant, mois, jour, jourNombre, tarif, numUn, numDeux,numTrois,numQuatre,numCinq,numSix, gagnantSix,gagnantCinq,gagnantQuatre," +
               "gagnantTrois, gagnantDeux,gainSix,gainCinq,gainQuatre,gainTrois ,gainDeux " +
               "FROM tirage " +
             "INNER JOIN datetirages ON datetirages.idOrdre = tirage.id_dateTirage " +
             "INNER JOIN resultattirage ON resultattirage.tirage_id = tirage.id_tirage " +
             "INNER JOIN tiragestat ON tiragestat.id_tirage = tirage.id_tirage " +
             "INNER JOIN gaintirage ON gaintirage.id_tirage = tirage.id_tirage;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                dataGridViewResultat.Rows.Add(rdr.GetString(0), rdr.GetString(4) + " " + rdr.GetString(5) + " " + rdr.GetString(3), rdr.GetString(6) + "€", rdr.GetString(1) + "€", rdr.GetString(2), rdr.GetString(7) + "." + rdr.GetString(8) + "." + rdr.GetString(9) + "." + rdr.GetString(10) + "." + rdr.GetString(11) + "." + rdr.GetString(12), rdr.GetString(13), rdr.GetString(14), rdr.GetString(15), rdr.GetString(16), rdr.GetString(17), rdr.GetString(18) + "€", rdr.GetString(19) + "€", rdr.GetString(20) + "€", rdr.GetString(21) + "€", rdr.GetString(22) + "€");
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();

        }



        // Afficher les resultats du tirage live dans le dataGridView
        private void RemplirDataGridViewLive()
        {

            dataGridViewLive.Rows.Clear();  // On clean le data grid pour eviter les doublons en cliquant plusieurs fois

            string tmpJourTirage;   // Pour donner un jour en fonction du prix du tirage


            string connStr = "server=localhost;user=root;database=gigaloto;port=3306;password=mysql";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                string sql = "SELECT id_tirage, userName, jourTirage, miseTotal, nombreParticipant, numeroUn, numeroDeux, numeroTrois, numeroQuatre, numeroCinq, numeroSix, numJoueurUn, numJoueurDeux, numJoueurTrois, numJoueurQuatre, numJoueurCinq, numJoueurSix, gainJoueur, gagnantSix, gagnantCinq, gagnantQuatre, gagnantTrois, gagnantDeux, numeroGagnantUser " +
                            "FROM tirageuser ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (rdr.GetString(2) == "2")         // Je verifie le prix du tirage pour savoir quel jour c'est
                    {
                        tmpJourTirage = "Lundi";
                    }
                    else
                    {
                        tmpJourTirage = "Jeudi";
                    }

                    dataGridViewLive.Rows.Add(rdr.GetString(0), rdr.GetString(1), tmpJourTirage, rdr.GetString(2) + "€", rdr.GetString(3) + "€", rdr.GetString(4), rdr.GetString(5) + "." + rdr.GetString(6) + "." + rdr.GetString(7) + "." + rdr.GetString(8) + "." + rdr.GetString(9) + "." + rdr.GetString(10), rdr.GetString(11) + "." + rdr.GetString(12) + "." + rdr.GetString(13) + "." + rdr.GetString(14) + "." + rdr.GetString(15) + "." + rdr.GetString(16), rdr.GetString(17) + "€", rdr.GetString(23), rdr.GetString(18), rdr.GetString(19), rdr.GetString(20), rdr.GetString(21), rdr.GetString(22));

                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();

        }




        private void deleteDataUser()
        {

            string connStr = "server=localhost;user=root;database=gigaloto;port=3306;password=mysql";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                string sql = "TRUNCATE TABLE tirageuser ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();

        }

        private void deleteDataTirage()
        {

            string connStr = "server=localhost;user=root;database=gigaloto;port=3306;password=mysql";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                string sql = "BEGIN; " +
                    "TRUNCATE TABLE tirage; " +
                    "TRUNCATE TABLE tiragestat; " +
                    "TRUNCATE TABLE resultattirage; " +
                    "TRUNCATE TABLE gaintirage; " +
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








        // *********** Button


        private void buttonSimulateur_Click(object sender, EventArgs e)
        {
            panelLive.Hide();
            panelSimulateur.Show();
            RemplirDataGridViewSimulateur();
        }

        private void buttonLive_Click(object sender, EventArgs e)
        {
            panelSimulateur.Hide();
            panelLive.Show();
            RemplirDataGridViewLive();
        }

        private void buttonDeleteLive_Click(object sender, EventArgs e)
        {
            deleteDataUser();
            RemplirDataGridViewLive();
        }

        private void buttonDeleteSimulateur_Click(object sender, EventArgs e)
        {
            deleteDataTirage();
            RemplirDataGridViewSimulateur();
        }
    }
}
