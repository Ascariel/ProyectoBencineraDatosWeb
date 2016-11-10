<%@ Page Title="" Language="C#" MasterPageFile="~/MasterLayout.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="BencineraWEB.vistas.Home" %>


<asp:Content ID="content" runat="server" ContentPlaceHolderID="head">
    <title>Home</title>
    
    <style type="text/css">
        .auto-style1 {
            width: 1125px;
            height: 402px;
        }
    </style>
</asp:Content>



<asp:Content ID="content2" runat="server" ContentPlaceHolderID="main_content">

    <div class="jumbotron" style="background-image:url(http://asexma.cl/wp-content/uploads/2015/04/copec.jpg); background-repeat:no-repeat; background-size:cover">
        <h1 style="text-align:right; color:white ">Bienvenido</h1>
        <p style="text-align:right; color:white " class="lead">Mantenedor de usuarios<br />para acceso diferentes procesos.</p>
        <p><a class="btn btn-lg btn-default" href="SignUp.aspx" role="button" style="margin-left:380px;">Regístrate aquí</a></p></div>

    <div class="row marketing">
        <div class="col-md-">
            <img alt="" width="100%"  src="http://cms-adm.cocha.com/images/images/Captura.PNG" />
        </div>
        <hr />
        <div class="col-lg-6">
            <h3 style="color:crimson">COPEC</h3>
            <p>En 1934 un grupo de visionarios formó la Compañía de Petróleos de Chile, Copec S.A. Desde ese momento su objetivo ha sido llegar a todos y cada uno de los chilenos.</p>
        </div>
        <div class="col-lg-6">
            <h3 style="color:crimson">QUIENES SOMOS</h3>
            <p>Contamos con una extensa red de más de 615 Estaciones de Servicio de Arica a Punta Arenas, las que complementan la oferta de combustibles, con servicios de lubricación, lavado y comida a través de sus tiendas Pronto, Punto y Dpaso. </p>
        </div>
    </div>

    <footer class="footer">
        <p style="font-weight: bolder;">Oficinas Generales: Agustinas 1382 Stgo. Copec en Linea - Fono 600 200 02 02<br />
        <span style="font-weight: bolder; color:cornflowerblue;">Noticias Legales: Resoluciones TDLC</span><br />
            <hr />
        <span style="font-size:12px;">@Copyright 2013 Compañía de Petróleos de Chile Copec S. A. Todos los derechos reservados</span> <br />
        <a href="http://ww2.copec.cl/terms" target="_blank">Términos y Condiciones</a></p>
    </footer>
</asp:Content>


<asp:Content ID="Content4" ContentPlaceHolderID="javascripts" runat="server">
</asp:Content>
