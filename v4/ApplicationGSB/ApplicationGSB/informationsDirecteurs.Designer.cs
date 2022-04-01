
namespace GSB
{
    partial class frmInformationsDirecteurs
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
            this.cbbDirecteur = new System.Windows.Forms.ComboBox();
            this.lblDirecteurs = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ltbVisiteurs = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.ltbSecteurs = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(2, 36);
            this.lblAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(34, 15);
            this.lblAge.TabIndex = 24;
            this.lblAge.Text = "Âge :";
            // 
            // txtAge
            // 
            this.txtAge.Enabled = false;
            this.txtAge.Location = new System.Drawing.Point(70, 33);
            this.txtAge.Margin = new System.Windows.Forms.Padding(2);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(261, 23);
            this.txtAge.TabIndex = 19;
            // 
            // cbbDirecteur
            // 
            this.cbbDirecteur.FormattingEnabled = true;
            this.cbbDirecteur.Location = new System.Drawing.Point(106, 55);
            this.cbbDirecteur.Name = "cbbDirecteur";
            this.cbbDirecteur.Size = new System.Drawing.Size(193, 23);
            this.cbbDirecteur.TabIndex = 25;
            this.cbbDirecteur.SelectedIndexChanged += new System.EventHandler(this.cbbDirecteur_SelectedIndexChanged);
            // 
            // lblDirecteurs
            // 
            this.lblDirecteurs.AutoSize = true;
            this.lblDirecteurs.Location = new System.Drawing.Point(23, 58);
            this.lblDirecteurs.Name = "lblDirecteurs";
            this.lblDirecteurs.Size = new System.Drawing.Size(61, 15);
            this.lblDirecteurs.TabIndex = 26;
            this.lblDirecteurs.Text = "Directeur :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ltbVisiteurs);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtRegion);
            this.panel1.Controls.Add(this.lblRegion);
            this.panel1.Controls.Add(this.ltbSecteurs);
            this.panel1.Controls.Add(this.lblAge);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Location = new System.Drawing.Point(332, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 373);
            this.panel1.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Visiteurs :";
            // 
            // ltbVisiteurs
            // 
            this.ltbVisiteurs.FormattingEnabled = true;
            this.ltbVisiteurs.ItemHeight = 15;
            this.ltbVisiteurs.Location = new System.Drawing.Point(567, 30);
            this.ltbVisiteurs.Name = "ltbVisiteurs";
            this.ltbVisiteurs.Size = new System.Drawing.Size(182, 289);
            this.ltbVisiteurs.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Secteurs :";
            // 
            // txtRegion
            // 
            this.txtRegion.Enabled = false;
            this.txtRegion.Location = new System.Drawing.Point(70, 64);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(261, 23);
            this.txtRegion.TabIndex = 27;
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(3, 67);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(50, 15);
            this.lblRegion.TabIndex = 26;
            this.lblRegion.Text = "Region :";
            // 
            // ltbSecteurs
            // 
            this.ltbSecteurs.FormattingEnabled = true;
            this.ltbSecteurs.ItemHeight = 15;
            this.ltbSecteurs.Location = new System.Drawing.Point(337, 30);
            this.ltbSecteurs.Name = "ltbSecteurs";
            this.ltbSecteurs.Size = new System.Drawing.Size(182, 289);
            this.ltbSecteurs.TabIndex = 25;
            // 
            // frmInformationsDirecteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1123, 576);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDirecteurs);
            this.Controls.Add(this.cbbDirecteur);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmInformationsDirecteurs";
            this.Text = "Informations sur les Directeurs";
            this.Load += new System.EventHandler(this.frmMesInformations_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.ComboBox cbbDirecteur;
        private System.Windows.Forms.Label lblDirecteurs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.ListBox ltbSecteurs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ltbVisiteurs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegion;
    }
}