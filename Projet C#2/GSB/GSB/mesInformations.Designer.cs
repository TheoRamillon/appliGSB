
namespace GSB
{
    partial class frmMesInformations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMesInformations));
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblDateNaiss = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblSecteur = new System.Windows.Forms.Label();
            this.lblDirecteurCharge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(26, 93);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(50, 20);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "label1";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(26, 137);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(50, 20);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "label2";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(26, 192);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(50, 20);
            this.lblMail.TabIndex = 2;
            this.lblMail.Text = "label3";
            // 
            // lblDateNaiss
            // 
            this.lblDateNaiss.AutoSize = true;
            this.lblDateNaiss.Location = new System.Drawing.Point(26, 241);
            this.lblDateNaiss.Name = "lblDateNaiss";
            this.lblDateNaiss.Size = new System.Drawing.Size(50, 20);
            this.lblDateNaiss.TabIndex = 3;
            this.lblDateNaiss.Text = "label4";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(26, 292);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(50, 20);
            this.lblRegion.TabIndex = 4;
            this.lblRegion.Text = "label5";
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Location = new System.Drawing.Point(26, 337);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(50, 20);
            this.lblSecteur.TabIndex = 5;
            this.lblSecteur.Text = "label5";
            // 
            // lblDirecteurCharge
            // 
            this.lblDirecteurCharge.AutoSize = true;
            this.lblDirecteurCharge.Location = new System.Drawing.Point(26, 381);
            this.lblDirecteurCharge.Name = "lblDirecteurCharge";
            this.lblDirecteurCharge.Size = new System.Drawing.Size(50, 20);
            this.lblDirecteurCharge.TabIndex = 6;
            this.lblDirecteurCharge.Text = "label5";
            // 
            // frmMesInformations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GSB.Properties.Resources.laboratoire;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDirecteurCharge);
            this.Controls.Add(this.lblSecteur);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.lblDateNaiss);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMesInformations";
            this.Text = "mesInformations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblDateNaiss;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.Label lblDirecteurCharge;
    }
}