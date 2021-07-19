<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="TrangTinTucDonGian.Admin.AdminHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>AdminHome</h1>
    <asp:HyperLink ID="QuanlyBaiViet" runat="server" NavigateUrl="~/Admin/QuanLyBaiViet.aspx">Quản lí bài viết</asp:HyperLink></br>
    <asp:HyperLink ID="QuanlyUser" runat="server" NavigateUrl="~/Admin/QuanLyUser.aspx">Quản lí User</asp:HyperLink>
</asp:Content>
