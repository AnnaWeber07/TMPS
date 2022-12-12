using TMPS_lab_3.Memento;
using TMPS_lab_3.Iterator;
using TMPS_lab_3.Visitor;
using TMPS_lab_3.TemplateMethod;
using TMPS_lab_3.State;
using System.IO;
using System.Runtime.ConstrainedExecution;

//Memento

Agent s = new Agent();
s.Name = "Anna Weber";
s.Phone = "373 600 60056";
s.Salary = 35000.0;
// Store internal state
MemoryLoader m = new MemoryLoader();
m.Memento = s.SaveMemento();
// Continue changing originator
s.Name = "Some Random Guy";
s.Phone = "373 455 54211";
s.Salary = 1000000.0;
// Restore saved state
s.RestoreMemento(m.Memento);
// Wait for user
Console.WriteLine();
Console.ReadKey();


//Iterator
// Build a collection of users
Collection collection = new Collection();
collection[0] = new Item("Person 10");
collection[1] = new Item("Person 11");
collection[2] = new Item("Person 12");
collection[3] = new Item("Person 13");
collection[4] = new Item("Person 14");
collection[5] = new Item("Person 15");
collection[6] = new Item("Person 16");
collection[7] = new Item("Person 17");
collection[8] = new Item("Person 18");
// Create iterator
Iterator iterator = collection.CreateIterator();
// Skip every other item
iterator.Step = 2;
Console.WriteLine("Iterating over clients:");
for (Item item = iterator.First();
    !iterator.IsDone; item = iterator.Next())
{
    Console.WriteLine(item.Name);
}
Console.WriteLine();

Console.ReadKey();

//State

// Setup context in a state
// Open a new account
Account account = new Account("Anna Weber");
// Apply financial transactions
account.Deposit(500.0);
account.Deposit(300.0);
account.Deposit(550.0);
account.PayInterest();
account.Withdraw(2000.00);
account.Withdraw(1100.00);
// Wait for user
Console.ReadKey();

Console.WriteLine();

//TemplateMethod

CardAccessor categories = new Categories();
categories.Run(5);
CardAccessor products = new Currency();
products.Run(3);
// Wait for user
Console.ReadKey();
Console.WriteLine();
//Visitor

//Employees employee = new Employees();
//employee.Attach(new Clerk());
//employee.Attach(new Director());
//employee.Attach(new President());
//// Employees are 'visited'
//employee.Accept(new IncomeVisitor());
//employee.Accept(new VacationVisitor());
//// Wait for user
