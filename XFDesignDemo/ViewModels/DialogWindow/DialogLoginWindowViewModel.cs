using Prism.Commands;
using Prism.Ioc;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using XFDesign.DialogWindow.DialogLoginWindow.Interface;
using XFDesign.MessageBox;

namespace XFDesignDemo.ViewModels.DialogWindow
{
    public class DialogLoginWindowViewModel
    {
        private readonly IDialogService dialogService;

        public DialogLoginWindowViewModel(IDialogService dialogService)
        {
            this.dialogService = dialogService;
        }

        public DelegateCommand DialogLoginWindowCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    dialogService.AddLoginWindow("XF登录", (user, password) =>
                    {
                        return new LoginResult(ButtonResult.OK);
                    },null);
                });
            }
        }

        public DelegateCommand<string> MessageBoxCommand
        {
            get
            {
                return new DelegateCommand<string>(str =>
                {
                    if (str == "提示")
                    {
                        MessageBoxXF.Info("收到一则提示消息");
                    }
                    if (str == "警告")
                    {
                        MessageBoxXF.Warning("收到一则警告消息");
                    }
                    if (str == "错误")
                    {
                        MessageBoxXF.Error("收到一则错误消息");
                    }
                    if (str == "询问")
                    {
                        MessageBoxXF.Question("收到一则询问消息");
                    }
                    if (str == "成功")
                    {
                        MessageBoxXF.Error("收到一则成功消息");
                    }
                });
            }
        }
    }
}
