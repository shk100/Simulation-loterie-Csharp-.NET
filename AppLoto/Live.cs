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
    public partial class Live : Form
    {


        // Tableau pour recuperer le resultat du tirage
        public static int[] resultatTirage = new int[6];

        // Tableau pour recuperer les nombres coché dans la grille
        public static int[] nombreCocheUser = new int[6];
        bool nombreCocheUserOk = false;

        // Variable du jour de tirage
        public static int jourTirage = 0;
        bool jourTirageOK = false;

        // variable du nombre de parieur
        public static int nombreParieur = 0;
        bool nombreParieurOk = false;



        public Live()
        {
            InitializeComponent();
        }



        // Permet de recuperer les cases cochés par l'utilisateur et les stocks dans un tableau. 

        private void VerifCaseCoche()
        {

            // On met en tableau tout les checkboxs qui represente les nombres de la lotterie.

            CheckBox[] checkBoxNombre = new CheckBox[29];

            checkBoxNombre[0] = checkBox0;
            checkBoxNombre[1] = checkBox1;
            checkBoxNombre[2] = checkBox2;
            checkBoxNombre[3] = checkBox3;
            checkBoxNombre[4] = checkBox4;
            checkBoxNombre[5] = checkBox5;
            checkBoxNombre[6] = checkBox6;
            checkBoxNombre[7] = checkBox7;
            checkBoxNombre[8] = checkBox8;
            checkBoxNombre[9] = checkBox9;
            checkBoxNombre[10] = checkBox10;
            checkBoxNombre[11] = checkBox11;
            checkBoxNombre[12] = checkBox12;
            checkBoxNombre[13] = checkBox13;
            checkBoxNombre[14] = checkBox14;
            checkBoxNombre[15] = checkBox15;
            checkBoxNombre[16] = checkBox16;
            checkBoxNombre[17] = checkBox17;
            checkBoxNombre[18] = checkBox18;
            checkBoxNombre[19] = checkBox19;
            checkBoxNombre[20] = checkBox20;
            checkBoxNombre[21] = checkBox21;
            checkBoxNombre[22] = checkBox22;
            checkBoxNombre[23] = checkBox23;
            checkBoxNombre[24] = checkBox24;
            checkBoxNombre[25] = checkBox25;
            checkBoxNombre[26] = checkBox26;
            checkBoxNombre[27] = checkBox27;
            checkBoxNombre[28] = checkBox28;


            // Verifie le nombre de case coché dans la grille

            int caseCoche = 0;          

            for (int i = 0; i < 29; i++)
            {
                if (checkBoxNombre[i].Checked)
                {
                    caseCoche++;
                }
            }


            if (caseCoche != 6)
            {
                MessageBox.Show("Il faut cocher 6 cases pour valider votre grille");
            }
            else
            {
                // On creer une liste temporaire pour y ajouter a chaque passage de la boucle le nombre coché

                List<int> tmpListeNombre = new List<int>();

                for (int i = 0; i < 29; i++)
                {
                    if (checkBoxNombre[i].Checked)
                    {
                        tmpListeNombre.Add(i + 1);                // Ajout du nombre dans la liste
                    }

                }

                int[] tableauNombreCocheTmp = tmpListeNombre.ToArray();          // Conversion de la liste en array et on la stock dans un tableau

                for (int i = 0; i < 6; i++)
                {
                    nombreCocheUser[i] = tableauNombreCocheTmp[i];               // On stock les nombres cochés dans une variable
                }
                nombreCocheUserOk = true;

            }
        }





        private void verifyNombreParieur()
        {
            int tmpNombreParieur = int.Parse(textBoxNombreParieur.Text);
            if (tmpNombreParieur >= 0 & tmpNombreParieur <= 1000)
            {
                nombreParieur = tmpNombreParieur;
                nombreParieurOk = true;
            }
            else
            {
                MessageBox.Show("Le nombre de parieur doit être entre 0 et 1000.");
            }
        }






        // Verifie quel jour est coché

        private void verifyJourTirage()
        {
            if(checkBoxLundi.Checked)
            {
                jourTirage = 2;
                jourTirageOK = true;
            }
            else if(checkBoxJeudi.Checked)
            {
                jourTirage = 5;
                jourTirageOK = true;
            }
            else
            {
                MessageBox.Show("Il faut selectioner un jour de tirage.");
            }
        }




        // Si la grille et le jour de tirage sont coché alors lance le tirage, si un nombre est deja tiré, en tire un autre

        private void lancementTirage()
        {
            List<int> tmpResultatList = new List<int>();

            if (jourTirageOK & nombreCocheUserOk & nombreParieurOk)
            {
                Random rnd = new Random();

                for (int i = 0; i < 6; i++)
                {
                    int tmpRandomNombre = rnd.Next(1, 30);

                    if(tmpResultatList.Contains(tmpRandomNombre))
                    {
                        tmpRandomNombre = rnd.Next(1, 30);
                        tmpResultatList.Add(tmpRandomNombre);
                        resultatTirage[i] = tmpRandomNombre;
                    }
                    else
                    {
                        tmpResultatList.Add(tmpRandomNombre);
                        resultatTirage[i] = tmpRandomNombre;
                    }
                    
                       // MessageBox.Show(" Nombre tiré : " + resultatTirage[i]);
                }
                OpenLiveTirage();
            }
        }







        // Ouvrir le form de tirage live
        private void OpenLiveTirage()
        {
            Form tirageLive = new TirageLive();
            tirageLive.ShowDialog();
        }











        // ****************** Bouton

        private void button1_Click(object sender, EventArgs e)
        {
            VerifCaseCoche();
            verifyJourTirage();
            verifyNombreParieur();
            lancementTirage();
        }



        // Empecher les inputs autre que des nombres dans la textBox du nombre de parieur

        private void textBoxNombreParieur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
