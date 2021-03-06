﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using Maticsoft.Common;
using System.Drawing;
using Maticsoft.Accounts.Bus;
namespace Maticsoft.Web.Admin.SysManage
{
    public partial class ErrorLog : PageBaseAdmin
    {
        Maticsoft.BLL.SysManage.ErrorLog bll = new Maticsoft.BLL.SysManage.ErrorLog();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {   if (!UserPrincipal.HasPermissionID(GetPermidByActID(Act_DeleteList)))
                {
                    btnDelete.Visible = false;
                }
                gridView.BorderColor = ColorTranslator.FromHtml(Application[Session["Style"].ToString() + "xtable_bordercolorlight"].ToString());
                gridView.HeaderStyle.BackColor = ColorTranslator.FromHtml(Application[Session["Style"].ToString() + "xtable_titlebgcolor"].ToString());

                gridView.OnBind();
                txtDate.Text = DateTime.Today.ToShortDateString();
            }
        }

        protected void btnDeleteAll_Click(object sender, EventArgs e)
        {            
            Maticsoft.BLL.SysManage.ErrorLog.DeleteByDate(Convert.ToDateTime(txtDate.Text));
            gridView.OnBind();
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            gridView.OnBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string idlist = GetSelIDlist(); if(idlist.Trim().Length == 0) return;
            Maticsoft.BLL.SysManage.ErrorLog.Delete(idlist);
            gridView.OnBind();
        }


        #region gridView

        public void BindData()
        {
            #region
            if (!Context.User.Identity.IsAuthenticated)
            {
                return;
            }
            //AccountsPrincipal user = new AccountsPrincipal(Context.User.Identity.Name);
            //if (user.HasPermissionID(PermId_Modify))
            //{
            //    gridView.Columns[6].Visible = true;
            //}
            //if (user.HasPermissionID(PermId_Delete))
            //{
            //    gridView.Columns[7].Visible = true;
            //}
            #endregion

            DataSet ds = new DataSet();
            string keyword = "";
            if (txtKeyword.Text.Trim() != "")
            {
                keyword = txtKeyword.Text.Trim();
            }

            ds = Maticsoft.BLL.SysManage.ErrorLog.GetList(-1, "Loginfo like '%" + keyword + "%'", "id desc");
            gridView.DataSetSource = ds;
        }

        public override void VerifyRenderingInServerForm(Control control)
        {
        }
        protected void gridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridView.PageIndex = e.NewPageIndex;
            gridView.OnBind();
        }

        protected void gridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Attributes.Add("style", "background:#FFF");
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //object obj1 = DataBinder.Eval(e.Row.DataItem, "Levels");
                //if ((obj1 != null) && ((obj1.ToString() != "")))
                //{
                //    e.Row.Cells[4].Text = obj1.ToString() == "0" ? "Private" : "Shared";
                //}
                //object obj2 = DataBinder.Eval(e.Row.DataItem, "Userid");
                //if ((obj2 != null) && ((obj2.ToString().Trim() != "")))
                //{
                //    int uid = Convert.ToInt32(obj2);
                //    if (uid != UserID)
                //    {
                //        e.Row.Cells[6].Text = "Modify";
                //        e.Row.Cells[7].Text = "Delete";
                //    }
                //}
                //object obj3 = DataBinder.Eval(e.Row.DataItem, "userid");
                //if ((obj3 != null) && ((obj3.ToString() != "")))
                //{
                //    int userid = Convert.ToInt32(obj3);
                //    Maticsoft.Accounts.Bus.User user = new User(userid);
                //    e.Row.Cells[5].Text = user.TrueName;
                //}
            }
        }


        protected void gridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int ID = (int)gridView.DataKeys[e.RowIndex].Value;
            Maticsoft.BLL.SysManage.ErrorLog.Delete(ID);
            gridView.OnBind();
        }

        private string GetSelIDlist()
        {
            string idlist = "";
            bool BxsChkd = false;
            for (int i = 0; i < gridView.Rows.Count; i++)
            {
                CheckBox ChkBxItem = (CheckBox)gridView.Rows[i].FindControl(gridView.CheckBoxID);
                if (ChkBxItem != null && ChkBxItem.Checked)
                {
                    BxsChkd = true;
                    if (gridView.DataKeys[i].Value != null)
                    {
                        //idlist += gridView.Rows[i].Cells[1].Text + ",";
                        idlist += gridView.DataKeys[i].Value.ToString() + ",";
                    }
                }
            }
            if (BxsChkd)
            {
                idlist = idlist.Substring(0, idlist.LastIndexOf(","));
            }
            return idlist;
        }

        #endregion





    }
}
