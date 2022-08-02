using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFDesign.DialogWindow.DialogLoginWindow.Interface
{
    internal interface ILoginVerification
    {
        string? Title { get; set; }

        Func<string, string, LoginResult>? CanLogin { get; set; }

        public event Action<LoginResult>? RequestClose;
    }
}
