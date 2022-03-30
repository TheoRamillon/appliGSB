
namespace GSB
{
    partial class frmInfoRegion
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
            this.cbbRegion = new System.Windows.Forms.ComboBox();
            this.cbbSecteur = new System.Windows.Forms.ComboBox();
            this.lblNomDirecteur = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCbbSecteur = new System.Windows.Forms.Label();
            this.lbxSecteur = new System.Windows.Forms.ListBox();
            this.lblVisiteur = new System.Windows.Forms.Label();
            this.lbxVisiteur = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbRegion
            // 
            this.cbbRegion.FormattingEnabled = true;
            this.cbbRegion.Location = new System.Drawing.Point(12, 38);
            this.cbbRegion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbRegion.Name = "cbbRegion";
            this.cbbRegion.Size = new System.Drawing.Size(133, 23);
            this.cbbRegion.TabIndex = 0;
            this.cbbRegion.SelectedIndexChanged += new System.EventHandler(this.cbbRegion_SelectedIndexChanged);
            // 
            // cbbSecteur
            // 
            this.cbbSecteur.FormattingEnabled = true;
            this.cbbSecteur.Location = new System.Drawing.Point(555, 303);
            this.cbbSecteur.Name = "cbbSecteur";
            this.cbbSecteur.Size = new System.Drawing.Size(121, 23);
            this.cbbSecteur.TabIndex = 2;
            this.cbbSecteur.Visible = false;
            // 
            // lblNomDirecteur
            // 
            this.lblNomDirecteur.AutoSize = true;
            this.lblNomDirecteur.Location = new System.Drawing.Point(12, 12);
            this.lblNomDirecteur.Name = "lblNomDirecteur";
            this.lblNomDirecteur.Size = new System.Drawing.Size(38, 15);
            this.lblNomDirecteur.TabIndex = 3;
            this.lblNomDirecteur.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbxVisiteur);
            this.panel1.Controls.Add(this.lblVisiteur);
            this.panel1.Controls.Add(this.lbxSecteur);
            this.panel1.Controls.Add(this.lblCbbSecteur);
            this.panel1.Location = new System.Drawing.Point(190, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 246);
            this.panel1.TabIndex = 4;
            // 
            // lblCbbSecteur
            // 
            this.lblCbbSecteur.AutoSize = true;
            this.lblCbbSecteur.Location = new System.Drawing.Point(15, 8);
            this.lblCbbSecteur.Name = "lblCbbSecteur";
            this.lblCbbSecteur.Size = new System.Drawing.Size(76, 15);
            this.lblCbbSecteur.TabIndex = 3;
            this.lblCbbSecteur.Text = "Les secteurs :";
            // 
            // lbxSecteur
            // 
            this.lbxSecteur.FormattingEnabled = true;
            this.lbxSecteur.ItemHeight = 15;
            this.lbxSecteur.Location = new System.Drawing.Point(15, 26);
            this.lbxSecteur.Name = "lbxSecteur";
            this.lbxSecteur.Size = new System.Drawing.Size(120, 184);
            this.lbxSecteur.TabIndex = 5;
            // 
            // lblVisiteur
            // 
            this.lblVisiteur.AutoSize = true;
            this.lblVisiteur.Location = new System.Drawing.Point(262, 7);
            this.lblVisiteur.Name = "lblVisiteur";
            this.lblVisiteur.Size = new System.Drawing.Size(76, 15);
            this.lblVisiteur.TabIndex = 6;
            this.lblVisiteur.Text = "Les visiteurs :";
            // 
            // lbxVisiteur
            // 
            this.lbxVisiteur.FormattingEnabled = true;
            this.lbxVisiteur.ItemHeight = 15;
            this.lbxVisiteur.Location = new System.Drawing.Point(262, 26);
            this.lbxVisiteur.Name = "lbxVisiteur";
            this.lbxVisiteur.Size = new System.Drawing.Size(120, 184);
            this.lbxVisiteur.TabIndex = 7;
            // 
            // frmInfoRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.cbbSecteur);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNomDirecteur);
            this.Controls.Add(this.cbbRegion);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmInfoRegion";
            this.Text = "Information sur les régions";
            this.Load += new System.EventHandler(this.frmInfoRegion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbRegion;
        private System.Windows.Forms.ComboBox cbbSecteur;
        private System.Windows.Forms.Label lblNomDirecteur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCbbSecteur;
        private System.Windows.Forms.ListBox lbxSecteur;
        private System.Windows.Forms.ListBox lbxVisiteur;
        private System.Windows.Forms.Label lblVisiteur;
    }
}