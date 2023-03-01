using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
using XFDesign_Shared.Behaviors;

namespace XFDesign.MessageBox
{
    public enum MessageBoxXFResult
    {
        None,
        OK,
        Cancel,
        Retry
    }

    public enum MessageBoxButtonType
    {
        SingleButton = 1,
        DoubleButton = 2,
        MultipleButton = 3,
    }

    public enum MessageBoxXFImage
    {
        Info,
        Success,
        Warning,
        Error,
        Ask,
    }

    /// <summary>
    /// MessageBoxXF.xaml 的交互逻辑
    /// </summary>
    public partial class MessageBoxXF : Window
    {
        public MessageBoxXFResult Result { get; private set; } = MessageBoxXFResult.None;

        public MessageBoxXF()
        {
            InitializeComponent();
        }

        #region Info


        public static MessageBoxXFResult Info(string message)
        {
            return Show(message, "", MessageBoxXFImage.Info);
        }

        public static MessageBoxXFResult Info(string message, string caption)
        {
            return Show(message, caption, MessageBoxXFImage.Info);
        }

        public static MessageBoxXFResult Info(string message, Brush background)
        {
            return Show(message, "", MessageBoxXFImage.Info, background:background);
        }

        public static MessageBoxXFResult Info(string message, string caption, Brush background)
        {
            return Show(message, caption, MessageBoxXFImage.Info);
        }

        public static MessageBoxXFResult Info(string message, Window owner, Brush background)
        {
            return Show(message, owner:owner, background:background);
        }

        #endregion

        #region Ask

        public static MessageBoxXFResult Question(string message)
        {
            return Show(message, "", MessageBoxXFImage.Ask, MessageBoxButtonType.DoubleButton, null, null);
        }

        public static MessageBoxXFResult Question(string message, string caption)
        {
            return Show(message, caption, MessageBoxXFImage.Ask, MessageBoxButtonType.DoubleButton, null, null);
        }

        public static MessageBoxXFResult Question(string message, Brush background)
        {
            return Show(message, "", MessageBoxXFImage.Ask, MessageBoxButtonType.DoubleButton, null, background);
        }

        public static MessageBoxXFResult Question(string message, string caption, Brush background)
        {
            return Show(message, caption, MessageBoxXFImage.Ask, MessageBoxButtonType.DoubleButton, null, background);
        }

        public static MessageBoxXFResult Question(string message, Window owner, Brush background)
        {
            return Show(message, "", MessageBoxXFImage.Ask, MessageBoxButtonType.DoubleButton, owner, background);
        }

        public static MessageBoxXFResult Question(string message, string caption, MessageBoxButtonType buttonType = MessageBoxButtonType.MultipleButton, Brush? background = null, string okContent = "", string cancelContent = "", string retryContent = "")
        {
            return Show(message, caption, MessageBoxXFImage.Ask, buttonType, null, background, okContent, cancelContent, retryContent);
        }

        #endregion

        #region Warning

        public static MessageBoxXFResult Warning(string message)
        {
            return Show(message, "", MessageBoxXFImage.Warning, MessageBoxButtonType.SingleButton, null, null);
        }

        public static MessageBoxXFResult Warning(string message, string caption)
        {
            return Show(message, caption, MessageBoxXFImage.Warning, MessageBoxButtonType.SingleButton, null, null);
        }

        public static MessageBoxXFResult Warning(string message, Brush background)
        {
            return Show(message, "", MessageBoxXFImage.Warning, MessageBoxButtonType.SingleButton, null, background);
        }

        public static MessageBoxXFResult Warning(string message, string caption, Brush background)
        {
            return Show(message, caption, MessageBoxXFImage.Warning, MessageBoxButtonType.SingleButton, null, background);
        }

        public static MessageBoxXFResult Warning(string message, Window owner, Brush background)
        {
            return Show(message, "", MessageBoxXFImage.Warning, MessageBoxButtonType.SingleButton, owner, background);
        }

        public static MessageBoxXFResult Warning(string message, string caption, MessageBoxButtonType buttonType = MessageBoxButtonType.SingleButton, Brush? background = null, string okContent = "")
        {
            return Show(message, caption, MessageBoxXFImage.Warning, buttonType, null, background, okContent);
        }

        #endregion

        #region Error

        public static MessageBoxXFResult Error(string message)
        {
            return Show(message, "", MessageBoxXFImage.Error, MessageBoxButtonType.SingleButton, null, null);
        }

        public static MessageBoxXFResult Error(string message, string caption)
        {
            return Show(message, caption, MessageBoxXFImage.Error, MessageBoxButtonType.SingleButton, null, null);
        }

        public static MessageBoxXFResult Error(string message, Brush background)
        {
            return Show(message, "", MessageBoxXFImage.Error, MessageBoxButtonType.SingleButton, null, background);
        }

        public static MessageBoxXFResult Error(string message, string caption, Brush background)
        {
            return Show(message, caption, MessageBoxXFImage.Error, MessageBoxButtonType.SingleButton, null, background);
        }

        public static MessageBoxXFResult Error(string message, Window owner, Brush background)
        {
            return Show(message, "", MessageBoxXFImage.Error, MessageBoxButtonType.SingleButton, owner, background);
        }

