﻿<%@ Page Language="C#" MasterPageFile="~/Admin/Basic.Master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="Maticsoft.Web.Admin.TaoCategories.Add" Title="增加页" %>

<%@ Register Src="~/Controls/UCDroplistPermission.ascx" TagName="UCDroplistPermission"
    TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/style.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="user_border" cellspacing="0" cellpadding="0" width="100%" align="center"
        border="0" id="table1">
        <tr>
            <td valign="top">
                <table class="user_box" cellspacing="0" cellpadding="5" width="100%" border="0" id="table2">
                    <tr>
                        <td align="left">
                            <span style="font-size: 12pt; font-weight: bold; color: #3666AA">
                                <img src="/admin/images/icon.gif" align="absmiddle" style="border-width: 0px;" />
                                <asp:Literal ID="Literal1" runat="server" Text="新增类别" /></span>
                        </td>
                        <td align="middle">
                            <table align="left" id="table3">
                                <tr valign="top" align="left">
                                    <td width="80">
                                        <a href="list.aspx">
                                            <img title="" src="/admin/images/view.gif" border="0" alt="" /></a>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    <table style="width: 100%;" cellspacing="0" cellpadding="0" class="formTableList"
        id="addItemsTable">
        <tr>
            <td class="leftTD">
                <asp:Literal ID="lblCategoryName" Text="分类名称" runat="server"></asp:Literal>：
            </td>
            <td class="rightTD">
                <asp:TextBox ID="txtCategoryName" runat="server" CssClass="input_short"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="rfvCategoryName" runat="server" ErrorMessage="*不能为空！"
                                ControlToValidate="txtCategoryName" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
            <td class="rightTD">
                <div id="txtCategoryNameTip" runat="server">
                </div>
            </td>
        </tr>
        <tr runat="server" id="tblrParent">
            <td class="leftTD">
                <asp:Literal ID="lblParentCategory" Text="上级分类" runat="server"></asp:Literal>：
            </td>
            <td class="rightTD">
                <asp:DropDownList ID="listTarget" runat="server" Width="200px" CssClass="input_short">
                    <asp:ListItem Value="0" Selected="True">Root</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="rightTD">
                <label class="msgNormal">
            </td>
        </tr>
        <tr runat="server" id="tblrRewriteName">
            <td class="leftTD">
                <asp:Literal ID="litUrl" Text="URL重写" runat="server"></asp:Literal>：
            </td>
            <td class="rightTD">
                <asp:TextBox ID="TextBox1" runat="server" CssClass="input_short"></asp:TextBox>
            </td>
            <td class="rightTD">
                <div id="txtRewriteNameTip" runat="server">
                </div>
            </td>
        </tr>
        <tr>
            <td class="leftTD">
                <asp:Literal ID="lblCategoryIcon" Text="分类图标" runat="server"></asp:Literal>：
            </td>
            <td class="rightTD">
                <asp:FileUpload ID="fileUpload" CssClass="input_longest" runat="server" />
            </td>
            <td class="rightTD">
                <div class="msgNormal">
                </div>
            </td>
        </tr>
        <tr>
            <td class="leftTD">
                <asp:Literal ID="litDec" Text="分类描述" runat="server"></asp:Literal>：
            </td>
            <td class="rightTD">
                <span>
                    <asp:TextBox ID="txtPageDesc" CssClass="input_short" runat="server"></asp:TextBox></span>
            </td>
            <td class="rightTD">
                <div id="txtPageDescTip" runat="server">
                </div>
            </td>
        </tr>
        <tr>
            <td class="leftTD">
                <asp:Button ID="btnSave" runat="server" Text="<%$ Resources:Site, btnSaveText %>"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
            <td class="rightTD">
                <asp:Button ID="Button2" runat="server" Text="返回分类列表" OnClick="btnCancle_Click" class="inputbutton"
                    onmouseover="this.className='inputbutton_hover'" onmouseout="this.className='inputbutton'" ValidationGroup="A">
                </asp:Button>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>
