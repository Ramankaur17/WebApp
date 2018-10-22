Description: Web application using MVC and WebApi

Detail of the application:
1. TDD methodology:  Here I used the TDD methodology with MSTest. So I created the interface "IStringGenerator" and custom mock class "MockStringGenerator" to write the test cases and to achieve my target due to time shortage. In the future, we can use a mock framework instead of a custom mock class. There are many mock frameworks but my favorite one is moq and it is best for mocking database calls.

Note: I created the main logic in business layer which under class "StringGenerator" which is invoked by controller.I created the tests for business layer, which reduced the need to create the tests for controllers as controller method is responsible for calling the business class and dedicating all logical responsibility to it.
Hence, i did not wrte any unit tests cases for controllers.

2. Dependency injection : I implemented this technique with StructureMap as it is handy for me. The registry of the dependency is done in the "Global.asax" file.

3. Consume the WebService: Used AJAX and Jquery.

4. A solution is seprated into three layers: 
a. Presentation layer
b. Business logic layer
c. and Business logic test layer

5. For executing the solution, simply open the solution file and press F5 from Visual Studio.
