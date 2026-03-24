// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//TODO: Make project
/* Project Name: GigGrid
Features: 
- client manager 
- project/task/deadline manager 
- job type/pricing manager 
- income manager

Core OOP: 
- Encapsulation: All money stuff fields (hourly/project rate, money earned, invoice totals) will be private or protected w/public properties + validation to stop negative money/invalid anything 
- Abstraction: abstract BaseContract class for structure of general work agreement. ISaveable for data being saved to another file
- Inheritance: HourlyContract and ProjectContract inherit from BaseContract.
- Polymorphism: Both child classes will have a CalculateInvoiceTotal() method. The Hourly version by hourly rate, and the project version for end of project paymentsor pre/post project payments.
- Instances/objects: Each Client and Project object.
- Static: Formatting methods, project progress methods, deadline calculator, project quote?

Bonus features:
- analytics stuff (what makes the most, what I'm getting to most requests for)
- automatic invoices? Like sending emails
- I saw something that said I could save it to a spreadsheet, I wanna see that if I can figure it out
*/