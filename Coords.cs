using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeLaVieConsole
{
    public struct Coords
    {

        private int _x;

        public int x
        {
            get { return _x; }
            set { _x = value; }
        }

        private int _y;

        public int y
        {
            get { return _y; }
            set { _y = value; }
        }

        public Coords (int X, int Y)
        {
            //oui je sais qu'on doit normalement utiliser l'accesseur
            //mais a priori là je ne peux pas car ma version de C# est trop vieille
            //et je ne peux pas la mettre à jour car dotnet est juste buggé
            _x = X;
            _y = Y;
        }

        public override string ToString()
        {
            return "( " + this.x + " , " + this.y + " )";
        }

    }
}
