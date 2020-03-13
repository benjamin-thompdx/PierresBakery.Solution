# _Pierre's Bakery | Vendor and Order Tracker_

#### _A C# MVC application to track vendors and their unique orders._, _Mar. 13, 2020_

#### By _**Benjamin Thom**_

## Description

_MVC application to track vendor purchases and their orders for Pierre's Bakery._

## Project Specifications

| Behavior | Input | Output |
|---|:---:|:---:|
|Homepage displays a welcome message and a link to a Vendor page.|User enters the following url into their search browser: localhost:5000/|A splash page is displayed welcoming the user (Pierre) and provides them with a link to a Vendor page|
|The user clicks on the Vendor page link and is provided with a form they can fill out to create a new Vendor|User clicks Vendor page link|Vendors page displays a New Vendor form|
|User fills out New Vendor form, clicks submit, and user is routed back to the homepage|New Vendor form inputs: "Vendor Name", "Vendor Description"|User is routed back to homepage "Welcome back Piere!"|
|From the homepage the user can click on the Vendor page again and now they will be able to view a list of vendors with based off their previous inputs|User clicks link to Vendor page|Vendor page displays a list of vendors|
|User can then click on a vendor's name and be routed to a Vendor's Orders page that displays all the specific vendor's orders and a link to add New Order|User clicks on vendor name|Vendor's orders "Order 1: 'Title', 'Description', 'Price', and 'Date'", and a link to add a New Order|
|User clicks on New Order link, and fills out New Order form, clicks submit, and user is routed back to the homepage | New Order form inputs: "Title", "Description", "Price", and "Date"|User is routed back to homepage "Welcome back Piere!"|

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