# MVC_project
Table in SQL database is created, name Users.
MVC project was opened. 
I made connection between database and project with Entity framework, table first aproach.
Not all table rows are visible in Index view. 
I opened new class file for userValidation, I aded validation to Name=>StringLenght, Required, RegularExpression, Display(Name); Gender=>NullDisplayText; PhoneNumber=> Required, Display(Name), DataType; Address=> Display(Name); Email=> DataType; WebSite=> DataType, UIHint, Display(Name), NullDisplayText; Age=> Range;        
I aded two more columns in database, for Photo and AltText than saved changes, made refresh in  model. Folder for photos i made and I aded some photo to it. On Create action is posible to add photo with <browse>. I made partial view for details, everything is partial view, I tested just to see how it works.
I have made some custom error pages.
I made all @Html.ActionLink <button>............aded bootstrap class like new {@class="btn btn-"}
I made default route to my project in route.config.cs
I have changed default favicon for all pages.
I added paging, it shows 5 rows from database in one page.  
I added upload method for user Image, it' is shown in Details view, and path is saved in database, uploaded image is saved in ~/Photo/UserImg/ folder.  
