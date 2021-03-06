﻿using System;
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
using BL.Amlo.Autorizing;

namespace ANZ2AMLO.Forms
{
    public partial class frmSubMenu : DevExpress.XtraEditors.XtraForm
    {
        MenuGroupBL blMenuGroup = new MenuGroupBL();
        public PAction pageState = new PAction();
        string pKey = "";

        private void loadComboBoxMenuGroup()
        {
            DataTable dtMainMenu = blMenuGroup.FindMainMenu();
            cbMainMenu.DataSource = dtMainMenu;
            cbMainMenu.DisplayMember = "Name";
            cbMainMenu.ValueMember = "MENU_OID";
                        
            DataRow drMainMenu = dtMainMenu.NewRow();
            drMainMenu["Name"] = "-- Please Select --";
            drMainMenu["MENU_OID"] = "";
            dtMainMenu.Rows.InsertAt(drMainMenu, 0);

            cbMainMenu.SelectedIndex = 0;
        }

        void initialData()
        {
            BindingGridviewAsPaging();
            pnAddEdit.Visible = false;
            btnSave.Enabled = false;
            btnClose.Enabled = false;
            btnNew.Enabled = true;
            this.BackColor = Color.WhiteSmoke;
            pnAddEdit.Location = new Point((this.MdiParent.ClientSize.Width / 2) - pnAddEdit.Size.Width / 2, pnAddEdit.Location.Y);
            pnAddEdit.BackgroundImage = ANZ2AMLO.Properties.Resources.bgg;
            groupBox2.BackColor = Color.Transparent;
            this.Refresh();
        }
        private void clearData()
        {
            txtName.Text = "";
            txtDesc.Text = "";
            txtScreen.Text = "";
            txtLink.Text = "";
            cbMainMenu.SelectedIndex = 0;
            txtOrderNo.Text = "";
            rdActive.Checked = false;
            rdInActive.Checked = false;
        }

        void BindingGridviewAsPaging()
        {
            DataTable dt = blMenuGroup.FindMenu("", "", "");
            gdResult.DataSource = dt;
            gridViewResult.RefreshData();
            gdResult.RefreshDataSource();
        }

        bool validateData()
        {
            bool isValidate = true;
            StringBuilder msg = new StringBuilder();

            if (txtName.Text.Equals(""))
            {
                msg.AppendLine("- Please input name.");
                isValidate = false;
            }

            if (cbMainMenu.SelectedIndex == 0)
            {
                msg.AppendLine("- Please input Main Menu.");
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
            if (MessageBox.Show(message, ".:User Group", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ActionStep2(pKey, cbMainMenu.SelectedValue.ToString(), txtName.Text, txtDesc.Text, txtScreen.Text, txtLink.Text, rdActive.Checked, MyLogin.USER_LOGIN);
                initialData();
            }
        }

        void ActionStep2(string id, string menugroup, string name, string desc, string screenName, string link, bool active, string userlogin)
        {
            if (blMenuGroup.Action(id, menugroup, name, desc, screenName, link, userlogin, active, pageState))
            {
                string message = "";
                switch (pageState)
                {
                    case PAction.Add: message = ActionDone.Add.Value; break;
                    case PAction.Update: message = ActionDone.Update.Value; break;
                    case PAction.Delete: message = ActionDone.Delete.Value; break;
                }
                MessageBox.Show(message, ".:User Group");
            }
        }

        private void deleteSubMenu()
        {
            pKey = gridViewResult.GetFocusedRowCellValue("MENU_OID").ToString();
            pageState = PAction.Delete;

            ActionStep1();
        }

        private void saveSubMenu()
        {
            if (validateData())
            {
                ActionStep1();
                gdResult.Visible = true;
            }
        }

        private void editSubMenu()
        {
            DataRow dr = gridViewResult.GetFocusedDataRow();
            pKey = gridViewResult.GetFocusedRowCellValue("MENU_OID").ToString();
            pageState = PAction.Update;

            txtName.Text = dr["Name"].ToString();
            txtDesc.Text = dr["DESC"].ToString();
            txtScreen.Text = dr["SCREEN"].ToString();
            txtLink.Text = dr["LINK"].ToString();
            txtOrderNo.Text = dr["OrderNo"].ToString();
            cbMainMenu.SelectedValue = dr["MENUGROUP_OID"].ToString();
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
            btnSave.Enabled = true;
        }

        public frmSubMenu()
        {
            InitializeComponent();
        }

        private void frmSubMenu_Load(object sender, EventArgs e)
        {
            loadComboBoxMenuGroup();
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
            saveSubMenu();
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
            editSubMenu();
            gdResult.Visible = false;
            btnSave.Enabled = true;
            btnClose.Enabled = true;
            btnNew.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteSubMenu();
        }

        private void btnCloseDialog_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void btnCloseDialog_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            pnAddEdit.Visible = false;
        }
    }
}