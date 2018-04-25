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
                    <asp:Image ID="foto" runat="server"/>
                </div>
                <asp:FileUpload ID="img" runat="server"  CssClass="form-control" onchange="onImg_upload"/>
            </div>
            <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="Curriculum"></asp:Label>
                <asp:FileUpload ID="curriculum" runat="server" CssClass="form-control" />
            </div>
             <div class="form-group">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-success" OnClick="btnSubmit_Click" />
            </div>
         </div>
         <div class="col-sm-6">
            <h2>Formulario de Carrera</h2>
            <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="Codigo De Carrera"></asp:Label>
                <asp:TextBox ID="txtNombreCarrera" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label6" runat="server" Text="Encargado"></asp:Label>
                <asp:TextBox ID="txtEncargado" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label7" runat="server" Text="Ubicacion"></asp:Label>
                <asp:TextBox ID="TextUbicacion" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
             <div class="form-group">
                <asp:Button ID="btnSubmitCarrera" runat="server" Text="Submit" CssClass="btn btn-success" OnClick="btnSubmit_Click" />
            </div>
         </div>
    </div>
    <div class="row">
        <div class="col-sm-6">
            <asp:GridView ID="tbEstudiantes" runat="server" AutoGenerateColumns="False" DataKeyNames="cedula" DataSourceID="LinqDataSource1" CssClass="table" OnSelectedIndexChanged="tbEstudiantes_SelectedIndexChanged" >
                <Columns >
                    <asp:BoundField DataField="cedula" HeaderText="Cedula" ReadOnly="True" SortExpression="cedula" />
                    <asp:BoundField DataField="carnet" HeaderText="Carnet" SortExpression="carnet" />
                    <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre" />
                    <asp:BoundField DataField="id_carrera" HeaderText="Id Carrera" SortExpression="id_carrera" NullDisplayText="Null" />
                    <asp:BoundField DataField="fecha_ingreso" HeaderText="Fecha de Ingreso" SortExpression="fecha_ingreso" DataFormatString="{0:dd/MM/yy} " />
                    <asp:CommandField ShowDeleteButton="True" ShowSelectButton="True" />
                </Columns>
                <HeaderStyle BackColor="Black" ForeColor="White" />
                <SelectedRowStyle CssClass="info" BackColor="#CCFF99" />
                <SortedAscendingHeaderStyle BackColor="Black" />
            </asp:GridView>
            <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="Tarea3.DataClasses1DataContext" EntityTypeName="" TableName="Estudiantes" EnableDelete="True" EnableInsert="True" EnableUpdate="True">
            </asp:LinqDataSource>
        </div>
        <div class="col-sm-6">

            <asp:GridView ID="tbCarrera" runat="server" AutoGenerateColumns="False" DataSourceID="LinqDataSource3" CssClass="table" OnSelectedIndexChanged="tbCarrera_SelectedIndexChanged" >
                <Columns >
                    
                    <asp:BoundField DataField="id_carrera" HeaderText="Codigo de Carrera" ReadOnly="True" SortExpression="id_carrera" />
                    <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre" ReadOnly="True" />
                    <asp:BoundField DataField="encargado" HeaderText="Encargado" SortExpression="encargado" ReadOnly="True" />
                    <asp:BoundField DataField="ubicacion" HeaderText="Ubicacion" SortExpression="ubicacion" ReadOnly="True" />
                    <asp:CommandField ShowDeleteButton="True" ShowSelectButton="True" />
                </Columns>
                <HeaderStyle BackColor="Black" ForeColor="White" />
                <SelectedRowStyle CssClass="info" BackColor="#CCFF99" />
                <SortedAscendingHeaderStyle BackColor="Black" />
            </asp:GridView>
            <asp:LinqDataSource ID="LinqDataSource3" runat="server" ContextTypeName="Tarea3.DataClasses1DataContext" EnableDelete="True" EnableInsert="True" EnableUpdate="True" EntityTypeName="" OrderBy="nombre" Select="new (id_carrera, nombre, encargado, ubicacion)" TableName="Carreras">
            </asp:LinqDataSource>

        </div>
    </div>

</asp:Content>
