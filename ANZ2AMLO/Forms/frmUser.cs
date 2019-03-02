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
    public partial class frmUser : DevExpress.XtraEditors.XtraForm
    {
        UserGroupBL blUserGroup = new UserGroupBL();
        UserBL blUser = new UserBL();
        public PAction pageState = new PAction();
        string pKey = "";
        public frmUser()
        {
            InitializeComponent();
        }

        private void loadComboBoxUserGroup()
        {
            DataTable dtUserGroup = blUserGroup.FindByAll();
            cbUserGroup.DataSource = dtUserGroup;
            cbUserGroup.DisplayMember = "Name";
            cbUserGroup.ValueMember = "USERGROUP_OID";

            DataRow drUserGroup = dtUserGroup.NewRow();
            drUserGroup["Name"] = "-- Please Select --";
            drUserGroup["USERGROUP_OID"] = "";
            dtUserGroup.Rows.InsertAt(drUserGroup, 0);

            cbUserGroup.SelectedIndex = 0;
        }

        void initialData()
        {
            BindingGridviewAsPaging();
            pnAddEdit.Visible = false;
            btnSave.Enabled = false;
            btnClose.Enabled = false;
            btnNew.Enabled = true;
            this.Refresh();

          
        }

        void BindingGridviewAsPaging()
        {
            DataTable dt = blUser.FindByColumn("", "", "");
            gdResult.DataSource = dt;
            gridViewResult.RefreshData();
            gdResult.RefreshDataSource();
        }

        bool validateData()
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

            if (!isValidate)
            {
                MessageBox.Show(msg.ToString(), "User Validation");
            }

            return isValidate;
        }

        void ActionStep1()
        {
            string message = "";
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
                initialData();
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
            string message = "";
            if (blUser.Action(USER_OID, USERGROUP_OID, USER_LOGIN, FName, LName, Position, Addr1, Telephone, Email, PASSWORD, active, userlogin, pageState))
            {
                switch (pageState)
                {
                    case PAction.Add: message = ActionDone.Add.Value; break;
                    case PAction.Update: message = ActionDone.Update.Value; break;
                    case PAction.Delete: message = ActionDone.Delete.Value; break;
                }
                MessageBox.Show(message, ".:User");
            }
        }

        private void deleteUser()
        {
            pKey = gridViewResult.GetFocusedRowCellValue("USER_OID").ToString();
            pageState = PAction.Delete;

            ActionStep1();
        }

        private void editUser()
        {
            DataRow dr = gridViewResult.GetFocusedDataRow();
            pKey = gridViewResult.GetFocusedRowCellValue("USER_OID").ToString();
            pageState = PAction.Update;

            txtFName.Text = dr["FName"].ToString();
            txtLName.Text = dr["LName"].ToString();
            txtPosition.Text = dr["Position"].ToString();
            txtTelephone.Text = dr["Telephone"].ToString();
            txtUserLogin.Text = dr["USER_LOGIN"].ToString();
            txtAddr1.Text = dr["Addr1"].ToString();
            txtEmail.Text = dr["Email"].ToString();
            txtPassword.Text = dr["Password"].ToString();
            txtConfirmPassword.Text = dr["Password"].ToString();
            cbUserGroup.SelectedValue = dr["USERGROUP_OID"].ToString();
            string status = dr["ROW_STATE"].ToString();

            if ("1".Equals(status.Trim()))
            {
                rdActive.Checked = true;
            }
            else if ("0".Equals(status.Trim()))
            {
                rdInActive.Checked = true;
            }

            pnAddEdit.Visible = true;
            btnSave.Enabled = false;
        }

        private void clearData()
        {
            txtFName.Text = "";
            txtLName.Text = "";
            txtPosition.Text = "";
            txtTelephone.Text = "";
            txtUserLogin.Text = "";
            txtAddr1.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            cbUserGroup.SelectedIndex = 0;
            rdActive.Checked = false;
            rdInActive.Checked = false;
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            loadComboBoxUserGroup();
            pnAddEdit.Location = new Point((this.MdiParent.ClientSize.Width / 2) - pnAddEdit.Size.Width / 2, (this.MdiParent.ClientSize.Height / 2) - pnAddEdit.Size.Height / 2);
            initialData();
        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pageState = PAction.Add;
            clearData();
            btnSave.Enabled = true;
            pnAddEdit.Visible = true;
            gdResult.Visible = false;
            btnClose.Enabled = true;
            btnNew.Enabled = false;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (validateData())
            {
                ActionStep1();
                gdResult.Visible = true;
            }
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnAddEdit.Visible = false;
            btnSave.Enabled = false;
            gdResult.Visible = true;
            btnClose.Enabled = false;
            btnNew.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editUser();
            gdResult.Visible = false;
            btnSave.Enabled = true;
            btnClose.Enabled = true;
            btnNew.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteUser();
        }

        private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            initialData();
            gdResult.Visible = true;
        }
    }
}