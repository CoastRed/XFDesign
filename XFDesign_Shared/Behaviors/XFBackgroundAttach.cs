using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace XFDesign_Shared.Behaviors
{
    public class XFBackgroundAttach
    {


        public static Brush GetXFBackground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(XFBackgroundProperty);
        }

        public static void SetXFBackground(DependencyObject obj, Brush value)
        {
            obj.SetValue(XFBackgroundProperty, value);
        }

        // Using a DependencyProperty as the backing store for XFBackground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty XFBackgroundProperty =
            DependencyProperty.RegisterAttached("XFBackground", typeof(Brush), typeof(XFBackgroundAttach), new PropertyMetadata(Brushes.Orange));


    }
}
