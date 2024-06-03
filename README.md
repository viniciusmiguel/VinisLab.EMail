# VinisLab.EMail
Defines an email type in dotnet and adds functionality of validation and parsing compliant with RFCs 5322 and 6854

Usage Examples:

```csharp
using VinisLab.EMail;

var email = "username@example.com".ToEMail(); //Throws if invalid

var domain = email.Domain; // returns the domain part of the email

var localPart = email.LocalPart // returns the e-mail local part

var isValid = EMail.Validate("username@example.com"); //Validates the e-mail

var parsingResult = EMail.TryParse("email@example.com", out EMail? result);

```