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

        public static Rectangle Rect1 { set; get; } // Ball

        public static Rectangle Rect2 { set; get; } // Racket

        public static Rectangle Rect3 { set; get; } // S1

        public static Rectangle Rect4 { set; get; } // S2

        public static Rectangle Rect5 { set; get; } // S3

        public static int GameResponse()
        {
            Random _rand = new Random();
            int _randNumbr = _rand.Next(0, 2);
            if (Rect1.IntersectsWith(Rect2))
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
            if (Rect1.IntersectsWith(Rect3))
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
            if (Rect1.IntersectsWith(Rect4))
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
            if (Rect1.IntersectsWith(Rect5))
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

        public static int[,] PointMaker(int x1, int y1, int x2, int y2)
        {
            /*
             
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
                    

             */
            int[,] _firstPoint;
            int[,] _secondPoint;
            int[,] _thirdPoint = new int[1, 1];

            _firstPoint = LacationConvertor(x1, y1);
            _firstPoint = LacationConvertor(x2, y2);
            return _thirdPoint;


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
