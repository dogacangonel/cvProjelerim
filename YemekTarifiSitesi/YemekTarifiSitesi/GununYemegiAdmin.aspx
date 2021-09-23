<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="GununYemegiAdmin.aspx.cs" Inherits="GununYemegiAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">


        .auto-style14 {
            width: 34px;
        }

        .auto-style16 {
            font-weight: bold;
            font-size: large;
        }

        .auto-style15 {
            font-size: large;
            margin-left: 0px;
        }

        .auto-style17 {
        text-align: right;
    }

        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:Panel ID="Panel1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style14"><strong>
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style16" Text="+" Width="30px" OnClick="Button1_Click"  />
                    </strong></td>
                <td class="auto-style14"><strong>
                    <asp:Button ID="Button2" runat="server" CssClass="auto-style15" Text="-" Width="30px" OnClick="Button2_Click"  />
                    </strong></td>
                <td><strong>GÜNÜN YEMEĞİ LİSTESİ</strong></td>
            </tr>
        </table>

    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
        <strong>
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("YemekAd") %>'></asp:Label>
                        </td>
                        <td class="auto-style17"><a href='YemekGuncelle.aspx?YemekID=<%# Eval("YemekID") %>'>
                            <asp:Image ID="Image3" runat="server" Height="15px" ImageAlign="Right" ImageUrl="~/resimler/readIcon.png" Width="20px" />
                            </a></td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
        </strong>

    </asp:Panel>
</asp:Content>

