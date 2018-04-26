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
                <asp:DropDownList ID="cbCarrera" runat="server" CssClass="form-control" DataSourceID="LinqDataSource2" DataTextField="nombre" DataValueField="id_carrera"></asp:DropDownList>
                <asp:LinqDataSource ID="LinqDataSource2" runat="server" ContextTypeName="Tarea3.DataClasses1DataContext" EntityTypeName="" OrderBy="nombre" Select="new (id_carrera, nombre)" TableName="Carreras">
                </asp:LinqDataSource>
            </div>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Fecha de Ingreso"></asp:Label>
                <asp:Calendar ID="calendar" runat="server"></asp:Calendar>
            </div>
            <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="Foto"></asp:Label>
                <div class="container">
                </div>
                <asp:FileUpload ID="img" runat="server"  CssClass="form-control"/>
            </div>
            <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="Curriculum"></asp:Label>
                <asp:FileUpload ID="curriculum" runat="server" CssClass="form-control" />
            </div>
             <div class="form-group">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-success" OnClick="btnSubmit_Click" />
            </div>
             <asp:GridView ID="tbEstudiantes" runat="server" AutoGenerateColumns="False" DataKeyNames="cedula" DataSourceID="LinqDataSource1" CssClass="table" >
                <Columns >
                    <asp:BoundField DataField="cedula" HeaderText="Cedula" ReadOnly="True" SortExpression="cedula" />
                    <asp:BoundField DataField="carnet" HeaderText="Carnet" SortExpression="carnet" />
                    <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre" />
                    <asp:BoundField DataField="id_carrera" HeaderText="Id Carrera" SortExpression="id_carrera" NullDisplayText="Null" />
                    <asp:BoundField DataField="fecha_ingreso" HeaderText="Fecha de Ingreso" SortExpression="fecha_ingreso" DataFormatString="{0:dd/MM/yy} " />
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                </Columns>
                <HeaderStyle BackColor="Black" ForeColor="White" />
                <SelectedRowStyle CssClass="info" BackColor="#CCFF99" />
                <SortedAscendingHeaderStyle BackColor="Black" />
            </asp:GridView>
            <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="Tarea3.DataClasses1DataContext" EntityTypeName="" TableName="Estudiantes" EnableDelete="True" EnableInsert="True" EnableUpdate="True">
            </asp:LinqDataSource>
      
         </div>
         <div class="col-sm-6">
            <h2>Formulario de Carrera</h2>
             <div class="form-group">
                <asp:Label ID="Label8" runat="server" Text="Codigo de Carrera"></asp:Label>
                <asp:TextBox ID="txtCodigoCarrera" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox ID="txtNombreCarrera" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label6" runat="server" Text="Encargado"></asp:Label>
                <asp:TextBox ID="txtEncargado" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label7" runat="server" Text="Ubicacion"></asp:Label>
                <asp:TextBox ID="txtUbicacion" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
             <div class="form-group">
                <asp:Button ID="btnSubmitCarrera" runat="server" Text="Submit" CssClass="btn btn-success" OnClick="btnSubmitCarrera_Click" />
            </div>
             <h2>Tabla Carreras</h2>
             <asp:GridView ID="tbCarrera" runat="server" DataKeyNames="id_carrera" AutoGenerateColumns="False" DataSourceID="LinqDataSource3" CssClass="table" >
                <Columns >
                    <asp:BoundField DataField="id_carrera" HeaderText="id_carrera" SortExpression="id_carrera" ReadOnly="true" />
                    <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre"  />
                    <asp:BoundField DataField="encargado" HeaderText="encargado" SortExpression="encargado"  />
                    <asp:BoundField DataField="ubicacion" HeaderText="ubicacion" SortExpression="ubicacion"  />
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True"/>
                </Columns>
                <HeaderStyle BackColor="Black" ForeColor="White" />
                <SelectedRowStyle CssClass="info" BackColor="#CCFF99" />
                <SortedAscendingHeaderStyle BackColor="Black" />
            </asp:GridView>
            <asp:LinqDataSource ID="LinqDataSource3" runat="server" ContextTypeName="Tarea3.DataClasses1DataContext" EnableDelete="True" EnableInsert="True" EnableUpdate="True" EntityTypeName="" TableName="Carreras">
            </asp:LinqDataSource>
         </div>
    </div>
    <div class="row">
        <div class="col-sm-6">
            <h2>Estudiantes de Carrera</h2>
            <div class="form-group">
                <asp:Label ID="Label9" runat="server" Text="Carrera"></asp:Label>
                <asp:DropDownList ID="cbCarrera2" runat="server" CssClass="form-control" AutoPostBack="True" DataSourceID="LinqDataSource2" DataTextField="nombre" DataValueField="id_carrera" OnSelectedIndexChanged="cbCarrera2_SelectedIndexChanged"></asp:DropDownList>
            </div>
            <div class="container">
                <asp:DataGrid ID="spEstudiantesCarrera" runat="server"  CssClass="table">
                    <HeaderStyle BackColor="Black" ForeColor="White" />
                </asp:DataGrid>
            </div>
        </div>
        <div class="col-sm-6">
            <h2>Total de Estudiantes Ingresados a cada Carrera por Año</h2>
            <div class="container">
                <asp:GridView ID="spEstudiantesCarreraAno" runat="server"  CssClass="table">
                    <HeaderStyle BackColor="Black" ForeColor="White" />
                </asp:GridView>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-4">
            <h2>Total de Estudiantes</h2>
            <div class="container">
            <asp:GridView ID="tbTotalEstudiantes" runat="server"  CssClass="table">
                <HeaderStyle BackColor="Black" ForeColor="White" />
            </asp:GridView>
            </div>
        </div>
        <div class="col-sm-4">
            <h2>Total de Estudiantes por Carrera</h2>
            <div class="container">
            <asp:GridView ID="tbTotalEstudiantesCarrera" runat="server"  CssClass="table">
                <HeaderStyle BackColor="Black" ForeColor="White" />
            </asp:GridView>
            </div>
        </div>
        <div class="col-sm-4">
            <h2>Total de Estudiantes por Año</h2>
            <div class="container">
            <asp:GridView ID="tbTotalEstudiantesAno" runat="server"  CssClass="table">
                <HeaderStyle BackColor="Black" ForeColor="White" />
            </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
