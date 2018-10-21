Description: Web application using MVC and WebApi

Detail of the application:
1. TDD methodology:  Here I used the TDD methodology with MSTest. So I created the interface "IStringGenerator" and custom mock class "MockStringGenerator" to write the test cases and to achieve my target due to time shortage. In the future, we can use a mock framework instead of a custom mock class. There are many mock frameworks but my favorite one is moq and it is best for database connectivity too.

Note: I did not write any logic in the controller so test cases for the controller are not there.

2. Dependency injection : I implemented this technique with StructureMap as it is handy for me. The registry of the dependency is done in the "Global.asax" file.

3. Consume the WebService: Used AJAX and Jquery.

4. A solution is seprated into three layers: 
a. Presentation layer
b. Business logic layer
c. and Business logic test layer

5. For executing the solution, simply open the solution file and press F5 from Visual Studio.