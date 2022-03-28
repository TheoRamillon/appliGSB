﻿
namespace GSB
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.mspMenu = new System.Windows.Forms.MenuStrip();
            this.créationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directeurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visiteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.régionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesInformationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationRégionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AjoutEvaluationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbConnexionUtilisateur = new System.Windows.Forms.GroupBox();
            this.llbSansConnexion = new System.Windows.Forms.LinkLabel();
            this.lblCapLock = new System.Windows.Forms.Label();
            this.btnConnexionUtilisateur = new System.Windows.Forms.Button();
            this.txtConnexionNomUtilisateur = new System.Windows.Forms.TextBox();
            this.txtConnexionMotDePasse = new System.Windows.Forms.TextBox();
            this.lblConnexionMotDePasse = new System.Windows.Forms.Label();
            this.lblConnexionNomUtilisateur = new System.Windows.Forms.Label();
            this.lblSecteurVisiteur = new System.Windows.Forms.Label();
            this.lblDirecteurVisiteur = new System.Windows.Forms.Label();
            this.visiteurToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mspMenu.SuspendLayout();
            this.gpbConnexionUtilisateur.SuspendLayout();
            this.SuspendLayout();
            // 
            // mspMenu
            // 
            this.mspMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créationToolStripMenuItem,
            this.informationsToolStripMenuItem,
            this.deconnexionToolStripMenuItem,
            this.AjoutEvaluationToolStripMenuItem});
            this.mspMenu.Location = new System.Drawing.Point(0, 0);
            this.mspMenu.Name = "mspMenu";
            this.mspMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mspMenu.Size = new System.Drawing.Size(1000, 33);
            this.mspMenu.TabIndex = 1;
            this.mspMenu.Text = "menuStrip1";
            this.mspMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mspMenu_ItemClicked_1);
            // 
            // créationToolStripMenuItem
            // 
            this.créationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.directeurToolStripMenuItem,
            this.drhToolStripMenuItem,
            this.visiteurToolStripMenuItem,
            this.régionToolStripMenuItem,
            this.secteurToolStripMenuItem});
            this.créationToolStripMenuItem.Name = "créationToolStripMenuItem";
            this.créationToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.créationToolStripMenuItem.Text = "Création";
            this.créationToolStripMenuItem.Click += new System.EventHandler(this.créationToolStripMenuItem_Click);
            // 
            // directeurToolStripMenuItem
            // 
            this.directeurToolStripMenuItem.Name = "directeurToolStripMenuItem";
            this.directeurToolStripMenuItem.Size = new System.Drawing.Size(185, 34);
            this.directeurToolStripMenuItem.Text = "Directeur";
            this.directeurToolStripMenuItem.Click += new System.EventHandler(this.directeurToolStripMenuItem_Click);
            // 
            // drhToolStripMenuItem
            // 
            this.drhToolStripMenuItem.Name = "drhToolStripMenuItem";
            this.drhToolStripMenuItem.Size = new System.Drawing.Size(185, 34);
            this.drhToolStripMenuItem.Text = "DRH";
            this.drhToolStripMenuItem.Click += new System.EventHandler(this.responsableToolStripMenuItem_Click);
            // 
            // visiteurToolStripMenuItem
            // 
            this.visiteurToolStripMenuItem.Name = "visiteurToolStripMenuItem";
            this.visiteurToolStripMenuItem.Size = new System.Drawing.Size(185, 34);
            this.visiteurToolStripMenuItem.Text = "Visiteur";
            this.visiteurToolStripMenuItem.Click += new System.EventHandler(this.visiteurToolStripMenuItem_Click);
            // 
            // régionToolStripMenuItem
            // 
            this.régionToolStripMenuItem.Name = "régionToolStripMenuItem";
            this.régionToolStripMenuItem.Size = new System.Drawing.Size(185, 34);
            this.régionToolStripMenuItem.Text = "Région";
            this.régionToolStripMenuItem.Click += new System.EventHandler(this.régionToolStripMenuItem_Click);
            // 
            // secteurToolStripMenuItem
            // 
            this.secteurToolStripMenuItem.Name = "secteurToolStripMenuItem";
            this.secteurToolStripMenuItem.Size = new System.Drawing.Size(185, 34);
            this.secteurToolStripMenuItem.Text = "Secteur";
            this.secteurToolStripMenuItem.Click += new System.EventHandler(this.secteurToolStripMenuItem_Click);
            // 
            // informationsToolStripMenuItem
            // 
            this.informationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesInformationsToolStripMenuItem,
            this.informationRégionToolStripMenuItem});
            this.informationsToolStripMenuItem.Name = "informationsToolStripMenuItem";
            this.informationsToolStripMenuItem.Size = new System.Drawing.Size(130, 29);
            this.informationsToolStripMenuItem.Text = "Informations";
            // 
            // mesInformationsToolStripMenuItem
            // 
            this.mesInformationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visiteurToolStripMenuItem1});
            this.mesInformationsToolStripMenuItem.Name = "mesInformationsToolStripMenuItem";
            this.mesInformationsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.mesInformationsToolStripMenuItem.Text = "Mes Informations";
            this.mesInformationsToolStripMenuItem.Click += new System.EventHandler(this.mesInformationsToolStripMenuItem_Click);
            // 
            // informationRégionToolStripMenuItem
            // 
            this.informationRégionToolStripMenuItem.Name = "informationRégionToolStripMenuItem";
            this.informationRégionToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.informationRégionToolStripMenuItem.Text = "Information Région";
            this.informationRégionToolStripMenuItem.Click += new System.EventHandler(this.informationRégionToolStripMenuItem_Click);
            // 
            // deconnexionToolStripMenuItem
            // 
            this.deconnexionToolStripMenuItem.Name = "deconnexionToolStripMenuItem";
            this.deconnexionToolStripMenuItem.Size = new System.Drawing.Size(131, 29);
            this.deconnexionToolStripMenuItem.Text = "Deconnexion";
            this.deconnexionToolStripMenuItem.Click += new System.EventHandler(this.deconnexionToolStripMenuItem_Click_1);
            // 
            // AjoutEvaluationToolStripMenuItem
            // 
            this.AjoutEvaluationToolStripMenuItem.Name = "AjoutEvaluationToolStripMenuItem";
            this.AjoutEvaluationToolStripMenuItem.Size = new System.Drawing.Size(206, 29);
            this.AjoutEvaluationToolStripMenuItem.Text = "Ajouter une evaluation";
            this.AjoutEvaluationToolStripMenuItem.Click += new System.EventHandler(this.AjoutEvaluationToolStripMenuItem_Click);
            // 
            // gpbConnexionUtilisateur
            // 
            this.gpbConnexionUtilisateur.BackColor = System.Drawing.Color.Transparent;
            this.gpbConnexionUtilisateur.Controls.Add(this.llbSansConnexion);
            this.gpbConnexionUtilisateur.Controls.Add(this.lblCapLock);
            this.gpbConnexionUtilisateur.Controls.Add(this.btnConnexionUtilisateur);
            this.gpbConnexionUtilisateur.Controls.Add(this.txtConnexionNomUtilisateur);
            this.gpbConnexionUtilisateur.Controls.Add(this.txtConnexionMotDePasse);
            this.gpbConnexionUtilisateur.Controls.Add(this.lblConnexionMotDePasse);
            this.gpbConnexionUtilisateur.Controls.Add(this.lblConnexionNomUtilisateur);
            this.gpbConnexionUtilisateur.Location = new System.Drawing.Point(240, 84);
            this.gpbConnexionUtilisateur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbConnexionUtilisateur.Name = "gpbConnexionUtilisateur";
            this.gpbConnexionUtilisateur.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbConnexionUtilisateur.Size = new System.Drawing.Size(520, 396);
            this.gpbConnexionUtilisateur.TabIndex = 7;
            this.gpbConnexionUtilisateur.TabStop = false;
            // 
            // llbSansConnexion
            // 
            this.llbSansConnexion.AutoSize = true;
            this.llbSansConnexion.Location = new System.Drawing.Point(136, 350);
            this.llbSansConnexion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbSansConnexion.Name = "llbSansConnexion";
            this.llbSansConnexion.Size = new System.Drawing.Size(238, 25);
            this.llbSansConnexion.TabIndex = 9;
            this.llbSansConnexion.TabStop = true;
            this.llbSansConnexion.Text = "(Connexion en tant qu\'invité)";
            this.llbSansConnexion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbSansConnexion_LinkClicked);
            // 
            // lblCapLock
            // 
            this.lblCapLock.AutoSize = true;
            this.lblCapLock.BackColor = System.Drawing.Color.Transparent;
            this.lblCapLock.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCapLock.ForeColor = System.Drawing.Color.Black;
            this.lblCapLock.Location = new System.Drawing.Point(116, 229);
            this.lblCapLock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapLock.Name = "lblCapLock";
            this.lblCapLock.Size = new System.Drawing.Size(0, 41);
            this.lblCapLock.TabIndex = 8;
            // 
            // btnConnexionUtilisateur
            // 
            this.btnConnexionUtilisateur.BackColor = System.Drawing.Color.Black;
            this.btnConnexionUtilisateur.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConnexionUtilisateur.FlatAppearance.BorderSize = 0;
            this.btnConnexionUtilisateur.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConnexionUtilisateur.ForeColor = System.Drawing.Color.White;
            this.btnConnexionUtilisateur.Location = new System.Drawing.Point(168, 252);
            this.btnConnexionUtilisateur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConnexionUtilisateur.Name = "btnConnexionUtilisateur";
            this.btnConnexionUtilisateur.Size = new System.Drawing.Size(186, 80);
            this.btnConnexionUtilisateur.TabIndex = 4;
            this.btnConnexionUtilisateur.Text = "Connexion";
            this.btnConnexionUtilisateur.UseVisualStyleBackColor = false;
            this.btnConnexionUtilisateur.Click += new System.EventHandler(this.btnConnexionUtilisateur_Click);
            // 
            // txtConnexionNomUtilisateur
            // 
            this.txtConnexionNomUtilisateur.BackColor = System.Drawing.SystemColors.Window;
            this.txtConnexionNomUtilisateur.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConnexionNomUtilisateur.Location = new System.Drawing.Point(281, 52);
            this.txtConnexionNomUtilisateur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConnexionNomUtilisateur.Name = "txtConnexionNomUtilisateur";
            this.txtConnexionNomUtilisateur.Size = new System.Drawing.Size(196, 47);
            this.txtConnexionNomUtilisateur.TabIndex = 1;
            // 
            // txtConnexionMotDePasse
            // 
            this.txtConnexionMotDePasse.BackColor = System.Drawing.SystemColors.Window;
            this.txtConnexionMotDePasse.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConnexionMotDePasse.Location = new System.Drawing.Point(281, 130);
            this.txtConnexionMotDePasse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConnexionMotDePasse.Name = "txtConnexionMotDePasse";
            this.txtConnexionMotDePasse.Size = new System.Drawing.Size(196, 47);
            this.txtConnexionMotDePasse.TabIndex = 3;
            // 
            // lblConnexionMotDePasse
            // 
            this.lblConnexionMotDePasse.AutoSize = true;
            this.lblConnexionMotDePasse.BackColor = System.Drawing.Color.Transparent;
            this.lblConnexionMotDePasse.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConnexionMotDePasse.ForeColor = System.Drawing.Color.Black;
            this.lblConnexionMotDePasse.Location = new System.Drawing.Point(59, 131);
            this.lblConnexionMotDePasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConnexionMotDePasse.Name = "lblConnexionMotDePasse";
            this.lblConnexionMotDePasse.Size = new System.Drawing.Size(213, 41);
            this.lblConnexionMotDePasse.TabIndex = 2;
            this.lblConnexionMotDePasse.Text = "Mot de passe :";
            // 
            // lblConnexionNomUtilisateur
            // 
            this.lblConnexionNomUtilisateur.AutoSize = true;
            this.lblConnexionNomUtilisateur.BackColor = System.Drawing.Color.Transparent;
            this.lblConnexionNomUtilisateur.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConnexionNomUtilisateur.ForeColor = System.Drawing.Color.Black;
            this.lblConnexionNomUtilisateur.Location = new System.Drawing.Point(9, 59);
            this.lblConnexionNomUtilisateur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConnexionNomUtilisateur.Name = "lblConnexionNomUtilisateur";
            this.lblConnexionNomUtilisateur.Size = new System.Drawing.Size(261, 41);
            this.lblConnexionNomUtilisateur.TabIndex = 0;
            this.lblConnexionNomUtilisateur.Text = "Nom d\'utilisateur :";
            // 
            // lblSecteurVisiteur
            // 
            this.lblSecteurVisiteur.AutoSize = true;
            this.lblSecteurVisiteur.BackColor = System.Drawing.Color.Transparent;
            this.lblSecteurVisiteur.Location = new System.Drawing.Point(15, 48);
            this.lblSecteurVisiteur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecteurVisiteur.Name = "lblSecteurVisiteur";
            this.lblSecteurVisiteur.Size = new System.Drawing.Size(0, 25);
            this.lblSecteurVisiteur.TabIndex = 9;
            // 
            // lblDirecteurVisiteur
            // 
            this.lblDirecteurVisiteur.AutoSize = true;
            this.lblDirecteurVisiteur.BackColor = System.Drawing.Color.Transparent;
            this.lblDirecteurVisiteur.Location = new System.Drawing.Point(15, 84);
            this.lblDirecteurVisiteur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDirecteurVisiteur.Name = "lblDirecteurVisiteur";
            this.lblDirecteurVisiteur.Size = new System.Drawing.Size(0, 25);
            this.lblDirecteurVisiteur.TabIndex = 10;
            // 
            // visiteurToolStripMenuItem1
            // 
            this.visiteurToolStripMenuItem1.Name = "visiteurToolStripMenuItem1";
            this.visiteurToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.visiteurToolStripMenuItem1.Text = "Visiteur";
            this.visiteurToolStripMenuItem1.Click += new System.EventHandler(this.visiteurToolStripMenuItem1_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.lblDirecteurVisiteur);
            this.Controls.Add(this.lblSecteurVisiteur);
            this.Controls.Add(this.gpbConnexionUtilisateur);
            this.Controls.Add(this.mspMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mspMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            this.mspMenu.ResumeLayout(false);
            this.mspMenu.PerformLayout();
            this.gpbConnexionUtilisateur.ResumeLayout(false);
            this.gpbConnexionUtilisateur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mspMenu;
        private System.Windows.Forms.GroupBox gpbConnexionUtilisateur;
        private System.Windows.Forms.Label lblCapLock;
        private System.Windows.Forms.Button btnConnexionUtilisateur;
        private System.Windows.Forms.TextBox txtConnexionNomUtilisateur;
        private System.Windows.Forms.TextBox txtConnexionMotDePasse;
        private System.Windows.Forms.Label lblConnexionMotDePasse;
        private System.Windows.Forms.Label lblConnexionNomUtilisateur;
        private System.Windows.Forms.ToolStripMenuItem créationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directeurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visiteurToolStripMenuItem;
        private System.Windows.Forms.Label lblSecteurVisiteur;
        private System.Windows.Forms.Label lblDirecteurVisiteur;
        private System.Windows.Forms.ToolStripMenuItem informationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesInformationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AjoutEvaluationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationRégionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem régionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secteurToolStripMenuItem;
        private System.Windows.Forms.LinkLabel llbSansConnexion;
        private System.Windows.Forms.ToolStripMenuItem visiteurToolStripMenuItem1;
    }
}