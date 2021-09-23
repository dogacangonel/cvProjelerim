<%@ Page Title="" Language="C#" MasterPageFile="~/User.master" AutoEventWireup="true" CodeFile="TarifOner.aspx.cs" Inherits="TarifOner" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style3 {
        height: 26px;
    }
    .auto-style4 {
        text-align: right;
    }
    .auto-style5 {
        height: 26px;
        text-align: right;
    }
        .auto-style6 {
            text-align: left;
            font-size: medium;
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
        <td class="auto-style4"><strong>Tarif Ad:</strong></td>
        <td>
            <asp:TextBox ID="txtTarifAd" runat="server" Height="20px" Width="200px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style4"><strong>Malzemeler:</strong></td>
        <td>
            <asp:TextBox ID="txtMalzemeler" runat="server" Height="100px" TextMode="MultiLine" Width="200px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style4"><strong>Yapılışı:</strong></td>
        <td>
            <asp:TextBox ID="txtYapilis" runat="server" Height="100px" TextMode="MultiLine" Width="200px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style4"><strong>Resim:</strong></td>
        <td>
&nbsp;<asp:FileUpload ID="FileUpload1" runat="server" Height="25px" Width="200px" />
        </td>
    </tr>
    <tr>
        <td class="auto-style5"><strong>Tarifi Öneren:</strong></td>
        <td class="auto-style6"><strong>
            <asp:TextBox ID="txtTarifOneren" runat="server" Height="20px" Width="200px"></asp:TextBox>
            </strong></td>
    </tr>
    <tr>
        <td class="auto-style4"><strong>Mail Adresi:</strong></td>
        <td>
            <asp:TextBox ID="txtMail" runat="server" Height="20px" TextMode="Email" Width="200px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Button ID="btnTarifOner" runat="server" Text="Tarifi Öner" OnClick="btnTarifOner_Click" style="height: 26px" />
        </td>
    </tr>
</table>
</asp:Content>

