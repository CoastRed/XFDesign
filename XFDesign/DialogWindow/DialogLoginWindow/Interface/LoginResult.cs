using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFDesign.DialogWindow.DialogLoginWindow.Interface
{
    public class LoginResult
    {
        public ButtonResult Result { get; set; }
        public string? Message { get; set; }

        public LoginResult(ButtonResult result)
        {
            this.Result = result;
        }

        public LoginResult(ButtonResult result, string message)
        {
            this.Result = result;
            this.Message = message;
        }
    }
}
