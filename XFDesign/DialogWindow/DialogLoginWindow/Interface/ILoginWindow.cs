using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFDesign.DialogWindow.DialogLoginWindow.Interface
{
    internal interface ILoginWindow
    {
        LoginResult? Result { get; set; }

        Action<LoginResult>? Collback { get; set; }
    }
}
