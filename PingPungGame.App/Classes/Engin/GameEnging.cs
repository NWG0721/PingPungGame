using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace PingPungGame.App
{
    public static class GameEnging
    {

        public static Rectangle Ball { set; get; } // Ball          -->         0

        public static Rectangle Racket { set; get; } // Racket      -->         1

        public static Rectangle LSide { set; get; } // S1           -->         2

        public static Rectangle TSide { set; get; } // S2           -->         3

        public static Rectangle RSide { set; get; } // S3           -->         4



        private static int _accidents;

        private static int _lastSide;



        public static int GameResponse()
        {

            Random _rand = new Random();
            int _randNumbr = _rand.Next(0, 4);
            if (Ball.IntersectsWith(Racket))
            {
                return MovementSelector(_randNumbr, 1);
            }

            if (Ball.IntersectsWith(LSide))
            {
                return MovementSelector(_randNumbr, 2);
            }

            if (Ball.IntersectsWith(TSide))
            {
                return MovementSelector(_randNumbr, 3);
            }

            if (Ball.IntersectsWith(RSide))
            {
                return MovementSelector(_randNumbr, 4);
            }

            else
            {
                return 0;
            }
        }

        private static int MovementSelector(int _randNumbr, int _side)
        {
            if (_side == 1)
            {
                switch (_randNumbr)
                {
                    case 0:
                        return 3;
                    case 1:
                        return 4;
                    case 2:
                        return 7;
                    case 3:
                        return 8;
                    default: return 0;
                }
            }
            if (_side == 2)
            {
                switch (_randNumbr)
                {
                    case 0:
                        return 2;
                    case 1:
                        return 4;
                    case 2:
                        return 6;
                    case 3:
                        return 8;
                    default: return 0;
                }
            }
            if (_side == 3)
            {
                switch (_randNumbr)
                {
                    case 0:
                        return 1;
                    case 1:
                        return 2;
                    case 2:
                        return 5;
                    case 3:
                        return 6;
                    default: return 0;
                }
            }
            if (_side == 4)
            {
                switch (_randNumbr)
                {
                    case 0:
                        return 1;
                    case 1:
                        return 3;
                    case 2:
                        return 5;
                    case 3:
                        return 7;
                    default: return 0;
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
                    _point[0] = _ballLocation[0] + 4;
                    _point[1] = _ballLocation[1] + 4;

                    return _point;

                //------------------------------| If accidents with rect 2 |------------------------------//
                case 2:
                    _point[0] = _ballLocation[0] + 4;
                    _point[1] = _ballLocation[1] - 4;

                    return _point;
                //------------------------------| If accidents with rect 3 |------------------------------//
                case 3:
                    _point[0] = _ballLocation[0] - 4;
                    _point[1] = _ballLocation[1] + 4;

                    return _point;
                //------------------------------| If accidents with rect 3 |------------------------------//
                case 4:
                    _point[0] = _ballLocation[0] - 4;
                    _point[1] = _ballLocation[1] - 4;

                    return _point;
                //------------------------------| If accidents with rect 2  |------------------------------//
                case 5:
                    _point[0] = _ballLocation[0] + 4;
                    _point[1] = _ballLocation[1] + 2;

                    return _point;

                //------------------------------| If accidents with rect 2 |------------------------------//
                case 6:
                    _point[0] = _ballLocation[0] + 4;
                    _point[1] = _ballLocation[1] - 2;

                    return _point;
                //------------------------------| If accidents with rect 3 |------------------------------//
                case 7:
                    _point[0] = _ballLocation[0] - 4;
                    _point[1] = _ballLocation[1] + 2;

                    return _point;
                //------------------------------| If accidents with rect 3 |------------------------------//
                case 8:
                    _point[0] = _ballLocation[0] - 4;
                    _point[1] = _ballLocation[1] - 2;

                    return _point;
                default:
                    _point[0] = -1;
                    _point[1] = -1;
                    return _point;

            }
        }
        public static int PointCrator()
        {
            int _random;
            Random random = new Random();
            while (true)
            {
                _random = random.Next(299, 299 + 255);
                if (_random != 444)
                {
                    return _random;
                }

            }
        }
    }
}









//------------------------------| There are for version 2 or more |------------------------------//

//private static int[,] LacationConvertor(int _x, int _y)
//{
//    /*

//    The big picture of game form is: s

//        852, 772

//    The small picture of game form is: 

//        852, 528

//    Convert  --> 

//        852/2 => 426 => X = 0

//        528/2 => 264 => Y = 0

//    Example : 

//        Input X = 540 , Y = 300 ->

//               X -> 540 - 426

//               Y -> 300 - 264

//        Output X = 24 , Y = 36

//    */

//    //------------------------------| Code Starts |------------------------------//
//    int _mainX = 426;
//    int _mainY = 264;

//    int _xCalc = _x - _mainX;
//    int _yCalc = _y - _mainY;

//    int[,] _newLocation = { { _xCalc }, { _yCalc } };

//    return _newLocation;
//    //------------------------------| Code Ends |------------------------------//
//}



/*

Point Maker


This function is for 
Making a new point for
Teleporting a ball to another
Location ( _thirdPoint ) of game 

Example : 

    _firstPoint : x1 , y1 
        x1 = 150 (It's a random variable)
        y1 = 300 (This is fixed for the first time of playing on 300)

-----------------------------------------------------------------------------

Convert to vectorial = LacationConvertor(int _x, int _y)

        x1 =>  426 - 150 =   276 <-- This is an answer
        y1 =>  264 - 300 =   -36 <-- This is an answer

▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄

    _secondPoint : x2 , y2
        x2 = 22.5~ 22   OR   (  (852 / 2) - (45 / 2)  )
        y2 = 401    OR   (   446-45  )

-----------------------------------------------------------------------------

Convert to vectorial = LacationConvertor(int _x, int _y)

        x2 =>  426 - 22 =   404 <-- This is an answer
        y2 =>  264 - 401 =   -137 <-- This is an answer

    _thirdPoint : x3 , y3 

▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄

    _slope      y2 - y1   -137 - (-36)   -36
                ─────── = ──────────── = ─── = -36/128 = -0.28125
                x2 - x1    404 - 276     128

▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄

    If an  accident was on the walls: 
        The location of ball usialy is on the 



int[,] _firstPoint;
int[,] _secondPoint;
int[,] _thirdPoint = new int[1, 1];

_firstPoint = LacationConvertor(x1, y1);
_firstPoint = LacationConvertor(x2, y2);
return _thirdPoint;


 */
