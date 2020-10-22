# PairProgramming
 Remote pair programming, using Live Share

https://prod.liveshare.vsengsaas.visualstudio.com/join?61F0ADD257724C3D29F0B82C36A97149E78F

# Exercise: REST + TypeScript from user stories

In this exercise you must act as a full stack developer:

- You make the back-end: REST, CORS, and publish to Azure
- You make the front-end: HTML, CSS (including Bootstrap) and TypeScript

## Testing

1. The REST controller(s) must be unit tested using MSTest
2. The REST controller(s) must be integration tested using Postman
3. The front-end must be UI tested using MSTest with Selenium.

## The case

DR (Danmarks Radio) has a huge collection of music records. They want to make a web application to administrate the collection.

A music record has attributes like *title*, artist, *duration*, *yearOfPublication* and more …
Duration is the of number seconds (a simple *int*)

## User stories

The exercise is defined through a number of user stories. You must implement back-end + front-end for each user story **in turn**. Implement back-end + front-end + test for the first user story **before** moving to the next story.



1. As a user I want to be able to see all music records.
2. As a user I want to be able to search for music records by title, artist etc.
3. As a user I want to be able to add another music record
4. As a user I want to be able to delete a music record
5. As a user I want to be able to change data about a music record



For *each* user story in **turn** you must:

1. Make a single REST method (Visual Studio)
   Projecttype: ASP.NET core
   The model class should be included in the project (no DLL needed).
   The model class should have *no* constraints, only very simple properties with get + set.
2. Try the REST method in a browser or Postman
3. Unit test the REST method with MS Test (Visual Studio)
4. Integration test the REST method with [Postman](https://www.google.com/url?q=https://www.postman.com/automated-testing&sa=D&ust=1603103140224000&usg=AOvVaw2AHxiAc5LZBzSpXtBVXAT-) (check the snippets)
   Postman Learning Center: [Test Scripts](https://www.google.com/url?q=https://learning.postman.com/docs/postman/scripts/test-scripts/&sa=D&ust=1603103140224000&usg=AOvVaw3gBrYyhuSvuIe1HBc7X_fp)
5. Generate Swagger based documentation for the REST service.
6. Publish the REST service to Azure
   If you cannot publish to Azure, then run the REST service on localhost
7. Try the REST method from Azure in a browser or Postman.
8. Add a little HTML + Typescript to the web application.
   Communicate with the REST service method using Axios.
9. UI test the web application with MS Test (Visual Studio) + Selenium.
10. Publish the web application to Azure. [Help](https://www.google.com/url?q=https://docs.google.com/document/d/e/2PACX-1vQcX6jztzCNmj-I746tKZpEKZqtUOjMHn04RTyvgDlyqj5tH5z3nwbbuXpxkeMfd3-Lvb_tu2CQKiOc/pub&sa=D&ust=1603103140225000&usg=AOvVaw0fbfQVn2ivHjVLBOgNnMWW)!

## Extra: Tracks

Each music record has a number of tracks.

The application must register tracks as well as records.

## Extra: Artists

We should like to keep information about artists ...
