
namespace GSB
{
    partial class frmInformationsVisiteurs
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
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSecteur = new System.Windows.Forms.TextBox();
            this.lblSecteur = new System.Windows.Forms.Label();
            this.txtDirecteur = new System.Windows.Forms.TextBox();
            this.lblDirecteur = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblVisiteurs = new System.Windows.Forms.Label();
            this.cbbVisiteurs = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(9, 67);
            this.lblAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(34, 15);
            this.lblAge.TabIndex = 24;
            this.lblAge.Text = "Âge :";
            // 
            // txtAge
            // 
            this.txtAge.Enabled = false;
            this.txtAge.Location = new System.Drawing.Point(77, 64);
            this.txtAge.Margin = new System.Windows.Forms.Padding(2);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(190, 23);
            this.txtAge.TabIndex = 19;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSecteur);
            this.panel1.Controls.Add(this.lblSecteur);
            this.panel1.Controls.Add(this.txtDirecteur);
            this.panel1.Controls.Add(this.lblDirecteur);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtRegion);
            this.panel1.Controls.Add(this.lblRegion);
            this.panel1.Controls.Add(this.lblAge);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Location = new System.Drawing.Point(284, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 435);
            this.panel1.TabIndex = 30;
            // 
            // txtSecteur
            // 
            this.txtSecteur.Enabled = false;
            this.txtSecteur.Location = new System.Drawing.Point(77, 153);
            this.txtSecteur.Name = "txtSecteur";
            this.txtSecteur.Size = new System.Drawing.Size(190, 23);
            this.txtSecteur.TabIndex = 34;
            this.txtSecteur.TextChanged += new System.EventHandler(this.txtSecteur_TextChanged);
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Location = new System.Drawing.Point(10, 156);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(52, 15);
            this.lblSecteur.TabIndex = 33;
            this.lblSecteur.Text = "Secteur :";
            // 
            // txtDirecteur
            // 
            this.txtDirecteur.Enabled = false;
            this.txtDirecteur.Location = new System.Drawing.Point(77, 124);
            this.txtDirecteur.Name = "txtDirecteur";
            this.txtDirecteur.Size = new System.Drawing.Size(190, 23);
            this.txtDirecteur.TabIndex = 32;
            this.txtDirecteur.TextChanged += new System.EventHandler(this.txtDirecteur_TextChanged);
            // 
            // lblDirecteur
            // 
            this.lblDirecteur.AutoSize = true;
            this.lblDirecteur.Location = new System.Drawing.Point(10, 127);
            this.lblDirecteur.Name = "lblDirecteur";
            this.lblDirecteur.Size = new System.Drawing.Size(61, 15);
            this.lblDirecteur.TabIndex = 31;
            this.lblDirecteur.Text = "Directeur :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Informations :";
            // 
            // txtRegion
            // 
            this.txtRegion.Enabled = false;
            this.txtRegion.Location = new System.Drawing.Point(77, 95);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(190, 23);
            this.txtRegion.TabIndex = 27;
            this.txtRegion.TextChanged += new System.EventHandler(this.txtRegion_TextChanged);
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(10, 98);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(50, 15);
            this.lblRegion.TabIndex = 26;
            this.lblRegion.Text = "Region :";
            // 
            // lblVisiteurs
            // 
            this.lblVisiteurs.AutoSize = true;
            this.lblVisiteurs.Location = new System.Drawing.Point(21, 79);
            this.lblVisiteurs.Name = "lblVisiteurs";
            this.lblVisiteurs.Size = new System.Drawing.Size(57, 15);
            this.lblVisiteurs.TabIndex = 29;
            this.lblVisiteurs.Text = "Visiteurs :";
            // 
            // cbbVisiteurs
            // 
            this.cbbVisiteurs.FormattingEnabled = true;
            this.cbbVisiteurs.Location = new System.Drawing.Point(94, 76);
            this.cbbVisiteurs.Name = "cbbVisiteurs";
            this.cbbVisiteurs.Size = new System.Drawing.Size(161, 23);
            this.cbbVisiteurs.TabIndex = 28;
            this.cbbVisiteurs.SelectedIndexChanged += new System.EventHandler(this.cbbVisiteurs_SelectedIndexChanged);
            // 
            // frmInformationsVisiteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 530);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblVisiteurs);
            this.Controls.Add(this.cbbVisiteurs);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmInformationsVisiteurs";
            this.Text = "mesInformations";
            this.Load += new System.EventHandler(this.frmMesInformations_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSecteur;
        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.TextBox txtDirecteur;
        private System.Windows.Forms.Label lblDirecteur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblVisiteurs;
        private System.Windows.Forms.ComboBox cbbVisiteurs;
    }
}