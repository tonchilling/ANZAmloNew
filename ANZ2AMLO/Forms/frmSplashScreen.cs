using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace ANZ2AMLO.Forms
{
    public partial class frmSplashScreen : SplashScreen
    {
        public frmSplashScreen()
        {
            InitializeComponent();
            String cc = string.Format("Copyright © 2018-{0}", DateTime.Now.Year.ToString());
            if (DateTime.Now.Year == 2018) {
                cc = "Copyright © 2018";
            }
            this.labelControl1.Text = cc;
            this.pictureEdit1.Visible = false;
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
    }
}