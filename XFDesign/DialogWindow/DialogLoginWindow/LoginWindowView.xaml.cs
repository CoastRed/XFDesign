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
using System.Windows.Shapes;
using XFDesign.DialogWindow.DialogLoginWindow.Interface;

namespace XFDesign.DialogWindow.DialogLoginWindow
{
    /// <summary>
    /// LoginWindowView.xaml 的交互逻辑
    /// </summary>
    public partial class LoginWindowView : Window, ILoginWindow
    {
        public LoginResult? Result { get; set; }
        public Action<LoginResult>? Collback { get; set; }
        public LoginWindowView()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.user_tb.Focus();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
