<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Mesajlar.aspx.cs" Inherits="Mesajlar" %>

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
            height: 23px;
            width: 124px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:Panel ID="Panel1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style14"><strong>
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style16" Text="+" Width="30px" OnClick="Button1_Click1"  />
                    </strong></td>
                <td class="auto-style14"><strong>
                    <asp:Button ID="Button2" runat="server" CssClass="auto-style15" Text="-" Width="30px" OnClick="Button2_Click1"  />
                    </strong></td>
                <td><strong>MESAJLAR LİSTESİ</strong></td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
        <strong>
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style17">
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("mesajGonderen") %>'></asp:Label>
                        </td>
                        <td>
                            <a href="GelenMesajlar.aspx?mesajID=<%# Eval("mesajID") %>"><asp:Image ID="Image3" runat="server" Height="15px" ImageAlign="Right" ImageUrl="~/resimler/readIcon.png" /></a>  
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
        </strong></asp:Panel>
</asp:Content>

