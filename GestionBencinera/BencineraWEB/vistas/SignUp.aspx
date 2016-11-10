<%@ Page Title="" Language="C#" MasterPageFile="~/MasterLayout.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="BencineraWEB.vistas.SignUp" %>

<asp:Content ID="bla" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="content1" ContentPlaceHolderID="main_content" runat="server">
    <!-- CONTENEDOR -->
    <div class="row well">
        <h2 class="text-center">Ingrese datos para crear su cuenta de usuario</h2>
        <h3 style="text-align:center; color:crimson;"><asp:Label ID="lblMsg" runat="server" /></h3>
        <div class="col-xs-12 col-md">
            <div class="col-md-6">
                <asp:Label ID="lblNombre" Text="*Nombre: " runat="server" />
                <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server" />
            </div>
            <div class="col-md-6">
                <asp:Label ID="lblApellido" Text="*Apellido:" runat="server" />
                <asp:TextBox ID="txtApellido" CssClass="form-control" runat="server" />
            </div>
            <div class="col-md-6">
                <asp:Label ID="lblEmail" Text="*Email: " runat="server" />
                <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server" />
            </div>
            <div class="col-md-6">
                <asp:Label ID="lblPass" Text="*Password: " runat="server" />
                <asp:TextBox ID="txtPass" type="password" CssClass="form-control" placeholder="Ingrese password" runat="server" />                
            </div>
            <div class="col-md-6">
                <asp:Label ID="lblRut" Text="*Rut: " runat="server" />
                <asp:TextBox ID="txtRut" CssClass="form-control" runat="server" />
            </div>
            <div class="col-md-6">
                <asp:Label ID="lblTelefono" Text="*Teléfono: " runat="server" />
                <asp:TextBox ID="txtTelefono" CssClass="form-control" runat="server" />
            </div>
            <div class="col-md-6">
                <asp:Label ID="lblTurno" Text="*Tipo Turno: " runat="server" />
                <asp:TextBox ID="txtTurno" CssClass="form-control" runat="server" />
            </div>
            <div class="col-md-6">
                <br />
                <asp:DropDownList ID="ddlTipoUsuario" runat="server" Height="30px" Width="266px">
                    <asp:ListItem>Tipo de Usuario</asp:ListItem>
                    <asp:ListItem>Bombero</asp:ListItem>
                    <asp:ListItem>Secretari@</asp:ListItem>
                    <asp:ListItem>Jefe</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="col-md-6">
                <br />
                <asp:Button ID="btnCrearCuenta" Text="Crear cuenta" runat="server" CssClass="btn btn-primary" OnClick="btnCrearCuenta_Click" />                
            </div>
        </div>
    </div>
</asp:Content>


