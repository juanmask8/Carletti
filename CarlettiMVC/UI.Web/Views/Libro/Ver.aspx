<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/HeaderFotter.Master" Inherits="System.Web.Mvc.ViewPage<UI.Web.Models.DetalleModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Detalle Libro
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentScript" runat="server">
      <link href="../../Content/portfolio-item.css" rel="stylesheet" type="text/css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <!-- Portfolio Item Heading -->
        <div class="row">
            <div class="col-lg-12">
                <h1 class="page-header"><%:Model.libro.Titulo %>
                    <small><%:Model.libro.Copete %></small>
                </h1>
            </div>
        </div>
        <!-- /.row -->
            <!-- Libro Item Row -->
        <div class="row">

            <div class="col-md-8">
                <img class="img-responsive" src="http://placehold.it/750x500" alt="">
            </div>

            <div class="col-md-4">
                <h3>Descripcion del Libro</h3>
                <p><%:Model.libro.Detalle %></p>
                <p><%: Model.libro.IdLibro %></p>
                <a href="<%: Model.libro.LinkLibro %>">Descargar el Libro!</a></br>
                <a class="btn btn-primary" href="/Contacto">Consultar! <span class="glyphicon glyphicon-chevron-right"></span></a>
            </div>

        </div>
        <!-- /.row -->

</asp:Content>
