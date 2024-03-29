﻿using Prism.Commands;
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
    /// <summary>
    /// 
    /// </summary>
    public class LoginWindowViewModel : BindableBase, ILoginVerification
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string? Title { get; set; }

        private string? _UserName;
        /// <summary>
        /// 用户名
        /// </summary>
        public string? UserName
        {
            get { return _UserName; }
            set { _UserName = value; base.RaisePropertyChanged(); }
        }

        private string? _Password = "";
        /// <summary>
        /// 密码
        /// </summary>
        public string? Password
        {
            get { return _Password; }
            set { _Password = value; base.RaisePropertyChanged(); }
        }

        private string? _Message;
        /// <summary>
        /// 提示信息
        /// </summary>
        public string? Message
        {
            get { return _Message; }
            set { _Message = value; base.RaisePropertyChanged(); }
        }

        /// <summary>
        /// 关闭窗口事件
        /// </summary>
        public event Action<LoginResult>? RequestClose;

        /// <summary>
        /// 登录验证委托
        /// </summary>
        public Func<string, string, LoginResult>? CanLogin { get; set; }


        /// <summary>
        /// 登录命令
        /// </summary>
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

        /// <summary>
        /// 退出命令
        /// </summary>
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
