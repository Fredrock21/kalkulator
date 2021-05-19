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

namespace RasingDEMO2._0
{
    /// <summary>
    /// Interaction logic for GameView.xaml
    /// </summary>
    public partial class GameView : UserControl
    {
        public GameView()
        {
            InitializeComponent();

            gameTimer.Tick += MainEventTimer;
            gameTimer.Interval = TimeSpan.FromMilliseconds(20);
            StartGame();
        }


        DispatcherTimer gameTimer = new DispatcherTimer();

        int lives = 1;
        double dis = 0;
        int moveX = 0;
        Rect F1HitBox;
        Random speed = new Random();
        int moveY = 0;

        private void MainEventTimer(object sender, EventArgs e)
        {
            livs.Content = "lives: " + lives;
            distanc.Content = "Distanc " + dis + " m";

            F1HitBox = new Rect(Canvas.GetLeft(F1) + 10, Canvas.GetTop(F1) + 10, F1.Width - 20, F1.Height - 20);

            Canvas.SetLeft(F1, Canvas.GetLeft(F1) + moveX);
            Canvas.SetTop(F1, Canvas.GetTop(F1) + moveY);



            foreach (var y in MyCanvas.Children.OfType<Image>())
            {
                if ((string)y.Tag == "Line1" || (string)y.Tag == "Line2" || (string)y.Tag == "Line3" || (string)y.Tag == "Line4" || (string)y.Tag == "Line5")
                {
                    Canvas.SetTop(y, Canvas.GetTop(y) + 10);

                    if (Canvas.GetTop(y) > 300)
                    {
                        Canvas.SetTop(y, -60);

                        dis += 1;
                    }

                }


                int carmove = Difficulty.difficulty(dis);
                Random plasment = new Random();
                int flytaX = plasment.Next(1, 500);

                if ((string)y.Tag == "car1" || (string)y.Tag == "car2" || (string)y.Tag == "car3" || (string)y.Tag == "car4" || (string)y.Tag == "car5")
                {
                    Canvas.SetTop(y, Canvas.GetTop(y) + carmove);

                    if (Canvas.GetTop(y) > 400)
                    {
                        Canvas.SetLeft(y, flytaX);
                        Canvas.SetTop(y, -90); // återför bilarna till toppen 
                    }

                }

                Crash.crash(gameTimer, lives, livs, F1, car1, car2, car3, car4, F1HitBox);

            }
        }

        private void Stering(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left || e.Key == Key.Right)
            {
                moveX = stering._stering(sender, e, moveX, F1);
            }
            else if (e.Key == Key.R)
            {
                StartGame();
            }
            else
            {
                moveY = accelerates._accelerates(sender, e, moveY, F1);
            }
        }

        private void Crusing(object sender, KeyEventArgs e)
        {
            F1.RenderTransform = new RotateTransform(0); // steller hastighet till 0 
            moveX = 0;
            moveY = 0;
        }

        private void StartGame()
        {
            MyCanvas.Focus();

            Canvas.SetLeft(F1, 220);
            Canvas.SetTop(F1, 205);

            lives = 1;

            dis = 0;

            foreach (var y in MyCanvas.Children.OfType<Image>())
            {
                if ((string)y.Tag == "Line1")
                {

                    Canvas.SetTop(y, 300);
                }

                if ((string)y.Tag == "Line2")
                {
                    Canvas.SetTop(y, 210);
                }

                if ((string)y.Tag == "Line3")
                {
                    Canvas.SetTop(y, 120);
                }

                if ((string)y.Tag == "Line4")
                {
                    Canvas.SetTop(y, 30);
                }
                if ((string)y.Tag == "Line5")
                {
                    Canvas.SetTop(y, -60);
                }

                if ((string)y.Tag == "car1")
                {
                    Canvas.SetTop(y, -400);
                }
                if ((string)y.Tag == "car2")
                {
                    Canvas.SetTop(y, -100);
                }
                if ((string)y.Tag == "car3")
                {
                    Canvas.SetTop(y, -340);
                }
                if ((string)y.Tag == "car4")
                {
                    Canvas.SetTop(y, -200);
                }
            }
            gameTimer.Start();
        }
    }
}
