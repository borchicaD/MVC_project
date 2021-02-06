# MVC_project
Table in SQL database is created, name Users.
MVC project was opened. 
I made connection between database and project with Entity framework, table first aproach.
Not all table rows are visible in Index view. 
I opened new class file for userValidation, i aded validation to Name=>StringLenght, Required, RegularExpression, Display(Name); Gender=>NullDisplayText; DateOfBirth=> DisplayFormat, DataType, Display(Name); PhoneNumber=> Required, Display(Name), DataType; Address=> Display(Name); Email=> DataType; WebSite=> DataType, UIHint, Display(Name), NullDisplayText; Age=> Range;        
I aded two more columns in database, for Photo and AltText than saved changes, made refresh in  model. Folder for photos i made and I aded some photo to it. On Creation is posible to add photo with this route ~/Photo?UserImg/1.jpg(last is user photo). I made partial view for details.
I have made some custom error pages.
I made all @Html.ActionLink <button>............aded bootstrap class like new {@class="btn btn-"}
I made default route to my project in route.config.cs
