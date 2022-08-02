using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XFDesign.DialogWindow.DialogLoginWindow.Interface;

namespace XFDesign.DialogWindow.DialogLoginWindow
{
    public class LoginWindowViewModel : BindableBase, ILoginVerification
    {
        public string? Title { get; set; }

        private string? _UserName;

        public string? UserName
        {
            get { return _UserName; }
            set { _UserName = value; base.RaisePropertyChanged(); }
        }

        private string? _Password = "";

        public string? Password
        {
            get { return _Password; }
            set { _Password = value; base.RaisePropertyChanged(); }
        }

        private string? _Message;

        public string? Message
        {
            get { return _Message; }
            set { _Message = value; base.RaisePropertyChanged(); }
        }

        public event Action<LoginResult>? RequestClose;

        public Func<string, string, LoginResult>? CanLogin { get; set; }

        public DelegateCommand LoginCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    LoginResult? result = CanLogin?.Invoke(this.UserName, this.Password);
                    if (result?.Result == ButtonResult.OK)
                    {
                        RequestClose?.Invoke(result);
                    }
                    else
                    {
                        this.Message = result?.Message;
                    }

                });
            }
        }

        public DelegateCommand LoginOutCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    RequestClose?.Invoke(new LoginResult(ButtonResult.Cancel));
                });
            }
        }
    }
}
