<%@ Page Title="Libros" Language="C#" MasterPageFile="~/Views/Shared/HeaderFotter.Master" Inherits="System.Web.Mvc.ViewPage<UI.Web.Models.LibrosModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Libros
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentScript" runat="server">
    <link href="../../Content/1-col-portfolio.css" rel="stylesheet" type="text/css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">Todos los Libros
                <small>los encontras aca!</small>
            </h1>
        </div>
    </div>

    <!-- Libro One -->
        <% foreach (Entidades.Libro libros in Model.Libros)
           {  %>
        <div class="row">
            <div class="col-md-7">
                <a href="#">
                    <img class="img-responsive" src="http://placehold.it/350x150" alt="<%: libros.LinkImagen %>">
                </a>
            </div>
            <div class="col-md-5">
                <h3><%: libros.Titulo %></h3>
                <h4><%: libros.Copete %></h4>
                <p></p>
                <a class="btn btn-primary" href="Ver/<%: libros.IdLibro %>">Ver Libro <span class="glyphicon glyphicon-chevron-right"></span></a>
            </div>
        </div>
        <!-- /.row -->

        <hr>
        <% } %>

</asp:Content>
