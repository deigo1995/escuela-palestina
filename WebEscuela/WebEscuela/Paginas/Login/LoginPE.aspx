<%@ Page Title="" Language="C#" MasterPageFile="~/Plantillas/plantillaLogin.Master" AutoEventWireup="true" CodeBehind="LoginPE.aspx.cs" Inherits="WebEscuela.Paginas.Login.LoginPE" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoTitulo" runat="server">
    <div class="login-logo">
        <a><b>Inicio</b> Sesión <b>Personal</b></a>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="login" runat="server">

    <asp:Literal ID="alerta" runat="server"></asp:Literal>

    <form method="post" runat="server">
        <div class="form-group has-feedback">
            <label>Rut</label>
            <asp:TextBox ID="txtEmail" TextMode="SingleLine" CssClass="form-control" runat="server"></asp:TextBox>
            <span class="glyphicon glyphicon-envelope form-control-feedback"></span>
        </div>
        <div class="form-group has-feedback">
            <label>Contraseña</label>
            <asp:TextBox ID="txtPass" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>
            <span class="glyphicon glyphicon-lock form-control-feedback"></span>
        </div>

        <div class="row">
            <div class="col-xs-4">
                <asp:Button Text="Ingresar" CssClass="btn btn-primary btn-block btn-flat" runat="server"/>
            </div>
            <div class="col-xs-4 pull-right">
                <asp:Button Text="Cancelar" CssClass="btn btn-default btn-block btn-flat" runat="server" />
            </div>
        </div>
    </form>
</asp:Content>