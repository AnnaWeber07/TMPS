using StructuralPatterns.Facade;
using StructuralPatterns.Bridge;
using StructuralPatterns.Adapter;
using StructuralPatterns.Decorator;

Console.WriteLine("This lab work is dedicated to structural design patterns");

// Create easyCredit
NoPercentCredit easyCredit = new NoPercentCredit("Student", "Being a Student is Hard", 10);

easyCredit.Display();

// Create personal discussion
PersonalEmployee personalEmployee = new PersonalEmployee("Spielberg", "Because I need more money", 3, 92);

personalEmployee.Display();

// Make discussion , then borrow and display
Console.WriteLine("\nMaking discussion available:");

Possible borrowvideo = new Possible(personalEmployee);

borrowvideo.PossibleCredit("Customer #1");

borrowvideo.PossibleCredit("Customer #2");

borrowvideo.Display();

// Create RefinedAbstraction
var customers = new Customers();

// Set ConcreteImplementor
customers.Data = new CustomersData("Chicago");

// Exercise the bridge
customers.Show();

customers.Latter();

customers.Show();

customers.Latter();

customers.Show();

customers.Add("Henry Velasquez");

customers.ShowAll();

Card unknown = new Card();
unknown.Display();
// Adapted card compounds
Card first = new ExtendedCard("FIRST CARD");
first.Display();
Card second = new ExtendedCard("SECOND CARD");
second.Display();
Card third = new ExtendedCard("THIRD CARD");
third.Display();


MortgageFacade mortgage = new MortgageFacade();

// Evaluate mortgage eligibility for customer
Customer customer = new Customer("Ann McKinsey", 25, 35000, "coder", 4500);

bool eligible = mortgage.IsElligible(customer, 105000);

Console.WriteLine("\n" + customer.Name + " has been " + (eligible ? "Approved" : "Rejected"));

// Wait for user
Console.ReadKey();