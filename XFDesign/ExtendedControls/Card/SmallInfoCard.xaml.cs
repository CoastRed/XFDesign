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

namespace XFDesign.ExtendedControls
{
    /// <summary>
    /// SmallInfoCard.xaml 的交互逻辑
    /// </summary>
    public partial class SmallInfoCard : UserControl
    {
        /// <summary>
        /// 信息卡片
        /// </summary>
        public SmallInfoCard()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 卡片标题名称
        /// </summary>
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        /// <summary>
        /// 卡片标题名称
        /// </summary>
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(SmallInfoCard));

        /// <summary>
        /// 要显示的数字
        /// </summary>
        public string Number
        {
            get { return (string)GetValue(NumberProperty); }
            set { SetValue(NumberProperty, value); }
        }
        /// <summary>
        /// 要显示的数字
        /// </summary>
        public static readonly DependencyProperty NumberProperty = DependencyProperty.Register("Number", typeof(string), typeof(SmallInfoCard));

        /// <summary>
        /// 卡片背景颜色1
        /// </summary>
        public Color Background1
        {
            get { return (Color)GetValue(Background1Property); }
            set { SetValue(Background1Property, value); }
        }
        /// <summary>
        /// 卡片背景颜色1
        /// </summary>
        public static readonly DependencyProperty Background1Property = DependencyProperty.Register("Background1", typeof(Color), typeof(SmallInfoCard));

        /// <summary>
        /// 卡片背景颜色2
        /// </summary>
        public Color Background2
        {
            get { return (Color)GetValue(Background2Property); }
            set { SetValue(Background2Property, value); }
        }
        /// <summary>
        /// 卡片背景颜色2
        /// </summary>
        public static readonly DependencyProperty Background2Property = DependencyProperty.Register("Background2", typeof(Color), typeof(SmallInfoCard));

        /// <summary>
        /// 卡片上圆的背景颜色1
        /// </summary>
        public Color EllipseBackground1
        {
            get { return (Color)GetValue(EllipseBackground1Property); }
            set { SetValue(EllipseBackground1Property, value); }
        }
        /// <summary>
        /// 卡片上圆的背景颜色1
        /// </summary>
        public static readonly DependencyProperty EllipseBackground1Property = DependencyProperty.Register("EllipseBackground1", typeof(Color), typeof(SmallInfoCard));

        /// <summary>
        /// 卡片上圆的背景颜色2
        /// </summary>
        public Color EllipseBackground2
        {
            get { return (Color)GetValue(EllipseBackground2Property); }
            set { SetValue(EllipseBackground2Property, value); }
        }
        /// <summary>
        /// 卡片上圆的背景颜色2
        /// </summary>
        public static readonly DependencyProperty EllipseBackground2Property = DependencyProperty.Register("EllipseBackground2", typeof(Color), typeof(SmallInfoCard));
    }
}
