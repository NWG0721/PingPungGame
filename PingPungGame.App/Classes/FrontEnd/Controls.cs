using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPungGame.App
{
     public partial class Game
    {
        private Point MouseDownLocation;
        private void txtRacket_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor.Hide();
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }
        private void txtRacket_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                txtRacket.Left = e.X + txtRacket.Left - MouseDownLocation.X;
            }
        }

        private void txtRacket_MouseUp(object sender, MouseEventArgs e)
        {
           Cursor.Show();
        }






        private void picBall_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor.Hide();
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void picBall_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                picBall.Left = e.X + picBall.Left - MouseDownLocation.X;
                picBall.Top = e.Y + picBall.Top - MouseDownLocation.Y;
            }
        }

        private void picBall_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor.Show();
        }
    }
}
