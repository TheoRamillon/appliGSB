
namespace GSB
{
    partial class frmRegion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegion));
            this.gpbConnexionUtilisateur = new System.Windows.Forms.GroupBox();
            this.cbbDirecteur = new System.Windows.Forms.ComboBox();
            this.lblNomDIrecteur = new System.Windows.Forms.Label();
            this.lblCapLock = new System.Windows.Forms.Label();
            this.btnAjouterSecteur = new System.Windows.Forms.Button();
            this.txtNomRegion = new System.Windows.Forms.TextBox();
            this.lblNomRegion = new System.Windows.Forms.Label();
            this.gpbConnexionUtilisateur.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbConnexionUtilisateur
            // 
            this.gpbConnexionUtilisateur.BackColor = System.Drawing.Color.Transparent;
            this.gpbConnexionUtilisateur.Controls.Add(this.cbbDirecteur);
            this.gpbConnexionUtilisateur.Controls.Add(this.lblNomDIrecteur);
            this.gpbConnexionUtilisateur.Controls.Add(this.lblCapLock);
            this.gpbConnexionUtilisateur.Controls.Add(this.btnAjouterSecteur);
            this.gpbConnexionUtilisateur.Controls.Add(this.txtNomRegion);
            this.gpbConnexionUtilisateur.Controls.Add(this.lblNomRegion);
            this.gpbConnexionUtilisateur.Location = new System.Drawing.Point(566, 128);
            this.gpbConnexionUtilisateur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbConnexionUtilisateur.Name = "gpbConnexionUtilisateur";
            this.gpbConnexionUtilisateur.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbConnexionUtilisateur.Size = new System.Drawing.Size(619, 415);
            this.gpbConnexionUtilisateur.TabIndex = 9;
            this.gpbConnexionUtilisateur.TabStop = false;
            // 
            // cbbDirecteur
            // 
            this.cbbDirecteur.FormattingEnabled = true;
            this.cbbDirecteur.Location = new System.Drawing.Point(338, 142);
            this.cbbDirecteur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbDirecteur.Name = "cbbDirecteur";
            this.cbbDirecteur.Size = new System.Drawing.Size(188, 33);
            this.cbbDirecteur.TabIndex = 10;
            // 
            // lblNomDIrecteur
            // 
            this.lblNomDIrecteur.AutoSize = true;
            this.lblNomDIrecteur.BackColor = System.Drawing.Color.Transparent;
            this.lblNomDIrecteur.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomDIrecteur.ForeColor = System.Drawing.Color.Black;
            this.lblNomDIrecteur.Location = new System.Drawing.Point(11, 144);
            this.lblNomDIrecteur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomDIrecteur.Name = "lblNomDIrecteur";
            this.lblNomDIrecteur.Size = new System.Drawing.Size(276, 41);
            this.lblNomDIrecteur.TabIndex = 9;
            this.lblNomDIrecteur.Text = "Nom du directeur : ";
            // 
            // lblCapLock
            // 
            this.lblCapLock.AutoSize = true;
            this.lblCapLock.BackColor = System.Drawing.Color.Transparent;
            this.lblCapLock.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCapLock.ForeColor = System.Drawing.Color.Black;
            this.lblCapLock.Location = new System.Drawing.Point(116, 231);
            this.lblCapLock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapLock.Name = "lblCapLock";
            this.lblCapLock.Size = new System.Drawing.Size(0, 41);
            this.lblCapLock.TabIndex = 8;
            // 
            // btnAjouterSecteur
            // 
            this.btnAjouterSecteur.BackColor = System.Drawing.Color.Black;
            this.btnAjouterSecteur.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAjouterSecteur.FlatAppearance.BorderSize = 0;
            this.btnAjouterSecteur.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAjouterSecteur.ForeColor = System.Drawing.Color.White;
            this.btnAjouterSecteur.Location = new System.Drawing.Point(229, 325);
            this.btnAjouterSecteur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAjouterSecteur.Name = "btnAjouterSecteur";
            this.btnAjouterSecteur.Size = new System.Drawing.Size(186, 80);
            this.btnAjouterSecteur.TabIndex = 4;
            this.btnAjouterSecteur.Text = "Ajouter";
            this.btnAjouterSecteur.UseVisualStyleBackColor = false;
            this.btnAjouterSecteur.Click += new System.EventHandler(this.btnAjouterSecteur_Click);
            // 
            // txtNomRegion
            // 
            this.txtNomRegion.BackColor = System.Drawing.SystemColors.Window;
            this.txtNomRegion.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomRegion.Location = new System.Drawing.Point(338, 58);
            this.txtNomRegion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomRegion.Name = "txtNomRegion";
            this.txtNomRegion.Size = new System.Drawing.Size(196, 47);
            this.txtNomRegion.TabIndex = 1;
            // 
            // lblNomRegion
            // 
            this.lblNomRegion.AutoSize = true;
            this.lblNomRegion.BackColor = System.Drawing.Color.Transparent;
            this.lblNomRegion.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomRegion.ForeColor = System.Drawing.Color.Black;
            this.lblNomRegion.Location = new System.Drawing.Point(44, 61);
            this.lblNomRegion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomRegion.Name = "lblNomRegion";
            this.lblNomRegion.Size = new System.Drawing.Size(265, 41);
            this.lblNomRegion.TabIndex = 0;
            this.lblNomRegion.Text = "Nom de la region :";
            this.lblNomRegion.Click += new System.EventHandler(this.lblNomRegion_Click);
            // 
            // frmRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 685);
            this.Controls.Add(this.gpbConnexionUtilisateur);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRegion";
            this.Text = "Region";
            this.Load += new System.EventHandler(this.frmRegion_Load);
            this.gpbConnexionUtilisateur.ResumeLayout(false);
            this.gpbConnexionUtilisateur.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbConnexionUtilisateur;
        private System.Windows.Forms.Label lblCapLock;
        private System.Windows.Forms.Button btnAjouterSecteur;
        private System.Windows.Forms.TextBox txtNomRegion;
        private System.Windows.Forms.Label lblNomRegion;
        private System.Windows.Forms.Label lblNomDIrecteur;
        private System.Windows.Forms.ComboBox cbbDirecteur;
    }
}