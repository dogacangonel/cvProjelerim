<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="YemekGuncelle.aspx.cs" Inherits="YemekGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style4 {
            font-weight: bold;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <div>
        &nbsp;
    </div>
    <table class="auto-style1">
            <tr>
                <td class="auto-style11"><strong>Yemek Adı:</strong></td>
                <td>
                    <strong>
                        <asp:TextBox ID="txtYemekAd" runat="server" Width="200px"></asp:TextBox>
                    </strong>
                </td>

            </tr>
            <tr>
                <td class="auto-style11"><strong>Malzemeler:</strong></td>
                <td>
                    <asp:TextBox ID="txtMalzeme" runat="server" Height="200px" Width="200px" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style11"><strong>Yemek Tarifi:</strong></td>
                <td>
                    <asp:TextBox ID="txtTarif" runat="server" Height="200px" Width="200px" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style11"><strong>Yemek Resim:</strong></td>
                <td><strong>
                    <asp:FileUpload ID="FileUpload2" runat="server" Width="208px" />
                </strong></td>
            </tr>
        
            <tr>
                <td class="auto-style11"><strong>Yemek Kategori</strong></td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="207px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td><strong>
                    <asp:Button ID="btnEkle" runat="server" CssClass="auto-style10" Height="25px" OnClick="btnEkle_Click" Text="Güncelle" Width="200px" style="font-weight: bold; margin-left: 0px" />
                    </strong></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td><strong>
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style4" Height="25px" OnClick="Button1_Click" Text="Günün Yemeği Seç" Width="200px" />
                    </strong></td>
            </tr>
        </table>
    </asp:Content>

