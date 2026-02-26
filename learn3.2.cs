Console.WriteLine("Hello\nWorld!"); // \n is a newline character, it moves the cursor to the next line after printing "Hello".
Console.WriteLine("Hello\tWorld!"); // \t is a tab character, it adds a horizontal tab space between "Hello" and "World!".
Console.WriteLine("Hello \"World\"!"); // \" is an escape sequence for a double quote, it allows you to include double quotes in the string without ending it.
Console.WriteLine("c:\\source\\repos"); // \\ is an escape sequence for a backslash, it allows you to include a backslash in the string without it being interpreted as an escape character.
Console.WriteLine();

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.Write("\nOutput Directory:\t");
Console.Write(@"c:\invoices");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)"); // The @ symbol before the string indicates that it is a verbatim string literal, which means that escape sequences are not processed and the string is taken as-is. This allows you to include backslashes and newlines without needing to escape them.
Console.WriteLine();
// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!"); // \u is an escape sequence for a Unicode character, note that this line doesn't work
