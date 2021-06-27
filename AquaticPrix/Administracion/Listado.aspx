<%@ Page Title="" Language="C#" MasterPageFile="~/MasterJuego.Master" AutoEventWireup="true" CodeBehind="Listado.aspx.cs" Inherits="AquaticPrix.Administracion.Listado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="well well-sm">
            <div class="row">
                <div class="col-md-12" style="width: 100%; height: 600px; overflow: scroll">
                    <div class="col-md-12">
                        <asp:GridView ID="grvListadoGeneral" runat="server" CssClass="table table-hover table-striped" GridLines="None"
                            AutoGenerateColumns="False">
                            <Columns>
<%--                                <asp:BoundField DataField="IdEmpleado" HeaderText="#">
                                    <HeaderStyle CssClass="hide" />
                                    <ItemStyle CssClass="hide" />
                                </asp:BoundField>--%>
                                <asp:BoundField DataField="id" HeaderText="idTipoDocumento" Visible="False" />
                                <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                                <asp:BoundField DataField="apellido" HeaderText="Apellido" />
                                <asp:BoundField DataField="correoElectronico" HeaderText="Correo Electronico" />
                                <asp:BoundField DataField="fechaNacimiento" HeaderText="Fecha Nacimiento" />
                                <asp:BoundField DataField="idUsuario" HeaderText="idUsuario" Visible="False" />
                                <asp:BoundField DataField="nombreUsuario" HeaderText="Usuario" />
                                <asp:BoundField DataField="estado" HeaderText="Estado" />

<%--                                <asp:TemplateField HeaderText="">
                                    <ItemTemplate>
                                        <button runat="server" id="btnRun" class="btn btn-info" title="Search" onclick="llamarJson(this);return false">
                                            <span class="glyphicon glyphicon-search"></span>
                                        </button>
                                    </ItemTemplate>
                                </asp:TemplateField>--%>
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
