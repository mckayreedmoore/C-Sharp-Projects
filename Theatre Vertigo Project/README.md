<h1> Theatre Vertigo Project </h1>

<h3>Technologies Used </h3>
<p> In this project I utilized C# in the .NET framework. Entity was used for the object-relational mapping framework over ADO.NET. Vanilla CSS was used to style the project.</p>

<h3> Project Summary </h3>
<p>In this project I created the CRUD pages for rentals of a performing arts company. This included creation of an entity object, structuring and styling CRUD pages, and creating and implementing a byte array conversion method that allows for storage and retreival of photos within the database. Additionally, I created a helper method for truncating strings to allow for toggleable string elements on the front-end. </p>

<h3> Coding Snippets </h3>

<h4> 1 - Front-End - Index Page </h4>
<p> This is a snip of the index page. It displays all the rental photo objects within the database. In adition it demonstrates the byte array conversion method for storing, and then reverting images to allow for display to the web page. If no photo is uploaded upon object creation, a default image is assigned as shown by the first entry. </p>

<h4> 2 - Front-End - Create Page </h4>
<p> This page allows users to add new Rental Photos into the database. Input fields include the Title, image upload, status of the photo (damaged/in good condition), and details about the photo. </p>

<h4> 3 - Code of Model </h4>
<p>This shows the code for the model that was used during this project. </p>

<h4> 4 - Create Page Form Posting adjustment </h4>
<p> The top section allows for the form to be able to post with HttpPostedFileBase which will then be converted into a byte array before database storage </p>

<h4> 5 - Method that converts the HttpPostedFileBase into the byteArray before storage in the database. </h4>

<h4> 6 - Retrieval of Byte Array and Conversion into image (base64) format for display on the index page </h4>

<h4> 7 - String Truncating Helper Method </h4>
<p> This is a method that allows for string to be truncated. It accepts a parameter of how many characters to include in the truncated string, and the string itself. After truncating the string to the specified amount, the method concatenates an elipses. </p>


