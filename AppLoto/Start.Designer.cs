
namespace AppLoto
{
    partial class Start
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConnexion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.fichierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inputUserName = new System.Windows.Forms.TextBox();
            this.gigaLotoLabel = new System.Windows.Forms.Label();
            this.askLabel = new System.Windows.Forms.Label();
            this.validateUserNameButton = new System.Windows.Forms.Button();
            this.userButton0 = new System.Windows.Forms.Button();
            this.userButton1 = new System.Windows.Forms.Button();
            this.userButton3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteUser0 = new System.Windows.Forms.Button();
            this.deleteUser1 = new System.Windows.Forms.Button();
            this.deleteUser2 = new System.Windows.Forms.Button();
            this.deleteUser3 = new System.Windows.Forms.Button();
            this.userButton2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1086, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConnexion,
            this.menuQuitter,
            this.fichierToolStripMenuItem1});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // menuConnexion
            // 
            this.menuConnexion.Name = "menuConnexion";
            this.menuConnexion.Size = new System.Drawing.Size(132, 22);
            this.menuConnexion.Text = "Connexion";
            this.menuConnexion.Click += new System.EventHandler(this.menuConnexion_Click);
            // 
            // menuQuitter
            // 
            this.menuQuitter.Name = "menuQuitter";
            this.menuQuitter.Size = new System.Drawing.Size(132, 22);
            this.menuQuitter.Text = "Quitter";
            // 
            // fichierToolStripMenuItem1
            // 
            this.fichierToolStripMenuItem1.Name = "fichierToolStripMenuItem1";
            this.fichierToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.fichierToolStripMenuItem1.Text = "Fichier";
            // 
            // inputUserName
            // 
            this.inputUserName.Location = new System.Drawing.Point(454, 400);
            this.inputUserName.Name = "inputUserName";
            this.inputUserName.Size = new System.Drawing.Size(186, 23);
            this.inputUserName.TabIndex = 2;
            // 
            // gigaLotoLabel
            // 
            this.gigaLotoLabel.AutoSize = true;
            this.gigaLotoLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gigaLotoLabel.Location = new System.Drawing.Point(258, 74);
            this.gigaLotoLabel.Name = "gigaLotoLabel";
            this.gigaLotoLabel.Size = new System.Drawing.Size(564, 65);
            this.gigaLotoLabel.TabIndex = 3;
            this.gigaLotoLabel.Text = "Bienvenue dans GigaLoto";
            // 
            // askLabel
            // 
            this.askLabel.AutoSize = true;
            this.askLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.askLabel.Location = new System.Drawing.Point(278, 326);
            this.askLabel.Name = "askLabel";
            this.askLabel.Size = new System.Drawing.Size(569, 32);
            this.askLabel.TabIndex = 4;
            this.askLabel.Text = "Veuillez entrer votre nom d\'utilisateur s\'il vous plaît ";
            // 
            // validateUserNameButton
            // 
            this.validateUserNameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.validateUserNameButton.Location = new System.Drawing.Point(496, 461);
            this.validateUserNameButton.Name = "validateUserNameButton";
            this.validateUserNameButton.Size = new System.Drawing.Size(106, 44);
            this.validateUserNameButton.TabIndex = 5;
            this.validateUserNameButton.Text = "Valider";
            this.validateUserNameButton.UseVisualStyleBackColor = true;
            this.validateUserNameButton.Click += new System.EventHandler(this.validateUserNameButton_Click);
            // 
            // userButton0
            // 
            this.userButton0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userButton0.Location = new System.Drawing.Point(71, 373);
            this.userButton0.Name = "userButton0";
            this.userButton0.Size = new System.Drawing.Size(181, 155);
            this.userButton0.TabIndex = 6;
            this.userButton0.Text = "ajouter un utilisateur";
            this.userButton0.UseVisualStyleBackColor = true;
            this.userButton0.Click += new System.EventHandler(this.userButton0_Click);
            // 
            // userButton1
            // 
            this.userButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userButton1.Location = new System.Drawing.Point(332, 373);
            this.userButton1.Name = "userButton1";
            this.userButton1.Size = new System.Drawing.Size(181, 155);
            this.userButton1.TabIndex = 8;
            this.userButton1.Text = "ajouter un utilisateur";
            this.userButton1.UseVisualStyleBackColor = true;
            this.userButton1.Click += new System.EventHandler(this.userButton1_Click);
            // 
            // userButton3
            // 
            this.userButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userButton3.Location = new System.Drawing.Point(826, 373);
            this.userButton3.Name = "userButton3";
            this.userButton3.Size = new System.Drawing.Size(181, 155);
            this.userButton3.TabIndex = 12;
            this.userButton3.Text = "ajouter un utilisateur";
            this.userButton3.UseVisualStyleBackColor = true;
            this.userButton3.Click += new System.EventHandler(this.userButton3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(121, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(808, 40);
            this.label2.TabIndex = 15;
            this.label2.Text = "Grace a cette application vous allez pouvoir miser a la lotterie ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(243, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 40);
            this.label1.TabIndex = 15;
            this.label1.Text = "ainsi que generer des paris et voir l\'historique";
            // 
            // deleteUser0
            // 
            this.deleteUser0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteUser0.Location = new System.Drawing.Point(121, 550);
            this.deleteUser0.Name = "deleteUser0";
            this.deleteUser0.Size = new System.Drawing.Size(75, 23);
            this.deleteUser0.TabIndex = 16;
            this.deleteUser0.Text = "Supprimer";
            this.deleteUser0.UseVisualStyleBackColor = true;
            this.deleteUser0.Click += new System.EventHandler(this.deleteUser0_Click);
            // 
            // deleteUser1
            // 
            this.deleteUser1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteUser1.Location = new System.Drawing.Point(396, 550);
            this.deleteUser1.Name = "deleteUser1";
            this.deleteUser1.Size = new System.Drawing.Size(75, 23);
            this.deleteUser1.TabIndex = 16;
            this.deleteUser1.Text = "Supprimer";
            this.deleteUser1.UseVisualStyleBackColor = true;
            this.deleteUser1.Click += new System.EventHandler(this.deleteUser1_Click);
            // 
            // deleteUser2
            // 
            this.deleteUser2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteUser2.Location = new System.Drawing.Point(646, 550);
            this.deleteUser2.Name = "deleteUser2";
            this.deleteUser2.Size = new System.Drawing.Size(75, 23);
            this.deleteUser2.TabIndex = 16;
            this.deleteUser2.Text = "Supprimer";
            this.deleteUser2.UseVisualStyleBackColor = true;
            this.deleteUser2.Click += new System.EventHandler(this.deleteUser2_Click);
            // 
            // deleteUser3
            // 
            this.deleteUser3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteUser3.Location = new System.Drawing.Point(882, 550);
            this.deleteUser3.Name = "deleteUser3";
            this.deleteUser3.Size = new System.Drawing.Size(75, 23);
            this.deleteUser3.TabIndex = 16;
            this.deleteUser3.Text = "Supprimer";
            this.deleteUser3.UseVisualStyleBackColor = true;
            this.deleteUser3.Click += new System.EventHandler(this.deleteUser3_Click);
            // 
            // userButton2
            // 
            this.userButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userButton2.Location = new System.Drawing.Point(580, 373);
            this.userButton2.Name = "userButton2";
            this.userButton2.Size = new System.Drawing.Size(181, 155);
            this.userButton2.TabIndex = 10;
            this.userButton2.Text = "ajouter un utilisateur";
            this.userButton2.UseVisualStyleBackColor = true;
            this.userButton2.Click += new System.EventHandler(this.userButton2_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 654);
            this.Controls.Add(this.deleteUser3);
            this.Controls.Add(this.deleteUser2);
            this.Controls.Add(this.deleteUser1);
            this.Controls.Add(this.deleteUser0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userButton3);
            this.Controls.Add(this.userButton2);
            this.Controls.Add(this.userButton1);
            this.Controls.Add(this.userButton0);
            this.Controls.Add(this.validateUserNameButton);
            this.Controls.Add(this.askLabel);
            this.Controls.Add(this.gigaLotoLabel);
            this.Controls.Add(this.inputUserName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Start";
            this.Text = "Application GigaLoto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Start_FormClosing);
            this.Load += new System.EventHandler(this.Start_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuConnexion;
        private System.Windows.Forms.ToolStripMenuItem menuQuitter;
        private System.Windows.Forms.TextBox inputUserName;
        private System.Windows.Forms.Label gigaLotoLabel;
        private System.Windows.Forms.Label askLabel;
        private System.Windows.Forms.Button validateUserNameButton;
        private System.Windows.Forms.Button userButton0;
        private System.Windows.Forms.Button userButton1;
        private System.Windows.Forms.Button userButton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteUser0;
        private System.Windows.Forms.Button deleteUser1;
        private System.Windows.Forms.Button deleteUser2;
        private System.Windows.Forms.Button deleteUser3;
        private System.Windows.Forms.Button userButton2;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem1;
    }
}

