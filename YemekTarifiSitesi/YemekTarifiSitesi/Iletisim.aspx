<%@ Page Title="" Language="C#" MasterPageFile="~/User.master" AutoEventWireup="true" CodeFile="Iletisim.aspx.cs" Inherits="Iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .auto-style7 {
            font-size: x-large;
        }
        .auto-style5 {
            text-align: right;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style7" colspan="2"><strong>Mesaj Paneli</strong></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5"><strong>Ad Soyad:</strong></td>
            <td class="auto-style4">
                <asp:TextBox ID="txtAdSoyad"  runat="server" CssClass="textbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5"><strong>Mail Adresiniz:</strong></td>
            <td class="auto-style4">
                <asp:TextBox ID="txtMailAdres"  runat="server" CssClass="textbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5"><strong>Konu:</strong></td>
            <td class="auto-style4">
                <asp:TextBox ID="txtKonu"   runat="server" CssClass="textbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5"><strong>Mesaj:</strong></td>
            <td class="auto-style4">
                <asp:TextBox ID="txtMesaj"  runat="server" CssClass="textbox" Height="100px" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style4"><strong>
                <asp:Button ID="btnGonder" runat="server" CssClass="fb8" Text="Gönder" Width="238px" OnClick="btnGonder_Click" />
                </strong></td>
        </tr>
    </table>
</asp:Content>

