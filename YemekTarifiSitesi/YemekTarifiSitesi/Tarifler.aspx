<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Tarifler.aspx.cs" Inherits="Tarifler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .auto-style17 {
            height: 23px;
            width: 124px;
        }
        
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
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:Panel ID="Panel1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style14"><strong>
                <asp:Button ID="Button1" runat="server" CssClass="auto-style16" Text="+" Width="30px" OnClick="Button1_Click"   />
                </strong></td>
            <td class="auto-style14"><strong>
                <asp:Button ID="Button2" runat="server" CssClass="auto-style15" Text="-" Width="30px" OnClick="Button2_Click"   />
                </strong></td>
            <td><strong>ONAYSIZ LİSTESİ</strong></td>
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
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("TarifAD") %>'></asp:Label>
                        </td>
                        <td>
                            <a href="TarifOnayla.aspx?TarifID=<%# Eval("TarifID") %>"><asp:Image ID="Image3" runat="server" Height="15px" ImageAlign="Right" ImageUrl="~/resimler/readIcon.png" /></a> 
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
        </strong></asp:Panel>
    <asp:Panel ID="Panel3" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style14"><strong>
                    <asp:Button ID="Button3" runat="server" CssClass="auto-style16" Text="+" Width="30px" OnClick="Button3_Click"   />
                    </strong></td>
                <td class="auto-style14"><strong>
                    <asp:Button ID="Button4" runat="server" CssClass="auto-style15" Text="-" Width="30px" OnClick="Button4_Click"   />
                    </strong></td>
                <td><strong>ONAYLI LİSTESİ</strong></td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel4" runat="server">
        <strong>
        <asp:DataList ID="DataList2" runat="server">
            <ItemTemplate>
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style17">
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("TarifAD") %>'></asp:Label>
                        </td>
                        <td><a href="TarifOnayla.aspx?TarifID=<%# Eval("TarifID") %>">
                            <asp:Image ID="Image4" runat="server" Height="15px" ImageAlign="Right" ImageUrl="~/resimler/readIcon.png" />
                            </a></td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
        </strong></asp:Panel>
</asp:Content>

