<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MenuLogin1Ejemplo.aspx.cs" Inherits="Ejemplo.MenuLogin1Ejemplo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Te Logueaste Correctamente</h1>
    <div class="row">
        <div class="col">
            <asp:Button Text="Pagina 1" CssClass="btn btn-primary" ID="Pagina1" runat="server" />
        </div>
        <div class="col">
            <asp:Button Text="Pagina 2" ID="Pagina2" CssClass="btn btn-primary float-end" runat="server" />
        </div>
        <div class="row">
            <div class="col">
                <asp:Label Text="Tenes que ser admin" CssClass="float-lg-end" runat="server" />
            </div>
        </div>
    </div>

</asp:Content>
