## Automated Login Test Project for Stifel

This project automates the login process for the Stifel website using Selenium WebDriver and Xunit for testing. The goal is to validate the login functionality by simulating a user interacting with the website.

## Features

Automated navigation to the Stifel website.
Locating and interacting with web elements such as login links, input fields, and buttons.
Waiting for elements to load dynamically using explicit waits.
Flexible test framework using Xunit.
Prerequisites

## To run this project, you need:

.NET Core SDK installed.
A compatible WebDriver (e.g., ChromeDriver for Google Chrome).
Google Chrome or another supported browser installed.

## Setup Instructions

Clone this repository to your local machine.
Install the necessary WebDriver (e.g., ChromeDriver for Chrome).
Place the WebDriver in a directory included in your system's PATH.
Update the test credentials:
Replace "YourLoginID" with a valid Stifel login ID.
Replace "YourPassword" with a valid password.
Build the project:
Run dotnet build in the project directory.
Running the Tests

Navigate to the project directory in the terminal.
Execute the tests using the following command:
dotnet test
Code Workflow

Navigate to the Stifel Homepage:
The test starts by navigating to http://www.stifel.com/.
Locate and Click the Login Link:
The login link is found using its text and clicked to access the login page.
Wait for the Login Page to Load:
Explicit waits ensure the required elements (e.g., user ID field) are fully loaded before interacting.
Fill Out Login Form:
Input fields for user_id and password are located and populated with the test credentials.
Submit the Form:
The form is submitted by clicking the submit button.
Verification:
The script can include assertions to verify a successful login (e.g., checking the page title or a confirmation element).

## Challenges and Notes

Password Auto-fill Issue:
A logic error was identified where the password auto-fill was skipped. Potential solutions from Stack Overflow were tested.
Dynamic Loading:
Explicit waits are used to handle dynamic page loading and ensure reliable interactions.
Customization:
The Assert statements and wait conditions can be customized based on the behavior of the Stifel website after login.

## Resources

Selenium Documentation
Xunit Documentation

## Disclaimer

This project is for testing and learning purposes only. Replace test credentials with valid information in a secure manner when running the tests. Ensure you comply with Stifel's terms of use and policies before performing automated actions on their website.
