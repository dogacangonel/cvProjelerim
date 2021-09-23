<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OgrenciListele.aspx.cs" Inherits="OgrenciListele" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">


    <table class="table table-bordered table-hover">
        <tr>
            <th>Öğrenci ID</th>
            <th>Öğrenci Ad</th>
            <th>Öğrenci Soyad</th>
            <th>Öğrenci Numarası</th>
            <th>Öğrenci Fotoğraf</th>
            <th>Öğrenci Şifre</th>
            <th>Öğrenci Bakiye</th>
            <th>İşlemler</th>


        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("ID") %></td>
                        <td><%# Eval("AD") %></td>
                        <td><%# Eval("SOYAD") %></td>
                        <td><%# Eval("NUMARA") %></td>
                        <td><%# Eval("FOTOGRAF") %></td>
                        <td><%# Eval("SIFRE") %></td>
                        <td><%# Eval("BAKIYE") %></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%# "~/OgrenciGuncelle.aspx?ogrId="+ Eval("ID") %>' runat="server" CssClass="btn btn-success">Güncelle</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%# "~/OgrenciSil.aspx?ogrId="+ Eval("ID") %>' runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>

                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>

        </tbody>
    </table>
    <a href="AnaSayfa.aspx" class="btn btn-primary">Öğrenci Ekle</a>
</asp:Content>

