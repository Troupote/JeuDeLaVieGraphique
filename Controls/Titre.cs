using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuDeLaVieGraphique.Controls
{
    public class Titre : Label
    {
        public Titre()
        {
            this.Text = "";
            this.ForeColor = System.Drawing.Color.Black;
            this.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Width = 100;
            this.Height = 23;
            this.BorderStyle = BorderStyle.FixedSingle;
            

        }
    }
}
