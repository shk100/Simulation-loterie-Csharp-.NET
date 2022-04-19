
namespace AppLoto
{
    partial class Accueil
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonCaché = new System.Windows.Forms.Button();
            this.buttonHistorique = new System.Windows.Forms.Button();
            this.buttonSimulateur = new System.Windows.Forms.Button();
            this.liveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelCurrentUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.buttonCaché);
            this.panel1.Controls.Add(this.buttonHistorique);
            this.panel1.Controls.Add(this.buttonSimulateur);
            this.panel1.Controls.Add(this.liveButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.labelCurrentUser);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 654);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AppLoto.Properties.Resources.eeeeeee;
            this.pictureBox2.Location = new System.Drawing.Point(55, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // buttonCaché
            // 
            this.buttonCaché.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCaché.Location = new System.Drawing.Point(-9, 610);
            this.buttonCaché.Name = "buttonCaché";
            this.buttonCaché.Size = new System.Drawing.Size(254, 41);
            this.buttonCaché.TabIndex = 1;
            this.buttonCaché.Text = ".";
            this.buttonCaché.UseVisualStyleBackColor = true;
            this.buttonCaché.Click += new System.EventHandler(this.buttonCaché_Click);
            // 
            // buttonHistorique
            // 
            this.buttonHistorique.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHistorique.Location = new System.Drawing.Point(-9, 435);
            this.buttonHistorique.Name = "buttonHistorique";
            this.buttonHistorique.Size = new System.Drawing.Size(254, 69);
            this.buttonHistorique.TabIndex = 1;
            this.buttonHistorique.Text = "Historique";
            this.buttonHistorique.UseVisualStyleBackColor = true;
            this.buttonHistorique.Click += new System.EventHandler(this.buttonHistorique_Click);
            // 
            // buttonSimulateur
            // 
            this.buttonSimulateur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSimulateur.Location = new System.Drawing.Point(-9, 357);
            this.buttonSimulateur.Name = "buttonSimulateur";
            this.buttonSimulateur.Size = new System.Drawing.Size(254, 69);
            this.buttonSimulateur.TabIndex = 1;
            this.buttonSimulateur.Text = "Simulateur de paris";
            this.buttonSimulateur.UseVisualStyleBackColor = true;
            this.buttonSimulateur.Click += new System.EventHandler(this.buttonSimulateur_Click);
            // 
            // liveButton
            // 
            this.liveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.liveButton.Location = new System.Drawing.Point(-9, 280);
            this.liveButton.Name = "liveButton";
            this.liveButton.Size = new System.Drawing.Size(254, 69);
            this.liveButton.TabIndex = 1;
            this.liveButton.Text = "Jouer en live";
            this.liveButton.UseVisualStyleBackColor = true;
            this.liveButton.Click += new System.EventHandler(this.liveButton_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(-9, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 69);
            this.button1.TabIndex = 1;
            this.button1.Text = "Accueil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCurrentUser
            // 
            this.labelCurrentUser.AutoSize = true;
            this.labelCurrentUser.Location = new System.Drawing.Point(99, 154);
            this.labelCurrentUser.Name = "labelCurrentUser";
            this.labelCurrentUser.Size = new System.Drawing.Size(29, 15);
            this.labelCurrentUser.TabIndex = 0;
            this.labelCurrentUser.Text = "user";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppLoto.Properties.Resources.fond_app;
            this.pictureBox1.Location = new System.Drawing.Point(242, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(943, 654);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 654);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Accueil";
            this.Text = "Giga Loto App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Accueil_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCurrentUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSimulateur;
        private System.Windows.Forms.Button liveButton;
        private System.Windows.Forms.Button buttonHistorique;
        private System.Windows.Forms.Button buttonCaché;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}