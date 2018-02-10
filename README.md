# Contact Book
#### C Sharp and ASP.Net web app for creating and displaying contact information, 2-09-18  

#### _By Stephanie Faber_  

## Description
_This is a project designed to take user input in the form of contact information and display it. The Index page on localhost:5000/contacts shows a list of all contacts as well as a link to add more contacts. If there are contacts listed you can click on them to see the specific details of that contact, such as their name, phone number, and address. At the bottom of the details page there are 3 links, one to delete that specific contact, one to make another contact, and one to go back to the homepage. The page for creating a contact has a form to take in user input for name, phone number, and address. On submission of  that form it takes the user back to the Index homepage and displays all contacts again._  

## Specifications

1. User enters localhost:5000/contacts to browser and it takes them to the Index.
* Example input: User enters localhost:5000/contacts to browser
* Example output: Index is displayed with a list of contacts and links to other pages

2. On Index, user clicks Make Contact. It takes them to a page to make a contact.
* Example input: User clicks Make Contact
* Example output: Goes to Make Contact page

3. User enters information into forms on Make Contact page and submits. They are taken back to the homepage on localhost:5000/contacts with their new contact appearing in the list.
* Example input: User enters information into forms and submits
* Example output: They are taken back to the homepage on localhost:5000/contacts with their new contact appearing in the list.

4. On redirect after the form is submitted, a new Contact object is created with that information. It is added to the List of Contact objects.
* Example input: User submits new contact form
* Example output: new Contact is created and it is added to List of Contacts

5. On the homepage the user clicks on a contact. It links them to a Details page displaying that contact's information.
* Example input: User clicks on a contact
* Example output: Details page appears with that contact's information

6. User clicks on Delete This Contact button at bottom of the Details page. It takes them to the home page while removing that contact from the static List.
* Example input: User clicks on Delete This Contact button
* Example output: The home page appears, that contact is now gone from the list of contacts.

7. User clicks on link in Details page for Back to Home. They are taken to the Index page.
* Example input: User clicks on link in Details page for Back to Home.
* Example output: They are taken to the Index page

8. User clicks on New Contact link at bottom of the Details page. It takes them to the Make Contact page.
* Example input: User clicks on New Contact link
* Example output: The Make Contact page appears


## Setup/Installation Requirements

* _Clone Repository_

* _Download and install .NET Core 1.1 SDK_

* _Download and install .NET runtime_

* _Download and install Mono for your platform_

* _In Mono command prompt, navigate to ContactBook repository_

* _In Mono command prompt, enter >dotnet build_

* _If there are no errors: In Mono command prompt, enter >dotnet run_

* _If there is an error, please contact me via email and describe your issue_

* _When the command prompt runs the build, enter localhost:5000/contacts to your web browser. This should take you to the index page._

Github Repository Link (https://github.com/eyesicedover/ContactBook)

## Support and contact details

_Please email me directly at eyesicedover@gmail.com_

## Technologies Used

* HTML
* ASP.NET
* Razor
* .NET Core
* .NET SDK

### License

*MIT License*

Copyright (c) 2018 **_Stephanie Faber_**

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
