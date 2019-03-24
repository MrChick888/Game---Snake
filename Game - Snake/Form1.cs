using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game___Snake
{
    public partial class Background : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private Circle ood = new Circle();

        public Background()
        {
            InitializeComponent();
            new Settings();
            gameTimer.Interval = 1000 / Settings.Speed;
            gameTimer.Tick += UpdateScreen();
            gameTimer.Start();
            StartGame();
        }

        private void StartGame()
        {
            new Settings();
            Snake.Clear();
            Circle head = new Circle();
            head.X = 10;
            head.Y = 5;
            Snake.Add(head);

            LblScore.Text = Settings.Score.ToString();
            GenareteFood();

        }

        private void GenareteFood()
        {

        }
    }
}
