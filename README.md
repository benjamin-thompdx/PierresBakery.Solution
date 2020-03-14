# _Pierre's Bakery | Vendor and Order Tracker_

#### _A C# MVC application to track vendors and their unique orders._, _Mar. 13, 2020_

#### By _**Benjamin Thom**_

## Description

_MVC application to track vendor purchases and their orders for Pierre's Bakery._

## Project Specifications

| Behavior | Input | Output |
|---|:---:|:---:|
|Homepage displays a welcome message and links to "View vendors" and "Add a new Vendor"|User enters the following url into their search browser: localhost:5000/|A splash page is displayed "Welcome Back, Pierre!"|
|The user clicks on the "Add a new Vendor" link and is provided with a form they can fill out to create a new Vendor|User clicks Vendor page link|Vendors page displays a New Vendor form|
|User fills out New Vendor form, clicks submit, and user is routed to Vendors page |New Vendor form inputs: "Vendor Name", "Vendor Description"|User is routed to Vendors page|
|From the Vendors page, the user can click on the vendor's name they just created for more details, the "Clear All Vendors" button, or the "Return to homepage" link|User clicks link to vendor's name|The user is routed to the specified Vendor Details page|
|User can then click one of the following links: "Add a new order", "Return to vendor list", or "Return to homepage"|User clicks on "Add a new order"|User is provided with an order form for the specified vendor with the following inputs: "Order Title", Order Description", "Order Price", and "Order Date", and a button to "Add Order"|
|User clicks on "Add Order" button and is routed to an Orders page for the specified vendor. The user can then click on the newly created order name to review order details, or one of the other following links: "Add a new order", "Return to vendor list", or "Return to homepage" |User clicks on the newly created order name|Useris provided with an order review with the following details: "Vendor", "Vendor Description", "Order", "Order Description", "Order Price", and "Order Date" along with the following links: "Add another order" and "Return to vendor list"|
|User clicks on "Return to vendor list" and is routed back to the Vendors page. User can now click on a vendor's name to view/add orders, the "Clear All Vendors" button, or the link to "Return to homepage"|User clicks the "Clear All Vendors" button|User is routed to a success page with a display stating, "Your vendor list has been cleared!" and is given the option to click a link to ""Return to vendor list"|
|User clicks on "Return to vendor list" and is provided with a message stating, "No vendors have been added yet!", a button to "Clear All Vendors", and a link to "Return to homepage"|User clicks the "Return to homepage" link|User is provided with a "Welcome Back, Pierre!" message|

## Setup/Installation Requirements

_In Terminal:_

* Navigate to where you want this application to be saved, i.e.:
```cd desktop```
* Clone the file from GitHub with HTTPS
```git clone https://github.com/benjamin-thompdx/PierresBakery.Solution.git```
* Open file in your preferred text editor
* On Mac: ```open -a {your text editor} PierresBakery.Solution```
* On Windows: ```PierresBakery.Solution```

_Download Manually:_

* Navigate to https://github.com/benjamin-thompdx/PierresBakery.Solution.
* Click the green "Clone or Download" button.
* Click "Download ZIP".
* Click downloaded file to unzip.
* Open folder called "PierresBakery.Solution".

_Note For Editors:_ 
* Download the .NET Core SDK [Software Development Kit](https://dotnet.microsoft.com/download)
* Open the .Net Core SDK file and install
* To confirm installation was successful, run the ```$ dotnet --version``` command in your terminal

* Install dotnet script, run the ```$ dotnet tool install -g dotnet-script``` command in your terminal
* Restart your terminal to complete installation, and run the ```$ dotnet run``` command to run application within your terminal - Note: To exit, simply press ```Ctrl + C```

## Known Bugs

_No known bugs at this time._

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/benjamin-thompdx/PierresBakery.Solution/issues) here on GitHub._

## Technologies Used
* _Git_
* _C#_
* _.NET Core 2.2_
* _dotnet script_
* _VS Code_
* MVC framework
* CRUD functionality

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Benjamin Thom_**