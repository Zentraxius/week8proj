# Pierre's MVC

#### An application to let a user check order cost, 7/24/20

#### By Cody Fritz

## Specification
1. Application is built in MVC format
2. Application supports and uses Razor functionality
3. Application has a Vendor class, with support for the Vendor's name, a description of the vendor, and a list of orders belonging to the vendor.
4. Application has an Order class, with support for Title, Description, the price, and date of the Order.
5. Homepage of the application should be located at localhost:5000/ and should be a Splash Page, this page must welcome Pierre and contain a link to the Vendors page.
6. The vendors page must contain a link to a page that Pierre may fill out to create a new Vendor.
7. When the form to submit a new vendor is created, it should be saved to a static list and then reroute Pierre back to the homepage/splash page.
8. When clicking on a Vendor, a page should display with that Vendor's orders.
9. A link must be provided to a page that allows Pierre to fill out a form to create a new order for a Vendor, eg /vendors/1/orders/new



## Installation

1.  Download a web browser, such as Apple Safari, Brave, Google Chrome, Microsoft Edge, Mozilla Firefox, or Yandex.
2.  Navigate to [repository]. ( https://github.com/Zentraxius/week8proj this one! )
3.  Click the green "Clone or download" button at the right of the screen.
4.  Select "Download ZIP."
5.  Use a file extractor or unzip program (such as PeaZip, Unzipper, WinZip, Zipware, or 7-ZIP) to extract the ZIP files onto your computer.
6.  Open the directory containing the extracted files.
7.  Open your computer's terminal and navigate to the directory bearing the name of the program and containing the top level subdirectories and files.
8.  Run dotnet restore to generate the backend files
    8a. (Note: Ensure you are in proper directory, for example if you are in Desktop/PierresMVC.Solution, you would need to either move into Desktop/PierresMVC.Solution/PierresWebsite.Tests or run dotnet restore PierresWebsite.Tests)
9.  Run dotnet test on PierresWebsite.Tests to initiate the test, either by being in the PierresWebsite.Tests directory, or running "dotnet test PierresWebsite.Tests" without quotations from the PierresWebsite.Solutions directory
10. Run dotnet run from PierresMVC.Solutions to run program as a whole.

## Known Bugs

When user orders an amount of bread &/ pastries where they are able to get an additional bread/pastry at the same price, no notice is given. This is not a bug, it is a feature.

## Support and contact details

For support please contact clanalia55@gmail.com

### Programming Languages & Libraries

C# / .netframework / VSC
Microsoft.net.SDK

### Operating Systems & Programs

- Git Bash
- Google Chrome(devtools)
- Microsoft Windows 10

### License

MIT

Copyright (c) 2020 **Cody Fritz**
