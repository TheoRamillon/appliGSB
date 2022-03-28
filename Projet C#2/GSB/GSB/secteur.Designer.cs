
namespace GSB
{
    partial class frmSecteur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSecteur));
            this.gpbConnexionUtilisateur = new System.Windows.Forms.GroupBox();
            this.cbbRegion = new System.Windows.Forms.ComboBox();
            this.lblCapLock = new System.Windows.Forms.Label();
            this.btnAjouterSecteur = new System.Windows.Forms.Button();
            this.txtNomSecteur = new System.Windows.Forms.TextBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblNomRegion = new System.Windows.Forms.Label();
            this.gpbConnexionUtilisateur.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbConnexionUtilisateur
            // 
            this.gpbConnexionUtilisateur.BackColor = System.Drawing.Color.Transparent;
            this.gpbConnexionUtilisateur.Controls.Add(this.cbbRegion);
            this.gpbConnexionUtilisateur.Controls.Add(this.lblCapLock);
            this.gpbConnexionUtilisateur.Controls.Add(this.btnAjouterSecteur);
            this.gpbConnexionUtilisateur.Controls.Add(this.txtNomSecteur);
            this.gpbConnexionUtilisateur.Controls.Add(this.lblRegion);
            this.gpbConnexionUtilisateur.Controls.Add(this.lblNomRegion);
            this.gpbConnexionUtilisateur.Location = new System.Drawing.Point(436, 112);
            this.gpbConnexionUtilisateur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbConnexionUtilisateur.Name = "gpbConnexionUtilisateur";
            this.gpbConnexionUtilisateur.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbConnexionUtilisateur.Size = new System.Drawing.Size(446, 295);
            this.gpbConnexionUtilisateur.TabIndex = 8;
            this.gpbConnexionUtilisateur.TabStop = false;
            // 
            // cbbRegion
            // 
            this.cbbRegion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbRegion.FormattingEnabled = true;
            this.cbbRegion.Location = new System.Drawing.Point(236, 114);
            this.cbbRegion.Name = "cbbRegion";
            this.cbbRegion.Size = new System.Drawing.Size(158, 36);
            this.cbbRegion.TabIndex = 9;
            // 
            // lblCapLock
            // 
            this.lblCapLock.AutoSize = true;
            this.lblCapLock.BackColor = System.Drawing.Color.Transparent;
            this.lblCapLock.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCapLock.ForeColor = System.Drawing.Color.Black;
            this.lblCapLock.Location = new System.Drawing.Point(93, 184);
            this.lblCapLock.Name = "lblCapLock";
            this.lblCapLock.Size = new System.Drawing.Size(0, 35);
            this.lblCapLock.TabIndex = 8;
            // 
            // btnAjouterSecteur
            // 
            this.btnAjouterSecteur.BackColor = System.Drawing.Color.Black;
            this.btnAjouterSecteur.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAjouterSecteur.FlatAppearance.BorderSize = 0;
            this.btnAjouterSecteur.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAjouterSecteur.ForeColor = System.Drawing.Color.White;
            this.btnAjouterSecteur.Location = new System.Drawing.Point(156, 195);
            this.btnAjouterSecteur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAjouterSecteur.Name = "btnAjouterSecteur";
            this.btnAjouterSecteur.Size = new System.Drawing.Size(149, 64);
            this.btnAjouterSecteur.TabIndex = 4;
            this.btnAjouterSecteur.Text = "Ajouter";
            this.btnAjouterSecteur.UseVisualStyleBackColor = false;
            this.btnAjouterSecteur.Click += new System.EventHandler(this.btnAjouterSecteur_Click);
            // 
            // txtNomSecteur
            // 
            this.txtNomSecteur.BackColor = System.Drawing.SystemColors.Window;
            this.txtNomSecteur.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomSecteur.Location = new System.Drawing.Point(236, 42);
            this.txtNomSecteur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomSecteur.Name = "txtNomSecteur";
            this.txtNomSecteur.Size = new System.Drawing.Size(158, 41);
            this.txtNomSecteur.TabIndex = 1;
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.BackColor = System.Drawing.Color.Transparent;
            this.lblRegion.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegion.ForeColor = System.Drawing.Color.Black;
            this.lblRegion.Location = new System.Drawing.Point(108, 112);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(104, 35);
            this.lblRegion.TabIndex = 2;
            this.lblRegion.Text = "Région :";
            // 
            // lblNomRegion
            // 
            this.lblNomRegion.AutoSize = true;
            this.lblNomRegion.BackColor = System.Drawing.Color.Transparent;
            this.lblNomRegion.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomRegion.ForeColor = System.Drawing.Color.Black;
            this.lblNomRegion.Location = new System.Drawing.Point(6, 45);
            this.lblNomRegion.Name = "lblNomRegion";
            this.lblNomRegion.Size = new System.Drawing.Size(206, 35);
            this.lblNomRegion.TabIndex = 0;
            this.lblNomRegion.Text = "Nom du secteur :";
            this.lblNomRegion.Click += new System.EventHandler(this.lblNomRegion_Click);
            // 
            // frmSecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(987, 545);
            this.Controls.Add(this.gpbConnexionUtilisateur);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSecteur";
            this.Text = "Secteur";
            this.Load += new System.EventHandler(this.frmRegion_Load);
            this.gpbConnexionUtilisateur.ResumeLayout(false);
            this.gpbConnexionUtilisateur.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbConnexionUtilisateur;
        private System.Windows.Forms.Label lblCapLock;
        private System.Windows.Forms.Button btnAjouterSecteur;
        private System.Windows.Forms.TextBox txtNomSecteur;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblNomRegion;
        private System.Windows.Forms.ComboBox cbbRegion;
    }
}