<%@ Page Title="" Language="C#" MasterPageFile="~/User.master" AutoEventWireup="true" CodeFile="Hakkimizda.aspx.cs" Inherits="Hakkimizda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style3 {
            font-size: x-large;
            text-align: center;
        }
        .auto-style4 {
            text-align: justify;
        }
        .auto-style5 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style3"><strong>Hakkımızda</strong></td>
        </tr>
    </table>
    <br />
    <table class="auto-style1">
        <tr>
            <td class="auto-style4">
                <asp:DataList ID="DataList2" runat="server">
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("metin") %>'></asp:Label>
                    </ItemTemplate>
                </asp:DataList>
                <br />
            </td>
        </tr>

        <tr>
            <td class="auto-style5">
                <asp:Image ID="Image1" runat="server" Height="262px" ImageUrl="~/resimler/coding.jpg" Width="533px" />
            </td>
        </tr>
    </table>
</asp:Content>

