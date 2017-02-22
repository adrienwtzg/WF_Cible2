using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Cible2
{
    public partial class frmMain : Form
    {
        Cible maCible = new Cible(new PointF(100, 100), 300);

        public frmMain()
        {
            DoubleBuffered = true; //Evite de la vascillement de l'image
            InitializeComponent();
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            maCible.Paint(sender, e); //Appelle la fonction Paint de la classe Cible
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Assigne les dimensions de la fenêtre au max des Scrollbars
            hsbCible.Maximum = (sender as Form).Width; 
            vsbCible.Maximum = (sender as Form).Height;
            hsbCible.Value = (int)(maCible.Location.X);
            vsbCible.Value = (int)(maCible.Location.Y);
        }

        private void hsbCible_Scroll(object sender, ScrollEventArgs e)
        {
            maCible.Location = new PointF(hsbCible.Value, maCible.Location.Y);
            Invalidate(); //Rafraichis l'image
        }

        private void vsbCible_Scroll(object sender, ScrollEventArgs e)
        {
            maCible.Location = new PointF(maCible.Location.X, vsbCible.Value);
            Invalidate(); //Rafraichis l'image
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            //Assigne les dimensions de la fenêtre au max des Scrollbars
            hsbCible.Maximum = (sender as Form).Width;
            vsbCible.Maximum = (sender as Form).Height;
            hsbCible.Value = (int)(maCible.Location.X);
            vsbCible.Value = (int)(maCible.Location.Y);
        }
    }
}
