
namespace GSB
{
    partial class frmCVisiteur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCVisiteur));
            this.gpbCreationMedecin = new System.Windows.Forms.GroupBox();
            this.cbbRegion = new System.Windows.Forms.ComboBox();
            this.lblRegions = new System.Windows.Forms.Label();
            this.dateEmbauche = new System.Windows.Forms.Label();
            this.nudEnfantsCharge = new System.Windows.Forms.NumericUpDown();
            this.dudSituationFamilliale = new System.Windows.Forms.DomainUpDown();
            this.btnAjouterMedecin = new System.Windows.Forms.Button();
            this.dateNaissanceMedecin = new System.Windows.Forms.Label();
            this.situtationFamilliale = new System.Windows.Forms.Label();
            this.nbEnfantCharge = new System.Windows.Forms.Label();
            this.nomMedecin = new System.Windows.Forms.Label();
            this.txtNomMedecin = new System.Windows.Forms.TextBox();
            this.dtpDateNaissanceMedecin = new System.Windows.Forms.DateTimePicker();
            this.dtpDateEmbaucheMedecin = new System.Windows.Forms.DateTimePicker();
            this.gpbCreationMedecin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnfantsCharge)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbCreationMedecin
            // 
            this.gpbCreationMedecin.BackColor = System.Drawing.Color.Transparent;
            this.gpbCreationMedecin.Controls.Add(this.dtpDateEmbaucheMedecin);
            this.gpbCreationMedecin.Controls.Add(this.dtpDateNaissanceMedecin);
            this.gpbCreationMedecin.Controls.Add(this.cbbRegion);
            this.gpbCreationMedecin.Controls.Add(this.lblRegions);
            this.gpbCreationMedecin.Controls.Add(this.dateEmbauche);
            this.gpbCreationMedecin.Controls.Add(this.nudEnfantsCharge);
            this.gpbCreationMedecin.Controls.Add(this.dudSituationFamilliale);
            this.gpbCreationMedecin.Controls.Add(this.btnAjouterMedecin);
            this.gpbCreationMedecin.Controls.Add(this.dateNaissanceMedecin);
            this.gpbCreationMedecin.Controls.Add(this.situtationFamilliale);
            this.gpbCreationMedecin.Controls.Add(this.nbEnfantCharge);
            this.gpbCreationMedecin.Controls.Add(this.nomMedecin);
            this.gpbCreationMedecin.Controls.Add(this.txtNomMedecin);
            this.gpbCreationMedecin.Location = new System.Drawing.Point(468, 33);
            this.gpbCreationMedecin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbCreationMedecin.Name = "gpbCreationMedecin";
            this.gpbCreationMedecin.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbCreationMedecin.Size = new System.Drawing.Size(631, 542);
            this.gpbCreationMedecin.TabIndex = 14;
            this.gpbCreationMedecin.TabStop = false;
            this.gpbCreationMedecin.Text = " ";
            this.gpbCreationMedecin.Enter += new System.EventHandler(this.gpbCreationMedecin_Enter);
            // 
            // cbbRegion
            // 
            this.cbbRegion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbRegion.FormattingEnabled = true;
            this.cbbRegion.Location = new System.Drawing.Point(281, 372);
            this.cbbRegion.Name = "cbbRegion";
            this.cbbRegion.Size = new System.Drawing.Size(226, 36);
            this.cbbRegion.TabIndex = 31;
            // 
            // lblRegions
            // 
            this.lblRegions.AutoSize = true;
            this.lblRegions.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegions.Location = new System.Drawing.Point(144, 370);
            this.lblRegions.Name = "lblRegions";
            this.lblRegions.Size = new System.Drawing.Size(122, 35);
            this.lblRegions.TabIndex = 29;
            this.lblRegions.Text = "Régions : ";
            // 
            // dateEmbauche
            // 
            this.dateEmbauche.AutoSize = true;
            this.dateEmbauche.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateEmbauche.Location = new System.Drawing.Point(36, 308);
            this.dateEmbauche.Name = "dateEmbauche";
            this.dateEmbauche.Size = new System.Drawing.Size(230, 35);
            this.dateEmbauche.TabIndex = 27;
            this.dateEmbauche.Text = "Date d\'embauche : ";
            // 
            // nudEnfantsCharge
            // 
            this.nudEnfantsCharge.Location = new System.Drawing.Point(281, 112);
            this.nudEnfantsCharge.Name = "nudEnfantsCharge";
            this.nudEnfantsCharge.Size = new System.Drawing.Size(117, 27);
            this.nudEnfantsCharge.TabIndex = 26;
            // 
            // dudSituationFamilliale
            // 
            this.dudSituationFamilliale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dudSituationFamilliale.Location = new System.Drawing.Point(281, 176);
            this.dudSituationFamilliale.Name = "dudSituationFamilliale";
            this.dudSituationFamilliale.Size = new System.Drawing.Size(226, 34);
            this.dudSituationFamilliale.TabIndex = 25;
            // 
            // btnAjouterMedecin
            // 
            this.btnAjouterMedecin.BackColor = System.Drawing.Color.Black;
            this.btnAjouterMedecin.ForeColor = System.Drawing.Color.White;
            this.btnAjouterMedecin.Location = new System.Drawing.Point(280, 442);
            this.btnAjouterMedecin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAjouterMedecin.Name = "btnAjouterMedecin";
            this.btnAjouterMedecin.Size = new System.Drawing.Size(86, 44);
            this.btnAjouterMedecin.TabIndex = 18;
            this.btnAjouterMedecin.Text = "Ajouter";
            this.btnAjouterMedecin.UseVisualStyleBackColor = false;
            this.btnAjouterMedecin.Click += new System.EventHandler(this.btnAjouterMedecin_Click_1);
            // 
            // dateNaissanceMedecin
            // 
            this.dateNaissanceMedecin.AutoSize = true;
            this.dateNaissanceMedecin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateNaissanceMedecin.Location = new System.Drawing.Point(38, 245);
            this.dateNaissanceMedecin.Name = "dateNaissanceMedecin";
            this.dateNaissanceMedecin.Size = new System.Drawing.Size(228, 35);
            this.dateNaissanceMedecin.TabIndex = 10;
            this.dateNaissanceMedecin.Text = "Date de naissance :";
            // 
            // situtationFamilliale
            // 
            this.situtationFamilliale.AutoSize = true;
            this.situtationFamilliale.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.situtationFamilliale.Location = new System.Drawing.Point(29, 174);
            this.situtationFamilliale.Name = "situtationFamilliale";
            this.situtationFamilliale.Size = new System.Drawing.Size(237, 35);
            this.situtationFamilliale.TabIndex = 9;
            this.situtationFamilliale.Text = "Situation familliale : ";
            // 
            // nbEnfantCharge
            // 
            this.nbEnfantCharge.AutoSize = true;
            this.nbEnfantCharge.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nbEnfantCharge.Location = new System.Drawing.Point(55, 105);
            this.nbEnfantCharge.Name = "nbEnfantCharge";
            this.nbEnfantCharge.Size = new System.Drawing.Size(211, 35);
            this.nbEnfantCharge.TabIndex = 8;
            this.nbEnfantCharge.Text = "Enfants à charge :";
            // 
            // nomMedecin
            // 
            this.nomMedecin.AutoSize = true;
            this.nomMedecin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nomMedecin.Location = new System.Drawing.Point(183, 34);
            this.nomMedecin.Name = "nomMedecin";
            this.nomMedecin.Size = new System.Drawing.Size(83, 35);
            this.nomMedecin.TabIndex = 7;
            this.nomMedecin.Text = "Nom :";
            // 
            // txtNomMedecin
            // 
            this.txtNomMedecin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomMedecin.Location = new System.Drawing.Point(281, 36);
            this.txtNomMedecin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomMedecin.Name = "txtNomMedecin";
            this.txtNomMedecin.Size = new System.Drawing.Size(226, 34);
            this.txtNomMedecin.TabIndex = 0;
            // 
            // dtpDateNaissanceMedecin
            // 
            this.dtpDateNaissanceMedecin.CustomFormat = "yyyy-MM-dd";
            this.dtpDateNaissanceMedecin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDateNaissanceMedecin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateNaissanceMedecin.Location = new System.Drawing.Point(280, 245);
            this.dtpDateNaissanceMedecin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDateNaissanceMedecin.Name = "dtpDateNaissanceMedecin";
            this.dtpDateNaissanceMedecin.Size = new System.Drawing.Size(227, 34);
            this.dtpDateNaissanceMedecin.TabIndex = 32;
            // 
            // dtpDateEmbaucheMedecin
            // 
            this.dtpDateEmbaucheMedecin.CustomFormat = "yyyy-MM-dd";
            this.dtpDateEmbaucheMedecin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDateEmbaucheMedecin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateEmbaucheMedecin.Location = new System.Drawing.Point(281, 308);
            this.dtpDateEmbaucheMedecin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDateEmbaucheMedecin.Name = "dtpDateEmbaucheMedecin";
            this.dtpDateEmbaucheMedecin.Size = new System.Drawing.Size(227, 34);
            this.dtpDateEmbaucheMedecin.TabIndex = 33;
            // 
            // frmCVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1111, 776);
            this.Controls.Add(this.gpbCreationMedecin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCVisiteur";
            this.Text = "CVisiteur";
            this.Load += new System.EventHandler(this.frmCVisiteur_Load);
            this.gpbCreationMedecin.ResumeLayout(false);
            this.gpbCreationMedecin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnfantsCharge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.GroupBox gpbCreationMedecin;
        private System.Windows.Forms.Label dateEmbauche;
        private System.Windows.Forms.NumericUpDown nudEnfantsCharge;
        private System.Windows.Forms.DomainUpDown dudSituationFamilliale;
        private System.Windows.Forms.Button btnAjouterMedecin;
        private System.Windows.Forms.Label dateNaissanceMedecin;
        private System.Windows.Forms.Label situtationFamilliale;
        private System.Windows.Forms.Label nbEnfantCharge;
        private System.Windows.Forms.Label nomMedecin;
        private System.Windows.Forms.TextBox txtNomMedecin;
        private System.Windows.Forms.Label lblRegions;
        private System.Windows.Forms.ComboBox cbbRegion;
        private System.Windows.Forms.DateTimePicker dtpDateEmbaucheMedecin;
        private System.Windows.Forms.DateTimePicker dtpDateNaissanceMedecin;
    }
}