using JeuDeLaVieConsole;
using JeuDeLaVieGraphique.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuDeLaVieGraphique
{
    public partial class Form1 : Form
    {

        public int n;
        public ZoneJeu zoneJeu;
        public Titre titre;
        private Game game = new Game(4, 10);
        private static readonly Timer Timer = new Timer();
        private int generation;
        public Form1(int n = 40)
        {
            InitializeComponent();

            this.n = n;
            zoneJeu = new ZoneJeu(n);
            titre = new Titre();
            generation = 0;

            Timer.Interval = 200;
            Timer.Start();
            Timer.Tick += UpdateGrid;
            game.RunGameConsole();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(100, 100);
            this.Size = new Size(800, 500);
            this.Text = "Jeu de la vie";

            int centerX = (this.ClientSize.Width - zoneJeu.Width) / 2;
            int centerY = (this.ClientSize.Height - zoneJeu.Height) / 2;

            titre.Location = new Point(centerX, centerY - titre.Height - 10);

            zoneJeu.Location = new Point(centerX, centerY);


            titre.Visible = true;
            zoneJeu.Visible = true;

            this.Controls.Add(zoneJeu);
            this.Controls.Add(titre);

        }

        private void UpdateGrid(object sender, EventArgs e)
        {

            // Mise à jour de la grille du jeu

            // Incrémentation de 1 de la variable generation

            // Mise à jour du label avec la valeur contenue dans generation

            // Mise à jour de la fenêtre graphique



        }
    }
}
