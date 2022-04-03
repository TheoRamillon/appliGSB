
namespace GSB
{
    partial class frmMVisiteur
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
            this.cbbSituation = new System.Windows.Forms.ComboBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.lblDirecteur = new System.Windows.Forms.Label();
            this.lblDirecteurA = new System.Windows.Forms.Label();
            this.dtpDateEmbaucheMedecin = new System.Windows.Forms.DateTimePicker();
            this.dateEmbauche = new System.Windows.Forms.Label();
            this.nudEnfantsCharge = new System.Windows.Forms.NumericUpDown();
            this.dtpDateNaissanceMedecin = new System.Windows.Forms.DateTimePicker();
            this.dateNaissanceMedecin = new System.Windows.Forms.Label();
            this.situtationFamilliale = new System.Windows.Forms.Label();
            this.nbEnfantCharge = new System.Windows.Forms.Label();
            this.nomMedecin = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVisiteur = new System.Windows.Forms.Label();
            this.cbbVisiteur = new System.Windows.Forms.ComboBox();
            this.pnlValidation = new System.Windows.Forms.Panel();
            this.lblDemandeValidation = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNon = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnfantsCharge)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlValidation.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbSituation
            // 
            this.cbbSituation.Enabled = false;
            this.cbbSituation.FormattingEnabled = true;
            this.cbbSituation.Location = new System.Drawing.Point(256, 128);
            this.cbbSituation.Name = "cbbSituation";
            this.cbbSituation.Size = new System.Drawing.Size(198, 23);
            this.cbbSituation.TabIndex = 48;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(553, 275);
            this.btnValider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(123, 44);
            this.btnValider.TabIndex = 47;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Visible = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(553, 275);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(123, 44);
            this.btnModifier.TabIndex = 46;
            this.btnModifier.Text = "Modification";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // lblDirecteur
            // 
            this.lblDirecteur.AutoSize = true;
            this.lblDirecteur.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDirecteur.Location = new System.Drawing.Point(44, 264);
            this.lblDirecteur.Name = "lblDirecteur";
            this.lblDirecteur.Size = new System.Drawing.Size(101, 28);
            this.lblDirecteur.TabIndex = 45;
            this.lblDirecteur.Text = "Directeur :";
            // 
            // lblDirecteurA
            // 
            this.lblDirecteurA.AutoSize = true;
            this.lblDirecteurA.Location = new System.Drawing.Point(256, 275);
            this.lblDirecteurA.Name = "lblDirecteurA";
            this.lblDirecteurA.Size = new System.Drawing.Size(55, 15);
            this.lblDirecteurA.TabIndex = 44;
            this.lblDirecteurA.Text = "Directeur";
            // 
            // dtpDateEmbaucheMedecin
            // 
            this.dtpDateEmbaucheMedecin.CustomFormat = "yyyy-MM-dd";
            this.dtpDateEmbaucheMedecin.Enabled = false;
            this.dtpDateEmbaucheMedecin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateEmbaucheMedecin.Location = new System.Drawing.Point(256, 230);
            this.dtpDateEmbaucheMedecin.Name = "dtpDateEmbaucheMedecin";
            this.dtpDateEmbaucheMedecin.Size = new System.Drawing.Size(199, 23);
            this.dtpDateEmbaucheMedecin.TabIndex = 42;
            // 
            // dateEmbauche
            // 
            this.dateEmbauche.AutoSize = true;
            this.dateEmbauche.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateEmbauche.Location = new System.Drawing.Point(43, 224);
            this.dateEmbauche.Name = "dateEmbauche";
            this.dateEmbauche.Size = new System.Drawing.Size(179, 28);
            this.dateEmbauche.TabIndex = 41;
            this.dateEmbauche.Text = "Date d\'embauche : ";
            // 
            // nudEnfantsCharge
            // 
            this.nudEnfantsCharge.Enabled = false;
            this.nudEnfantsCharge.Location = new System.Drawing.Point(256, 78);
            this.nudEnfantsCharge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudEnfantsCharge.Name = "nudEnfantsCharge";
            this.nudEnfantsCharge.Size = new System.Drawing.Size(102, 23);
            this.nudEnfantsCharge.TabIndex = 40;
            // 
            // dtpDateNaissanceMedecin
            // 
            this.dtpDateNaissanceMedecin.CustomFormat = "yyyy-MM-dd";
            this.dtpDateNaissanceMedecin.Enabled = false;
            this.dtpDateNaissanceMedecin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateNaissanceMedecin.Location = new System.Drawing.Point(256, 183);
            this.dtpDateNaissanceMedecin.Name = "dtpDateNaissanceMedecin";
            this.dtpDateNaissanceMedecin.Size = new System.Drawing.Size(199, 23);
            this.dtpDateNaissanceMedecin.TabIndex = 38;
            // 
            // dateNaissanceMedecin
            // 
            this.dateNaissanceMedecin.AutoSize = true;
            this.dateNaissanceMedecin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateNaissanceMedecin.Location = new System.Drawing.Point(44, 177);
            this.dateNaissanceMedecin.Name = "dateNaissanceMedecin";
            this.dateNaissanceMedecin.Size = new System.Drawing.Size(176, 28);
            this.dateNaissanceMedecin.TabIndex = 36;
            this.dateNaissanceMedecin.Text = "Date de naissance :";
            // 
            // situtationFamilliale
            // 
            this.situtationFamilliale.AutoSize = true;
            this.situtationFamilliale.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.situtationFamilliale.Location = new System.Drawing.Point(36, 124);
            this.situtationFamilliale.Name = "situtationFamilliale";
            this.situtationFamilliale.Size = new System.Drawing.Size(188, 28);
            this.situtationFamilliale.TabIndex = 35;
            this.situtationFamilliale.Text = "Situation familliale : ";
            // 
            // nbEnfantCharge
            // 
            this.nbEnfantCharge.AutoSize = true;
            this.nbEnfantCharge.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nbEnfantCharge.Location = new System.Drawing.Point(59, 72);
            this.nbEnfantCharge.Name = "nbEnfantCharge";
            this.nbEnfantCharge.Size = new System.Drawing.Size(163, 28);
            this.nbEnfantCharge.TabIndex = 34;
            this.nbEnfantCharge.Text = "Enfants à charge :";
            // 
            // nomMedecin
            // 
            this.nomMedecin.AutoSize = true;
            this.nomMedecin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nomMedecin.Location = new System.Drawing.Point(155, 18);
            this.nomMedecin.Name = "nomMedecin";
            this.nomMedecin.Size = new System.Drawing.Size(65, 28);
            this.nomMedecin.TabIndex = 33;
            this.nomMedecin.Text = "Nom :";
            // 
            // txtNom
            // 
            this.txtNom.Enabled = false;
            this.txtNom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNom.Location = new System.Drawing.Point(256, 21);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(198, 29);
            this.txtNom.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSupprimer);
            this.panel1.Controls.Add(this.cbbSituation);
            this.panel1.Controls.Add(this.btnValider);
            this.panel1.Controls.Add(this.btnModifier);
            this.panel1.Controls.Add(this.lblDirecteur);
            this.panel1.Controls.Add(this.lblDirecteurA);
            this.panel1.Controls.Add(this.dtpDateEmbaucheMedecin);
            this.panel1.Controls.Add(this.dateEmbauche);
            this.panel1.Controls.Add(this.nudEnfantsCharge);
            this.panel1.Controls.Add(this.dtpDateNaissanceMedecin);
            this.panel1.Controls.Add(this.dateNaissanceMedecin);
            this.panel1.Controls.Add(this.situtationFamilliale);
            this.panel1.Controls.Add(this.nbEnfantCharge);
            this.panel1.Controls.Add(this.nomMedecin);
            this.panel1.Controls.Add(this.txtNom);
            this.panel1.Location = new System.Drawing.Point(320, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 342);
            this.panel1.TabIndex = 32;
            // 
            // lblVisiteur
            // 
            this.lblVisiteur.AutoSize = true;
            this.lblVisiteur.Location = new System.Drawing.Point(8, 44);
            this.lblVisiteur.Name = "lblVisiteur";
            this.lblVisiteur.Size = new System.Drawing.Size(46, 15);
            this.lblVisiteur.TabIndex = 31;
            this.lblVisiteur.Text = "Visiteur";
            // 
            // cbbVisiteur
            // 
            this.cbbVisiteur.FormattingEnabled = true;
            this.cbbVisiteur.Location = new System.Drawing.Point(92, 41);
            this.cbbVisiteur.Name = "cbbVisiteur";
            this.cbbVisiteur.Size = new System.Drawing.Size(193, 23);
            this.cbbVisiteur.TabIndex = 30;
            this.cbbVisiteur.SelectedIndexChanged += new System.EventHandler(this.cbbVisiteur_SelectedIndexChanged);
            // 
            // pnlValidation
            // 
            this.pnlValidation.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlValidation.Controls.Add(this.lblDemandeValidation);
            this.pnlValidation.Controls.Add(this.btnYes);
            this.pnlValidation.Controls.Add(this.btnNon);
            this.pnlValidation.Location = new System.Drawing.Point(320, 44);
            this.pnlValidation.Name = "pnlValidation";
            this.pnlValidation.Size = new System.Drawing.Size(699, 345);
            this.pnlValidation.TabIndex = 33;
            this.pnlValidation.Visible = false;
            // 
            // lblDemandeValidation
            // 
            this.lblDemandeValidation.AutoSize = true;
            this.lblDemandeValidation.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDemandeValidation.ForeColor = System.Drawing.Color.Red;
            this.lblDemandeValidation.Location = new System.Drawing.Point(155, 128);
            this.lblDemandeValidation.Name = "lblDemandeValidation";
            this.lblDemandeValidation.Size = new System.Drawing.Size(413, 28);
            this.lblDemandeValidation.TabIndex = 2;
            this.lblDemandeValidation.Text = "Voulez vous vraiment supprimer ce directeur ?";
            // 
            // btnYes
            // 
            this.btnYes.ForeColor = System.Drawing.Color.Red;
            this.btnYes.Location = new System.Drawing.Point(386, 222);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(182, 52);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "Oui";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNon
            // 
            this.btnNon.Location = new System.Drawing.Point(149, 220);
            this.btnNon.Name = "btnNon";
            this.btnNon.Size = new System.Drawing.Size(182, 54);
            this.btnNon.TabIndex = 0;
            this.btnNon.Text = "Non";
            this.btnNon.UseVisualStyleBackColor = true;
            this.btnNon.Click += new System.EventHandler(this.btnNon_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(553, 226);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(123, 44);
            this.btnSupprimer.TabIndex = 50;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // frmMVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 479);
            this.Controls.Add(this.pnlValidation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblVisiteur);
            this.Controls.Add(this.cbbVisiteur);
            this.Name = "frmMVisiteur";
            this.Text = "mVisiteur";
            this.Load += new System.EventHandler(this.mVisiteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudEnfantsCharge)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlValidation.ResumeLayout(false);
            this.pnlValidation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbSituation;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label lblDirecteur;
        private System.Windows.Forms.Label lblDirecteurA;
        private System.Windows.Forms.DateTimePicker dtpDateEmbaucheMedecin;
        private System.Windows.Forms.Label dateEmbauche;
        private System.Windows.Forms.NumericUpDown nudEnfantsCharge;
        private System.Windows.Forms.DateTimePicker dtpDateNaissanceMedecin;
        private System.Windows.Forms.Label dateNaissanceMedecin;
        private System.Windows.Forms.Label situtationFamilliale;
        private System.Windows.Forms.Label nbEnfantCharge;
        private System.Windows.Forms.Label nomMedecin;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVisiteur;
        private System.Windows.Forms.ComboBox cbbVisiteur;
        private System.Windows.Forms.Panel pnlValidation;
        private System.Windows.Forms.Label lblDemandeValidation;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNon;
        private System.Windows.Forms.Button btnSupprimer;
    }
}