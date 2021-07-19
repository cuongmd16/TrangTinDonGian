<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="AddNews.aspx.cs" Inherits="TrangTinTucDonGian.AddNews" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1>Thêm bản tin mới cho Website</h1>
    <div id="ndcontent">
        <h4>Chọn bản tin: </h4>
        <asp:DropDownList ID="drDanhMuc" runat="server"  Height="22px" Width="400px" DataSourceID="SqlDataSource1" DataTextField="category_ID" DataValueField="category_ID" ></asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TrangTinTucConnectionString2 %>" SelectCommand="SELECT * FROM [tblCategory]"></asp:SqlDataSource>
        <h4>Người thêm bản tin: </h4>
        <asp:DropDownList ID="drNguoiDang" runat="server"  Height="22px" Width="400px" DataSourceID="SqlDataSource2" DataTextField="user_ID" DataValueField="user_ID" ></asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:TrangTinTucConnectionString2 %>" SelectCommand="SELECT [user_ID], [username] FROM [tblUser]"></asp:SqlDataSource>
        <h4>Tiêu đề bản tin:</h4>
        <asp:TextBox ID="TxtTitle" runat="server" Width="600px" Height="22px"></asp:TextBox>
        <h4>Nội dung bản tin</h4>
        <asp:TextBox ID="txtBody" runat="server" Height="155px" Width="595px"></asp:TextBox>
        <br /><br />
        <asp:Button ID="btnAdd" runat="server" Text="Add News" OnClick="btnAdd_Click" />
    </div>
</asp:Content>
