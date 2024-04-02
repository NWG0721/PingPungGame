using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PingPungGame.App.Classes.BackEnd;
using PingPungGame.App;
using System.Threading;
using System.Collections.Specialized;
using System.Runtime.InteropServices;

namespace PingPungGame.App
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        private int _random;
        private int[,] _thirdPoint;
        private int _isInsert;
        private void Form1_Load(object sender, EventArgs e)
        {
            txtRacket.Text = DataGetter.GetUserName;
            Random random = new Random();
            while (true)
            {
                _random = random.Next(100, 800);
                if (_random != 444)
                {
                    break;
                }

            }
            picBall.Location = new Point(_random, 300);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GameEnging.Rect1 = picBall.Bounds;
            GameEnging.Rect2 = txtRacket.Bounds;//Down
            GameEnging.Rect3 = s1.Bounds;//Side
            GameEnging.Rect4 = s2.Bounds;//Up
            GameEnging.Rect5 = s3.Bounds;//Side
            //timer1.Enabled=!timer1.Enabled;
            //Random rand = new Random();
            //int randLocation = rand.Next(100, 963);
            //picBall.Location = new Point(randLocation, 0);
            //GameEnging.BallMovement(randLocation);
            /* string getter = */
            _isInsert = GameEnging.GameResponse(true);
            if (_isInsert != 0)
            {
            }
            textBox1.Text = _isInsert.ToString();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            Thread.Sleep(1000);
            picBall.Location = new Point((852 / 2) - (45 / 2), 446 - 45);
                _thirdPoint = GameEnging.PointMaker(_random, 300, (852 / 2) - (45 / 2), 446-45);
                //MessageBox.Show($"X = {_thirdPoint[0, 0]} , Y = {_thirdPoint[1, 0]}");
                picBall.Location = new Point(_thirdPoint[0, 0], _thirdPoint[1, 0]);
                //MessageBox.Show(_random.ToString());
                chartLocation.Series["Location"].Points.AddXY(_random, 300);
                chartLocation.Series["Location"].Points.AddXY((852 / 2) - (45 / 2), 446-45);
                chartLocation.Series["Location"].Points.AddXY(_thirdPoint[0, 0], _thirdPoint[1, 0]);
                textBox1.Text =
                    $"X1 = {_random} | Y1 = {300} \n" +
                    $"X2 = {(852 / 2) - (45 / 2)} | Y2 = {490} \n" +
                    $"X3 = {_thirdPoint[0, 0]} | Y3 = {_thirdPoint[1, 0]} \n";

        }
        
    }
}
