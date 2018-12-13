<%@ Page Title="Profile" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="True" CodeBehind="Profile.aspx.cs" Inherits="WebApplication4.Profile" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<div>

    <h2><%: Title %>This is your profile</h2>
    <h3> Welcome  
        <asp:Label ID="Lbl_user" runat="server" Text="____"></asp:Label>
        , please buy lots! 
    </h3>

</div>
<br />
<br />
<br />
<br />
<br />
<br />
<div>
    id du produit :
    <asp:TextBox ID="product_id" runat="server" />  
    <br></br>
    Nom du produit :
    <asp:TextBox ID="product_name" runat="server" />  
    <br></br>
    categorie du produit :
    <asp:TextBox ID="product_category" runat="server" />  
    <br></br>    
    prix du produit :
    <asp:TextBox TextMode="Number" ID="product_price" runat="server" min="-123213123" max="9999999" step="1"/>
    <asp:RangeValidator runat="server" id="rng_price" controltovalidate="product_price" type="Integer" minimumvalue="1" maximumvalue="9999" errormessage="price must be between 1$ and 9999$" />
    <br></br>
    <asp:Button ID="btn_create_product" Text="create product" runat="server" OnClick="btn_create_product_Click" />

</div>     
</asp:Content>
