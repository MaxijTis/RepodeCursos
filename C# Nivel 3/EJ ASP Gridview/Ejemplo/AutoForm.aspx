<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AutoForm.aspx.cs" Inherits="Ejemplo.AutoForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <label for="txtId" class="form-label">Id</label>
                <asp:TextBox runat="server" ID="txtId" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtModelo" class="form-label">Modelo</label>
                <asp:TextBox runat="server" ID="txtModelo" CssClass="form-control"/>
            </div>
            <div class="mb-3">
                <label for="txtDescripcion" class="form-label">Descripción</label>
                <asp:TextBox runat="server" TextMode="MultiLine" ID="txtDescripcion" CssClass="form-control"/>
            </div>
            <div class="mb-3">
                <label for="" class="form-label">Color</label>
                <asp:DropDownList  ID="ddlColores" CssClass="form-select" runat="server"></asp:DropDownList>
            </div>
            <div class="mb-3">
                <label for="txtFecha" class="form-label">Fecha</label>
                <asp:TextBox runat="server" TextMode="Date" ID="txtFecha" CssClass="form-control"/>
            </div>
                <asp:CheckBox Text="" ID="chkUsado" runat="server" />
                <asp:label Text="Usado" CssClass="form-check-label" runat="server" />
            <div class="mb-3">
                <asp:RadioButton ID="rdbImportado" Text="" Checked="true" AutoPostBack="True"  OnCheckedChanged="rdbImportado_CheckedChanged" runat="server" GroupName="Importado" />
                <asp:label Text="Importado" CssClass="form-check-label" runat="server" />
                <asp:RadioButton ID="rdbNacional" Text=""  GroupName="Importado" AutoPostBack="True" OnCheckedChanged="rdbImportado_CheckedChanged" runat="server" />
                <asp:label Text="Nacional" CssClass="form-check-label" runat="server" />
            </div>
            <div class="mb-3">
                <asp:Button Text="Aceptar" ID="btnAceptar" CssClass="btn btn-primary" OnClick="btnAceptar_Click" runat="server" />
                <a href="Formulario.aspx">Cancelar</a> 
            </div>
        </div>
    </div>



</asp:Content>
