<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Kategoriler.aspx.cs" Inherits="Kategoriler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style3 {
            width: 135px;
        }

        .auto-style5 {
            font-size: large;
        }

        .auto-style6 {
            font-weight: bold;
            font-size: large;
            margin-left: 0px;
        }

        .auto-style7 {
            width: 31px;
        }

        .auto-style8 {
            width: 33px;
        }

        .auto-style9 {
            font-weight: bold;
            font-size: large;
        }

        .auto-style10 {
            font-weight: bold;
        }

        .auto-style11 {
            background-color: #FF3300;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <strong>
    <asp:Panel ID="Panel1" runat="server" CssClass="auto-style5">
        <table class="auto-style1">
            <tr>
                <td class="auto-style7">
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style9" Height="25px" Text="+" Width="25px" OnClick="Button1_Click" />
                </td>
                </strong>
                <td class="auto-style8"><strong>
                    <asp:Button ID="Button2" runat="server" CssClass="auto-style6" Height="25px" Text="-" Width="25px" OnClick="Button2_Click" />
                    </strong></td>
                <strong>
                <td>Kategori Listesi</td>
                </strong>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("KategoriAd") %>'></asp:Label>
                        </td>
                        <td>
                            <a href="Kategoriler.aspx?KategoriID=<%# Eval("KategoriID") %>&islem=sil"  > <asp:Image ID="Image2" runat="server" Height="22px" ImageAlign="Right" ImageUrl="~/resimler/delete.png" /></a> 
                        </td>
                        <td>
                            <a href="KategoriDuzenle.aspx?KategoriID=<%# Eval("KategoriID") %>"> <asp:Image ID="Image3" runat="server" Height="22px" ImageAlign="Right" ImageUrl="~/resimler/update.png" /> </a>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
</asp:Panel>
    <div class="auto-style11" style="height:10px"> &nbsp;</div>
    <asp:Panel ID="Panel3" runat="server">
        <strong>
        <table class="auto-style1">
            <tr>
                <td class="auto-style7">
                    <asp:Button ID="Button3" runat="server" CssClass="auto-style9" Height="25px" Text="+" Width="25px" OnClick="Button3_Click" />
                </td>
        </strong  _designer:mapid="37">
        <td class="auto-style8"><strong>
            <asp:Button ID="Button4" runat="server" CssClass="auto-style6" Height="25px" Text="-" Width="25px" OnClick="Button4_Click" />
            </strong></td>
        <td>Kategori Ekle</td>
        </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel4" runat="server">
        <table class="auto-style1">
            <tr>
                <td>Kategori Adı:</td>
                <strong>
                <td>
                    <asp:TextBox ID="txtAdSoyad" runat="server"></asp:TextBox>
                </td>
                </strong>
            </tr>
            <tr>
                <td>Kategori Icon:</td>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td><strong>
                    <asp:Button ID="btnEkle" runat="server" CssClass="auto-style10" Height="22px" Text="Ekle" Width="74px" OnClick="Button5_Click" />
                    </strong></td>
            </tr>
        </table>

</asp:Panel>
</asp:Content>

