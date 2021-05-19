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
    class stering
    {
        static public int _stering(object sender, KeyEventArgs e, int moveX, Image F1)
        {
            if (e.Key == Key.Left)
            {
                F1.RenderTransform = new RotateTransform(-5);
                moveX = -5;
            }

            if (e.Key == Key.Right)
            {
                F1.RenderTransform = new RotateTransform(5);
                moveX = 5;
            }

            return moveX;

        }
    }
}
