using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Linq;


namespace AppLoto
{
    public partial class Simulateur : Form
    {
        // Bool pour la fonction de verification si les infos sont deja en base
        bool insertionbdd = false;

        // Nombre de parieur a simuler
        public static int nombreParieur;
        bool nombreParieurOk = false;

        // Jour cliqué dans le calendrier
        int jourSelectionné;

        // Liste pour y stocker la selection de tirage
        public static List<int> tirageList = new List<int>();
        bool tirageListOk = false;

        // Liste pour y stocker les elements affiché dans le dataGridView
        List<int> listeDataGridView = new List<int>();

        public Simulateur()
        {
            InitializeComponent();
            this.Size = new Size(1345, 880);
            createDateTirageTable();               // Création de la table "dateTirage"
            insertDataIntoDb();                    // Remplissage de la table "dateTirage" avec les infos de tirage
        }



        // Tableau contenant les informations sur chaque tirage
        string[] id0 = new string[5];
        string[] id1 = new string[5];
        string[] id2 = new string[5];
        string[] id3 = new string[5];
        string[] id4 = new string[5];
        string[] id5 = new string[5];
        string[] id6 = new string[5];
        string[] id7 = new string[5];
        string[] id8 = new string[5];
        string[] id9 = new string[5];
        string[] id10 = new string[5];
        string[] id11 = new string[5];
        string[] id12 = new string[5];
        string[] id13 = new string[5];
        string[] id14 = new string[5];
        string[] id15 = new string[5];
        string[] id16 = new string[5];
        string[] id17 = new string[5];
        string[] id18 = new string[5];
        string[] id19 = new string[5];
        string[] id20 = new string[5];
        string[] id21 = new string[5];
        string[] id22 = new string[5];
        string[] id23 = new string[5];
        string[] id24 = new string[5];
        string[] id25 = new string[5];
        string[] id26 = new string[5];
        string[] id27 = new string[5];
        string[] id28 = new string[5];
        string[] id29 = new string[5];
        string[] id30 = new string[5];
        string[] id31 = new string[5];
        string[] id32 = new string[5];
        string[] id33 = new string[5];
        string[] id34 = new string[5];
        string[] id35 = new string[5];
        string[] id36 = new string[5];
        string[] id37 = new string[5];
        string[] id38 = new string[5];
        string[] id39 = new string[5];
        string[] id40 = new string[5];
        string[] id41 = new string[5];
        string[] id42 = new string[5];
        string[] id43 = new string[5];
        string[] id44 = new string[5];
        string[] id45 = new string[5];
        string[] id46 = new string[5];
        string[] id47 = new string[5];
        string[] id48 = new string[5];
        string[] id49 = new string[5];
        string[] id50 = new string[5];
        string[] id51 = new string[5];


