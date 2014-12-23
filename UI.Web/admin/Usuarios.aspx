<%@ Page Title="" Language="C#" MasterPageFile="~/admin/header-admin.master" AutoEventWireup="true" CodeFile="Usuarios.aspx.cs" Inherits="admin_Usuarios" %>

            
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">           
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row">
    <div class="container">    
    <h3>Usuarios:</h3>
    <div class="table-responsive">
        <asp:GridView ID="dgvUsuarios" runat="server" DataSourceID="odsUsuarios" 
            CssClass="table table-bordered table-hover table-striped" 
            onselectedindexchanged="dgvUsuarios_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" EditText="Editar" DeleteText="Eliminar" />
                <asp:BoundField DataField="usuraio" HeaderText="usuario" 
                    SortExpression="usuraio" />
                <asp:BoundField DataField="contraseña" HeaderText="contraseña" 
                    SortExpression="contraseña" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="odsUsuarios" runat="server" 
            DeleteMethod="borrarUsuario" InsertMethod="agregarUsuario" 
            SelectMethod="getAllUsuarios" TypeName="Negocio.ControladorUsuarios" 
            UpdateMethod="actualizarUsuario">
            <DeleteParameters>
                <asp:Parameter Name="idUsuario" Type="Int32" />
                <asp:Parameter Name="user" Type="String" />
                <asp:Parameter Name="pass" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="user" Type="String" />
                <asp:Parameter Name="pass" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="idUsuario" Type="Int32" />
                <asp:Parameter Name="user" Type="String" />
                <asp:Parameter Name="pass" Type="String" />
            </UpdateParameters>
        </asp:ObjectDataSource>
    </div>
    </div>
</div>
</asp:Content>

