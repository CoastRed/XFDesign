using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using XFDesign.DialogWindow.DialogLoginWindow;
using XFDesign.DialogWindow.DialogLoginWindow.Interface;

namespace Prism.Ioc
{
    public static class DialogServiceExtensions
    {
        /// <summary>
        /// 打开一个模态的登录窗口
        /// </summary>
        /// <param name="callback">验证登录的委托，第一个参数是用户名，第二个参数是密码, 传null或者不传则默认验证成功</param>
        public static void AddLoginWindow(this IDialogService dialogService, Action<LoginResult> callback)
        {
            ConfigLoginWindow("", (user, password) =>
            {
                return new LoginResult(ButtonResult.OK);
            }, callback, "", Stretch.Uniform);
        }

        /// <summary>
        /// 打开一个模态的登录窗口
        /// </summary>
        /// <param name="title">窗口的标题，默认为Sign into App</param>
        /// <param name="callback">验证成功或退出窗口后执行的回调</param>
        public static void AddLoginWindow(this IDialogService dialogService, string title, Action<LoginResult> callback)
        {
            ConfigLoginWindow(title, (user, password) =>
            {
                return new LoginResult(ButtonResult.OK);
            }, callback, "", Stretch.Uniform);
        }

        /// <summary>
        /// 打开一个模态的登录窗口
        /// </summary>
        /// <param name="title">窗口的标题，默认为Sign into App</param>
        /// <param name="canlogin">验证登录的委托，第一个参数是用户名，第二个参数是密码, 传null或者不传则默认验证成功</param>
        /// <param name="callback">验证成功或退出窗口后执行的回调</param>
        public static void AddLoginWindow(this IDialogService dialogService, string title, Func<string, string, LoginResult> canlogin, Action<LoginResult> callback)
        {
            ConfigLoginWindow(title, canlogin, callback, "", Stretch.Uniform);
        }

        /// <summary>
        /// 打开一个模态的登录窗口
        /// </summary>
        /// <param name="title">窗口的标题，默认为Sign into App</param>
        /// <param name="canlogin">验证登录的委托，第一个参数是用户名，第二个参数是密码, 传null或者不传则默认验证成功</param>
        /// <param name="callback">验证成功或退出窗口后执行的回调</param>
        /// <param name="imageName">要在窗口登录界面左边显示的图片名称，图片必须位于当前程序的Iamges文件夹下，如果传空字符串则自动寻找名字为loginDefault.png的图片，若不存在则不显示图片</param>
        public static void AddLoginWindow(this IDialogService dialogService, string title, Func<string, string, LoginResult> canlogin, Action<LoginResult> callback, string imageName)
        {
            ConfigLoginWindow(title, canlogin, callback, imageName, Stretch.Uniform);
        }

        /// <summary>
        /// 打开一个模态的登录窗口
        /// </summary>
        /// <param name="title">窗口的标题，默认为Sign into App</param>
        /// <param name="canlogin">验证登录的委托，第一个参数是用户名，第二个参数是密码, 传null或者不传则默认验证成功</param>
        /// <param name="callback">验证成功或退出窗口后执行的回调</param>
        /// <param name="imageName">要在窗口登录界面左边显示的图片名称，图片必须位于当前程序的Iamges文件夹下，如果传空字符串则自动寻找名字为loginDefault.png的图片，若不存在则不显示图片</param>
        /// <param name="imageStretch">图片在界面上的展示的填充方式</param>
        public static void AddLoginWindow(this IDialogService dialogService, string title, Func<string, string, LoginResult> canlogin, Action<LoginResult> callback, string imageName, Stretch imageStretch)
        {
            ConfigLoginWindow(title, canlogin, callback, imageName, imageStretch);
        }

        /// <summary>
        /// 打开一个模态的登录窗口
        /// </summary>
        /// <param name="title">窗口的标题，默认为Sign into App</param>
        /// <param name="canlogin">验证登录的委托，第一个参数是用户名，第二个参数是密码, 传null或者不传则默认验证成功</param>
        /// <param name="callback">验证成功或退出窗口后执行的回调</param>
        /// <param name="imageName">要在窗口登录界面左边显示的图片名称，图片必须位于当前程序的Iamges文件夹下，如果传空字符串则自动寻找名字为loginDefault.png的图片，若不存在则不显示图片</param>
        /// <param name="imageStretch">图片在界面上的展示的填充方式</param>
        private static void ConfigLoginWindow(string title, Func<string, string, LoginResult>? canlogin, Action<LoginResult> callback, string imageName, Stretch imageStretch)
        {
            LoginWindowView loginWindow = new LoginWindowView();
            LoginWindowViewModel loginWindowViewModel = new LoginWindowViewModel();
            loginWindowViewModel.Title = title ?? "Sign into App";

            string dir = AppDomain.CurrentDomain.BaseDirectory;
            if (string.IsNullOrEmpty(imageName))
            {
                imageName = "loginDefault.png";
            }
            string imguri = Path.Combine(dir, "Images", imageName);
            if (File.Exists(imguri))
            {
                loginWindow.logo.ImageSource = new BitmapImage(new Uri(imguri));
                loginWindow.logo.Stretch = imageStretch;
            }
            if (canlogin == null)
            {
                canlogin = (user, password) =>
                {
                    return new LoginResult(ButtonResult.OK);
                };
            }
            loginWindowViewModel.CanLogin = canlogin;
            loginWindowViewModel.RequestClose += result =>
            {
                if (result == null)
                {
                    result = new LoginResult(ButtonResult.None);
                }
                loginWindow.Result = result;
                loginWindow.Close();
            };
            loginWindow.Closing += (s, e) =>
            {
                if (loginWindow.Result == null)
                {
                    loginWindow.Result = new LoginResult(ButtonResult.Cancel);
                }
            };
            if (callback != null)
            {
                loginWindow.Closed += (s, e) => callback(loginWindow.Result);
            }
            loginWindow.DataContext = loginWindowViewModel;
            loginWindow.ShowDialog();
        }
    }
}
