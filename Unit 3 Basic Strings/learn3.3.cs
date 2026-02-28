// string firstName = "Bob";
// string message = "Hello " + firstName;
// Console.WriteLine(message); // Output: Hello Bob

string firstName = "Bob";
string greeting = "Hello";
string message = greeting + " " + firstName + "!";  // AVOID THIS!! This is example of using intermediate variables - avoid
Console.WriteLine(message);
// Instead use
Console.WriteLine(greeting + " " + firstName + "!");  // much better !!!

