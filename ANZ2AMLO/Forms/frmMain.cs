using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;
using ANZ1AMLO.Forms;

using DTO.Amlo.Autorizing;
using BL.Amlo.Autorizing;
using BAL.Amlo.Autorizing;


namespace ANZ2AMLO.Forms
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {

            InitializeComponent();
        }

        private void doLogin()
        {
            if (XLogin(txtUserName.Text, txtPassword.Text))
            {
                //LoadOperratonConfigAll();
                navBarControlMain.Visible = true;
                bar2.Visible = true;
                pnLogin.Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid UserName / Password!!");
            }
        }

        bool XLogin(string username, string password)
        {
            bool result = false;
            UserBL lb = new UserBL();
            try
            {
                DataTable dt = lb.UserLogin(username, password);

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataView dv = new DataView(dt);
                    MyLogin.USER_OID = dv[0]["USER_OID"].ToString();
                    MyLogin.FName = dv[0]["FName"].ToString();
                    MyLogin.LName = dv[0]["LName"].ToString();
                    MyLogin.Position = dv[0]["Position"].ToString();
                    MyLogin.Telephone = dv[0]["Telephone"].ToString();
                    MyLogin.USER_LOGIN = dv[0]["USER_LOGIN"].ToString();
                    MyLogin.Addr1 = dv[0]["Addr1"].ToString();
                    MyLogin.Email = dv[0]["Email"].ToString();
                    MyLogin.PASSWORD = dv[0]["Password"].ToString();
                    MyLogin.ROW_STATE = dv[0]["ROW_STATE"].ToString();
                    MyLogin.USERGROUP_OID = dv[0]["USERGROUP_OID"].ToString();
                    MyLogin.USERGroupName = dv[0]["USERGroupName"].ToString();
                    MyLogin.Active = dv[0]["Active"].ToString();
                    result = true;

                    barStaticUser.Caption = "User : " + MyLogin.FName + " " + MyLogin.LName;

                    if (!"Admin".Equals(MyLogin.USERGroupName))
                    {
                        hideMenu();
                    }
                    //CreateMenu();
                }

            }
            catch (Exception ex)
            { throw ex; }

            return result;
        }

        private void doLogOff()
        {
            MyLogin.USER_OID = "";
            MyLogin.FName = "";
            MyLogin.LName = "";
            MyLogin.Position = "";
            MyLogin.Telephone = "";
            MyLogin.USER_LOGIN = "";
            MyLogin.Addr1 = "";
            MyLogin.Email = "";
            MyLogin.PASSWORD = "";
            MyLogin.ROW_STATE = "";
            MyLogin.USERGROUP_OID = "";
            MyLogin.USERGroupName = "";
            MyLogin.Active = "";

            //Main Menu
            foreach (DevExpress.XtraNavBar.NavBarGroup menuGroup in navBarControlMain.Groups)
            {
                menuGroup.Visible = true;
            }

            //Sub Menu

            foreach (DevExpress.XtraNavBar.NavBarItem menuItem in navBarControlMain.Items)
            {
                menuItem.Visible = true;
            }

            gotoLogin();
        }

        private void gotoLogin()
        {
            foreach (Form mdiForm in MdiChildren)
            {
                mdiForm.Close();
            }
            txtUserName.Text = "";
            txtPassword.Text = "";
            navBarControlMain.Visible = false;
            bar2.Visible = false;
            pnLogin.Visible = true;
            barStaticUser.Caption = "User : " + MyLogin.FName + " " + MyLogin.LName;
            this.BackColor = Color.CadetBlue;
            pnLogin.Location = new Point((this.ClientSize.Width / 2) - pnLogin.Size.Width / 2, (this.ClientSize.Height / 2) - pnLogin.Size.Height / 2);
        }

        private void hideMenu()
        {
            DataTable dt = null;
            DataView dvPermission = null;

            //navBarControlMain.Items.Clear();
            MenuGroupBL bl = null;

            bl = new MenuGroupBL();
            dt = bl.FindMenuPermissionByUserGroup(MyLogin.USERGROUP_OID);
            dvPermission = new DataView(dt);
            dvPermission.RowFilter = string.Format("USERGROUP_OID='{0}' and View='1'", MyLogin.USERGROUP_OID);

            //Main Menu
            foreach (DevExpress.XtraNavBar.NavBarGroup menuGroup in navBarControlMain.Groups)
            {
                if (isAuthorizeMenu(dvPermission, menuGroup.Caption))
                {
                    menuGroup.Visible = true;
                }
                else
                {
                    menuGroup.Visible = false;
                }
            }

            //Sub Menu

            foreach (DevExpress.XtraNavBar.NavBarItem menuItem in navBarControlMain.Items)
            {
                if (isAuthorizeMenu(dvPermission, menuItem.Caption))
                {
                    menuItem.Visible = true;
                }
                else
                {
                    menuItem.Visible = false;
                }
            }
        }

        private bool isAuthorizeMenu(DataView menuList, string menuCaption)
        {
            if (menuList != null)
            {
                foreach (DataRowView node in menuList)
                {
                    if (menuCaption.Equals(node["Name"].ToString()))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void CreateMenu()
        {
            DataTable dt = null;
            DataView dv = null;

            DevExpress.XtraNavBar.NavBarGroup menuGroup = null;
            //navBarControlMain.Items.Clear();
            MenuGroupBL bl = null;

            bl = new MenuGroupBL();
            dt = bl.FindMenuPermissionByUserGroup(MyLogin.USERGROUP_OID);
            dv = new DataView(dt);
            dv.RowFilter = string.Format("[MENUGROUP_OID]='' and USERGROUP_OID='{0}' and View='1'", MyLogin.USERGROUP_OID);

            if (dv != null && dv.Count > 0)
            {
                foreach (DataRowView node in dv)
                {
                    try
                    {
                        menuGroup = new DevExpress.XtraNavBar.NavBarGroup();
                        menuGroup.Caption = node["Name"].ToString();
                        menuGroup.Name = "menuGroup" + node["MENUGROUP_OID"].ToString();

                        if (!node["Link"].ToString().Equals(""))
                        {
                        }

                        navBarControlMain.Groups.Add(menuGroup);
                        CreateSubMenu(navBarControlMain, dt, node);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }

        private void CreateSubMenu(DevExpress.XtraNavBar.NavBarControl navBarControlMain, DataTable dtAllMenu, DataRowView dtGroupMenu)
        {
            DataView dv = null;

            dv = new DataView(dtAllMenu);
            dv.RowFilter = string.Format("[MENUGROUP_OID]='{0}' and View='1'", dtGroupMenu["MENU_OID"]);

            foreach (DataRowView node in dv)
            {
                DevExpress.XtraNavBar.NavBarItem subMenu = new DevExpress.XtraNavBar.NavBarItem();
                subMenu.Caption = node["Name"].ToString();
                subMenu.Name = node["MENU_OID"].ToString();

                if (node["icon"] != null)
                {
                    object myIcon = ANZ2AMLO.Properties.Resources.ResourceManager.GetObject(node["icon"].ToString());
                    //subMenu.Image = (Image)myIcon;
                    //subMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
                }
                if (!node["Link"].ToString().Equals(""))
                {
                }
                navBarControlMain.Items.Add(subMenu);
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            gotoLogin();
            /* 
            XtraForm f = new XtraForm();
            WebBrowser w = new WebBrowser();
            w.Navigate("https://www.anz.com.au");
            w.Dock = DockStyle.Fill;
            f.Controls.Add(w);
            f.MdiParent = this;
            f.Show();   
            */
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            XtraForm1 newMDIChild = new XtraForm1();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void navSettingCustomerSebel_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!HaveForm("frmImportDataSetting"))
            {
                frmImportDataSetting importDataSetting = new frmImportDataSetting();
                importDataSetting.MdiParent = this;
                importDataSetting.Show();
            }
        }

        private void navImportAll_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!HaveForm("frmImportData"))
            {
                frmImportData frmImport = new frmImportData();
                frmImport.MdiParent = this;
                frmImport.Show();
            }
        }

        private void navBarImportDaily_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmImportDataDaily frmDaily = new frmImportDataDaily();
            frmDaily.MdiParent = this;
            frmDaily.Show();
        }

        private void navBarCustomerMaster_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!HaveForm("frmCustomerMaster"))
            {
                frmCustomerMaster frmCusMaster = new frmCustomerMaster();
                frmCusMaster.MdiParent = this;
                frmCusMaster.Show();
            }

        }

        private void navBarTransactionMaster_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!HaveForm("frmTransactionMaster"))
            {
                frmTransactionMaster frmTranMaster = new frmTransactionMaster();
                frmTranMaster.MdiParent = this;
                frmTranMaster.Show();
            }
        }

        private void navSourceFileMapping_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!HaveForm("frmSettingMapping"))
            {
                frmSettingMapping frmSettingMapping = new frmSettingMapping();
                frmSettingMapping.MdiParent = this;
                frmSettingMapping.Show();
            }
        }

        bool HaveForm(string formName)
        {
            foreach (Form mdiForm in MdiChildren)
            {
                if (mdiForm.Name.ToLower() == formName.ToLower())
                {
                    mdiForm.Focus();
                    return true;
                }
            }

            return false;
        }
        void CloseAllForm()
        {
            foreach (Form mdiForm in MdiChildren)
            {
                if (mdiForm != null)
                    mdiForm.Dispose();
            }
        }

        private void navBarGenAutoAMLO_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!HaveForm("frm000ReportWorkFlowStatus"))
            {
                frm000ReportWorkFlowStatus frm = new frm000ReportWorkFlowStatus();
                frm.MdiParent = this;
                frm.Show();
            }
            /*
            if (!HaveForm("frmGenerateAMLO"))
            {
                frmGenerateAMLO frmGenAMLO = new frmGenerateAMLO();
                frmGenAMLO.MdiParent = this;
                frmGenAMLO.Show();
            }
            */
        }

        private void navCutomerMasterMapping_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!HaveForm("frmCustomerMasterMapping"))
            {
                frmCustomerMasterMapping frm = new frmCustomerMasterMapping();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void navTransactionMasterMapping_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!HaveForm("frmTransectionMasterMapping"))
            {
                frmTransectionMasterMapping frm = new frmTransectionMasterMapping();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void navReportMapping_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!HaveForm("frmReportMappingcs"))
            {
                frmReportMappingcs frm = new frmReportMappingcs();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void navReportFilterRole_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!HaveForm("frmReportFilterRule"))
            {
                frmReportFilterRule frm = new frmReportFilterRule();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void navBarItem1_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!HaveForm("frmUserGroup"))
            {
                frmUserGroup frm = new frmUserGroup();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!HaveForm("frmImportDataView"))
            {
                frmImportDataView frm = new frmImportDataView();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!HaveForm("frmGenerateAMLO"))
            {
                frmGenerateAMLO frm = new frmGenerateAMLO();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            doLogin();
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            doLogOff();
        }

        private void navBarControlMain_Click(object sender, EventArgs e)
        {

        }
    }
}
