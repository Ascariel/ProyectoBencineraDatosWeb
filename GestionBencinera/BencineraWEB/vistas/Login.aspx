<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterLayout.Master" CodeBehind="Login.aspx.cs" Inherits="BencineraWEB.Login" %>

<asp:Content ID="content" runat="server" ContentPlaceHolderID="head" >
    <title>Login</title>
</asp:Content>

<asp:Content ID="content1" ContentPlaceHolderID="main_content" runat="server">
    <div class="row">
        <div class="col-sm-8 col-md-offset-2 well">

            <h2 class="">Inicio de Sesion</h2>
            <br />
            <br />
            <div class="form-group">
                <label for="txtUsername">Nombre Usuario</label>
                <asp:TextBox runat="server" ID="txtUsername" CssClass="form-control" placeholder="Ingrese nombre de usuario" />
            </div>

            <div class="form-group">
                <label>Password</label>
                <asp:TextBox runat="server" ID="txtPassword" type="password" CssClass="form-control" placeholder="Ingrese password" />
            </div>
            <asp:Button Text="Ingresar" ID="btnIngresar" CssClass="btn btn-primary" runat="server" OnClick="btnIngresar_Click" />

        </div>
    </div>


</asp:Content>

