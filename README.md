# Xamarin.UITest Page Objects
## Xamarin Studio Addin

This is an addin for Xamarin Studio that adds new file templates supporting the Page Object Pattern (POP) of test development.

With these templates, you can greatly simplify your tests to a fluent API that reads very naturally, instead of a bunch of loosely affiliated queries. The queries and actions are hidden into each page object class.

```
app.LoginPage()
   .LogIn("testUser", "testPassword")
   .GoToHomeScreen()
   .ViewOrders()
   .SelectFirstOrder()
   .VerifyOrderDetails();
```

## Usage
Install the mpack via the Xamarin Studio addin manager (Install from File). 

To start, in a brand new UITest project, right-click on your project and choose **Add > New File**. Choose UITest Helpers as the category. 

UITest Page Objects with Setup is a file template that adds all the requisite classes for the page object infrastructure, as well as a new page object with a name of your choosing. Choose this for the first page object you add.

UITest Page Object simply creates a new page object. 

## Traits
These templates offer an optional concept called **traits**. *to be continued*


