using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dori50_FrameModeling.Common
{
    class GlobalP
    {
    }
    public delegate void delLogSender(object sender, EventArgs e, enLogLevel eLevel, string strLog);

    public enum enLogLevel
    {
        info,
        warning,
        Error,
    }
}
