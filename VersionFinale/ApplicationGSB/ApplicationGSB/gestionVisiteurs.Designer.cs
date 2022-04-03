
namespace GSB
{
    partial class frmGestionVisiteurs
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
            this.cbbVisiteur = new System.Windows.Forms.ComboBox();
            this.lblVisiteur = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbSecteur = new System.Windows.Forms.ComboBox();
            this.lblAttribuerSecteur = new System.Windows.Forms.Label();
            this.lblAfficheSecteur = new System.Windows.Forms.Label();
            this.lblSecteur = new System.Windows.Forms.Label();
            this.btnAttribuer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbVisiteur
            // 
            this.cbbVisiteur.FormattingEnabled = true;
            this.cbbVisiteur.Location = new System.Drawing.Point(99, 51);
            this.cbbVisiteur.Name = "cbbVisiteur";
            this.cbbVisiteur.Size = new System.Drawing.Size(211, 23);
            this.cbbVisiteur.TabIndex = 0;
            this.cbbVisiteur.SelectedIndexChanged += new System.EventHandler(this.cbbVisiteur_SelectedIndexChanged);
            // 
            // lblVisiteur
            // 
            this.lblVisiteur.AutoSize = true;
            this.lblVisiteur.Location = new System.Drawing.Point(41, 54);
            this.lblVisiteur.Name = "lblVisiteur";
            this.lblVisiteur.Size = new System.Drawing.Size(52, 15);
            this.lblVisiteur.TabIndex = 1;
            this.lblVisiteur.Text = "Visiteur :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAttribuer);
            this.panel1.Controls.Add(this.cbbSecteur);
            this.panel1.Controls.Add(this.lblAttribuerSecteur);
            this.panel1.Controls.Add(this.lblAfficheSecteur);
            this.panel1.Controls.Add(this.lblSecteur);
            this.panel1.Location = new System.Drawing.Point(386, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 386);
            this.panel1.TabIndex = 2;
            // 
            // cbbSecteur
            // 
            this.cbbSecteur.FormattingEnabled = true;
            this.cbbSecteur.Location = new System.Drawing.Point(218, 69);
            this.cbbSecteur.Name = "cbbSecteur";
            this.cbbSecteur.Size = new System.Drawing.Size(234, 23);
            this.cbbSecteur.TabIndex = 3;
            this.cbbSecteur.Visible = false;
            // 
            // lblAttribuerSecteur
            // 
            this.lblAttribuerSecteur.AutoSize = true;
            this.lblAttribuerSecteur.Location = new System.Drawing.Point(16, 78);
            this.lblAttribuerSecteur.Name = "lblAttribuerSecteur";
            this.lblAttribuerSecteur.Size = new System.Drawing.Size(118, 15);
            this.lblAttribuerSecteur.TabIndex = 2;
            this.lblAttribuerSecteur.Text = "Attribuer un secteur :";
            this.lblAttribuerSecteur.Visible = false;
            // 
            // lblAfficheSecteur
            // 
            this.lblAfficheSecteur.AutoSize = true;
            this.lblAfficheSecteur.Location = new System.Drawing.Point(218, 33);
            this.lblAfficheSecteur.Name = "lblAfficheSecteur";
            this.lblAfficheSecteur.Size = new System.Drawing.Size(38, 15);
            this.lblAfficheSecteur.TabIndex = 1;
            this.lblAfficheSecteur.Text = "label1";
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Location = new System.Drawing.Point(16, 33);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(94, 15);
            this.lblSecteur.TabIndex = 0;
            this.lblSecteur.Text = "Secteur occupé :";
            // 
            // btnAttribuer
            // 
            this.btnAttribuer.Location = new System.Drawing.Point(307, 128);
            this.btnAttribuer.Name = "btnAttribuer";
            this.btnAttribuer.Size = new System.Drawing.Size(145, 49);
            this.btnAttribuer.TabIndex = 4;
            this.btnAttribuer.Text = "Attribuer";
            this.btnAttribuer.UseVisualStyleBackColor = true;
            this.btnAttribuer.Visible = false;
            this.btnAttribuer.Click += new System.EventHandler(this.btnAttribuer_Click);
            // 
            // frmGestionVisiteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 612);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblVisiteur);
            this.Controls.Add(this.cbbVisiteur);
            this.Name = "frmGestionVisiteurs";
            this.Text = "gestionVisiteurs";
            this.Load += new System.EventHandler(this.gestionVisiteurs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbVisiteur;
        private System.Windows.Forms.Label lblVisiteur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.Label lblAfficheSecteur;
        private System.Windows.Forms.ComboBox cbbSecteur;
        private System.Windows.Forms.Label lblAttribuerSecteur;
        private System.Windows.Forms.Button btnAttribuer;
    }
}