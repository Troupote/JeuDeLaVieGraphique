using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuDeLaVieGraphique.Controls
{
    public class ZoneJeu : PictureBox
    {
        public int n;

        public ZoneJeu(int n)
        {
            this.n = n;
            this.Width = 5 * this.n;
            this.Height = 5 * this.n;
            this.BackColor = System.Drawing.Color.Black;
            //this.Paint += new PaintEventHandler(this.ZoneJeu_Paint);
        }

    }
}
