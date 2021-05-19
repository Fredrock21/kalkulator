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
    class accelerates
    {
        static public int _accelerates(object sender, KeyEventArgs e, int moveY, Image F1)
        {
            if (e.Key == Key.Up)
            {
                F1.RenderTransform = new RotateTransform(0);
                moveY = -5;
            }

            if (e.Key == Key.Down)
            {
                F1.RenderTransform = new RotateTransform(0);
                moveY = 5;
            }

            return moveY;

        }
    }
}