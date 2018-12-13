<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Produits.aspx.cs" Inherits="WebApplication4.Produits" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
             <asp:GridView ID="product" runat="server"></asp:GridView>
        </div>
</asp:Content>