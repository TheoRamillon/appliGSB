
namespace GSB
{
    partial class frmMenu
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
            this.mspMenu = new System.Windows.Forms.MenuStrip();
            this.créationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directeurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visiteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.régionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationsVisiteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationsDirecteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationsSecteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationsRegionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AjoutEvaluationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directeurToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.visiteurToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.AjoutEvaluationToolStripMenuItem,
            this.employéToolStripMenuItem});
            this.mspMenu.Location = new System.Drawing.Point(0, 0);
            this.mspMenu.Name = "mspMenu";
            this.mspMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mspMenu.Size = new System.Drawing.Size(700, 24);
            this.mspMenu.TabIndex = 1;
            this.mspMenu.Text = "menuStrip1";
            // 
            // créationToolStripMenuItem
            // 
            this.créationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.directeurToolStripMenuItem,
            this.visiteurToolStripMenuItem,
            this.régionToolStripMenuItem,
            this.secteurToolStripMenuItem});
            this.créationToolStripMenuItem.Name = "créationToolStripMenuItem";
            this.créationToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.créationToolStripMenuItem.Text = "Création";
            this.créationToolStripMenuItem.Click += new System.EventHandler(this.créationToolStripMenuItem_Click);
            // 
            // directeurToolStripMenuItem
            // 
            this.directeurToolStripMenuItem.Name = "directeurToolStripMenuItem";
            this.directeurToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.directeurToolStripMenuItem.Text = "Directeur";
            this.directeurToolStripMenuItem.Click += new System.EventHandler(this.directeurToolStripMenuItem_Click);
            // 
            // visiteurToolStripMenuItem
            // 
            this.visiteurToolStripMenuItem.Name = "visiteurToolStripMenuItem";
            this.visiteurToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.visiteurToolStripMenuItem.Text = "Visiteur";
            this.visiteurToolStripMenuItem.Click += new System.EventHandler(this.visiteurToolStripMenuItem_Click);
            // 
            // régionToolStripMenuItem
            // 
            this.régionToolStripMenuItem.Name = "régionToolStripMenuItem";
            this.régionToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.régionToolStripMenuItem.Text = "Région";
            this.régionToolStripMenuItem.Click += new System.EventHandler(this.régionToolStripMenuItem_Click);
            // 
            // secteurToolStripMenuItem
            // 
            this.secteurToolStripMenuItem.Name = "secteurToolStripMenuItem";
            this.secteurToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.secteurToolStripMenuItem.Text = "Secteur";
            this.secteurToolStripMenuItem.Click += new System.EventHandler(this.secteurToolStripMenuItem_Click);
            // 
            // informationsToolStripMenuItem
            // 
            this.informationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationsVisiteursToolStripMenuItem,
            this.informationsDirecteursToolStripMenuItem,
            this.informationsSecteursToolStripMenuItem,
            this.informationsRegionsToolStripMenuItem});
            this.informationsToolStripMenuItem.Name = "informationsToolStripMenuItem";
            this.informationsToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.informationsToolStripMenuItem.Text = "Informations";
            // 
            // informationsVisiteursToolStripMenuItem
            // 
            this.informationsVisiteursToolStripMenuItem.Name = "informationsVisiteursToolStripMenuItem";
            this.informationsVisiteursToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.informationsVisiteursToolStripMenuItem.Text = "Informations Visiteur";
            this.informationsVisiteursToolStripMenuItem.Click += new System.EventHandler(this.informationsVisiteursToolStripMenuItem_Click);
            // 
            // informationsDirecteursToolStripMenuItem
            // 
            this.informationsDirecteursToolStripMenuItem.Name = "informationsDirecteursToolStripMenuItem";
            this.informationsDirecteursToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.informationsDirecteursToolStripMenuItem.Text = "Information Directeur";
            this.informationsDirecteursToolStripMenuItem.Click += new System.EventHandler(this.informationsDirecteursToolStripMenuItem_Click);
            // 
            // informationsSecteursToolStripMenuItem
            // 
            this.informationsSecteursToolStripMenuItem.Name = "informationsSecteursToolStripMenuItem";
            this.informationsSecteursToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.informationsSecteursToolStripMenuItem.Text = "Information Secteur";
            this.informationsSecteursToolStripMenuItem.Click += new System.EventHandler(this.informationsSecteursToolStripMenuItem_Click);
            // 
            // informationsRegionsToolStripMenuItem
            // 
            this.informationsRegionsToolStripMenuItem.Name = "informationsRegionsToolStripMenuItem";
            this.informationsRegionsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.informationsRegionsToolStripMenuItem.Text = "Information Region";
            this.informationsRegionsToolStripMenuItem.Click += new System.EventHandler(this.informationsRegionsToolStripMenuItem_Click);
            // 
            // deconnexionToolStripMenuItem
            // 
            this.deconnexionToolStripMenuItem.Name = "deconnexionToolStripMenuItem";
            this.deconnexionToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.deconnexionToolStripMenuItem.Text = "Deconnexion";
            this.deconnexionToolStripMenuItem.Click += new System.EventHandler(this.deconnexionToolStripMenuItem_Click_1);
            // 
            // AjoutEvaluationToolStripMenuItem
            // 
            this.AjoutEvaluationToolStripMenuItem.Name = "AjoutEvaluationToolStripMenuItem";
            this.AjoutEvaluationToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.AjoutEvaluationToolStripMenuItem.Text = "Ajouter une evaluation";
            this.AjoutEvaluationToolStripMenuItem.Click += new System.EventHandler(this.AjoutEvaluationToolStripMenuItem_Click);
            // 
            // employéToolStripMenuItem
            // 
            this.employéToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.directeurToolStripMenuItem1,
            this.visiteurToolStripMenuItem1});
            this.employéToolStripMenuItem.Name = "employéToolStripMenuItem";
            this.employéToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.employéToolStripMenuItem.Text = "Employé";
            // 
            // directeurToolStripMenuItem1
            // 
            this.directeurToolStripMenuItem1.Name = "directeurToolStripMenuItem1";
            this.directeurToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.directeurToolStripMenuItem1.Text = "Directeur";
            this.directeurToolStripMenuItem1.Click += new System.EventHandler(this.directeurToolStripMenuItem1_Click);
            // 
            // visiteurToolStripMenuItem1
            // 
            this.visiteurToolStripMenuItem1.Name = "visiteurToolStripMenuItem1";
            this.visiteurToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.visiteurToolStripMenuItem1.Text = "Visiteur";
            this.visiteurToolStripMenuItem1.Click += new System.EventHandler(this.visiteurToolStripMenuItem1_Click);
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
            this.gpbConnexionUtilisateur.Location = new System.Drawing.Point(168, 50);
            this.gpbConnexionUtilisateur.Name = "gpbConnexionUtilisateur";
            this.gpbConnexionUtilisateur.Size = new System.Drawing.Size(364, 238);
            this.gpbConnexionUtilisateur.TabIndex = 7;
            this.gpbConnexionUtilisateur.TabStop = false;
            // 
            // llbSansConnexion
            // 
            this.llbSansConnexion.AutoSize = true;
            this.llbSansConnexion.Location = new System.Drawing.Point(95, 210);
            this.llbSansConnexion.Name = "llbSansConnexion";
            this.llbSansConnexion.Size = new System.Drawing.Size(162, 15);
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
            this.lblCapLock.Location = new System.Drawing.Point(81, 137);
            this.lblCapLock.Name = "lblCapLock";
            this.lblCapLock.Size = new System.Drawing.Size(0, 28);
            this.lblCapLock.TabIndex = 8;
            // 
            // btnConnexionUtilisateur
            // 
            this.btnConnexionUtilisateur.BackColor = System.Drawing.Color.Black;
            this.btnConnexionUtilisateur.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConnexionUtilisateur.FlatAppearance.BorderSize = 0;
            this.btnConnexionUtilisateur.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConnexionUtilisateur.ForeColor = System.Drawing.Color.White;
            this.btnConnexionUtilisateur.Location = new System.Drawing.Point(117, 152);
            this.btnConnexionUtilisateur.Name = "btnConnexionUtilisateur";
            this.btnConnexionUtilisateur.Size = new System.Drawing.Size(130, 48);
            this.btnConnexionUtilisateur.TabIndex = 4;
            this.btnConnexionUtilisateur.Text = "Connexion";
            this.btnConnexionUtilisateur.UseVisualStyleBackColor = false;
            this.btnConnexionUtilisateur.Click += new System.EventHandler(this.btnConnexionUtilisateur_Click);
            // 
            // txtConnexionNomUtilisateur
            // 
            this.txtConnexionNomUtilisateur.BackColor = System.Drawing.SystemColors.Window;
            this.txtConnexionNomUtilisateur.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConnexionNomUtilisateur.Location = new System.Drawing.Point(197, 32);
            this.txtConnexionNomUtilisateur.Name = "txtConnexionNomUtilisateur";
            this.txtConnexionNomUtilisateur.Size = new System.Drawing.Size(139, 34);
            this.txtConnexionNomUtilisateur.TabIndex = 1;
            // 
            // txtConnexionMotDePasse
            // 
            this.txtConnexionMotDePasse.BackColor = System.Drawing.SystemColors.Window;
            this.txtConnexionMotDePasse.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConnexionMotDePasse.Location = new System.Drawing.Point(197, 78);
            this.txtConnexionMotDePasse.Name = "txtConnexionMotDePasse";
            this.txtConnexionMotDePasse.Size = new System.Drawing.Size(139, 34);
            this.txtConnexionMotDePasse.TabIndex = 3;
            // 
            // lblConnexionMotDePasse
            // 
            this.lblConnexionMotDePasse.AutoSize = true;
            this.lblConnexionMotDePasse.BackColor = System.Drawing.Color.Transparent;
            this.lblConnexionMotDePasse.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConnexionMotDePasse.ForeColor = System.Drawing.Color.Black;
            this.lblConnexionMotDePasse.Location = new System.Drawing.Point(41, 79);
            this.lblConnexionMotDePasse.Name = "lblConnexionMotDePasse";
            this.lblConnexionMotDePasse.Size = new System.Drawing.Size(138, 28);
            this.lblConnexionMotDePasse.TabIndex = 2;
            this.lblConnexionMotDePasse.Text = "Mot de passe :";
            // 
            // lblConnexionNomUtilisateur
            // 
            this.lblConnexionNomUtilisateur.AutoSize = true;
            this.lblConnexionNomUtilisateur.BackColor = System.Drawing.Color.Transparent;
            this.lblConnexionNomUtilisateur.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConnexionNomUtilisateur.ForeColor = System.Drawing.Color.Black;
            this.lblConnexionNomUtilisateur.Location = new System.Drawing.Point(6, 35);
            this.lblConnexionNomUtilisateur.Name = "lblConnexionNomUtilisateur";
            this.lblConnexionNomUtilisateur.Size = new System.Drawing.Size(173, 28);
            this.lblConnexionNomUtilisateur.TabIndex = 0;
            this.lblConnexionNomUtilisateur.Text = "Nom d\'utilisateur :";
            // 
            // lblSecteurVisiteur
            // 
            this.lblSecteurVisiteur.AutoSize = true;
            this.lblSecteurVisiteur.BackColor = System.Drawing.Color.Transparent;
            this.lblSecteurVisiteur.Location = new System.Drawing.Point(10, 28);
            this.lblSecteurVisiteur.Name = "lblSecteurVisiteur";
            this.lblSecteurVisiteur.Size = new System.Drawing.Size(0, 15);
            this.lblSecteurVisiteur.TabIndex = 9;
            // 
            // lblDirecteurVisiteur
            // 
            this.lblDirecteurVisiteur.AutoSize = true;
            this.lblDirecteurVisiteur.BackColor = System.Drawing.Color.Transparent;
            this.lblDirecteurVisiteur.Location = new System.Drawing.Point(10, 50);
            this.lblDirecteurVisiteur.Name = "lblDirecteurVisiteur";
            this.lblDirecteurVisiteur.Size = new System.Drawing.Size(0, 15);
            this.lblDirecteurVisiteur.TabIndex = 10;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.lblDirecteurVisiteur);
            this.Controls.Add(this.lblSecteurVisiteur);
            this.Controls.Add(this.gpbConnexionUtilisateur);
            this.Controls.Add(this.mspMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mspMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMenu";
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
        private System.Windows.Forms.ToolStripMenuItem visiteurToolStripMenuItem;
        private System.Windows.Forms.Label lblSecteurVisiteur;
        private System.Windows.Forms.Label lblDirecteurVisiteur;
        private System.Windows.Forms.ToolStripMenuItem informationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationsVisiteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AjoutEvaluationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationsDirecteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem régionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secteurToolStripMenuItem;
        private System.Windows.Forms.LinkLabel llbSansConnexion;
        private System.Windows.Forms.ToolStripMenuItem informationsSecteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationsRegionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directeurToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem visiteurToolStripMenuItem1;
    }
}