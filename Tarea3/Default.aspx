<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Tarea3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <div class="row">
         <div class="col-sm-6">
            <h2>Formulario de Estudiante</h2>
            <div class="form-group">
                <asp:Label ID="lblCedula" runat="server" Text="Cedula"></asp:Label>
                <asp:TextBox ID="txtCedula" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblCarnet" runat="server" Text="Carnet"></asp:Label>
                <asp:TextBox ID="txtCarnet" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Carrera"></asp:Label>
                <asp:DropDownList ID="cbCarrera" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Fecha de Ingreso"></asp:Label>
                <asp:Calendar ID="calendar" runat="server"></asp:Calendar>
            </div>
            <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="Foto"></asp:Label>
                <asp:FileUpload ID="img" runat="server"  CssClass="form-control"/>
            </div>
            <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="Curriculum"></asp:Label>
                <asp:FileUpload ID="curriculum" runat="server" CssClass="form-control" />
            </div>
             <div class="form-group">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-success" OnClick="btnSubmit_Click" />
            </div>
         </div>
    </div>


</asp:Content>
