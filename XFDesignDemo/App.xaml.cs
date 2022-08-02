using Prism.Ioc;
using Prism.Services.Dialogs;
using System;
using System.Windows;
using XFDesign.DialogWindow.DialogLoginWindow.Interface;
using XFDesignDemo.ViewModels.DialogWindow;
using XFDesignDemo.Views;
using XFDesignDemo.Views.BasicControls;
using XFDesignDemo.Views.DataDisplay;
using XFDesignDemo.Views.DialogWindow;

namespace XFDesignDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void OnInitialized()
        {
            var dialogservice = Container.Resolve<DialogService>();
            dialogservice.AddLoginWindow("XFDesign登录", (user, password) =>
            {
                //user用户名，password密码， 这个可以做验证
                if (string.IsNullOrEmpty(user))
                {
                    return new LoginResult(ButtonResult.Cancel, "用户名不能为空");
                }
                return new LoginResult(ButtonResult.OK);
            }, result =>
            {
                if (result.Result != ButtonResult.OK)
                {
                    Environment.Exit(0);
                }
            });
            base.OnInitialized();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<TextBoxView>();
            containerRegistry.RegisterForNavigation<ProgressBarView>();
            containerRegistry.RegisterForNavigation<TabControlView>();

            containerRegistry.RegisterForNavigation<DataGridView>();

            containerRegistry.RegisterForNavigation<DialogLoginWindowView, DialogLoginWindowViewModel>();
        }
    }
}
