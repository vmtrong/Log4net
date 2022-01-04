using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using log4net;

namespace Log4NetTest
{
    public partial class frmMain : Form
    {
        private ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public frmMain()
        {
            InitializeComponent();
            Logger.Error(ref this.logger, "Start");
            Logger.Debug(ref this.logger, "Start");
            Logger.Info(ref this.logger, "Start");
            Logger.Fatal(ref this.logger, "Start");
            Logger.Warning(ref this.logger, "Start");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //if (!Program.IsAdministrator())
            //{
            //    // Restart and run as admin
            //    var exeName = Process.GetCurrentProcess().MainModule.FileName;
            //    ProcessStartInfo startInfo = new ProcessStartInfo(exeName);
            //    startInfo.Verb = "runas";
            //    startInfo.Arguments = "restart";
            //    Process.Start(startInfo);
            //    Application.Exit();
            //}
            ////You should try to call the logger as soon as possible in your application
            //log.Debug("Application started");
        }

        //This method hooks to the button on the strt of the form.  When
        //you click the button, you call every type of log method available
        private void butRunTest_Click(object sender, EventArgs e)
        {
           
        }
    }

}
