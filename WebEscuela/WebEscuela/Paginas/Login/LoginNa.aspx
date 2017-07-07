<%@ Page Title="" Language="C#" MasterPageFile="~/Plantillas/plantillaLogin.Master" AutoEventWireup="true" CodeBehind="LoginNa.aspx.cs" Inherits="WebEscuela.Paginas.Login.LoginNa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoTitulo" runat="server">
    <div class="login-logo">
        <a><b>Inicio</b> Sesión <b>Clientes</b></a>
    </div>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="login" runat="server">

    <asp:Literal ID="alerta" runat="server"></asp:Literal>

    <form method="post" runat="server">
        <div class="form-group has-feedback">
            <label>Rut</label>
            <asp:TextBox ID="txtRut" TextMode="SingleLine" CssClass="form-control" runat="server"></asp:TextBox>
            <span class="glyphicon glyphicon-envelope form-control-feedback"></span>
        </div>
        <div class="form-group has-feedback">
            <label>Contraseña</label>
            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" CssClass="form-control"></asp:TextBox>
            <span class="glyphicon glyphicon-lock form-control-feedback"></span>
        </div>
        <div class="row">
            <div class="col-xs-4">
                <asp:Button runat="server" Text="Ingresar" CssClass="btn btn-primary btn-block btn-flat" OnClick="btnIngresar_Click" />
            </div>
            <div class="col-xs-4 pull-right">
                <asp:Button runat="server" Text="Cancelar" CssClass="btn btn-default btn-block btn-flat" OnClick="btnCancelar_Click" />
            </div>
        </div>
    </form>
</asp:Content>