
namespace GSB
{
    partial class frmInformationsSecteurs
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
            this.lblNomDirecteur = new System.Windows.Forms.Label();
            this.cbbSecteur = new System.Windows.Forms.ComboBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblVisiteur = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLabelVisiteur = new System.Windows.Forms.Label();
            this.lblLabelDirecteur = new System.Windows.Forms.Label();
            this.lblLabelRegion = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomDirecteur
            // 
            this.lblNomDirecteur.AutoSize = true;
            this.lblNomDirecteur.Location = new System.Drawing.Point(133, 65);
            this.lblNomDirecteur.Name = "lblNomDirecteur";
            this.lblNomDirecteur.Size = new System.Drawing.Size(38, 15);
            this.lblNomDirecteur.TabIndex = 6;
            this.lblNomDirecteur.Text = "label1";
            // 
            // cbbSecteur
            // 
            this.cbbSecteur.FormattingEnabled = true;
            this.cbbSecteur.Location = new System.Drawing.Point(48, 38);
            this.cbbSecteur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbSecteur.Name = "cbbSecteur";
            this.cbbSecteur.Size = new System.Drawing.Size(133, 23);
            this.cbbSecteur.TabIndex = 4;
            this.cbbSecteur.SelectedIndexChanged += new System.EventHandler(this.cbbSecteur_SelectedIndexChanged);
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(133, 16);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(38, 15);
            this.lblRegion.TabIndex = 7;
            this.lblRegion.Text = "label1";
            // 
            // lblVisiteur
            // 
            this.lblVisiteur.AutoSize = true;
            this.lblVisiteur.Location = new System.Drawing.Point(133, 113);
            this.lblVisiteur.Name = "lblVisiteur";
            this.lblVisiteur.Size = new System.Drawing.Size(38, 15);
            this.lblVisiteur.TabIndex = 8;
            this.lblVisiteur.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLabelVisiteur);
            this.panel1.Controls.Add(this.lblLabelDirecteur);
            this.panel1.Controls.Add(this.lblLabelRegion);
            this.panel1.Controls.Add(this.lblRegion);
            this.panel1.Controls.Add(this.lblVisiteur);
            this.panel1.Controls.Add(this.lblNomDirecteur);
            this.panel1.Location = new System.Drawing.Point(318, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 185);
            this.panel1.TabIndex = 9;
            // 
            // lblLabelVisiteur
            // 
            this.lblLabelVisiteur.AutoSize = true;
            this.lblLabelVisiteur.Location = new System.Drawing.Point(24, 113);
            this.lblLabelVisiteur.Name = "lblLabelVisiteur";
            this.lblLabelVisiteur.Size = new System.Drawing.Size(52, 15);
            this.lblLabelVisiteur.TabIndex = 11;
            this.lblLabelVisiteur.Text = "Visiteur :";
            // 
            // lblLabelDirecteur
            // 
            this.lblLabelDirecteur.AutoSize = true;
            this.lblLabelDirecteur.Location = new System.Drawing.Point(24, 65);
            this.lblLabelDirecteur.Name = "lblLabelDirecteur";
            this.lblLabelDirecteur.Size = new System.Drawing.Size(61, 15);
            this.lblLabelDirecteur.TabIndex = 10;
            this.lblLabelDirecteur.Text = "Directeur :";
            // 
            // lblLabelRegion
            // 
            this.lblLabelRegion.AutoSize = true;
            this.lblLabelRegion.Location = new System.Drawing.Point(24, 16);
            this.lblLabelRegion.Name = "lblLabelRegion";
            this.lblLabelRegion.Size = new System.Drawing.Size(50, 15);
            this.lblLabelRegion.TabIndex = 9;
            this.lblLabelRegion.Text = "Region :";
            // 
            // frmInformationsSecteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbbSecteur);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmInformationsSecteurs";
            this.Text = "Informations sur les Secteurs";
            this.Load += new System.EventHandler(this.informationsSecteurs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNomDirecteur;
        private System.Windows.Forms.ComboBox cbbSecteur;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblVisiteur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLabelVisiteur;
        private System.Windows.Forms.Label lblLabelDirecteur;
        private System.Windows.Forms.Label lblLabelRegion;
    }
}