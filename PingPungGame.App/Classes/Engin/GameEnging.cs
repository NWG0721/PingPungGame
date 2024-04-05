using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace PingPungGame.App
{
    public static class GameEnging
    {
        private static int _accidents;

        public static Rectangle Ball { set; get; } // Ball

        public static Rectangle Racket { set; get; } // Racket

        public static Rectangle LSide { set; get; } // S1

        public static Rectangle TSide { set; get; } // S2

        public static Rectangle RSide { set; get; } // S3

        public static int GameResponse()
        {
            Random _rand = new Random();
            int _randNumbr = _rand.Next(0, 2);
            if (Ball.IntersectsWith(Racket))
            {
                if (_randNumbr == 1)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
            if (Ball.IntersectsWith(LSide))
            {
                if (_randNumbr == 1)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            if (Ball.IntersectsWith(TSide))
            {
                if (_randNumbr == 1)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
            if (Ball.IntersectsWith(RSide))
            {
                if (_randNumbr == 1)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                return 0;
            }
        }

        public static int[] PointMaker(int _isInsert, int[] _ballLocation)
        {
            int[] _point = new int[2];

            switch (_isInsert)
            {
                //------------------------------| If accidents with rect 2  |------------------------------//
                case 1:
                    _point[0] = _ballLocation[0] + 2;
                    _point[1] = _ballLocation[1] + 2;

                    return _point;

                //------------------------------| If accidents with rect 2 |------------------------------//
                case 2:
                    _point[0] = _ballLocation[0] + 2;
                    _point[1] = _ballLocation[1] - 2;

                    return _point;
                //------------------------------| If accidents with rect 3 |------------------------------//
                case 3:
                    _point[0] = _ballLocation[0] - 2;
                    _point[1] = _ballLocation[1] + 2;

                    return _point;
                //------------------------------| If accidents with rect 3 |------------------------------//
                case 4:
                    _point[0] = _ballLocation[0] - 2;
                    _point[1] = _ballLocation[1] - 2;

                    return _point;
                default:
                    _point[0] = -1;
                    _point[1] = -1;
                    return _point;

            }
        }
        private static int[,] LacationConvertor(int _x, int _y)
        {
            /*

            The big picture of game form is: s

                852, 772

            The small picture of game form is: 

                852, 528

            Convert  --> 

                852/2 => 426 => X = 0

                528/2 => 264 => Y = 0

            Example : 

                Input X = 540 , Y = 300 ->

                       X -> 540 - 426

                       Y -> 300 - 264

                Output X = 24 , Y = 36
            
            */

            //------------------------------| Code Starts |------------------------------//
            int _mainX = 426;
            int _mainY = 264;

            int _xCalc = _x - _mainX;
            int _yCalc = _y - _mainY;

            int[,] _newLocation = { { _xCalc }, { _yCalc } };

            return _newLocation;
            //------------------------------| Code Ends |------------------------------//
        }
    }
}
