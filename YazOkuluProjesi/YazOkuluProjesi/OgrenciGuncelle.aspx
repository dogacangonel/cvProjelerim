<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OgrenciGuncelle.aspx.cs" Inherits="OgrenciGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
     <form id="Form1" runat="server">
        <div class="form-group" >
            <div>
                <asp:Label for="txtId" runat="server" Text="Öğrenci ID">
                </asp:Label><asp:TextBox ID="txtId" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="txtAd" runat="server" Text="Öğrenci Adı">
                </asp:Label><asp:TextBox ID="txtAd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="txtSoyad" runat="server" Text="Öğrenci Soyad">
                </asp:Label><asp:TextBox ID="txtSoyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
              <div>
                <asp:Label for="txtNumara" runat="server" Text="Öğrenci Numara">
                </asp:Label><asp:TextBox ID="txtNumara" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
              <div>
                <asp:Label for="txtFotograf" runat="server" Text="Öğrenci Fotoğraf">
                </asp:Label><asp:TextBox ID="txtFotograf" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
              <div>
                <asp:Label for="txtSifre" runat="server" Text="Öğrenci Şifre">
                </asp:Label><asp:TextBox ID="txtSifre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Güncelle"  class="btn btn-warning" OnClick="Button1_Click" />
    </form>
</asp:Content>

