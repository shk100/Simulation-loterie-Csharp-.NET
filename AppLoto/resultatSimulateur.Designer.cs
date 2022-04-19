
namespace AppLoto
{
    partial class resultatSimulateur
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewResultat = new System.Windows.Forms.DataGridView();
            this.dateTirage = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultat)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(580, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "Résultat du simulateur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 2;
            // 
            // dataGridViewResultat
            // 
            this.dataGridViewResultat.AllowUserToAddRows = false;
            this.dataGridViewResultat.AllowUserToDeleteRows = false;
            this.dataGridViewResultat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewResultat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateTirage,
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
            this.dataGridViewResultat.Location = new System.Drawing.Point(28, 23);
            this.dataGridViewResultat.Name = "dataGridViewResultat";
            this.dataGridViewResultat.ReadOnly = true;
            this.dataGridViewResultat.RowTemplate.Height = 25;
            this.dataGridViewResultat.Size = new System.Drawing.Size(1463, 482);
            this.dataGridViewResultat.TabIndex = 3;
            // 
            // dateTirage
            // 
            this.dateTirage.HeaderText = "Date du Tirage";
            this.dateTirage.Name = "dateTirage";
            this.dateTirage.ReadOnly = true;
            this.dateTirage.Width = 120;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridViewResultat);
            this.panel1.Location = new System.Drawing.Point(24, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1520, 634);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1221, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Refaire une simulation";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultatSimulateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1566, 764);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "resultatSimulateur";
            this.Text = "resultatSimulateur";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewResultat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTirage;
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
    }
}