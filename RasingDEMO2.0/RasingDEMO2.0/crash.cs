using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Windows.Threading;


namespace RasingDEMO2
{
    class Crash
    {
        static public void crash(DispatcherTimer gameTimer, int lives, Label livs, Image F1, Image car1, Image car2, Image car3, Image car4, Rect F1HitBox)
        {
            if (Canvas.GetLeft(F1) < -25 || Canvas.GetLeft(F1) > 460)
            {
                EndGame.endgame(gameTimer, lives, livs);
            }

            Rect CarHitBox1 = new Rect(Canvas.GetLeft(car1), Canvas.GetTop(car1), car1.Width, car1.Height);
            if (F1HitBox.IntersectsWith(CarHitBox1))
            {
                EndGame.endgame(gameTimer, lives, livs);
            }

            Rect CarHitBox2 = new Rect(Canvas.GetLeft(car2), Canvas.GetTop(car2), car2.Width, car2.Height);
            if (F1HitBox.IntersectsWith(CarHitBox2))
            {
                EndGame.endgame(gameTimer, lives, livs);
            }

            Rect CarHitBox3 = new Rect(Canvas.GetLeft(car3), Canvas.GetTop(car3), car3.Width, car3.Height);
            if (F1HitBox.IntersectsWith(CarHitBox3))
            {
                EndGame.endgame(gameTimer, lives, livs);
            }

            Rect CarHitBox4 = new Rect(Canvas.GetLeft(car4), Canvas.GetTop(car4), car4.Width, car4.Height);
            if (F1HitBox.IntersectsWith(CarHitBox4))
            {
                EndGame.endgame(gameTimer, lives, livs);
            }

        }
    }
}
