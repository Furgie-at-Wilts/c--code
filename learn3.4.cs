// String Interpolation - instead of
// string message = greeting + " " + firstName + "!";
// we can write
// string message = $"{greeting} {firstName}!";

// string firstName = "Bob";
// string message = $"Hello {firstName}!";
// Console.WriteLine(message);

int version = 11;
string updateText = "Update to Windows";
// string message = $"{updateText} {version}";  Avoid Intermediate varables!!
// Console.WriteLine(message);
Console.WriteLine($"{updateText} {version}!");

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

