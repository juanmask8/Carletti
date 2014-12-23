<%@ Page Title="" Language="C#" MasterPageFile="~/admin/header-admin.master" AutoEventWireup="true" CodeFile="AgregarLibro.aspx.cs" Inherits="admin_AgregarLibro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row">
   <div class="container">
        <h3>Agregar Nuevo Libro:</h3>
        <form role="form">
            <div class="form-group">
                <label>Titulo:</label>
                <input type="text" class="form-control" id="titulo" name="titulo" runat="server">                
            </div>  
            <div class="form-group">
                <label>ISBN:</label>
                <input type="text" class="form-control" id="isbn" name="isbn" runat="server">                
            </div>  
            <div class="form-group">    
                <label>Detalle:</label>
                <textarea ID="detalle" name="detalle" class="form-control" rows="3" runat="server"></textarea>                
            </div>  
            <div class="form-group">     
                <label>Subir archivo pdf:</label>
                <asp:FileUpload ID="filePDF" name="filePDF" runat="server" />
            </div>  
            <div class="form-group"> 
                <label>Subir imagen del Libro:</label>
                <asp:FileUpload ID="FilePortada" name="FilePortada" runat="server" />
            </div>  
            <div class="form-group"> 
                <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" 
                    class="btn btn-primary" onclick="btnAceptar_Click" />
            </div>            
        </form>
    </div>
</div>
</asp:Content>

