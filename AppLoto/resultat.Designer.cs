
namespace AppLoto
{
    partial class resultat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSimulateur = new System.Windows.Forms.Button();
            this.panelSimulateur = new System.Windows.Forms.Panel();
            this.dataGridViewResultat = new System.Windows.Forms.DataGridView();
            this.idTirage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTirage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixTirage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miseTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreParieur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultatTirage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sixNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinqNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quatreNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.troisNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deuxNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangUn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangDeux = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangTrois = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangQuatre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RangCinq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonLive = new System.Windows.Forms.Button();
            this.panelLive = new System.Windows.Forms.Panel();
            this.buttonDeleteLive = new System.Windows.Forms.Button();
            this.dataGridViewLive = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joueurNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gainJoueur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbJoueur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDeleteSimulateur = new System.Windows.Forms.Button();
            this.panelSimulateur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultat)).BeginInit();
            this.panelLive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLive)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(683, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historique des tirages";
            // 
            // buttonSimulateur
            // 
            this.buttonSimulateur.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSimulateur.Location = new System.Drawing.Point(12, 120);
            this.buttonSimulateur.Name = "buttonSimulateur";
            this.buttonSimulateur.Size = new System.Drawing.Size(186, 52);
            this.buttonSimulateur.TabIndex = 1;
            this.buttonSimulateur.Text = "Tirage Simulateur";
            this.buttonSimulateur.UseVisualStyleBackColor = true;
            this.buttonSimulateur.Click += new System.EventHandler(this.buttonSimulateur_Click);
            // 
            // panelSimulateur
            // 
            this.panelSimulateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelSimulateur.Controls.Add(this.buttonDeleteSimulateur);
            this.panelSimulateur.Controls.Add(this.dataGridViewResultat);
            this.panelSimulateur.Location = new System.Drawing.Point(12, 171);
            this.panelSimulateur.Name = "panelSimulateur";
            this.panelSimulateur.Size = new System.Drawing.Size(1610, 589);
            this.panelSimulateur.TabIndex = 2;
            // 
            // dataGridViewResultat
            // 
            this.dataGridViewResultat.AllowUserToAddRows = false;
            this.dataGridViewResultat.AllowUserToDeleteRows = false;
            this.dataGridViewResultat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewResultat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTirage,
            this.dateTirage,
            this.prixTirage,
            this.miseTotal,
            this.nombreParieur,
            this.resultatTirage,
            this.sixNum,
            this.cinqNum,
            this.quatreNum,
            this.troisNum,
            this.deuxNum,
            this.rangUn,
            this.rangDeux,
            this.rangTrois,
            this.rangQuatre,
            this.RangCinq});
            this.dataGridViewResultat.Location = new System.Drawing.Point(13, 18);
            this.dataGridViewResultat.Name = "dataGridViewResultat";
            this.dataGridViewResultat.ReadOnly = true;
            this.dataGridViewResultat.RowTemplate.Height = 25;
            this.dataGridViewResultat.Size = new System.Drawing.Size(1584, 486);
            this.dataGridViewResultat.TabIndex = 4;
            // 
            // idTirage
            // 
            this.idTirage.HeaderText = "ID";
            this.idTirage.Name = "idTirage";
            this.idTirage.ReadOnly = true;
            this.idTirage.Width = 40;
            // 
            // dateTirage
            // 
            this.dateTirage.HeaderText = "Date du Tirage";
            this.dateTirage.Name = "dateTirage";
            this.dateTirage.ReadOnly = true;
            this.dateTirage.Width = 120;
            // 
            // prixTirage
            // 
            this.prixTirage.HeaderText = "Prix du Tirage";
            this.prixTirage.Name = "prixTirage";
            this.prixTirage.ReadOnly = true;
            this.prixTirage.Width = 80;
            // 
            // miseTotal
            // 
            this.miseTotal.HeaderText = "Mise Total";
            this.miseTotal.Name = "miseTotal";
            this.miseTotal.ReadOnly = true;
            // 
            // nombreParieur
            // 
            this.nombreParieur.HeaderText = "Nombre Parieur";
            this.nombreParieur.Name = "nombreParieur";
            this.nombreParieur.ReadOnly = true;
            // 
            // resultatTirage
            // 
            this.resultatTirage.HeaderText = "Resultat Tirage";
            this.resultatTirage.Name = "resultatTirage";
            this.resultatTirage.ReadOnly = true;
            // 
            // sixNum
            // 
            this.sixNum.HeaderText = "6 Nb trouvés";
            this.sixNum.Name = "sixNum";
            this.sixNum.ReadOnly = true;
            // 
            // cinqNum
            // 
            this.cinqNum.HeaderText = "5 Nb trouvés";
            this.cinqNum.Name = "cinqNum";
            this.cinqNum.ReadOnly = true;
            // 
            // quatreNum
            // 
            this.quatreNum.HeaderText = "4 Nb trouvés";
            this.quatreNum.Name = "quatreNum";
            this.quatreNum.ReadOnly = true;
            // 
            // troisNum
            // 
            this.troisNum.HeaderText = "3 Nb trouvés";
            this.troisNum.Name = "troisNum";
            this.troisNum.ReadOnly = true;
            // 
            // deuxNum
            // 
            this.deuxNum.HeaderText = "2 Nb trouvés";
            this.deuxNum.Name = "deuxNum";
            this.deuxNum.ReadOnly = true;
            // 
            // rangUn
            // 
            this.rangUn.HeaderText = "Rang Un par gagnant";
            this.rangUn.Name = "rangUn";
            this.rangUn.ReadOnly = true;
            // 
            // rangDeux
            // 
            this.rangDeux.HeaderText = "Rang Deux par gagnant";
            this.rangDeux.Name = "rangDeux";
            this.rangDeux.ReadOnly = true;
            // 
            // rangTrois
            // 
            this.rangTrois.HeaderText = "Rang Trois par gagnant";
            this.rangTrois.Name = "rangTrois";
            this.rangTrois.ReadOnly = true;
            // 
            // rangQuatre
            // 
            this.rangQuatre.HeaderText = "Rang Quatre par gagnant";
            this.rangQuatre.Name = "rangQuatre";
            this.rangQuatre.ReadOnly = true;
            // 
            // RangCinq
            // 
            this.RangCinq.HeaderText = "Rang Cinq par gagnant";
            this.RangCinq.Name = "RangCinq";
            this.RangCinq.ReadOnly = true;
            // 
            // buttonLive
            // 
            this.buttonLive.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonLive.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLive.Location = new System.Drawing.Point(1436, 120);
            this.buttonLive.Name = "buttonLive";
            this.buttonLive.Size = new System.Drawing.Size(186, 52);
            this.buttonLive.TabIndex = 1;
            this.buttonLive.Text = "Tirage Live";
            this.buttonLive.UseVisualStyleBackColor = false;
            this.buttonLive.Click += new System.EventHandler(this.buttonLive_Click);
            // 
            // panelLive
            // 
            this.panelLive.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelLive.Controls.Add(this.buttonDeleteLive);
            this.panelLive.Controls.Add(this.dataGridViewLive);
            this.panelLive.Location = new System.Drawing.Point(12, 171);
            this.panelLive.Name = "panelLive";
            this.panelLive.Size = new System.Drawing.Size(1610, 589);
            this.panelLive.TabIndex = 5;
            // 
            // buttonDeleteLive
            // 
            this.buttonDeleteLive.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteLive.Location = new System.Drawing.Point(1315, 523);
            this.buttonDeleteLive.Name = "buttonDeleteLive";
            this.buttonDeleteLive.Size = new System.Drawing.Size(234, 53);
            this.buttonDeleteLive.TabIndex = 5;
            this.buttonDeleteLive.Text = "Supprimer les tirages";
            this.buttonDeleteLive.UseVisualStyleBackColor = true;
            this.buttonDeleteLive.Click += new System.EventHandler(this.buttonDeleteLive_Click);
            // 
            // dataGridViewLive
            // 
            this.dataGridViewLive.AllowUserToAddRows = false;
            this.dataGridViewLive.AllowUserToDeleteRows = false;
            this.dataGridViewLive.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridViewLive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.userName,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.joueurNum,
            this.gainJoueur,
            this.cmbJoueur,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dataGridViewLive.Location = new System.Drawing.Point(48, 18);
            this.dataGridViewLive.Name = "dataGridViewLive";
            this.dataGridViewLive.ReadOnly = true;
            this.dataGridViewLive.RowTemplate.Height = 25;
            this.dataGridViewLive.Size = new System.Drawing.Size(1513, 486);
            this.dataGridViewLive.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // userName
            // 
            this.userName.HeaderText = "Nom Joueur";
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Date du Tirage";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Prix du Tirage";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Mise Total";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Nombre Parieur";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Resultat Tirage";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // joueurNum
            // 
            this.joueurNum.HeaderText = "Numéro joueur";
            this.joueurNum.Name = "joueurNum";
            this.joueurNum.ReadOnly = true;
            // 
            // gainJoueur
            // 
            this.gainJoueur.HeaderText = "Gain Joueur";
            this.gainJoueur.Name = "gainJoueur";
            this.gainJoueur.ReadOnly = true;
            // 
            // cmbJoueur
            // 
            this.cmbJoueur.HeaderText = "Numéro trouvé Joueur";
            this.cmbJoueur.Name = "cmbJoueur";
            this.cmbJoueur.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "6 Nb trouvés";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "5 Nb trouvés";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "4 Nb trouvés";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "3 Nb trouvés";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "2 Nb trouvés";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // buttonDeleteSimulateur
            // 
            this.buttonDeleteSimulateur.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteSimulateur.Location = new System.Drawing.Point(27, 520);
            this.buttonDeleteSimulateur.Name = "buttonDeleteSimulateur";
            this.buttonDeleteSimulateur.Size = new System.Drawing.Size(234, 53);
            this.buttonDeleteSimulateur.TabIndex = 5;
            this.buttonDeleteSimulateur.Text = "Supprimer les tirages";
            this.buttonDeleteSimulateur.UseVisualStyleBackColor = true;
            this.buttonDeleteSimulateur.Click += new System.EventHandler(this.buttonDeleteSimulateur_Click);
            // 
            // resultat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 815);
            this.Controls.Add(this.panelSimulateur);
            this.Controls.Add(this.panelLive);
            this.Controls.Add(this.buttonLive);
            this.Controls.Add(this.buttonSimulateur);
            this.Controls.Add(this.label1);
            this.Name = "resultat";
            this.Text = "statistique";
            this.panelSimulateur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultat)).EndInit();
            this.panelLive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSimulateur;
        private System.Windows.Forms.Panel panelSimulateur;
        private System.Windows.Forms.Button buttonLive;
        private System.Windows.Forms.DataGridView dataGridViewResultat;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTirage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTirage;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixTirage;
        private System.Windows.Forms.DataGridViewTextBoxColumn miseTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreParieur;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultatTirage;
        private System.Windows.Forms.DataGridViewTextBoxColumn sixNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinqNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn quatreNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn troisNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn deuxNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangUn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangDeux;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangTrois;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangQuatre;
        private System.Windows.Forms.DataGridViewTextBoxColumn RangCinq;
        private System.Windows.Forms.Panel panelLive;
        private System.Windows.Forms.DataGridView dataGridViewLive;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn joueurNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn gainJoueur;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbJoueur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button buttonDeleteLive;
        private System.Windows.Forms.Button buttonDeleteSimulateur;
    }
}