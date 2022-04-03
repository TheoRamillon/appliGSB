
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
            this.txtEvaluation = new System.Windows.Forms.TextBox();
            this.lblEvaluation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnlistedico = new System.Windows.Forms.Button();
            this.cbbVisiteurs = new System.Windows.Forms.ComboBox();
            this.lstbMesEvaluations = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtEvaluation
            // 
            this.txtEvaluation.Location = new System.Drawing.Point(155, 80);
            this.txtEvaluation.Margin = new System.Windows.Forms.Padding(2);
            this.txtEvaluation.Multiline = true;
            this.txtEvaluation.Name = "txtEvaluation";
            this.txtEvaluation.Size = new System.Drawing.Size(230, 114);
            this.txtEvaluation.TabIndex = 1;
            // 
            // lblEvaluation
            // 
            this.lblEvaluation.AutoSize = true;
            this.lblEvaluation.Location = new System.Drawing.Point(50, 89);
            this.lblEvaluation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEvaluation.Name = "lblEvaluation";
            this.lblEvaluation.Size = new System.Drawing.Size(62, 15);
            this.lblEvaluation.TabIndex = 4;
            this.lblEvaluation.Text = "Evaluation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "NomVisiteur";
            // 
            // btnlistedico
            // 
            this.btnlistedico.Location = new System.Drawing.Point(268, 211);
            this.btnlistedico.Margin = new System.Windows.Forms.Padding(2);
            this.btnlistedico.Name = "btnlistedico";
            this.btnlistedico.Size = new System.Drawing.Size(117, 27);
            this.btnlistedico.TabIndex = 6;
            this.btnlistedico.Text = "Ajouter à la liste";
            this.btnlistedico.UseVisualStyleBackColor = true;
            this.btnlistedico.Click += new System.EventHandler(this.btnlistedico_Click);
            // 
            // cbbVisiteurs
            // 
            this.cbbVisiteurs.FormattingEnabled = true;
            this.cbbVisiteurs.Location = new System.Drawing.Point(155, 32);
            this.cbbVisiteurs.Margin = new System.Windows.Forms.Padding(2);
            this.cbbVisiteurs.Name = "cbbVisiteurs";
            this.cbbVisiteurs.Size = new System.Drawing.Size(230, 23);
            this.cbbVisiteurs.TabIndex = 7;
            this.cbbVisiteurs.SelectedIndexChanged += new System.EventHandler(this.cbbNomVisiteur_SelectedIndexChanged);
            // 
            // lstbMesEvaluations
            // 
            this.lstbMesEvaluations.FormattingEnabled = true;
            this.lstbMesEvaluations.ItemHeight = 15;
            this.lstbMesEvaluations.Location = new System.Drawing.Point(455, 32);
            this.lstbMesEvaluations.Margin = new System.Windows.Forms.Padding(2);
            this.lstbMesEvaluations.Name = "lstbMesEvaluations";
            this.lstbMesEvaluations.Size = new System.Drawing.Size(487, 349);
            this.lstbMesEvaluations.TabIndex = 9;
            // 
            // frmAjoutEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 591);
            this.Controls.Add(this.lstbMesEvaluations);
            this.Controls.Add(this.cbbVisiteurs);
            this.Controls.Add(this.btnlistedico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEvaluation);
            this.Controls.Add(this.txtEvaluation);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAjoutEvaluation";
            this.Text = "AjoutEvaluation";
            this.Load += new System.EventHandler(this.AjoutEvaluation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEvaluation;
        private System.Windows.Forms.Label lblEvaluation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnlistedico;
        private System.Windows.Forms.ComboBox cbbVisiteurs;
        private System.Windows.Forms.ListBox lstbMesEvaluations;
    }
}