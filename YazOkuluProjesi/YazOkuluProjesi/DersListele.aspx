<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DersListele.aspx.cs" Inherits="DersListele" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form runat="server">
        <div>
            <asp:Label for="txtId" runat="server" Text="Label">Öğrenci ID</asp:Label>
            <asp:TextBox ID="txtId" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label for="DropDownList1" runat="server" Text="Label">Ders Ekle</asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />
        <asp:Button ID="Button1" runat="server" CssClass="btn btn-warning" Text="Talep Oluştur" OnClick="Button1_Click" />
    </form>
</asp:Content>

