<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/HonestBobs.Master" AutoEventWireup="true" Inherits="HonestBobs.Website.bookDetails" CodeBehind="bookDetails.aspx.cs" %>

<asp:Content ID="cBody" ContentPlaceHolderID="cphBody" runat="server">

    <section>
        <div>
            <hgroup>
                <h2><%: Page.Title %></h2>
            </hgroup>


            <asp:FormView ID="bookDetail" runat="server" ItemType="HonestBobs.Website.Dal.Book" SelectMethod ="GetBooks" RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h2><%#:Item.BookName %></h2>
            </div>
            <br />
            <table>
                <tr>
                       
                    <td style="vertical-align: top; text-align:left;">
                
                        <b>Author:</b><br /><%#:Item.Author %>
                        <br />
                        <b>Description:</b><br /><%#:Item.BookDescription %>
                        <br />
                        <span><b>Price:</b>&nbsp;<%#: String.Format("{0:c}", Item.BookPrice) %></span>
                        <br />
                        <span><b>ISBN:</b>&nbsp;<%#:Item.ISBN %></span>
                        <br />
                        <span><b>Pages:</b>&nbsp;<%#:Item.PageCount %></span>
                        <br />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>

        </div>
    </section>
</asp:Content>

