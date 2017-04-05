<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/HonestBobs.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="HonestBobs.Website._default" %>

<asp:Content ID="cBody" ContentPlaceHolderID="cphBody" runat="server">
    
     
        <div id="CategoryMenu" style="text-align: center">       
            <asp:ListView ID="categoryList"  
                ItemType="HonestBobs.Website.Dal.Category" 
                runat="server"
                SelectMethod="GetCategories" >
                <ItemTemplate>
                    <b style="font-size: large; font-style: normal">
                        <a href="/<%#: Item.CategoryName %>.aspx?id=<%#: Item.CategoryID %>">
                        <%#: Item.CategoryName %>
                        </a>
                    </b>
                </ItemTemplate>
                <ItemSeparatorTemplate>  |  </ItemSeparatorTemplate>
            </asp:ListView>
        </div>
    
</asp:Content>
 