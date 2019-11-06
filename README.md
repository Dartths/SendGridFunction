# SendGridFunction
A Http Triggered Azure Function that will send emails via sendgrid.

#SetUp Instructions

##Prequisites: Azure Portal Account (Free)

1. Sign into your Azure Account.
2. INavigate to the Send Grid Accounts resource
3. Create a new Sendgrid account (Make sure to select free for subscription options)(If you already have one created you can skip this step)
4. Once the resource is created, enter it and click manage.
5. Navigate to ApiKeys section on left menu and create a new ApiKey. 
6. Copy this Api Key somewhere for use later.
7. In the azure portal, navigate to the Azure Functions section.
8. Add a new Azure function with a .Net core runtime. Click create, this may take a few moments to complete.
9. Once the function is created, enter it and go to the configuration menu.
10. Add new application Setting 
          Name : SendGridKey
          Value : Use the api key from earlier
    Make sure to save.
11. Navigate back to the function, click the + sign next to functions to add a new function.
12. Select in portal and HttpTrigger, and name appropriately.
13. Verify your function has been created. It can be run now and will write to a log in browser.
14. Replace the function code with what is in the run.csx file in the repo.
15. Replace function.json contents also, changing the to email address to your own.
