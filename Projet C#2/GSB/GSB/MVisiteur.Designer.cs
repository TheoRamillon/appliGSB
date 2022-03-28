
namespace GSB
{
    partial class frmMvisiteur
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
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtNbEnfantsAChargeV = new System.Windows.Forms.TextBox();
            this.txtLaSituationFamilialeV = new System.Windows.Forms.TextBox();
            this.txtDateEmbaucheV = new System.Windows.Forms.TextBox();
            this.txtDateNaissanceV = new System.Windows.Forms.TextBox();
            this.txtSecteurV = new System.Windows.Forms.TextBox();
            this.lblNomV = new System.Windows.Forms.Label();
            this.lblNbEnfantsAchargeV = new System.Windows.Forms.Label();
            this.lblSituationFamilialeV = new System.Windows.Forms.Label();
            this.lblDateNaissanceV = new System.Windows.Forms.Label();
            this.lblDateEmbaucheV = new System.Windows.Forms.Label();
            this.lblSecteurV = new System.Windows.Forms.Label();
            this.DirecteurEnCharge = new System.Windows.Forms.Label();
            this.txtNomDirecteurV = new System.Windows.Forms.TextBox();
            this.btnModifierV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(291, 54);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(150, 31);
            this.txtNom.TabIndex = 0;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // txtNbEnfantsAChargeV
            // 
            this.txtNbEnfantsAChargeV.Location = new System.Drawing.Point(291, 117);
            this.txtNbEnfantsAChargeV.Name = "txtNbEnfantsAChargeV";
            this.txtNbEnfantsAChargeV.Size = new System.Drawing.Size(150, 31);
            this.txtNbEnfantsAChargeV.TabIndex = 1;
            // 
            // txtLaSituationFamilialeV
            // 
            this.txtLaSituationFamilialeV.Location = new System.Drawing.Point(291, 181);
            this.txtLaSituationFamilialeV.Name = "txtLaSituationFamilialeV";
            this.txtLaSituationFamilialeV.Size = new System.Drawing.Size(150, 31);
            this.txtLaSituationFamilialeV.TabIndex = 2;
            // 
            // txtDateEmbaucheV
            // 
            this.txtDateEmbaucheV.Enabled = false;
            this.txtDateEmbaucheV.Location = new System.Drawing.Point(291, 301);
            this.txtDateEmbaucheV.Name = "txtDateEmbaucheV";
            this.txtDateEmbaucheV.Size = new System.Drawing.Size(150, 31);
            this.txtDateEmbaucheV.TabIndex = 3;
            // 
            // txtDateNaissanceV
            // 
            this.txtDateNaissanceV.Location = new System.Drawing.Point(291, 242);
            this.txtDateNaissanceV.Name = "txtDateNaissanceV";
            this.txtDateNaissanceV.Size = new System.Drawing.Size(150, 31);
            this.txtDateNaissanceV.TabIndex = 4;
            // 
            // txtSecteurV
            // 
            this.txtSecteurV.Enabled = false;
            this.txtSecteurV.Location = new System.Drawing.Point(291, 358);
            this.txtSecteurV.Name = "txtSecteurV";
            this.txtSecteurV.Size = new System.Drawing.Size(150, 31);
            this.txtSecteurV.TabIndex = 5;
            // 
            // lblNomV
            // 
            this.lblNomV.AutoSize = true;
            this.lblNomV.Location = new System.Drawing.Point(188, 60);
            this.lblNomV.Name = "lblNomV";
            this.lblNomV.Size = new System.Drawing.Size(66, 25);
            this.lblNomV.TabIndex = 6;
            this.lblNomV.Text = "Nom : ";
            // 
            // lblNbEnfantsAchargeV
            // 
            this.lblNbEnfantsAchargeV.AutoSize = true;
            this.lblNbEnfantsAchargeV.Location = new System.Drawing.Point(84, 123);
            this.lblNbEnfantsAchargeV.Name = "lblNbEnfantsAchargeV";
            this.lblNbEnfantsAchargeV.Size = new System.Drawing.Size(170, 25);
            this.lblNbEnfantsAchargeV.TabIndex = 7;
            this.lblNbEnfantsAchargeV.Text = "nbEnfantsAcharge : ";
            // 
            // lblSituationFamilialeV
            // 
            this.lblSituationFamilialeV.AutoSize = true;
            this.lblSituationFamilialeV.Location = new System.Drawing.Point(79, 181);
            this.lblSituationFamilialeV.Name = "lblSituationFamilialeV";
            this.lblSituationFamilialeV.Size = new System.Drawing.Size(175, 25);
            this.lblSituationFamilialeV.TabIndex = 8;
            this.lblSituationFamilialeV.Text = "LaSituationFamiliale :";
            // 
            // lblDateNaissanceV
            // 
            this.lblDateNaissanceV.AutoSize = true;
            this.lblDateNaissanceV.Location = new System.Drawing.Point(113, 248);
            this.lblDateNaissanceV.Name = "lblDateNaissanceV";
            this.lblDateNaissanceV.Size = new System.Drawing.Size(141, 25);
            this.lblDateNaissanceV.TabIndex = 9;
            this.lblDateNaissanceV.Text = "DateNaissance : ";
            // 
            // lblDateEmbaucheV
            // 
            this.lblDateEmbaucheV.AutoSize = true;
            this.lblDateEmbaucheV.Location = new System.Drawing.Point(109, 307);
            this.lblDateEmbaucheV.Name = "lblDateEmbaucheV";
            this.lblDateEmbaucheV.Size = new System.Drawing.Size(145, 25);
            this.lblDateEmbaucheV.TabIndex = 10;
            this.lblDateEmbaucheV.Text = "DateEmbauche : ";
            // 
            // lblSecteurV
            // 
            this.lblSecteurV.AutoSize = true;
            this.lblSecteurV.Location = new System.Drawing.Point(170, 358);
            this.lblSecteurV.Name = "lblSecteurV";
            this.lblSecteurV.Size = new System.Drawing.Size(84, 25);
            this.lblSecteurV.TabIndex = 11;
            this.lblSecteurV.Text = "Secteur : ";
            // 
            // DirecteurEnCharge
            // 
            this.DirecteurEnCharge.AutoSize = true;
            this.DirecteurEnCharge.Location = new System.Drawing.Point(49, 407);
            this.DirecteurEnCharge.Name = "DirecteurEnCharge";
            this.DirecteurEnCharge.Size = new System.Drawing.Size(205, 25);
            this.DirecteurEnCharge.TabIndex = 12;
            this.DirecteurEnCharge.Text = "NomDirecteurRegional : ";
            // 
            // txtNomDirecteurV
            // 
            this.txtNomDirecteurV.Enabled = false;
            this.txtNomDirecteurV.Location = new System.Drawing.Point(291, 407);
            this.txtNomDirecteurV.Name = "txtNomDirecteurV";
            this.txtNomDirecteurV.Size = new System.Drawing.Size(150, 31);
            this.txtNomDirecteurV.TabIndex = 13;
            // 
            // btnModifierV
            // 
            this.btnModifierV.Location = new System.Drawing.Point(581, 407);
            this.btnModifierV.Name = "btnModifierV";
            this.btnModifierV.Size = new System.Drawing.Size(112, 34);
            this.btnModifierV.TabIndex = 14;
            this.btnModifierV.Text = "Modifer";
            this.btnModifierV.UseVisualStyleBackColor = true;
            this.btnModifierV.Click += new System.EventHandler(this.btnModifierV_Click);
            // 
            // frmMvisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModifierV);
            this.Controls.Add(this.txtNomDirecteurV);
            this.Controls.Add(this.DirecteurEnCharge);
            this.Controls.Add(this.lblSecteurV);
            this.Controls.Add(this.lblDateEmbaucheV);
            this.Controls.Add(this.lblDateNaissanceV);
            this.Controls.Add(this.lblSituationFamilialeV);
            this.Controls.Add(this.lblNbEnfantsAchargeV);
            this.Controls.Add(this.lblNomV);
            this.Controls.Add(this.txtSecteurV);
            this.Controls.Add(this.txtDateNaissanceV);
            this.Controls.Add(this.txtDateEmbaucheV);
            this.Controls.Add(this.txtLaSituationFamilialeV);
            this.Controls.Add(this.txtNbEnfantsAChargeV);
            this.Controls.Add(this.txtNom);
            this.Name = "frmMvisiteur";
            this.Text = "MVisiteur";
            this.Load += new System.EventHandler(this.frmMvisiteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtNbEnfantsAChargeV;
        private System.Windows.Forms.TextBox txtLaSituationFamilialeV;
        private System.Windows.Forms.TextBox txtDateEmbaucheV;
        private System.Windows.Forms.TextBox txtDateNaissanceV;
        private System.Windows.Forms.TextBox txtSecteurV;
        private System.Windows.Forms.Label lblNomV;
        private System.Windows.Forms.Label lblNbEnfantsAchargeV;
        private System.Windows.Forms.Label lblSituationFamilialeV;
        private System.Windows.Forms.Label lblDateNaissanceV;
        private System.Windows.Forms.Label lblDateEmbaucheV;
        private System.Windows.Forms.Label lblSecteurV;
        private System.Windows.Forms.Label DirecteurEnCharge;
        private System.Windows.Forms.TextBox txtNomDirecteurV;
        private System.Windows.Forms.Button btnModifierV;
    }
}