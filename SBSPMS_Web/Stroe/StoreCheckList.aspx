<%@ Page Title="" Language="C#" MasterPageFile="~/Theme/MasterPage.Master" AutoEventWireup="true"
    CodeBehind="StoreCheckList.aspx.cs" Inherits="SBSPMS_Web.Stroe.StoreCheckList" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <tr>
        <td>
            选择盘点期间<asp:TextBox runat="server" />
        </td>
        <td>
            <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" />
        </td>
    </tr>
    <asp:GridView ID="GridView1" runat="server" Height="172px" Width="1266px">
    </asp:GridView>
</asp:Content>
