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
        private int[,] _thirdPoint;
        private int _isInsert;


        public Game()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            txtRacket.Text = DataGetter.GetUserName;

            picBall.Location = new Point(GameEnging.PointCrator(), 404);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int[] _ballLocation = new int[2];

            GameEnging.Ball = picBall.Bounds;//        Ball

            GameEnging.Racket = txtRacket.Bounds;//      Down

            GameEnging.LSide = s1.Bounds;//             Side Left

            GameEnging.TSide = s2.Bounds;//             Up

            GameEnging.RSide = s3.Bounds;//             Side Right

            int _accident = GameEnging.GameResponse();

            if (_accident != 0)
            {
                _isInsert = _accident;
            }

            _ballLocation[0] = picBall.Location.X;
            _ballLocation[1] = picBall.Location.Y;

            _ballLocation = GameEnging.PointMaker(_isInsert,_ballLocation);

            if (_ballLocation[0] != -1 && _ballLocation[1] != -1)
            {
                picBall.Location = new Point(_ballLocation[0], _ballLocation[1]);
            }
            //textBox1.Text += _isInsert.ToString();
            if (picBall.Location.Y > 480)
            {
                timer1.Enabled = false;
                //MessageBox.Show("You are a motherfucking loser, bitch!");
                MessageBox.Show("You are a loser!");

            }
            chartLocation.Series["Location"].Points.AddXY(_isInsert - (_isInsert - 1), _isInsert);

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            /*

            picBall.Location = new Point((852 / 2) - (45 / 2), 446 - 45);
            _thirdPoint = GameEnging.PointMaker(_random, 300, (852 / 2) - (45 / 2), 446 - 45);
            //MessageBox.Show($"X = {_thirdPoint[0, 0]} , Y = {_thirdPoint[1, 0]}");
            picBall.Location = new Point(_thirdPoint[0, 0], _thirdPoint[1, 0]);
            //MessageBox.Show(_random.ToString());
            chartLocation.Series["Location"].Points.AddXY(_random, 300);
            chartLocation.Series["Location"].Points.AddXY((852 / 2) - (45 / 2), 446 - 45);
            chartLocation.Series["Location"].Points.AddXY(_thirdPoint[0, 0], _thirdPoint[1, 0]);
            textBox1.Text =
                $"X1 = {_random} | Y1 = {300} \n" +
                $"X2 = {(852 / 2) - (45 / 2)} | Y2 = {490} \n" +
                $"X3 = {_thirdPoint[0, 0]} | Y3 = {_thirdPoint[1, 0]} \n";
             */
            Thread.Sleep(1000);
            timer1.Enabled = true;

        }

        private void picBall_Click(object sender, EventArgs e)
        {

        }
    }
}
