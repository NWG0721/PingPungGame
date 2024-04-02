using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace PingPungGame.App
{
    public static class GameEnging
    {
        private static int _accidents;
        public static int GameResponse(bool _true)
        {
            //string backer = BallReaction();
            //return backer;
            if (Rect1.IntersectsWith(Rect2) || Rect1.IntersectsWith(Rect3) || Rect1.IntersectsWith(Rect4) || Rect1.IntersectsWith(Rect5))
            {
                //MessageBox.Show("1");
                if (Rect1.IntersectsWith(Rect2) || Rect1.IntersectsWith(Rect4))
                {
                    //MessageBox.Show("2");
                    return 2;
                }
                if (Rect1.IntersectsWith(Rect3) || Rect1.IntersectsWith(Rect5))
                {

                    //MessageBox.Show("1");
                    return 1;

                }
                else
                { return 0; }

            }
            else
            {
                return 0;
            }
            //return move;

        }
        public static Rectangle Rect1
        {
            set;
            get;
        }
        public static Rectangle Rect2
        {
            get;
            set;
        }
        public static Rectangle Rect3
        {
            get;
            set;
        }
        public static Rectangle Rect4
        {
            get;
            set;
        }
        public static Rectangle Rect5
        {
            get;
            set;
        }
        public static int[,] PointMaker(int x1, int y1, int x2, int y2)
        {
            int[,] _firstPoint;
            int[,] _secondPoint;
            int[,] _thirdPoint;

            _firstPoint = LacationConvertor(x1,y1);
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
