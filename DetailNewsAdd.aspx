<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="DetailNewsAdd.aspx.cs" Inherits="TrangTinTucDonGian.DetailNews" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Thêm bản tin mới cho Website</h1>
    <div id="ndcontent">
        <h4>Chọn bản tin: </h4>
        <asp:DropDownList ID="rpDanhMuc" runat="server"  Height="22px" Width="400px" ></asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TrangTinTucConnectionString2 %>" SelectCommand="SELECT [title] FROM [tblCategory]"></asp:SqlDataSource>
        <h4>Tiêu đề bản tin:</h4>
        <asp:TextBox ID="TxtTieuDe" runat="server" Width="600px" Height="22px"></asp:TextBox>
        <h4>Nội dung bản tin</h4>
        <CKEditor:CKEditorControl ID="txtNoiDung" runat="server"></CKEditor:CKEditorControl>
        <br /><br />
        <asp:Button ID="btnInsert" runat="server" Text="Cập nhật" Height="39px" Width="120px" OnClick="btnInsert_Click" />
    </div>
</asp:Content>

