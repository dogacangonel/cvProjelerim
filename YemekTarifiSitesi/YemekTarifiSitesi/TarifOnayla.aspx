<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="TarifOnayla.aspx.cs" Inherits="TarifOnayla" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style4 {
            height: 31px;
        }
        .auto-style5 {
            text-align: right;
        }
        .auto-style6 {
            height: 31px;
            text-align: right;
        }
        .auto-style7 {
            text-align: right;
            height: 110px;
        }
        .auto-style8 {
            height: 110px;
        }
        .auto-style9 {
            font-weight: bold;
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
            <td class="auto-style6"><strong>Tarif Ad:</strong></td>
            <td class="auto-style4">
                <asp:TextBox ID="txtTarifAd" runat="server" Height="20px" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5"><strong>Tarif Malzemeler:</strong></td>
            <td>
                <asp:TextBox ID="txtMalzeme" runat="server" Height="20px" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7"><strong>Yapılışı:</strong></td>
            <td class="auto-style8">
                <asp:TextBox ID="txtYapilis" runat="server" Height="100px" TextMode="MultiLine" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5"><strong>Tarif Resim</strong></td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" Height="25px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style5"><strong>Tarif Öneren:</strong></td>
            <td>
                <asp:TextBox ID="txtOneren" runat="server" Height="20px" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5"><strong>Kategori:</strong></td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" Height="28px" Width="207px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style5"><strong>Öneren Mail:</strong></td>
            <td>
                <asp:TextBox ID="txtMail" runat="server" Height="20px" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td><strong>
                <asp:Button ID="btnOnayla" runat="server" CssClass="auto-style9" OnClick="btnOnayla_Click" Text="Tarifi Onayla" Width="200px" />
                </strong></td>
        </tr>
    </table>

</asp:Content>