        private void createDateTirageTable()
        {
            string connStr = "server=localhost;user=root;database=gigaloto;port=3306;password=mysql";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {

                conn.Open();



                string sql = "create table if not exists datetirages(" +
                "idOrdre       int primary key," +
                "mois    varchar(25)," +
                "jour  varchar(25)," +
                "jourNombre     varchar(25)," +
                "tarif     varchar(25)" +
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




        // Mise en base de donnée des informations des dates de tirage
        private void insertDataIntoDb()
        {
            // Janvier
            id0[0] = "0";
            id0[1] = "Lundi";
            id0[2] = "3";
            id0[3] = "Janvier";
            id0[4] = "10";

            id1[0] = "1";
            id1[1] = "Jeudi";
            id1[2] = "6";
            id1[3] = "Janvier";
            id1[4] = "5";

            id2[0] = "2";
            id2[1] = "Lundi";
            id2[2] = "10";
            id2[3] = "Janvier";
            id2[4] = "2";

            id3[0] = "3";
            id3[1] = "Jeudi";
            id3[2] = "13";
            id3[3] = "Janvier";
            id3[4] = "5";

            id4[0] = "4";
            id4[1] = "Lundi";
            id4[2] = "17";
            id4[3] = "Janvier";
            id4[4] = "2";

            id5[0] = "5";
            id5[1] = "Jeudi";
            id5[2] = "20";
            id5[3] = "Janvier";
            id5[4] = "5";

            id6[0] = "6";
            id6[1] = "Lundi";
            id6[2] = "24";
            id6[3] = "Janvier";
            id6[4] = "2";

            id7[0] = "7";
            id7[1] = "Jeudi";
            id7[2] = "27";
            id7[3] = "Janvier";
            id7[4] = "5";

            id8[0] = "8";
            id8[1] = "Lundi";
            id8[2] = "31";
            id8[3] = "Janvier";
            id8[4] = "2";

            // Fevrier
            id9[0] = "9";
            id9[1] = "Jeudi";
            id9[2] = "3";
            id9[3] = "Fevrier";
            id9[4] = "10";

            id10[0] = "10";
            id10[1] = "Lundi";
            id10[2] = "7";
            id10[3] = "Fevrier";
            id10[4] = "10";

            id11[0] = "11";
            id11[1] = "Jeudi";
            id11[2] = "10";
            id11[3] = "Fevrier";
            id11[4] = "5";

            id12[0] = "12";
            id12[1] = "Lundi";
            id12[2] = "14";
            id12[3] = "Fevrier";
            id12[4] = "2";

            id13[0] = "13";
            id13[1] = "Jeudi";
            id13[2] = "17";
            id13[3] = "Fevrier";
            id13[4] = "5";

            id14[0] = "14";
            id14[1] = "Lundi";
            id14[2] = "21";
            id14[3] = "Fevrier";
            id14[4] = "2";

            id15[0] = "15";
            id15[1] = "Jeudi";
            id15[2] = "24";
            id15[3] = "Fevrier";
            id15[4] = "5";

            id16[0] = "16";
            id16[1] = "Lundi";
            id16[2] = "28";
            id16[3] = "Fevrier";
            id16[4] = "2";

            //Mars
            id17[0] = "17";
            id17[1] = "Jeudi";
            id17[2] = "3";
            id17[3] = "Mars";
            id17[4] = "5";

            id18[0] = "18";
            id18[1] = "Lundi";
            id18[2] = "7";
            id18[3] = "Mars";
            id18[4] = "10";

            id19[0] = "19";
            id19[1] = "Jeudi";
            id19[2] = "10";
            id19[3] = "Mars";
            id19[4] = "5";

            id20[0] = "20";
            id20[1] = "Lundi";
            id20[2] = "14";
            id20[3] = "Mars";
            id20[4] = "2";

            id21[0] = "21";
            id21[1] = "Jeudi";
            id21[2] = "17";
            id21[3] = "Mars";
            id21[4] = "5";

            id22[0] = "22";
            id22[1] = "Lundi";
            id22[2] = "21";
            id22[3] = "Mars";
            id22[4] = "2";

            id23[0] = "23";
            id23[1] = "Jeudi";
            id23[2] = "24";
            id23[3] = "Mars";
            id23[4] = "5";

            id24[0] = "24";
            id24[1] = "Lundi";
            id24[2] = "28";
            id24[3] = "Mars";
            id24[4] = "2";

            id25[0] = "25";
            id25[1] = "Jeudi";
            id25[2] = "31";
            id25[3] = "Mars";
            id25[4] = "5";

            //Avril
            id26[0] = "26";
            id26[1] = "Lundi";
            id26[2] = "4";
            id26[3] = "Avril";
            id26[4] = "10";

            id27[0] = "27";
            id27[1] = "Jeudi";
            id27[2] = "7";
            id27[3] = "Avril";
            id27[4] = "5";

            id28[0] = "28";
            id28[1] = "Lundi";
            id28[2] = "11";
            id28[3] = "Avril";
            id28[4] = "2";

            id29[0] = "29";
            id29[1] = "Jeudi";
            id29[2] = "14";
            id29[3] = "Avril";
            id29[4] = "5";

            id30[0] = "30";
            id30[1] = "Lundi";
            id30[2] = "18";
            id30[3] = "Avril";
            id30[4] = "2";

            id31[0] = "31";
            id31[1] = "Jeudi";
            id31[2] = "21";
            id31[3] = "Avril";
            id31[4] = "5";

            id32[0] = "32";
            id32[1] = "Lundi";
            id32[2] = "25";
            id32[3] = "Avril";
            id32[4] = "2";

            id33[0] = "33";
            id33[1] = "Jeudi";
            id33[2] = "28";
            id33[3] = "Avril";
            id33[4] = "5";

            //Mai
            id34[0] = "34";
            id34[1] = "Lundi";
            id34[2] = "2";
            id34[3] = "Mai";
            id34[4] = "10";

            id35[0] = "35";
            id35[1] = "Jeudi";
            id35[2] = "5";
            id35[3] = "Mai";
            id35[4] = "5";

            id36[0] = "36";
            id36[1] = "Lundi";
            id36[2] = "9";
            id36[3] = "Mai";
            id36[4] = "2";

            id37[0] = "37";
            id37[1] = "Jeudi";
            id37[2] = "12";
            id37[3] = "Mai";
            id37[4] = "5";

            id38[0] = "38";
            id38[1] = "Lundi";
            id38[2] = "16";
            id38[3] = "Mai";
            id38[4] = "2";

            id39[0] = "39";
            id39[1] = "Jeudi";
            id39[2] = "19";
            id39[3] = "Mai";
            id39[4] = "5";

            id40[0] = "40";
            id40[1] = "Lundi";
            id40[2] = "23";
            id40[3] = "Mai";
            id40[4] = "2";

            id41[0] = "41";
            id41[1] = "Jeudi";
            id41[2] = "26";
            id41[3] = "Mai";
            id41[4] = "5";

            id42[0] = "42";
            id42[1] = "Lundi";
            id42[2] = "30";
            id42[3] = "Mai";
            id42[4] = "2";

            //Juin
            id43[0] = "43";
            id43[1] = "Jeudi";
            id43[2] = "2";
            id43[3] = "Juin";
            id43[4] = "5";

            id44[0] = "44";
            id44[1] = "Lundi";
            id44[2] = "6";
            id44[3] = "Juin";
            id44[4] = "10";

            id45[0] = "45";
            id45[1] = "Jeudi";
            id45[2] = "9";
            id45[3] = "Juin";
            id45[4] = "5";

            id46[0] = "46";
            id46[1] = "Lundi";
            id46[2] = "13";
            id46[3] = "Juin";
            id46[4] = "2";

            id47[0] = "47";
            id47[1] = "Jeudi";
            id47[2] = "16";
            id47[3] = "Juin";
            id47[4] = "5";

            id48[0] = "48";
            id48[1] = "Lundi";
            id48[2] = "20";
            id48[3] = "Juin";
            id48[4] = "2";

            id49[0] = "49";
            id49[1] = "Jeudi";
            id49[2] = "23";
            id49[3] = "Juin";
            id49[4] = "5";

            id50[0] = "50";
            id50[1] = "Lundi";
            id50[2] = "27";
            id50[3] = "Juin";
            id50[4] = "2";

            id51[0] = "51";
            id51[1] = "Jeudi";
            id51[2] = "30";
            id51[3] = "Juin";
            id51[4] = "5";

            // Plutot que de faire une grosse requete SQL Insert , j'ai mis mes tableaux dans un tableau pour boucler une requete Insert dessus
            string[][] dateArray = new string[52][];
            dateArray[0] = id0;
            dateArray[1] = id1;
            dateArray[2] = id2;
            dateArray[3] = id3;
            dateArray[4] = id4;
            dateArray[5] = id5;
            dateArray[6] = id6;
            dateArray[7] = id7;
            dateArray[8] = id8;
            dateArray[9] = id9;
            dateArray[10] = id10;
            dateArray[11] = id11;
            dateArray[12] = id12;
            dateArray[13] = id13;
            dateArray[14] = id14;
            dateArray[15] = id15;
            dateArray[16] = id16;
            dateArray[17] = id17;
            dateArray[18] = id18;
            dateArray[19] = id19;
            dateArray[20] = id20;
            dateArray[21] = id21;
            dateArray[22] = id22;
            dateArray[23] = id23;
            dateArray[24] = id24;
            dateArray[25] = id25;
            dateArray[26] = id26;
            dateArray[27] = id27;
            dateArray[28] = id28;
            dateArray[29] = id29;
            dateArray[30] = id30;
            dateArray[31] = id31;
            dateArray[32] = id32;
            dateArray[33] = id33;
            dateArray[34] = id34;
            dateArray[35] = id35;
            dateArray[36] = id36;
            dateArray[37] = id37;
            dateArray[38] = id38;
            dateArray[39] = id39;
            dateArray[40] = id40;
            dateArray[41] = id41;
            dateArray[42] = id42;
            dateArray[43] = id43;
            dateArray[44] = id44;
            dateArray[45] = id45;
            dateArray[46] = id46;
            dateArray[47] = id47;
            dateArray[48] = id48;
            dateArray[49] = id49;
            dateArray[50] = id50;
            dateArray[51] = id51;



            string connStr = "server=localhost;user=root;database=gigaloto;port=3306;password=mysql";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                string sql = "SELECT * FROM datetirages";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (!rdr.HasRows)
                {
                    //  MessageBox.Show("la base est vide, insertion des infos en base");
                    insertionbdd = true;
                }

                rdr.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();





            if (insertionbdd)
            {
                try
                {
                    conn.Open();

                    for (int i = 0; i < 52; i++)                     // Boucle pour inserer chaque info dans la base de donnée pour les recuperer plus tard
                    {

                        string sql = "INSERT INTO datetirages (`idOrdre`, `jour`, `jourNombre`, `mois`, `tarif`) VALUES " +
                          "('" + dateArray[i][0] + "','" + dateArray[i][1] + "','" + dateArray[i][2] + "','" + dateArray[i][3] + "','" + dateArray[i][4] + "')";

                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                conn.Close();
            }
        }



        // Ajoute le jour qui est selectionné dans la liste de tirage
        private void addToList()
        {
            if (!tirageList.Contains(jourSelectionné))
            {
                tirageList.Add(jourSelectionné);
            }
            else
            {
                MessageBox.Show("Le tirage est déjà dans la liste !");
            }
        }



        // Afficher sur la dataGridView les tirages de la liste en empechant les doublons
        private void showDataGridView()
        {

            string connStr = "server=localhost;user=root;database=gigaloto;port=3306;password=mysql";
            MySqlConnection conn = new MySqlConnection(connStr);

            for (int i = 0; i < tirageList.Count; i++)  // On boucle sur longueur de la liste pour prendre tout les tirages selectioné
            {
                if (!listeDataGridView.Contains(tirageList[i]))   // On vérifie si ce tirage n'est  pas déjà affiché dans la dataGridView
                {
                    try
                    {
                        conn.Open();

                        string sql = "SELECT * FROM datetirages WHERE idOrdre = " + tirageList[i];
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        MySqlDataReader rdr = cmd.ExecuteReader();

                        while (rdr.Read())                  // On ajoute les infos a la ligne
                        {
                            dataGridViewListeTirage.Rows.Add(rdr.GetString(2), rdr.GetString(3), rdr.GetString(1), rdr.GetString(4) + "€");
                        }
                        rdr.Close();

                        listeDataGridView.Add(tirageList[i]);       // On ajoute ce tirage dans la liste des valeurs déjà affiché sur la dataGridView

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    conn.Close();
                }
            }
        }



        // Verifier si des elements se trouve dans la liste de tirage ou non
        private void verifyListTirage()
        {
            if (tirageList.Any())
            {
                // pas vide
                tirageListOk = true;
            }
            else
            {
                MessageBox.Show("Il faut selectionner au moins un tirage pour continuer");
            }
        }

        private void finalVerif()
        {
            if (tirageListOk & nombreParieurOk)
            {
                // Lancer la simulation
                lanceResultatSimulateur();
            }
        }


        private void lanceResultatSimulateur()
        {
            Form resultat = new resultatSimulateur();
            resultat.ShowDialog();
        }




        //*************** Bouton valider *********          Verifie le nombre de parieur puis si la liste de tirage n'est pas vide puis lance la simulation
        private void buttonValider_Click(object sender, EventArgs e)
        {
            verifyParieurNumber();
            verifyListTirage();
            finalVerif();
        }

        //*************** Bouton Add Selection *********     Ajoute le jour a la liste puis l'affiche dans le dataGrid
        private void buttonAddSelection_Click(object sender, EventArgs e)
        {
            addToList();
            showDataGridView();
        }


        //************ Bouton Clear liste ***********    Permet de clear toute les listes et la dataGridView
        private void buttonClear_Click(object sender, EventArgs e)
        {
            dataGridViewListeTirage.Rows.Clear();
            listeDataGridView.Clear();
            tirageList.Clear();
            MessageBox.Show("les tirages de la liste ont bien été delete");
        }





        // Verifier les inputs du nombre de parieur
        private void verifyParieurNumber()
        {
            if (checkBoxValeur.Checked & checkBoxAleatoire.Checked)
            {
                MessageBox.Show("Il faut cocher un seul choix au niveau du nombre de parieur.");
            }

            if (checkBoxValeur.Checked)
            {
                int tmpNombreParieur = int.Parse(textBoxValeur.Text);

                if (tmpNombreParieur >= 1)
                {
                    nombreParieur = tmpNombreParieur;
                    nombreParieurOk = true;
                }
                else
                {
                    MessageBox.Show("Le nombre de parieur doit être minimum de 1.");
                }
            }

            if (checkBoxAleatoire.Checked)
            {
                Random rnd = new Random();
                int tmpRandomNombre = rnd.Next(1, 1001);       // On tire un nombre aleatoire au hasard pour le nombre de parieur
                nombreParieur = tmpRandomNombre;
                nombreParieurOk = true;
            }

            if (!checkBoxAleatoire.Checked & !checkBoxValeur.Checked)
            {
                MessageBox.Show("Il faut cocher au moins une case au niveau du nombre de parieur.");
            }
        }












        // Change l'image du tirage en fonction du jour selectionné

        private void showLundiFou()
        {
            labelSelection.Hide();
            pictureBoxLundiFou.Show();
            pictureBoxJeudi.Hide();
            pictureBoxLundi.Hide();
        }

        private void showLundi()
        {
            labelSelection.Hide();
            pictureBoxLundi.Show();
            pictureBoxLundiFou.Hide();
            pictureBoxJeudi.Hide();
        }
        private void showJeudi()
        {
            labelSelection.Hide();
            pictureBoxLundi.Hide();
            pictureBoxLundiFou.Hide();
            pictureBoxJeudi.Show();
        }


        private void buttonNextJanvier_Click(object sender, EventArgs e)
        {
            panelJanvier.Hide();
            panelFevrier.Show();
            panelFevrier.Location = new Point(57, 272);
        }

        private void buttonPreviousFevrier_Click(object sender, EventArgs e)
        {
            panelFevrier.Hide();
            panelJanvier.Show();
            panelJanvier.Location = new Point(57, 272);
        }

        private void buttonNextFevrier_Click(object sender, EventArgs e)
        {
            panelFevrier.Hide();
            panelMars.Show();
            panelMars.Location = new Point(57, 272);
        }

        private void buttonPreviousMars_Click(object sender, EventArgs e)
        {
            panelMars.Hide();
            panelFevrier.Show();
            panelFevrier.Location = new Point(57, 272);
        }

        private void buttonNextMars_Click(object sender, EventArgs e)
        {
            panelMars.Hide();
            panelAvril.Show();
            panelAvril.Location = new Point(57, 272);
        }

        private void buttonPreviousMai_Click(object sender, EventArgs e)
        {
            panelMai.Hide();
            panelAvril.Show();
            panelAvril.Location = new Point(57, 272);
        }

        private void buttonNextMai_Click(object sender, EventArgs e)
        {
            panelMai.Hide();
            panelJuin.Show();
            panelJuin.Location = new Point(57, 272);
        }

        private void buttonPreviousAvril_Click(object sender, EventArgs e)
        {
            panelAvril.Hide();
            panelMars.Show();
            panelMars.Location = new Point(57, 272);
        }

        private void buttonNextAvril_Click(object sender, EventArgs e)
        {
            panelAvril.Hide();
            panelMai.Show();
            panelMai.Location = new Point(57, 272);
        }

        private void buttonPreviousJuin_Click(object sender, EventArgs e)
        {
            panelJuin.Hide();
            panelMai.Show();
            panelMai.Location = new Point(57, 272);
        }


        private void button125_Click(object sender, EventArgs e)
        {
            showJeudi();
            jourSelectionné = 1;
        }

        private void button135_Click_1(object sender, EventArgs e)
        {
            showLundiFou();
            jourSelectionné = 0;
        }

        private void button134_Click(object sender, EventArgs e)
        {
            showLundi();
            jourSelectionné = 2;
        }

        private void button114_Click(object sender, EventArgs e)
        {
            showJeudi();
            jourSelectionné = 3;
        }

        private void button133_Click(object sender, EventArgs e)
        {
            showLundi();
            jourSelectionné = 4;
        }

        private void button110_Click(object sender, EventArgs e)
        {
            showJeudi();
            jourSelectionné = 5;
        }

        private void button132_Click(object sender, EventArgs e)
        {
            showLundi();
            jourSelectionné = 6;
        }

        private void button92_Click(object sender, EventArgs e)
        {
            showJeudi();
            jourSelectionné = 7;
        }

        private void button131_Click(object sender, EventArgs e)
        {
            showLundi();
            jourSelectionné = 8;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            showJeudi();
            jourSelectionné = 9;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            showLundiFou();
            jourSelectionné = 10;
        }

        private void button81_Click(object sender, EventArgs e)
        {
            showJeudi();
            jourSelectionné = 11;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            showLundi();
            jourSelectionné = 12;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            showJeudi();
            jourSelectionné = 13;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            showLundi();
            jourSelectionné = 14;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            showJeudi();
            jourSelectionné = 15;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            showLundi();
            jourSelectionné = 16;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            showJeudi();
            jourSelectionné = 17;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            showLundiFou();
            jourSelectionné = 18;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            showJeudi();
            jourSelectionné = 19;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            showLundi();
            jourSelectionné = 20;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            showJeudi();
            jourSelectionné = 21;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            showLundi();
            jourSelectionné = 22;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            showJeudi();
            jourSelectionné = 23;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            showLundi();
            jourSelectionné = 24;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            showJeudi();
            jourSelectionné = 25;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            showLundiFou();
            jourSelectionné = 26;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            showJeudi();
            jourSelectionné = 27;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            showLundi();
            jourSelectionné = 28;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            showJeudi();
            jourSelectionné = 29;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            showLundi();
            jourSelectionné = 30;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            showJeudi();
            jourSelectionné = 31;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            showLundi();
            jourSelectionné = 32;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            showJeudi();
            jourSelectionné = 33;
        }

        private void button77_Click(object sender, EventArgs e)
        {
            showJeudi();
            jourSelectionné = 43;
        }

        private void button63_Click(object sender, EventArgs e)
        {
            showLundiFou();
            jourSelectionné = 44;
        }

        private void button58_Click(object sender, EventArgs e)
        {
            showJeudi();
            jourSelectionné = 45;
        }

        private void button62_Click(object sender, EventArgs e)
        {
            showLundi();
            jourSelectionné = 46;
        }

        private void button57_Click(object sender, EventArgs e)
        {
            showJeudi();
            jourSelectionné = 47;
        }

        private void button61_Click(object sender, EventArgs e)
        {
            showLundi();
            jourSelectionné = 48;
        }

        private void button56_Click(object sender, EventArgs e)
        {
            showJeudi();
            jourSelectionné = 49;
        }

        private void button60_Click(object sender, EventArgs e)
        {
            showLundi();
            jourSelectionné = 50;
        }

        private void button55_Click(object sender, EventArgs e)
        {
            showJeudi();
            jourSelectionné = 51;
        }

        private void button52_Click(object sender, EventArgs e)
        {
            showLundiFou();
            jourSelectionné = 34;

        }

        private void button47_Click(object sender, EventArgs e)
        {
            showJeudi();
            jourSelectionné = 35;
        }

        private void button51_Click(object sender, EventArgs e)
        {
            showLundi();
            jourSelectionné = 36;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            showJeudi();
            jourSelectionné = 37;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            showLundi();
            jourSelectionné = 38;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            showJeudi();
            jourSelectionné = 39;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            showLundi();
            jourSelectionné = 40;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            showJeudi();
            jourSelectionné = 41;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            showLundi();
            jourSelectionné = 42;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxValeur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }

}
