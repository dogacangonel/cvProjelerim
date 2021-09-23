<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="HakkimizdaAdmin.aspx.cs" Inherits="HakkimizdaAdmin" %>

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
        text-align: center;
    }
    .auto-style18 {
        font-weight: bold;
    }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:Panel ID="Panel1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style14"><strong>
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style16" OnClick="Button1_Click" Text="+" Width="30px" />
                    </strong></td>
                <td class="auto-style14"><strong>
                    <asp:Button ID="Button2" runat="server" CssClass="auto-style15" OnClick="Button2_Click" Text="-" Width="30px" />
                    </strong></td>
                <td><strong>HAKKIMIZDA</strong></td>
            </tr>
        </table>
    </asp:Panel>
    <div class="auto-style17">
    <asp:Panel ID="Panel2" runat="server">
    <asp:TextBox ID="TextBox1" runat="server" Height="170px" Width="530px" TextMode="MultiLine"></asp:TextBox>
        <strong>
        <asp:Button ID="Button3" runat="server" CssClass="auto-style18" Text="GÜNCELLE" Width="250px" OnClick="Button3_Click" />
        </strong></asp:Panel>
</div>
</asp:Content>

