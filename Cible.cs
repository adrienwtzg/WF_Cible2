using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Cible2
{
    class Cible
    {
        //Variables d'instances
        int size; //Taille de la cible
        PointF location;

        //Constantes
        const int SIZE_DEFAUT = 300;
        static PointF LOCATION_DEFAUT = new PointF(0, 0);

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="location">Position de la cible</param>
        /// <param name="size">Taille de la cible</param>
        public Cible(PointF location, int size)
        {
            this.location = location;
            this.size = size;
        }

        /// <summary>
        /// Constructeur pour valeurs par défaut
        /// </summary>
        public Cible() : this(LOCATION_DEFAUT, SIZE_DEFAUT)
        {
        }

        /// <summary>
        /// Paramètre location (entre nous c'est un pointF)
        /// </summary>
        public PointF Location
        {
            get { return location; }
            set { location = value; }
        }

        /// <summary>
        /// Fonction qui dessine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Paint(object sender, PaintEventArgs e)
        {
            //Grand Cercle
            e.Graphics.DrawEllipse(Pens.Red, new Rectangle(Point.Round(location), new Size(size, size))); //Dessine le grand cercle

            //Moyen Cercle
            PointF locationMoyen = new PointF(location.X + size / 4, location.Y + size / 4); //Point de cercle moyen
            int sizeMoyen = size / 2; //Taille de cercle moyen
            e.Graphics.DrawEllipse(Pens.Red, new Rectangle(Point.Round(locationMoyen), new Size(sizeMoyen, sizeMoyen))); //Dessine le cercle moyen

            //Petit Cercle
            int sizePetit = size / 8; //Taille de cercle petit
            PointF locationPetit = new PointF((location.X + size / 2) - sizePetit / 2, (location.Y + size / 2) - sizePetit / 2); //Point de cercle petit
            e.Graphics.FillEllipse(Brushes.Red, new Rectangle(Point.Round(locationPetit), new Size(sizePetit, sizePetit))); //Dessine le cercle petit
        }
    }
} 
