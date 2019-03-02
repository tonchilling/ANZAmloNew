using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO.Util;
using DTO.Amlo.Autorizing;
using BAL.Amlo.Autorizing;

namespace ANZ2AMLO.Forms
{
    public partial class frmUserProfile : DevExpress.XtraEditors.XtraForm
    {
        UserGroupBL blUserGroup = new UserGroupBL();
        UserBL blUser = new UserBL();
        string pKey = "";
        public PAction pageState = new PAction();

        private void initialData()
        {
            DataTable dtUserGroup = blUserGroup.FindByAll();
            cbUserGroup.DataSource = dtUserGroup;
            cbUserGroup.DisplayMember = "Name";
            cbUserGroup.ValueMember = "USERGROUP_OID";

            DataRow dr = dtUserGroup.NewRow();
            dr["Name"] = "-- Please Select --";
            dr["USERGROUP_OID"] = "";
            dtUserGroup.Rows.InsertAt(dr, 0);

            DisplayUser(MyLogin.USER_OID);
        }

        private void DisplayUser(string userOid)
        {
            pKey = userOid;
            DataView dv = null;
            DataTable dt = blUser.FindByPK(pKey);
            dv = new DataView(dt);
            if (dv.Count > 0)
            {
                txtFName.Text = dv[0]["FName"].ToString();
                txtLName.Text = dv[0]["LName"].ToString();
                txtPosition.Text = dv[0]["Position"].ToString();
                txtTelephone.Text = dv[0]["Telephone"].ToString();
                txtUserLogin.Text = dv[0]["USER_LOGIN"].ToString();
                txtAddr1.Text = dv[0]["Addr1"].ToString();
                txtEmail.Text = dv[0]["Email"].ToString();
                txtPassword.Text = dv[0]["Password"].ToString();
                txtConfirmPassword.Text = dv[0]["Password"].ToString();
                cbUserGroup.SelectedValue = dv[0]["USERGROUP_OID"].ToString();
                if (dv[0]["ROW_STATE"].ToString().Trim().Equals("1"))
                {
                    rdActive.Checked = true;
                }
                else
                {
                    rdInActive.Checked = true;
                }
                pageState = PAction.Update;
            }
        }

        private void saveUserProfile()
        {
            if (ValidateData())
            {
                ActionStep1();
            }
        }

        void ActionStep1()
        {
            String message = "";
            switch (pageState)
            {
                case PAction.Add: message = ActionConfirm.Add.Value; break;
                case PAction.Update: message = ActionConfirm.Update.Value; break;
                case PAction.Delete: message = ActionConfirm.Delete.Value; break;
            }
            if (MessageBox.Show(message, ".:User", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ActionStep2(pKey, cbUserGroup.SelectedValue.ToString()
                                , txtUserLogin.Text, txtFName.Text, txtLName.Text
                                , txtPosition.Text, txtAddr1.Text, txtTelephone.Text
                                , txtEmail.Text, txtPassword.Text
                                , rdActive.Checked, MyLogin.USER_LOGIN);
            }
        }

        void ActionStep2(string USER_OID
                            , string USERGROUP_OID
                            , string USER_LOGIN
                            , string FName
                            , string LName
                            , string Position
                            , string Addr1
                            , string Telephone
                            , string Email
                            , string PASSWORD
                            , bool active
                            , string userlogin)
        {
            if (blUser.Action(USER_OID, USERGROUP_OID, USER_LOGIN, FName, LName, Position, Addr1, Telephone, Email, PASSWORD, active, userlogin, pageState))
            {
                String message = "";
                switch (pageState)
                {
                    case PAction.Add: message = ActionDone.Add.Value; break;
                    case PAction.Update: message = ActionDone.Update.Value; break;
                    case PAction.Delete: message = ActionDone.Delete.Value; break;
                }
                MessageBox.Show(message, ".:User");
            }
        }

        bool ValidateData()
        {
            bool isValidate = true;
            StringBuilder msg = new StringBuilder();

            if (txtFName.Text.Equals(""))
            {
                msg.AppendLine("- Please input first name.");
                isValidate = false;
            }
            if (txtLName.Text.Equals(""))
            {
                msg.AppendLine("- Please input last name.");
                isValidate = false;
            }
            if (cbUserGroup.SelectedIndex == 0)
            {
                msg.AppendLine("- Please select user role.");
                isValidate = false;
            }
            if (txtUserLogin.Text.Equals(""))
            {
                msg.AppendLine("- Please input User Login.");
                isValidate = false;
            }
            if (txtPassword.Text.Trim().Equals(""))
            {
                msg.AppendLine("- Please input password.");
                isValidate = false;
            }
            if (txtConfirmPassword.Text.Trim().Equals(""))
            {
                msg.AppendLine("- Please input Confirm password.");
                isValidate = false;
            }
            if (!txtPassword.Text.Trim().Equals(txtConfirmPassword.Text.Trim()))
            {
                msg.AppendLine("- Password not match.");
                isValidate = false;
            }

            return isValidate;
        }

        public frmUserProfile()
        {
            InitializeComponent();
        }

        private void frmUserProfile_Load(object sender, EventArgs e)
        {
            initialData();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            saveUserProfile();
        }
    }
}