using System.Windows;
using System.Windows.Controls.Primitives;

namespace XFDesign.ExtendedControls
{
    /// <summary>
    /// 圆环进度条
    /// </summary>
    public class CircularProgressBar : RangeBase
    {
        public enum CircularProgressDisplay
        {
            SingleValue = 0,
            DisplayMaxValue = 1,
            DisplayPercentage = 2,
        }

        /// <summary>
        /// 圆环的环宽度
        /// </summary>
        public double RingWidth
        {
            get { return (double)GetValue(RingWidthProperty); }
            set { SetValue(RingWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for  RingWidth.  This enables animation, styling, binding, etc...
        /// <summary>
        /// 圆环的环宽度
        /// </summary>
        public static readonly DependencyProperty RingWidthProperty =
            DependencyProperty.Register("RingWidth", typeof(double), typeof(CircularProgressBar), new PropertyMetadata(10.0));

        /// <summary>
        /// 圆环底色的透明度
        /// </summary>
        public double BackgroundOpacity
        {
            get { return (double)GetValue(BackgroundOpacityProperty); }
            set { SetValue(BackgroundOpacityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BackgroundOpacity.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BackgroundOpacityProperty =
            DependencyProperty.Register("BackgroundOpacity", typeof(double), typeof(CircularProgressBar), new PropertyMetadata(0.0));

        /// <summary>
        /// 圆环颜色透明度
        /// </summary>
        public double ForegroundOpacity
        {
            get { return (double)GetValue(ForegroundOpacityProperty); }
            set { SetValue(ForegroundOpacityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ForegroundOpacity. This enables
        // animation, styling, binding, etc...
        public static readonly DependencyProperty ForegroundOpacityProperty =
            DependencyProperty.Register("ForegroundOpacity", typeof(double), typeof(CircularProgressBar), new PropertyMetadata(0.0));

        /// <summary>
        /// 圆环中间文本的显示模式
        /// </summary>
        public CircularProgressDisplay DisplayTextValue
        {
            get { return (CircularProgressDisplay)GetValue(DisplayTextValueProperty); }
            set { SetValue(DisplayTextValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DisplayTextValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DisplayTextValueProperty =
            DependencyProperty.Register("DisplayTextValue", typeof(CircularProgressDisplay), typeof(CircularProgressBar), new PropertyMetadata(CircularProgressDisplay.SingleValue));

        static CircularProgressBar()
        {
            //DefaultStyleKeyProperty.OverrideMetadata(typeof(CircularProgressBar), new FrameworkPropertyMetadata(typeof(CircularProgressBar)));
        }
    }
}