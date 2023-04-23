<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DropDownList.aspx.cs" Inherits="Ejemplo.DropDownList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col">
            <h4>Dropdown Estatico</h4>
            <asp:DropDownList CssClass="btn btn-outline-dark dropdown-toggle" ID="ddlColores" runat="server">
                <asp:ListItem Text="Rojo" />
                <asp:ListItem Text="Amarillo" />
                <asp:ListItem Text="Azul" />
            </asp:DropDownList>
        </div>
        <div class="col">
            <h4>DDL desde data Base</h4>
            <asp:DropDownList runat="server" ID="ddlPokemon" CssClass="btn btn-outline-dark dropdown-toggle ">
            </asp:DropDownList>
        </div>
    </div>
</asp:Content>
