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
        /// 卡片背景颜色
        /// </summary>
        public Brush BorderBackground
        {
            get { return (Brush)GetValue(BorderBackgroundProperty); }
            set { SetValue(BorderBackgroundProperty, value); }
        }
        /// <summary>
        /// 卡片背景颜色
        /// </summary>
        public static readonly DependencyProperty BorderBackgroundProperty = DependencyProperty.Register("BorderBackground", typeof(Brush), typeof(SmallInfoCard));


        /// <summary>
        /// 卡片上圆的背景颜色
        ///</summary>
        public Brush EllipseBackground
        {
            get { return (Brush)GetValue(EllipseBackgroundProperty); }
            set { SetValue(EllipseBackgroundProperty, value); }
        }

        // <summary>
        /// 卡片上圆的背景颜色
        /// </summary>
        public static readonly DependencyProperty EllipseBackgroundProperty =
            DependencyProperty.Register("EllipseBackground", typeof(Brush), typeof(SmallInfoCard));
    }
}
