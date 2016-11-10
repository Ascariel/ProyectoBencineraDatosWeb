<%@ Page Title="" Language="C#" MasterPageFile="~/MasterLayout.Master" AutoEventWireup="true" CodeBehind="ListadoUsuarios.aspx.cs" Inherits="BencineraWEB.ListadoUsuarios" %>
<asp:Content ID="Content5" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="navbar" runat="server">
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="main_content" runat="server">
    <h1>Listado Usuarios</h1>
    <br />

    <div class="row">
        <div class="col-sm-12">

            <asp:GridView ID="grdListadoUsuarios" AutoGenerateColumns="false" CssClass="table table-hover" Visible="true" OnRowCommand="grdListadoUsuarios_RowCommand" runat="server" ShowHeaderWhenEmpty="true" EmptyDataText="No se han encontrado usuarios">
                <Columns>
                    <asp:BoundField Visible="true" HeaderText="Email" DataField="Email" ShowHeader="true" />
                    <asp:BoundField Visible="true" HeaderText="Nombre" DataField="Nombre" ShowHeader="true" />
                    <asp:BoundField Visible="true" HeaderText="Apellido" DataField="Apellido" ShowHeader="true" />


                    <asp:TemplateField>
                        <HeaderTemplate>
                            Modificar
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Button ID="btnModificar" runat="server" CommandArgument='<%# Eval("Email") %>' CommandName="Modificar" Text="Modificar" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            Eliminar
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Button ID="btnEliminar" runat="server" CommandArgument='<%# Eval("Email") %>' CommandName="Eliminar" Text="Eliminar" />
                        </ItemTemplate>
                    </asp:TemplateField>



                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content8" ContentPlaceHolderID="javascripts" runat="server">
</asp:Content>
