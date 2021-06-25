<%@ Page Title="" Language="C#" MasterPageFile="~/MasterJuego.Master" AutoEventWireup="true" CodeBehind="ListadoPuntos.aspx.cs" Inherits="AquaticPrix.ListadoPuntos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container-fluid">
<%--        <h1 class="well">Empleados Activos</h1>--%>
        <div class="well well-sm">
            <div class="row">
                <div class="col-md-12" style="width: 100%; height: 600px; overflow: scroll">
<%--                    <div class="col-md-12">
                        <asp:GridView ID="grvListadoGeneral" runat="server" CssClass="table table-hover table-striped" GridLines="None"
                            AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundField DataField="IdEmpleado" HeaderText="#" >
                                <HeaderStyle CssClass="hide" />
                                <ItemStyle CssClass="hide" />
                                </asp:BoundField>
                                <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                                <asp:BoundField DataField="apellido" HeaderText="Apellido" />
                                <asp:BoundField DataField="idTipoDocumento" HeaderText="idTipoDocumento" Visible="False" />
                                <asp:BoundField DataField="tipDocDescrip" HeaderText="Tipo Doc" />
                                <asp:BoundField DataField="nroDocumento" HeaderText="Nro. Doc" />
                                <asp:BoundField DataField="idSexo" HeaderText="idSexo" Visible="False" />
                                <asp:BoundField DataField="sexoDescrip" HeaderText="Sexo" />
                                <asp:BoundField DataField="fechaNacimiento" HeaderText="Fecha Nacimiento" />
                                <asp:BoundField DataField="direccion" HeaderText="Dirección" />
                                <asp:BoundField DataField="direccionNro" HeaderText="Nro." />
                                <asp:BoundField DataField="codigoPostal" HeaderText="Cod. Postal" />
                                <asp:BoundField DataField="idPais" HeaderText="idPais" Visible="False" />
                                <asp:BoundField DataField="paisDescrip" HeaderText="Nacionalidad" />
                                <asp:BoundField DataField="idEstado" HeaderText="idEstado" Visible="False" />
                                <asp:BoundField DataField="estadoDescrip" HeaderText="Estado" />
                                <asp:BoundField DataField="idTipoRol" HeaderText="idTipoRol" Visible="False" />
                                <asp:BoundField DataField="rolDescrip" HeaderText="Perfil" />
                                <asp:BoundField DataField="fechaAlta" HeaderText="Fecha Alta" />

                                <asp:TemplateField HeaderText="">
                                    <ItemTemplate>
                                        <button runat="server" id="btnRun" class="btn btn-info" title="Search" onclick="llamarJson(this);return false">
                                            <span class="glyphicon glyphicon-search"></span>
                                        </button>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>


                    </div>--%>
                </div>


            </div>

        </div>


        <!-- Modal Advertencia-->
        <div id="modalAdvertencia" class="modal fade" data-backdrop="static">
            <div class="modal-dialog modal-lg modal-dialog-centered">
                <div class="modal-content ">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">
                        </button>
                        <h4 class="modal-title" id="h4TituloMensaje">Búsqueda</h4>
                    </div>
                    <div class="modal-body">
                        <div class="col-md-12">

                            <div class="row">
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <label for="subject">
                                            Nombre</label>
                                        <input type="text" id="txtNombre" class="form-control" required="required"
                                            placeholder="Nombre" readonly="true" style="background-color: #F3F2D7" />
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <label for="subject">
                                            Apellido</label>
                                        <input type="text" id="txtApellido" class="form-control" required="required"
                                            placeholder="Apellido" readonly="true" style="background-color: #F3F2D7" />
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <label for="subject">
                                            Sexo</label>
                                        <input type="text" id="txtSexo" class="form-control" required="required"
                                            placeholder="Apellido" readonly="true" style="background-color: #F3F2D7" />
                                    </div>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <label for="subject">
                                            Tipo Doc</label>
                                        <input type="text" runat="server" id="txtTipoDocumento" class="form-control" required="required"
                                            placeholder="Nombre" readonly="true" style="background-color: #F3F2D7" />
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <label for="subject">
                                            Nro</label>
                                        <input type="text" runat="server" id="txtNroDoc" class="form-control" required="required"
                                            placeholder="Apellido" readonly="true" style="background-color: #F3F2D7" />
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <label for="subject">
                                            Perfil</label>
                                        <input type="text" runat="server" id="txtPerfil" class="form-control" required="required"
                                            placeholder="Apellido" readonly="true" style="background-color: #F3F2D7" />
                                    </div>
                                </div>
                            </div>

                            <h5 class="modal-title" id="h5TituloTelefono">Teléfono</h5>
                            <div class="row">
                                <div class="col-md-12" style="width: 100%; height: 150px; overflow: scroll">
                                    <table id="tableTelefono" class="table table-dark">
                                        <thead>
                                            <tr>
                                                <th scope="col" class="hide">#</th>
                                                <th scope="col">Tipo</th>
                                                <th scope="col">Nro.</th>
                                            </tr>
                                        </thead>
                                        <tbody id="tbodyTelefo"></tbody>
                                    </table>
                                </div>
                            </div>

                            <h5 class="modal-title" id="h5TituloMail">Correo Electrónico</h5>

                            <div class="row">
                                <div class="col-md-12" style="width: 100%; height: 150px; overflow: scroll">
                                    <table id="tableCorreo" class="table table-dark">
                                        <thead>
                                            <tr>
                                                <th scope="col" class="hide">#</th>
                                                <th scope="col">Mail</th>
                                            </tr>
                                        </thead>
                                        <tbody id="tbodyCorreo"></tbody>
                                    </table>
                                </div>
                            </div>

                        </div>
                        <div class="tab-content">
                            <div class="row">
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" id="btnAdvertencia" class="btn btn-primary" data-dismiss="modal">
                            Aceptar</button>
                    </div>
                </div>
            </div>
        </div>

    </div>
</asp:Content>
