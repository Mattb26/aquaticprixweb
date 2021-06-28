<%@ Page Title="" Language="C#" MasterPageFile="~/MasterJuego.Master" AutoEventWireup="true" CodeBehind="ListadoGeneral.aspx.cs" Inherits="AquaticPrix.Usuario.ListadoGeneral" %>

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

                                <%--<asp:BoundField DataField="id" HeaderText="idTipoDocumento" Visible="False" />--%>
                                <asp:BoundField DataField="nombreUsuario" HeaderText="Usuario" />
                                <asp:BoundField DataField="posicion" HeaderText="Posición" />
                                <asp:BoundField DataField="perdido" HeaderText="Perdido" />
                                <asp:BoundField DataField="promedioPartidas" HeaderText="Promedio Partidas" />
                                <asp:BoundField DataField="bajas" HeaderText="Bajas"/>
                                <asp:BoundField DataField="promediobaja" HeaderText="Promedio baja" />
                                <asp:BoundField DataField="caidas" HeaderText="Caídas" />
                                <asp:BoundField DataField="promedioCaidas" HeaderText="Promedio Caídas" />
                                <asp:BoundField DataField="fecha" HeaderText="Fecha" />
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
