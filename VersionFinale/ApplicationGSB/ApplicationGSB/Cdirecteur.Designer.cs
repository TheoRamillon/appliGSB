
namespace GSB
{
    partial class frmCdirecteur
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
            this.gpbCreationMedecin = new System.Windows.Forms.GroupBox();
            this.lblZeroRegion = new System.Windows.Forms.Label();
            this.ckbRegion = new System.Windows.Forms.CheckBox();
            this.cbbRegion = new System.Windows.Forms.ComboBox();
            this.dtpDateEmbaucheMedecin = new System.Windows.Forms.DateTimePicker();
            this.dateEmbauche = new System.Windows.Forms.Label();
            this.nudEnfantsCharge = new System.Windows.Forms.NumericUpDown();
            this.dudSituationFamilliale = new System.Windows.Forms.DomainUpDown();
            this.btnAjouterMedecin = new System.Windows.Forms.Button();
            this.dtpDateNaissanceMedecin = new System.Windows.Forms.DateTimePicker();
            this.dateNaissanceMedecin = new System.Windows.Forms.Label();
            this.situtationFamilliale = new System.Windows.Forms.Label();
            this.nbEnfantCharge = new System.Windows.Forms.Label();
            this.nomMedecin = new System.Windows.Forms.Label();
            this.txtNomMedecin = new System.Windows.Forms.TextBox();
            this.gpbCreationMedecin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnfantsCharge)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbCreationMedecin
            // 
            this.gpbCreationMedecin.BackColor = System.Drawing.Color.Transparent;
            this.gpbCreationMedecin.Controls.Add(this.lblZeroRegion);
            this.gpbCreationMedecin.Controls.Add(this.ckbRegion);
            this.gpbCreationMedecin.Controls.Add(this.cbbRegion);
            this.gpbCreationMedecin.Controls.Add(this.dtpDateEmbaucheMedecin);
            this.gpbCreationMedecin.Controls.Add(this.dateEmbauche);
            this.gpbCreationMedecin.Controls.Add(this.nudEnfantsCharge);
            this.gpbCreationMedecin.Controls.Add(this.dudSituationFamilliale);
            this.gpbCreationMedecin.Controls.Add(this.btnAjouterMedecin);
            this.gpbCreationMedecin.Controls.Add(this.dtpDateNaissanceMedecin);
            this.gpbCreationMedecin.Controls.Add(this.dateNaissanceMedecin);
            this.gpbCreationMedecin.Controls.Add(this.situtationFamilliale);
            this.gpbCreationMedecin.Controls.Add(this.nbEnfantCharge);
            this.gpbCreationMedecin.Controls.Add(this.nomMedecin);
            this.gpbCreationMedecin.Controls.Add(this.txtNomMedecin);
            this.gpbCreationMedecin.Location = new System.Drawing.Point(33, 16);
            this.gpbCreationMedecin.Name = "gpbCreationMedecin";
            this.gpbCreationMedecin.Size = new System.Drawing.Size(727, 443);
            this.gpbCreationMedecin.TabIndex = 13;
            this.gpbCreationMedecin.TabStop = false;
            // 
            // lblZeroRegion
            // 
            this.lblZeroRegion.AutoSize = true;
            this.lblZeroRegion.Location = new System.Drawing.Point(246, 290);
            this.lblZeroRegion.Name = "lblZeroRegion";
            this.lblZeroRegion.Size = new System.Drawing.Size(171, 15);
            this.lblZeroRegion.TabIndex = 31;
            this.lblZeroRegion.Text = "Aucune région n\'est disponible";
            this.lblZeroRegion.Visible = false;
            // 
            // ckbRegion
            // 
            this.ckbRegion.AutoSize = true;
            this.ckbRegion.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbRegion.Location = new System.Drawing.Point(6, 273);
            this.ckbRegion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbRegion.Name = "ckbRegion";
            this.ckbRegion.Size = new System.Drawing.Size(207, 32);
            this.ckbRegion.TabIndex = 30;
            this.ckbRegion.Text = "Affecter une région :";
            this.ckbRegion.UseVisualStyleBackColor = true;
            this.ckbRegion.CheckedChanged += new System.EventHandler(this.ckbRegion_CheckedChanged);
            // 
            // cbbRegion
            // 
            this.cbbRegion.FormattingEnabled = true;
            this.cbbRegion.Location = new System.Drawing.Point(244, 282);
            this.cbbRegion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbRegion.Name = "cbbRegion";
            this.cbbRegion.Size = new System.Drawing.Size(200, 23);
            this.cbbRegion.TabIndex = 14;
            this.cbbRegion.Visible = false;
            // 
            // dtpDateEmbaucheMedecin
            // 
            this.dtpDateEmbaucheMedecin.CustomFormat = "yyyy-MM-dd";
            this.dtpDateEmbaucheMedecin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateEmbaucheMedecin.Location = new System.Drawing.Point(246, 236);
            this.dtpDateEmbaucheMedecin.Name = "dtpDateEmbaucheMedecin";
            this.dtpDateEmbaucheMedecin.Size = new System.Drawing.Size(199, 23);
            this.dtpDateEmbaucheMedecin.TabIndex = 28;
            // 
            // dateEmbauche
            // 
            this.dateEmbauche.AutoSize = true;
            this.dateEmbauche.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateEmbauche.Location = new System.Drawing.Point(32, 230);
            this.dateEmbauche.Name = "dateEmbauche";
            this.dateEmbauche.Size = new System.Drawing.Size(179, 28);
            this.dateEmbauche.TabIndex = 27;
            this.dateEmbauche.Text = "Date d\'embauche : ";
            // 
            // nudEnfantsCharge
            // 
            this.nudEnfantsCharge.Location = new System.Drawing.Point(246, 84);
            this.nudEnfantsCharge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudEnfantsCharge.Name = "nudEnfantsCharge";
            this.nudEnfantsCharge.Size = new System.Drawing.Size(102, 23);
            this.nudEnfantsCharge.TabIndex = 26;
            // 
            // dudSituationFamilliale
            // 
            this.dudSituationFamilliale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dudSituationFamilliale.Location = new System.Drawing.Point(246, 132);
            this.dudSituationFamilliale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dudSituationFamilliale.Name = "dudSituationFamilliale";
            this.dudSituationFamilliale.Size = new System.Drawing.Size(198, 29);
            this.dudSituationFamilliale.TabIndex = 25;
            this.dudSituationFamilliale.Text = "Marié";
            // 
            // btnAjouterMedecin
            // 
            this.btnAjouterMedecin.BackColor = System.Drawing.Color.Black;
            this.btnAjouterMedecin.ForeColor = System.Drawing.Color.White;
            this.btnAjouterMedecin.Location = new System.Drawing.Point(634, 339);
            this.btnAjouterMedecin.Name = "btnAjouterMedecin";
            this.btnAjouterMedecin.Size = new System.Drawing.Size(75, 33);
            this.btnAjouterMedecin.TabIndex = 18;
            this.btnAjouterMedecin.Text = "Ajouter";
            this.btnAjouterMedecin.UseVisualStyleBackColor = false;
            this.btnAjouterMedecin.Click += new System.EventHandler(this.btnAjouterMedecin_Click);
            // 
            // dtpDateNaissanceMedecin
            // 
            this.dtpDateNaissanceMedecin.CustomFormat = "yyyy-MM-dd";
            this.dtpDateNaissanceMedecin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateNaissanceMedecin.Location = new System.Drawing.Point(245, 189);
            this.dtpDateNaissanceMedecin.Name = "dtpDateNaissanceMedecin";
            this.dtpDateNaissanceMedecin.Size = new System.Drawing.Size(199, 23);
            this.dtpDateNaissanceMedecin.TabIndex = 14;
            // 
            // dateNaissanceMedecin
            // 
            this.dateNaissanceMedecin.AutoSize = true;
            this.dateNaissanceMedecin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateNaissanceMedecin.Location = new System.Drawing.Point(33, 183);
            this.dateNaissanceMedecin.Name = "dateNaissanceMedecin";
            this.dateNaissanceMedecin.Size = new System.Drawing.Size(176, 28);
            this.dateNaissanceMedecin.TabIndex = 10;
            this.dateNaissanceMedecin.Text = "Date de naissance :";
            // 
            // situtationFamilliale
            // 
            this.situtationFamilliale.AutoSize = true;
            this.situtationFamilliale.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.situtationFamilliale.Location = new System.Drawing.Point(25, 130);
            this.situtationFamilliale.Name = "situtationFamilliale";
            this.situtationFamilliale.Size = new System.Drawing.Size(188, 28);
            this.situtationFamilliale.TabIndex = 9;
            this.situtationFamilliale.Text = "Situation familliale : ";
            // 
            // nbEnfantCharge
            // 
            this.nbEnfantCharge.AutoSize = true;
            this.nbEnfantCharge.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nbEnfantCharge.Location = new System.Drawing.Point(48, 78);
            this.nbEnfantCharge.Name = "nbEnfantCharge";
            this.nbEnfantCharge.Size = new System.Drawing.Size(163, 28);
            this.nbEnfantCharge.TabIndex = 8;
            this.nbEnfantCharge.Text = "Enfants à charge :";
            // 
            // nomMedecin
            // 
            this.nomMedecin.AutoSize = true;
            this.nomMedecin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nomMedecin.Location = new System.Drawing.Point(144, 24);
            this.nomMedecin.Name = "nomMedecin";
            this.nomMedecin.Size = new System.Drawing.Size(65, 28);
            this.nomMedecin.TabIndex = 7;
            this.nomMedecin.Text = "Nom :";
            // 
            // txtNomMedecin
            // 
            this.txtNomMedecin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomMedecin.Location = new System.Drawing.Point(246, 27);
            this.txtNomMedecin.Name = "txtNomMedecin";
            this.txtNomMedecin.Size = new System.Drawing.Size(198, 29);
            this.txtNomMedecin.TabIndex = 0;
            // 
            // frmCdirecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(972, 582);
            this.Controls.Add(this.gpbCreationMedecin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCdirecteur";
            this.Text = "Création d\'un directeur";
            this.Load += new System.EventHandler(this.frmCdirecteur_Load);
            this.gpbCreationMedecin.ResumeLayout(false);
            this.gpbCreationMedecin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnfantsCharge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.GroupBox gpbCreationMedecin;
        private System.Windows.Forms.Button btnAjouterMedecin;
        private System.Windows.Forms.DateTimePicker dtpDateNaissanceMedecin;
        private System.Windows.Forms.Label dateNaissanceMedecin;
        private System.Windows.Forms.Label situtationFamilliale;
        private System.Windows.Forms.Label nbEnfantCharge;
        private System.Windows.Forms.Label nomMedecin;
        private System.Windows.Forms.TextBox txtNomMedecin;
        private System.Windows.Forms.DomainUpDown dudSituationFamilliale;
        private System.Windows.Forms.NumericUpDown nudEnfantsCharge;
        private System.Windows.Forms.DateTimePicker dtpDateEmbaucheMedecin;
        private System.Windows.Forms.Label dateEmbauche;
        private System.Windows.Forms.ComboBox cbbRegion;
        private System.Windows.Forms.CheckBox ckbRegion;
        private System.Windows.Forms.Label lblZeroRegion;
    }
}