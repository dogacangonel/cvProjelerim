<%@ Page Title="" Language="C#" MasterPageFile="~/User.master" AutoEventWireup="true" CodeFile="KategoriDetay.aspx.cs" Inherits="KategoriDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .auto-style3 {
            font-size: x-large;
        }

        .auto-style4 {
            height: 22px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:DataList ID="DataList2" runat="server">
        <ItemTemplate>
            <table class="auto-style1">
                <tr>
                    <td><strong><a href="YemekDetay.aspx?YemekID=<%# Eval("YemekID") %>">
                        <asp:Label ID="Label3" runat="server" CssClass="auto-style3" Text='<%# Eval("YemekAd") %>'></asp:Label>
                        </a></strong></td>
                </tr>
                <tr>
                    <td><strong>Malzemeler:</strong><asp:Label ID="Label4" runat="server" Text='<%# Eval("YemekMalzeme") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td><strong>Yemek Tarifi:</strong><asp:Label ID="Label5" runat="server" Text='<%# Eval("YemekTarif") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Eklenme Tarihi:<asp:Label ID="Label6" runat="server" Text='<%# Eval("YemekTarih") %>'></asp:Label>
                        &nbsp;- <strong>Puan:</strong><asp:Label ID="Label7" runat="server" Text='<%# Eval("YemekPuan") %>'></asp:Label>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4" style="border-bottom-style: ridge; border-bottom-width: thick; border-bottom-color: #993333">&nbsp;</td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>

