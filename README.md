
# Summary
> **Time spent:** 2-3 hrs.
>
>  I have used entity framework with model first approach which will genrate the database on first run. 
>  I have used the local sql db which ships with Visual studio 17
>  The database table structure can be seen within the dal directory.
> 
>  From the homepage the user has the option to select a category.
>
>  Clicking a category (Books) takes the user to the Books.aspx and retrieves a list of books, which then allows the user to click on 1 book to show the detail. 
>  I could have implemented a generic products page instead where I could have refined by CategoryId and displayed the category in a list/grid with basic data such as Name, description and price. Clicking on the product then would navigate to the detail page.
>
>  Ideally Models/db structure would be placed in the Dal directory and I would move the business obejects to a Bal directory - following a n-tier approach.

# Done
> A page listing the types of products Honest Bob’s sells, you can then click through to;
> A page that lists the products of a specific type and shows all their details
# Todo
> Shopping cart
> Movies which will follow a similar pattern to the books structure.



