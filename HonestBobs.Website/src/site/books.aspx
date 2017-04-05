<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/HonestBobs.Master" AutoEventWireup="true" Inherits="HonestBobs.Website.books" CodeBehind="books.aspx.cs" %>

<asp:Content ID="cBody" ContentPlaceHolderID="cphBody" runat="server">

    <section>
        <div>
            <hgroup>
                <h2><%: Page.Title %></h2>
            </hgroup>


            <asp:ListView ID="lvCustomers" runat="server" GroupPlaceholderID="groupPlaceHolder1"
                DataKeyNames="BookID" ItemType="HonestBobs.Website.Dal.Book" SelectMethod="GetBooks"
                ItemPlaceholderID="itemPlaceHolder1">
                <LayoutTemplate>
                    <table cellpadding="4" cellspacing="4">
                        <tr>
                            <th>Book
                            </th>
                            <th>Author
                            </th>
                            <th>Price
                            </th>
                            <th></th>
                        </tr>
                        <asp:PlaceHolder runat="server" ID="groupPlaceHolder1"></asp:PlaceHolder>

                    </table>
                </LayoutTemplate>
                <GroupTemplate>
                    <tr>
                        <asp:PlaceHolder runat="server" ID="itemPlaceHolder1"></asp:PlaceHolder>
                    </tr>
                </GroupTemplate>
                <ItemTemplate>
                    <td>
                        <a href="BookDetails.aspx?BookID=<%#:Item.BookID%>">
                            <span>
                                <%#:Item.BookName%>
                            </span>
                        </a>
                    </td>
                    <td>
                        <%#:Item.Author%>
                    </td>
                    <td>
                        <%#:Item.Author%>
                    </td>
                    <td>
                        <a href="/Basket.aspx?productID=<%#:Item.BookID %>&CategoryId=<%#:Item.CategoryID %>">
                            <b>Add To Basket<b>                
                        </a>
                    </td>
                </ItemTemplate>
            </asp:ListView>

        </div>
    </section>
</asp:Content>