        public static MessageBoxXFResult Error(string message, string caption, MessageBoxButtonType buttonType = MessageBoxButtonType.SingleButton, Brush? background = null, string okContent = "")
        {
            return Show(message, caption, MessageBoxXFImage.Error, buttonType, null, background, okContent);
        }

        #endregion

        #region Success

        public static MessageBoxXFResult Success(string message)
        {
            return Show(message, "", MessageBoxXFImage.Success, MessageBoxButtonType.SingleButton, null, null);
        }

        public static MessageBoxXFResult Success(string message, string caption)
        {
            return Show(message, caption, MessageBoxXFImage.Success, MessageBoxButtonType.SingleButton, null, null);
        }

        public static MessageBoxXFResult Success(string message, Brush background)
        {
            return Show(message, "", MessageBoxXFImage.Success, MessageBoxButtonType.SingleButton, null, background);
        }

        public static MessageBoxXFResult Success(string message, string caption, Brush background)
        {
            return Show(message, caption, MessageBoxXFImage.Success, MessageBoxButtonType.SingleButton, null, background);
        }

        public static MessageBoxXFResult Success(string message, Window owner, Brush background)
        {
            return Show(message, "", MessageBoxXFImage.Success, MessageBoxButtonType.SingleButton, owner, background);
        }

        public static MessageBoxXFResult Success(string message, string caption, MessageBoxButtonType buttonType = MessageBoxButtonType.SingleButton, Brush? background = null, string okContent = "")
        {
            return Show(message, caption, MessageBoxXFImage.Success, buttonType, null, background, okContent);
        }

        #endregion


        public static MessageBoxXFResult Show(string message, string? caption = "", MessageBoxXFImage image = MessageBoxXFImage.Info, MessageBoxButtonType buttonType = MessageBoxButtonType.SingleButton, Window? owner = null, Brush? background = null, string okContent = "", string cancelContent = "", string retryContent = ""
        )
        {
            MessageBoxXFResult res = MessageBoxXFResult.None;
            Application.Current.Dispatcher.Invoke(() =>
            {
                MessageBoxXF messageBoxXF = new MessageBoxXF();

                if (!string.IsNullOrWhiteSpace(caption))
                {
                    messageBoxXF.tb_caption.Visibility = Visibility.Visible;
                    messageBoxXF.tb_caption.Text = caption;
                }

                switch (image)
                {
                    case MessageBoxXFImage.Info:
                        messageBoxXF.image.Icon = FontAwesome6.EFontAwesomeIcon.Solid_CircleInfo;
                        break;
                    case MessageBoxXFImage.Success:
                        messageBoxXF.image.Icon = FontAwesome6.EFontAwesomeIcon.Regular_CircleCheck;
                        break;
                    case MessageBoxXFImage.Warning:
                        messageBoxXF.image.Icon = FontAwesome6.EFontAwesomeIcon.Solid_CircleExclamation;
                        break;
                    case MessageBoxXFImage.Error:
                        messageBoxXF.image.Icon = FontAwesome6.EFontAwesomeIcon.Regular_CircleXmark;
                        break;
                    case MessageBoxXFImage.Ask:
                        messageBoxXF.image.Icon = FontAwesome6.EFontAwesomeIcon.Regular_CircleQuestion;
                        break;
                    default:
                        break;
                }
                

                if (buttonType == MessageBoxButtonType.SingleButton)
                {
                    messageBoxXF.btn_Retry.Visibility = Visibility.Collapsed;
                    messageBoxXF.btn_Cancel.Visibility = Visibility.Collapsed;
                }
                else if (buttonType == MessageBoxButtonType.DoubleButton)
                {
                    messageBoxXF.btn_Retry.Visibility = Visibility.Collapsed;
                }
                else { }

                if (owner == null)
                {
                    messageBoxXF.Owner = Application.Current.MainWindow;
                }
                messageBoxXF.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                messageBoxXF.Height = messageBoxXF.Owner.ActualHeight;
                messageBoxXF.Width = messageBoxXF.Owner.ActualWidth;
                messageBoxXF.tb_msg.Text = message;
                
                if (background != null)
                    messageBoxXF.SetValue(XFBackgroundAttach.XFBackgroundProperty, background);
                if (!string.IsNullOrWhiteSpace(okContent))
                    messageBoxXF.btn_Ok.Content = okContent;
                if (!string.IsNullOrWhiteSpace(cancelContent))
                    messageBoxXF.btn_Cancel.Content = cancelContent;
                if (!string.IsNullOrWhiteSpace(retryContent))
                    messageBoxXF.btn_Retry.Content = retryContent;

                messageBoxXF.ShowDialog();
                res = messageBoxXF.Result;
            });
            return res;
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            Button? btn = e.OriginalSource as Button;
            if (btn == null)
            {
                return;
            }
            string? tag = btn.Tag == null ? string.Empty : btn.Tag.ToString();
            if (tag == "OK")
            {
                this.Result = MessageBoxXFResult.OK;
            }
            else if (tag == "Cancel")
            {
                this.Result = MessageBoxXFResult.Cancel;
            }
            else if (tag == "Retry")
            {
                this.Result = MessageBoxXFResult.Retry;
            }
            else
            {
                this.Result = MessageBoxXFResult.None;
            }
            this.Close();
        }
    }
}
