<%@ Page Title="" Language="C#" MasterPageFile="~/User.master" AutoEventWireup="true" CodeFile="GununYemegi.aspx.cs" Inherits="GununYemegi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style3 {
            font-size: x-large;
        }
        .auto-style4 {
            font-size: large;
        }
        .auto-style5 {
            font-size: large;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">   
        <asp:DataList ID="DataList2" runat="server">
            <ItemTemplate>
                <table class="auto-style1" dir="ltr">
                    <tr>
                        <td class="auto-style5"><strong>
                            <asp:Label ID="Label3" runat="server" CssClass="auto-style3" Text='<%# Eval("YemekAd") %>'></asp:Label>
                            </strong></td>
                    </tr>
                    <tr>
                        <td>
                            <span class="auto-style4"><strong>Malzemeler</strong></span><br />
                            <asp:Label ID="Label4" runat="server" Text='<%# Eval("YemekMalzeme") %>'></asp:Label>
                        </td>
                    </tr>
                  
                        
                        <tr>
                            <td>
                                <strong><span class="auto-style4">
                                <br />
                                Tarif</span></strong><br />
                                <asp:Label ID="Label5" runat="server" Text='<%# Eval("YemekTarif") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">
                                <asp:Image ID="Image1" runat="server" Height="205px" ImageUrl='<%# Eval("YemekResim") %>' Width="460px" />
                            </td>
                        </tr>
                        <tr>
                            <td><strong><span class="auto-style4">Puan:</span></strong><asp:Label ID="Label6" runat="server" Text='<%# Eval("YemekPuan") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td><strong><span class="auto-style4">Tarih:</span></strong><asp:Label ID="Label7" runat="server" Text='<%# Eval("YemekTarih") %>'></asp:Label>
                            </td>
                        </tr>
                   
                </table>
            </ItemTemplate>
        </asp:DataList>
</asp:Content>

