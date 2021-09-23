<%@ Page Title="" Language="C#" MasterPageFile="~/User.master" AutoEventWireup="true" CodeFile="YemekDetay.aspx.cs" Inherits="YemekDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style3 {
            font-size: xx-large;
        }

        .auto-style4 {
            font-size: x-small;
        }

        .auto-style5 {
            font-size: large;
        }

        .auto-style6 {
            font-size: small;
        }

        .auto-style7 {
            margin-left: 120px;
        }

        .auto-style8 {
            text-align: right;
        }

        .auto-style9 {
            font-weight: bold;
        }

        .auto-style10 {
            text-align: right;
            height: 26px;
        }

        .auto-style11 {
            height: 26px;
            margin-left: 120px;
        }

        .auto-style12 {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <strong>

        <asp:Label ID="Label3" runat="server" Text="Label" CssClass="auto-style3"></asp:Label>

        <br />
        <asp:DataList ID="DataList2" runat="server">
            <ItemTemplate>
                <table class="auto-style1">
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" CssClass="auto-style5" Text='<%# Eval("YorumAdSoyad") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label5" runat="server" CssClass="auto-style6" Text='<%# Eval("YorumIcerik") %>'></asp:Label>
                            &nbsp;-
                        <asp:Label ID="Label6" runat="server" CssClass="auto-style4" Text='<%# Eval("YorumTarih") %>'></asp:Label>
                            </strong></td>
                    </tr>
                    <tr>
                        <td style="border-bottom-style: groove; border-bottom-width: thick; border-bottom-color: #0066FF">&nbsp;</td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
        <br />
    </strong>
    <div>
        <strong>YORUM EKLE
        </strong>
    </div>
    <table class="auto-style1">
        <tr>
            <td class="auto-style12"></td>
            <td class="auto-style12"></td>
        </tr>
        <tr>
            <td class="auto-style8"><strong>Ad Soyad:</strong></td>
            <td>
                <asp:TextBox ID="txtAdSoyad" runat="server" Height="20px" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8"><strong>Mail:</strong></td>
            <td>
                <asp:TextBox ID="txtMail" runat="server" Height="20px" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style10"><strong>Yorumunuz:</strong></td>
            <td class="auto-style11">
                <asp:TextBox ID="txtYorum" runat="server" Height="100px" TextMode="MultiLine" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style7"><strong>
                <asp:Button ID="Button1" runat="server" CssClass="auto-style9" OnClick="Button1_Click" Text="Yorum Yap" Width="200px" />
            </strong></td>
        </tr>
    </table>
</asp:Content>

