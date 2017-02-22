namespace WF_Cible2
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.vsbCible = new System.Windows.Forms.VScrollBar();
            this.hsbCible = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // vsbCible
            // 
            this.vsbCible.Dock = System.Windows.Forms.DockStyle.Right;
            this.vsbCible.Location = new System.Drawing.Point(842, 0);
            this.vsbCible.Name = "vsbCible";
            this.vsbCible.Size = new System.Drawing.Size(17, 657);
            this.vsbCible.TabIndex = 0;
            this.vsbCible.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbCible_Scroll);
            // 
            // hsbCible
            // 
            this.hsbCible.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hsbCible.Location = new System.Drawing.Point(0, 640);
            this.hsbCible.Name = "hsbCible";
            this.hsbCible.Size = new System.Drawing.Size(842, 17);
            this.hsbCible.TabIndex = 1;
            this.hsbCible.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbCible_Scroll);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 657);
            this.Controls.Add(this.hsbCible);
            this.Controls.Add(this.vsbCible);
            this.Name = "frmMain";
            this.Text = "Cible v2";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.VScrollBar vsbCible;
        private System.Windows.Forms.HScrollBar hsbCible;
    }
}

