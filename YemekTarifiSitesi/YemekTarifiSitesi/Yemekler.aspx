<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Yemekler.aspx.cs" Inherits="Yemekler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style10 {
            font-weight: bold;
        }

        .auto-style11 {
            text-align: right;
        }

        .auto-style14 {
            width: 34px;
        }

        .auto-style15 {
            font-size: large;
            margin-left: 0px;
        }

        .auto-style16 {
            font-weight: bold;
            font-size: large;
        }

        .auto-style17 {
            font-size: large;
        }
        .auto-style18 {
            height: 23px;
            text-align: left;
            width: 184px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <asp:Panel ID="Panel1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style14"><strong>
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style16" Text="+" Width="30px" OnClick="Button1_Click1" />
                </strong></td>
                <td class="auto-style14"><strong>
                    <asp:Button ID="Button2" runat="server" CssClass="auto-style15" Text="-" Width="30px" OnClick="Button2_Click1" />
                </strong></td>
                <td><strong>YEMEK LİSTESİ</strong></td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
        <strong>
            <asp:DataList ID="DataList1" runat="server">
                <ItemTemplate>
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style18">
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("YemekAd") %>'></asp:Label>
                            </td>
                            <td class="auto-style11">
                                <a href="Yemekler.aspx?YemekID=<%# Eval("YemekID") %>&silme=sil&Kategori=<%# Eval("Kategori") %>">
                                    <asp:Image ID="Image2" runat="server" Height="22px" ImageAlign="Right" ImageUrl="~/resimler/delete.png" /></a>
                            </td>
                            <td class="auto-style11">
                                <a href="YemekGuncelle.aspx?YemekID=<%# Eval("YemekID") %>">
                                    <asp:Image ID="Image3" runat="server" Height="22px" ImageAlign="Right" ImageUrl="~/resimler/update.png" /></a>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
        </strong>
    </asp:Panel>
    <div>&nbsp;</div>
    <asp:Panel ID="Panel3" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style14"><strong>
                    <asp:Button ID="Button3" runat="server" CssClass="auto-style16" Text="+" Width="30px" OnClick="Button3_Click1" />
                </strong></td>
                <td class="auto-style14"><strong>
                    <asp:Button ID="Button4" runat="server" CssClass="auto-style17" Text="-" Width="30px" OnClick="Button4_Click1" />
                </strong></td>
                <td><strong>YEMEK EKLE</strong></td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel4" runat="server">
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
                    <asp:Button ID="btnEkle" runat="server" CssClass="auto-style10" Height="22px" OnClick="btnEkle_Click" Text="Ekle" Width="74px" />
                </strong></td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>

