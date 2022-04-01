
namespace GSB
{
    partial class frmCRegion
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
            this.gpbConnexionUtilisateur = new System.Windows.Forms.GroupBox();
            this.lblZeroDirecteur = new System.Windows.Forms.Label();
            this.ckbDirecteur = new System.Windows.Forms.CheckBox();
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
            this.gpbConnexionUtilisateur.Controls.Add(this.lblZeroDirecteur);
            this.gpbConnexionUtilisateur.Controls.Add(this.ckbDirecteur);
            this.gpbConnexionUtilisateur.Controls.Add(this.cbbDirecteur);
            this.gpbConnexionUtilisateur.Controls.Add(this.lblNomDIrecteur);
            this.gpbConnexionUtilisateur.Controls.Add(this.lblCapLock);
            this.gpbConnexionUtilisateur.Controls.Add(this.btnAjouterSecteur);
            this.gpbConnexionUtilisateur.Controls.Add(this.txtNomRegion);
            this.gpbConnexionUtilisateur.Controls.Add(this.lblNomRegion);
            this.gpbConnexionUtilisateur.Location = new System.Drawing.Point(23, 12);
            this.gpbConnexionUtilisateur.Name = "gpbConnexionUtilisateur";
            this.gpbConnexionUtilisateur.Size = new System.Drawing.Size(433, 249);
            this.gpbConnexionUtilisateur.TabIndex = 9;
            this.gpbConnexionUtilisateur.TabStop = false;
            // 
            // lblZeroDirecteur
            // 
            this.lblZeroDirecteur.AutoSize = true;
            this.lblZeroDirecteur.Location = new System.Drawing.Point(206, 139);
            this.lblZeroDirecteur.Name = "lblZeroDirecteur";
            this.lblZeroDirecteur.Size = new System.Drawing.Size(178, 15);
            this.lblZeroDirecteur.TabIndex = 13;
            this.lblZeroDirecteur.Text = "Aucun directeur n\'est disponible";
            this.lblZeroDirecteur.Visible = false;
            this.lblZeroDirecteur.Click += new System.EventHandler(this.lblZeroDirecteur_Click);
            // 
            // ckbDirecteur
            // 
            this.ckbDirecteur.AutoSize = true;
            this.ckbDirecteur.Location = new System.Drawing.Point(6, 87);
            this.ckbDirecteur.Name = "ckbDirecteur";
            this.ckbDirecteur.Size = new System.Drawing.Size(132, 19);
            this.ckbDirecteur.TabIndex = 12;
            this.ckbDirecteur.Text = "Ajouter un directeur";
            this.ckbDirecteur.UseVisualStyleBackColor = true;
            this.ckbDirecteur.CheckedChanged += new System.EventHandler(this.ckbDirecteur_CheckedChanged);
            // 
            // cbbDirecteur
            // 
            this.cbbDirecteur.FormattingEnabled = true;
            this.cbbDirecteur.Location = new System.Drawing.Point(237, 132);
            this.cbbDirecteur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbDirecteur.Name = "cbbDirecteur";
            this.cbbDirecteur.Size = new System.Drawing.Size(133, 23);
            this.cbbDirecteur.TabIndex = 10;
            this.cbbDirecteur.Visible = false;
            // 
            // lblNomDIrecteur
            // 
            this.lblNomDIrecteur.AutoSize = true;
            this.lblNomDIrecteur.BackColor = System.Drawing.Color.Transparent;
            this.lblNomDIrecteur.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomDIrecteur.ForeColor = System.Drawing.Color.Black;
            this.lblNomDIrecteur.Location = new System.Drawing.Point(6, 127);
            this.lblNomDIrecteur.Name = "lblNomDIrecteur";
            this.lblNomDIrecteur.Size = new System.Drawing.Size(181, 28);
            this.lblNomDIrecteur.TabIndex = 9;
            this.lblNomDIrecteur.Text = "Nom du directeur : ";
            this.lblNomDIrecteur.Visible = false;
            // 
            // lblCapLock
            // 
            this.lblCapLock.AutoSize = true;
            this.lblCapLock.BackColor = System.Drawing.Color.Transparent;
            this.lblCapLock.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCapLock.ForeColor = System.Drawing.Color.Black;
            this.lblCapLock.Location = new System.Drawing.Point(81, 139);
            this.lblCapLock.Name = "lblCapLock";
            this.lblCapLock.Size = new System.Drawing.Size(0, 28);
            this.lblCapLock.TabIndex = 8;
            // 
            // btnAjouterSecteur
            // 
            this.btnAjouterSecteur.BackColor = System.Drawing.Color.Black;
            this.btnAjouterSecteur.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAjouterSecteur.FlatAppearance.BorderSize = 0;
            this.btnAjouterSecteur.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAjouterSecteur.ForeColor = System.Drawing.Color.White;
            this.btnAjouterSecteur.Location = new System.Drawing.Point(160, 195);
            this.btnAjouterSecteur.Name = "btnAjouterSecteur";
            this.btnAjouterSecteur.Size = new System.Drawing.Size(130, 48);
            this.btnAjouterSecteur.TabIndex = 4;
            this.btnAjouterSecteur.Text = "Ajouter";
            this.btnAjouterSecteur.UseVisualStyleBackColor = false;
            this.btnAjouterSecteur.Click += new System.EventHandler(this.btnAjouterSecteur_Click);
            // 
            // txtNomRegion
            // 
            this.txtNomRegion.BackColor = System.Drawing.SystemColors.Window;
            this.txtNomRegion.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomRegion.Location = new System.Drawing.Point(237, 35);
            this.txtNomRegion.Name = "txtNomRegion";
            this.txtNomRegion.Size = new System.Drawing.Size(138, 34);
            this.txtNomRegion.TabIndex = 1;
            // 
            // lblNomRegion
            // 
            this.lblNomRegion.AutoSize = true;
            this.lblNomRegion.BackColor = System.Drawing.Color.Transparent;
            this.lblNomRegion.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomRegion.ForeColor = System.Drawing.Color.Black;
            this.lblNomRegion.Location = new System.Drawing.Point(6, 38);
            this.lblNomRegion.Name = "lblNomRegion";
            this.lblNomRegion.Size = new System.Drawing.Size(174, 28);
            this.lblNomRegion.TabIndex = 0;
            this.lblNomRegion.Text = "Nom de la region :";
            this.lblNomRegion.Click += new System.EventHandler(this.lblNomRegion_Click);
            // 
            // frmCRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(885, 411);
            this.Controls.Add(this.gpbConnexionUtilisateur);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCRegion";
            this.Text = "Création d\'une région";
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
        private System.Windows.Forms.CheckBox ckbDirecteur;
        private System.Windows.Forms.Label lblZeroDirecteur;
    }
}