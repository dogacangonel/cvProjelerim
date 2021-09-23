<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="YorumOnay.aspx.cs" Inherits="KategoriOnay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style4 {
            margin-left: 40px;
        }
        .auto-style5 {
            height: 30px;
            text-align: right;
        }
        .auto-style6 {
            height: 30px;
            margin-left: 40px;
        }
        .auto-style7 {
            font-weight: bold;
        }
        .auto-style8 {
            height: 34px;
            text-align: right;
        }
        .auto-style9 {
            height: 34px;
            margin-left: 40px;
        }
        .auto-style10 {
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10"><strong>Ad Soyad:</strong></td>
            <td class="auto-style4">
                <asp:TextBox ID="txtAdSoyad" runat="server" Height="20px" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5"><strong>Mail Adresi:</strong></td>
            <td class="auto-style6">
                <asp:TextBox ID="txtMail" runat="server" Height="20px" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style10"><strong>İçerik:</strong></td>
            <td class="auto-style4">
                <asp:TextBox ID="txtIcerik" runat="server" Height="100px" TextMode="MultiLine" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8"><strong>Yemek:</strong></td>
            <td class="auto-style9">
                <asp:TextBox ID="txtYemek" runat="server" Height="20px" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style4"><strong>
                <asp:Button ID="Button1" runat="server" CssClass="auto-style7" Height="25px" OnClick="Button1_Click" Text="Onayla" Width="120px" />
                </strong></td>
        </tr>
    </table>
</asp:Content>

