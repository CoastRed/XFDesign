using Prism.Commands;
using Prism.Ioc;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XFDesign.DialogWindow.DialogLoginWindow.Interface;

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

    }
}
