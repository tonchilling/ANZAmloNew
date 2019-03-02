using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BL.Amlo.Autorizing;
using DTO.Amlo.Autorizing;
using BAL.Amlo.Autorizing;

namespace ANZ2AMLO.Forms
{
    public partial class frmMenuPermission : DevExpress.XtraEditors.XtraForm
    {
        UserGroupBL blUserGroup = new UserGroupBL();
        MenuGroupBL blMenuGroup = new MenuGroupBL();
        List<PER_MENU_PERMISSIONDto> dtMenuPermissionList = null;
        PER_MENU_PERMISSIONBL blPermmission = new PER_MENU_PERMISSIONBL();
        string currentUserGroup = "";

        private void initialData()
        {
            DataTable dtUserGroup = blUserGroup.FindByAll();
            cbUserGroupSearch.DataSource = dtUserGroup;
            cbUserGroupSearch.DisplayMember = "Name";
            cbUserGroupSearch.ValueMember = "USERGROUP_OID";
            DataRow dr = dtUserGroup.NewRow();
            dr["Name"] = "-- Please Select --";
            dr["USERGROUP_OID"] = "";
            dtUserGroup.Rows.InsertAt(dr, 0);
            cbUserGroupSearch.SelectedIndex = 0;
        }

        void SearchData()
        {
            if (cbUserGroupSearch.SelectedIndex == 0)
            {
                MessageBox.Show("Please select Group", ".:Menu Permission");
            }
            else
            {
                currentUserGroup = cbUserGroupSearch.SelectedValue.ToString();
                DataTable dt = blMenuGroup.FindMenuPermissionByUserGroup(currentUserGroup);
                //CreateTreeMenu(dt);
                refreshGridDeatil(dt);
                btnSave.Enabled = true;
            }
        }

        void refreshGridDeatil(DataTable dt)
        {
            gdDetail.DataSource = dt;
            gdDetail.RefreshDataSource();
            gridDetail.RefreshData();
        }
        
        private void saveMenuPermission()
        {
            CollectResult();
            blPermmission.Save(currentUserGroup, dtMenuPermissionList);
            MessageBox.Show("Save Menu Permission successfully.", ".:Menu Permission");
        }

        List<PER_MENU_PERMISSIONDto> CollectResult()
        {
            dtMenuPermissionList = new List<PER_MENU_PERMISSIONDto>();
            DataTable dt = (DataTable)gdDetail.DataSource;

            foreach (DataRow dr in dt.Rows){
                if ("1".Equals(dr["VIEW"].ToString()) || "1".Equals(dr["EDIT"].ToString()) || "1".Equals(dr["DELETE"].ToString()))
                {
                    PER_MENU_PERMISSIONDto perm = new PER_MENU_PERMISSIONDto();
                    perm.USERGROUP_OID = currentUserGroup;
                    perm.MENU_OID = dr["MENU_OID"].ToString();
                    perm.ROW_STATE = "1";
                    perm.CREATE_BY = MyLogin.USER_LOGIN;
                    perm.EDIT = dr["EDIT"].ToString();
                    perm.VIEW = dr["VIEW"].ToString();
                    perm.DELETE = dr["DELETE"].ToString();

                    dtMenuPermissionList.Add(perm);
                }
            }            
            return dtMenuPermissionList;
        }
        
        public frmMenuPermission()
        {
            InitializeComponent();
        }

        private void frmMenuPermission_Load(object sender, EventArgs e)
        {
            initialData();
            btnSave.Enabled = false;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            saveMenuPermission();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchData();
        }
    }
}