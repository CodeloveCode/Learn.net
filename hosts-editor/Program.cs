using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hosts_editor
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            requestAdministratorAuthority();
        }

        /// <summary>
        /// 检查当前用户权限,如果不是管理员,则请求以管理员身份运行.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private static void requestAdministratorAuthority()
        {
            System.Security.Principal.WindowsIdentity windowsIdentity = System.Security.Principal.WindowsIdentity.GetCurrent();
            Application.EnableVisualStyles();
            System.Security.Principal.WindowsPrincipal windowsPrincipal = new System.Security.Principal.WindowsPrincipal(windowsIdentity);

            if (windowsPrincipal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator))
            {
                // 如果是管理员,则直接运行程序.(下面几行是Main()中原有的代码)
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else
            {
                System.Diagnostics.ProcessStartInfo processStartInfo = new System.Diagnostics.ProcessStartInfo();
                processStartInfo.FileName = System.Windows.Forms.Application.ExecutablePath;
                processStartInfo.Arguments = "";
                processStartInfo.Verb = "runas";
                System.Diagnostics.Process.Start(processStartInfo);
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
