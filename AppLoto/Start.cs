using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace AppLoto
{
    public partial class Start : Form
    {

        MySqlConnection sqlConnexion;

        bool isConnected = false;
        public static string currentUser;            //la variable qui va retenir l'user connecté dans tout les forms




        // Call au start de l'app
        public Start()
        {
            InitializeComponent();
            creationBdd();
            createUserTable();
            HideUserSelect();
            connectbdd();
            refreshForm();
            verifyUserStart();
        }



        // Creation de la base de donnée
        private void creationBdd()
        {
            string connStr = "server=localhost;user=root;port=3306;password=mysql";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string s0 = "CREATE DATABASE IF NOT EXISTS `gigaloto`;";
                MySqlCommand cmd = new MySqlCommand(s0, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
        }




        // Fonction qui permet de refresh le form et de verifier l'etat de isConnect pour changer le bouton du menu fichier

        public void refreshForm()
        {
            Width--;
            Width++;

            if (isConnected)
            {
                menuConnexion.Text = "Déconnexion";
            }
            else
            {
                menuConnexion.Text = "Connexion";
            }

        }





        // Fonction de connection a la bdd

        private void connectbdd()
        {

            isConnected = false;

            string stconnexion = "server=localhost; user id=root; password=mysql";
            sqlConnexion = new MySqlConnection(stconnexion);

            try
            {

                sqlConnexion.Open();
                isConnected = true;

            }
            catch (Exception co)
            {
                MessageBox.Show("Problème pour se connecter à la base de donnée");
                MessageBox.Show(co.ToString());

            }

            refreshForm();       // refresh le form
        }







        // Verifie au lancement de l'app si au moins un user existe et affiche le choix d'user

        private void verifyUserStart()
        {

            string connStr = "server=localhost;user=root;database=gigaloto;port=3306;password=mysql";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "SELECT * FROM user";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (!rdr.HasRows)
                {
                    MessageBox.Show("Aucun utilisateur enregistré, veuillez en creer un.");
                }
                else

                {
                    HideNewUser();
                    ShowUserSelect();
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();

        }




        // Creation de la table user
        private void createUserTable()
        {
            string connStr = "server=localhost;user=root;database=gigaloto;port=3306;password=mysql";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "create table if not exists user(" +
                "user_id       int primary key NOT NULL AUTO_INCREMENT," +
                "userName    varchar(25) NOT NULL" +
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










        // User input puis vérifie si l'utilisateur existe déjà . Si oui, il faut rentrer un nouveau nom sinon l'utilisateur est ajouté a la table "user"

        private void verifyUser(string userNameValue)
        {
            bool alreadyExist = false;

            string connStr = "server=localhost;user=root;database=gigaloto;port=3306;password=mysql";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "SELECT * FROM user";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (userNameValue == rdr.GetString(1))
                    {
                        alreadyExist = true;
                    }

                }
                rdr.Close();

                if (alreadyExist)                                     // Si le nom existe déjà
                {
                    MessageBox.Show("Ce nom existe déjà");
                }
                else
                {

                    insertNewUser(userNameValue);                     //Ajout du nouvel utilisateur en base

                    currentUser = userNameValue;                     // La variable globale currentUser prend la valeur du nom

                    hideStartShowAccueil();                         // On passe a la suite de l'application, l'utilisateur est connecté
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();

        }






        // Inserer un nouvel utilisateur dans la table "user"

        private void insertNewUser(string userNameValue)
        {

            string connStr = "server=localhost;user=root;database=gigaloto;port=3306;password=mysql";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "INSERT INTO user (userName) VALUES ('" + userNameValue + "')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();

        }






        // Supprimer un utilisateur dans la table "user"

        private void DeleteUser(string userNameValue)
        {

            string connStr = "server=localhost;user=root;database=gigaloto;port=3306;password=mysql";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {

                // conn.Open();

                string sql = "DELETE FROM user WHERE userName = '" + userNameValue + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("L'user a ete delete");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();

        }






















        // Afficher les elements de creation d'user

        private void ShowNewUser()
        {

            inputUserName.Show();
            validateUserNameButton.Show();
            askLabel.Text = "Veuillez entrer votre nom d'utilisateur s'il vous plaît ";
        }



        // Permet de cacher les elements de création d'user
        private void HideNewUser()
        {

            inputUserName.Hide();
            validateUserNameButton.Hide();

        }




        // Permet de cacher le choix d'user

        private void HideUserSelect()
        {
            userButton0.Hide();
            userButton1.Hide();
            userButton2.Hide();
            userButton3.Hide();
            deleteUser0.Hide();
            deleteUser1.Hide();
            deleteUser2.Hide();
            deleteUser3.Hide();

        }


















        // Affiche le choix d'user pour se connecter a partir de la base de donnée + le bouton supprimer

        private void ShowUserSelect()
        {



            string connStr = "server=localhost;user=root;database=gigaloto;port=3306;password=mysql";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "SELECT * FROM user";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();


                Button[] buttonUserName = new Button[4];

                // On stock les elements dans des tableaux pour pouvoir les modifiers dans la boucle

                buttonUserName[0] = userButton0;
                buttonUserName[1] = userButton1;
                buttonUserName[2] = userButton2;
                buttonUserName[3] = userButton3;


                string[] tableauUserName = new string[4];

                int tableLength = 0;

                while (rdr.Read())
                {

                    // Modification des textes d'elements du tableau avec les infos de la table
                    buttonUserName[tableLength].Text = rdr.GetString(1);
                    tableLength++;
                    if (rdr.HasRows)                                                         // Si un bouton n'est pas attribué ou supprimer, remplace le texte
                    {
                        buttonUserName[tableLength].Text = "ajouter un utilisateur";
                    }

                }
                rdr.Close();
            }
            catch
            {
            }
            conn.Close();


            userButton0.Show();
            userButton1.Show();
            userButton2.Show();
            userButton3.Show();

            askLabel.Text = "Veuillez choisir un utilisateur pour se connecter";

            if (userButton0.Text != "ajouter un utilisateur")
            {
                deleteUser0.Show();

            }
            if (userButton1.Text != "ajouter un utilisateur")
            {
                deleteUser1.Show();
            }
            if (userButton2.Text != "ajouter un utilisateur")
            {
                deleteUser2.Show();
            }
            if (userButton3.Text != "ajouter un utilisateur")
            {
                deleteUser3.Show();
            }
        }








        //**************** Bouton

        private void menuConnexion_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                sqlConnexion = null;
                isConnected = false;
                refreshForm();
            }
            else
            {
                connectbdd();
                refreshForm();
            }
        }



        private void validateUserNameButton_Click(object sender, EventArgs e)
        {
            string userNameValue = inputUserName.Text;
            verifyUser(userNameValue);
        }




        // Logique des boutons de selection user

        private void userButton0_Click(object sender, EventArgs e)
        {
            if (userButton0.Text != "ajouter un utilisateur")
            {
                currentUser = userButton0.Text;
                hideStartShowAccueil();
            }
            else
            {
                HideUserSelect();
                ShowNewUser();
            }
        }

        private void userButton1_Click(object sender, EventArgs e)
        {

            if (userButton1.Text != "ajouter un utilisateur")
            {
                currentUser = userButton1.Text;
                hideStartShowAccueil();
            }
            else
            {
                HideUserSelect();
                ShowNewUser();
            }
        }

        private void userButton2_Click(object sender, EventArgs e)
        {

            if (userButton2.Text != "ajouter un utilisateur")
            {
                currentUser = userButton2.Text;
                hideStartShowAccueil();
            }
            else
            {
                HideUserSelect();
                ShowNewUser();
            }
        }

        private void userButton3_Click(object sender, EventArgs e)
        {

            if (userButton3.Text != "ajouter un utilisateur")
            {
                currentUser = userButton3.Text;
                hideStartShowAccueil();
            }
            else
            {
                HideUserSelect();
                ShowNewUser();
            }
        }











        //Logique des boutons pour supprimer un user

        private void deleteUser0_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes vous sur de vouloir supprimer : " + userButton0.Text, "Vérification", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteUser(userButton0.Text);         // Supprimer l'utilisateur
                ShowUserSelect();                     // Refresh la liste d'user
            }
            else if (dialogResult == DialogResult.No)
            {
                // autre action
            }
        }


        private void deleteUser1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes vous sur de vouloir supprimer : " + userButton1.Text, "Vérification", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteUser(userButton1.Text);         // Supprimer l'utilisateur
                ShowUserSelect();
            }
            else if (dialogResult == DialogResult.No)
            {
                // autre action
            }
        }

        private void deleteUser2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes vous sur de vouloir supprimer : " + userButton2.Text, "Vérification", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteUser(userButton2.Text);         // Supprimer l'utilisateur
                ShowUserSelect();
            }
            else if (dialogResult == DialogResult.No)
            {
                // autre action
            }
        }


        private void deleteUser3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes vous sur de vouloir supprimer : " + userButton3.Text, "Vérification", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteUser(userButton3.Text);         // Supprimer l'utilisateur
                ShowUserSelect();
            }
            else if (dialogResult == DialogResult.No)
            {
                // autre action
            }
        }















        // fonction pour hide le form actuel et en ouvrir un autre 


        private void hideStartShowAccueil()
        {
            this.Hide();
            Form accueil = new Accueil();
            accueil.ShowDialog();
        }



        //Verification a la fermeture de l'app

        private void Start_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Start_Load(object sender, EventArgs e)
        {

        }
    }

}

