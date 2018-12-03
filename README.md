# Software Engineering
### This course explores the design and implementation of large, multi-module-program systems. Topics include the software life cycle, design tools, features and use of module-oriented programming languages, intermodule communication, and eXtreme programming. Students will require significant out-of-class time to complete this course successfully. This course is to be taken in the final year of the BCIS degree. 


### LAB 1 - Unit Testing
    1. Create a method, which takes Fibonacci Numbers (i.e.,  0,1,1,2,3,5,8,13) array as an argument.
    2. Add 1 to each numbers in Fibonacci series ( result; 1,2,2,3,4,6,9,14) and return this results from the method.
    3. Create a test case method to check based on your input array and output array gives the right result.
    Hint: CollectionAssest.AreEqual( ) function/method to test two arrays.
    
### LAB 2 - Unit Testing Continued
    Implement and run test cases to test following string operations:

    String concatenation 
    String comparison
    String copy
    Empty String
    
### LAB 3 - NUnit Test
    Step 1: Create a class for student details named as 'StudentDetails'.
    Step 2: Create get and set methods in 'StudentDetails' class.
    Step 3: Inside your main class 'Program' define the following methods - 

      public string  Login ( );
      public List<StudentDetails> AllUsers():

    Step 4 : Write NUnit test cases for both of the method Login( ) and AllUsers( ).
    Step 5: Run a loop to check whether any of the list member is empty or not.
    Step 6: Check individual content of list and compare the content as well.
   
 ### LAB 4 - MVC using the .NET Framework
        Marked and completed in class.
        
  ### LAB 5 - MVC and MVC Unit Testing. 
        Creating unit tests for the previously built MVC project. 
        
  ### LAB 6 - MVC and MVC Unit Testing Continued
        Create a new MVC project in .NET framework. Add unit test project while creating MVC project that performs several functions.
        1. Create a model of product list containing following attributes: id, name, price
        2. Create a Product list controller where you insert and return those product information as a list containing two methods
        
                - GetProductlist( )
                
                - Actionresult Product ( ) - query all records from Productlist
                
        3. Create associated view to show product list from web front end.
        4. In unit testing MVC project add a Test Method to check whether productlist is null or not.
        
  ### LAB 7 - Download Selenium WebDriver and run first Selenium Test using Firefox browser. 
  
     Steps involved:

        1) Create a c# console project (.Net framework).
        2) Go to Tools >> Nuget Package Manager >> Manage Nuget Packages for Solution
        3) In the Seach Box, search for Selenium.WebDriver or Selenium and Install it.
        
        4) Add following directives –
            using OpenQA.Selenium;
            using OpenQA.Selenium.Firefox;
            
        5) Add following statements inside Main( ) methodIWebDriver
            driver = new FirefoxDriver();
            driver.Url = "http://google.ca";
            
        6) If you encountered by an exception for “geckodriver.dll” – then get
            geckodriver.exe from following repository and add it in project\bin\debug
            directory – https://github.com/mozilla/geckodriver/releases
            
  ### LAB 8 - Selenium Testing with Chrome
  Web Navigation and Form submission using Selenium WebDriver.

    Steps involved:
        1)     Create a c# console project (.Net framework).
        2)     Go to Tools >> Nuget Package Manager >> Manage Nuget Packages for Solution
        3)     In the Seach Box, search for Selenium.WebDriver and Selenium.Chrome.WebDriver  and Install it.
        4)     Add appropriate directives by defining “using” keywords for Selenium Web Driver.
        5)     Open Brower and go to http://blog.testproject.io/
        6)     Navigate to https://blog.testproject.io/contact-us/
        7)     Using driver.FindElement( ) method,  fill up the first three field of the form, i.e., Name, Email and Subject
        8)     Try to Submit the form by clicking the ‘Send’ button.
        
  ### LAB 9 - Selenium Testing with Chrome
  Write Selenium Test cases using NUnit Framework.

Steps involved:

    1)      Add a new class library (.NET framework) into the solution
    2)      Go to References >> Manage Nuget Packages… from the Solution Explorer window from the right side.
    3)      Install all the required driver to NUnit test cases under Selenium environment. 
    4)      Inside the class create 3 methods and add NUnit Test Annotations as –
    
        [SetUp]  // Start a chrome Browser : Initialize
        [Test]  // Open https://blog.testproject.io Website in the browser started by Selenium and    
                //perform all the steps mentioned in task1
        [TearDown] // Close the Browser : EndTest

    5)      Run the test and observe the result.
