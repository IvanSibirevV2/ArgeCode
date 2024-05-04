using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_Or
{
    public static class Ext_Process
    {
        public static Process Set_NirCmd(this Process _this, string _Arguments)
        {
            _this.StartInfo.Verb = "runas";
            _this.StartInfo.CreateNoWindow = true;
            _this.StartInfo.UseShellExecute = false;
            _this.StartInfo.RedirectStandardOutput = false;
            _this.StartInfo.FileName = "nircmd.exe";
            _this.StartInfo.Arguments = _Arguments;
            _this.Start();
            _this.WaitForExit();
            return _this;
        }
    }
}
