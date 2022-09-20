<%@ Page Title="" Language="C#" MasterPageFile="~/gridview-one.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="gridview_one._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="row">
        <div class="col">
            <asp:GridView runat="server" CssClass="table" AutoGenerateColumns="false" ID="dgvauto">
        <Columns>   
            <asp:BoundField HeaderText="Modelo" DataField="Modelo" />
            <asp:BoundField HeaderText="Color" DataField="Color" />
            <asp:CheckBoxField HeaderText="Usado" DataField="Usado" />
            <asp:CheckBoxField HeaderText="Importado" DataField="Importado" />
        </Columns>

    </asp:GridView>

            <a href="Autoform.aspx">Agregar</a>

        </div>
    </div>        

</asp:Content>
