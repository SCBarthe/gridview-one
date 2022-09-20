<%@ Page Title="" Language="C#" MasterPageFile="~/gridview-one.Master" AutoEventWireup="true" CodeBehind="Autoform.aspx.cs" Inherits="gridview_one.Autoform" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <label for="txtid" class="form-label">ID</label>
                <asp:TextBox runat="server" ID="txtid" CssClass="form-control" />

            </div>
            <div class="mb-3">
                <label for="txtmodelo" class="form-label">Modelo</label>
                <asp:TextBox runat="server"  ID="txtmodelo" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtDescripcion" class="form-label">Descripcion</label>
                <asp:TextBox runat="server" TextMode="MultiLine" ID="txtdescripcion"  CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtDescripcion" class="form-label">Colores</label>
                <asp:DropDownList runat="server" Cssclass="form-select"  ID="ddlcolores"  />
            </div>
            <div class="mb-3">
                <label for="txtfecha" class="form-label">Fecha</label>
                <asp:TextBox runat="server" TextMode="Date" ID="Txtfecha"  CssClass="form-control" />
            </div>

            



        </div>
    </div>
</asp:Content>
