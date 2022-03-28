
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfoRegion));
            this.cbbRegion = new System.Windows.Forms.ComboBox();
            this.cbbSecteur = new System.Windows.Forms.ComboBox();
            this.lblNomDirecteur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbRegion
            // 
            this.cbbRegion.FormattingEnabled = true;
            this.cbbRegion.Location = new System.Drawing.Point(86, 75);
            this.cbbRegion.Name = "cbbRegion";
            this.cbbRegion.Size = new System.Drawing.Size(151, 28);
            this.cbbRegion.TabIndex = 0;
            this.cbbRegion.SelectedIndexChanged += new System.EventHandler(this.cbbRegion_SelectedIndexChanged);
            // 
            // cbbSecteur
            // 
            this.cbbSecteur.FormattingEnabled = true;
            this.cbbSecteur.Location = new System.Drawing.Point(611, 75);
            this.cbbSecteur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbSecteur.Name = "cbbSecteur";
            this.cbbSecteur.Size = new System.Drawing.Size(138, 28);
            this.cbbSecteur.TabIndex = 2;
            // 
            // lblNomDirecteur
            // 
            this.lblNomDirecteur.AutoSize = true;
            this.lblNomDirecteur.Location = new System.Drawing.Point(86, 118);
            this.lblNomDirecteur.Name = "lblNomDirecteur";
            this.lblNomDirecteur.Size = new System.Drawing.Size(50, 20);
            this.lblNomDirecteur.TabIndex = 3;
            this.lblNomDirecteur.Text = "label1";
            // 
            // frmInfoRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GSB.Properties.Resources.laboratoire;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.lblNomDirecteur);
            this.Controls.Add(this.cbbSecteur);
            this.Controls.Add(this.cbbRegion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInfoRegion";
            this.Text = "Information sur les régions";
            this.Load += new System.EventHandler(this.frmInfoRegion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbRegion;
        private System.Windows.Forms.ComboBox cbbSecteur;
        private System.Windows.Forms.Label lblNomDirecteur;
    }
}