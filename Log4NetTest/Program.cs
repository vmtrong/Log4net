using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Windows.Forms;

namespace Log4NetTest
{
    static class Program
    {
        private static ILog logger;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Program.logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
            Logger.Debug(ref Program.logger, "\n\n==================== App START ====================");
            Logger.Info(ref Program.logger, "\n\n==================== App START ====================");
            Logger.Error(ref Program.logger, "\n\n==================== App START ====================");


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            Application.Run(new frmMain());
        }
        public static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
           

        }
    }
  
}
