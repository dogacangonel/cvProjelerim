<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="GelenMesajlar.aspx.cs" Inherits="GelenMesajlar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style4 {
            height: 26px;
        }
        .auto-style5 {
            margin-left: 80px;
        }
        .auto-style6 {
            margin-left: 120px;
        }
        .auto-style7 {
            height: 25px;
        }
        .auto-style8 {
            text-align: right;
        }
        .auto-style9 {
            height: 25px;
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

    <table class="auto-style1">
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style9"><strong>Mesaj Gönderen:</strong></td>
            <td class="auto-style7">
                <asp:TextBox ID="txtAdSoyad" runat="server" Height="20px" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8"><strong>Başlık:</strong></td>
            <td class="auto-style5">
                <asp:TextBox ID="txtBaslik" runat="server" Height="20px" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8"><strong>Mail Adresi:</strong></td>
            <td class="auto-style6">
                <asp:TextBox ID="txtMail" runat="server" Height="20px" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8"><strong>Mesaj İçerik:</strong></td>
            <td class="auto-style6">
                <asp:TextBox ID="txtIcerik" runat="server" Height="200px" TextMode="MultiLine" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
        </tr>
    </table>

</asp:Content>

