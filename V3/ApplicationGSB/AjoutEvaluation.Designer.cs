
namespace GSB
{
    partial class frmAjoutEvaluation
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
            this.txtAnnee = new System.Windows.Forms.TextBox();
            this.txtEvaluation = new System.Windows.Forms.TextBox();
            this.lblAnnee = new System.Windows.Forms.Label();
            this.lblEvaluation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnlistedico = new System.Windows.Forms.Button();
            this.cbbNomVisiteur = new System.Windows.Forms.ComboBox();
            this.btnEvaluations = new System.Windows.Forms.Button();
            this.lstbMesEvaluations = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtAnnee
            // 
            this.txtAnnee.Location = new System.Drawing.Point(370, 70);
            this.txtAnnee.Name = "txtAnnee";
            this.txtAnnee.Size = new System.Drawing.Size(150, 31);
            this.txtAnnee.TabIndex = 0;
            // 
            // txtEvaluation
            // 
            this.txtEvaluation.Location = new System.Drawing.Point(370, 146);
            this.txtEvaluation.Name = "txtEvaluation";
            this.txtEvaluation.Size = new System.Drawing.Size(150, 31);
            this.txtEvaluation.TabIndex = 1;
            // 
            // lblAnnee
            // 
            this.lblAnnee.AutoSize = true;
            this.lblAnnee.Location = new System.Drawing.Point(220, 71);
            this.lblAnnee.Name = "lblAnnee";
            this.lblAnnee.Size = new System.Drawing.Size(62, 25);
            this.lblAnnee.TabIndex = 3;
            this.lblAnnee.Text = "Année";
            this.lblAnnee.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEvaluation
            // 
            this.lblEvaluation.AutoSize = true;
            this.lblEvaluation.Location = new System.Drawing.Point(220, 162);
            this.lblEvaluation.Name = "lblEvaluation";
            this.lblEvaluation.Size = new System.Drawing.Size(93, 25);
            this.lblEvaluation.TabIndex = 4;
            this.lblEvaluation.Text = "Evaluation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "NomVisiteur";
            // 
            // btnlistedico
            // 
            this.btnlistedico.Location = new System.Drawing.Point(203, 322);
            this.btnlistedico.Name = "btnlistedico";
            this.btnlistedico.Size = new System.Drawing.Size(167, 45);
            this.btnlistedico.TabIndex = 6;
            this.btnlistedico.Text = "Ajouter à la liste";
            this.btnlistedico.UseVisualStyleBackColor = true;
            this.btnlistedico.Click += new System.EventHandler(this.btnlistedico_Click);
            // 
            // cbbNomVisiteur
            // 
            this.cbbNomVisiteur.FormattingEnabled = true;
            this.cbbNomVisiteur.Location = new System.Drawing.Point(370, 244);
            this.cbbNomVisiteur.Name = "cbbNomVisiteur";
            this.cbbNomVisiteur.Size = new System.Drawing.Size(182, 33);
            this.cbbNomVisiteur.TabIndex = 7;
            this.cbbNomVisiteur.SelectedIndexChanged += new System.EventHandler(this.cbbNomVisiteur_SelectedIndexChanged);
            // 
            // btnEvaluations
            // 
            this.btnEvaluations.Location = new System.Drawing.Point(478, 322);
            this.btnEvaluations.Name = "btnEvaluations";
            this.btnEvaluations.Size = new System.Drawing.Size(145, 45);
            this.btnEvaluations.TabIndex = 8;
            this.btnEvaluations.Text = "Voir ";
            this.btnEvaluations.UseVisualStyleBackColor = true;
            // 
            // lstbMesEvaluations
            // 
            this.lstbMesEvaluations.FormattingEnabled = true;
            this.lstbMesEvaluations.ItemHeight = 25;
            this.lstbMesEvaluations.Location = new System.Drawing.Point(650, 53);
            this.lstbMesEvaluations.Name = "lstbMesEvaluations";
            this.lstbMesEvaluations.Size = new System.Drawing.Size(431, 204);
            this.lstbMesEvaluations.TabIndex = 9;
            this.lstbMesEvaluations.SelectedIndexChanged += new System.EventHandler(this.lstbMesEvaluations_SelectedIndexChanged);
            // 
            // frmAjoutEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 450);
            this.Controls.Add(this.lstbMesEvaluations);
            this.Controls.Add(this.btnEvaluations);
            this.Controls.Add(this.cbbNomVisiteur);
            this.Controls.Add(this.btnlistedico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEvaluation);
            this.Controls.Add(this.lblAnnee);
            this.Controls.Add(this.txtEvaluation);
            this.Controls.Add(this.txtAnnee);
            this.Name = "frmAjoutEvaluation";
            this.Text = "AjoutEvaluation";
            this.Load += new System.EventHandler(this.AjoutEvaluation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAnnee;
        private System.Windows.Forms.TextBox txtEvaluation;
        private System.Windows.Forms.Label lblAnnee;
        private System.Windows.Forms.Label lblEvaluation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnlistedico;
        private System.Windows.Forms.ComboBox cbbNomVisiteur;
        private System.Windows.Forms.Button btnEvaluations;
        private System.Windows.Forms.ListBox lstbMesEvaluations;
    }
}