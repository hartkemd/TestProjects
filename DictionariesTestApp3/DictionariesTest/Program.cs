
Dictionary<string, string> definitions = new Dictionary<string, string>();
definitions.Add("C", "a programming language developed at Bell Labs by Ken Thompson and Dennis Ritchie.");
definitions.Add("C++", "a programming language developed at Bell Labs by Bjarne Stroustrup.");
definitions.Add("C#", "a programming language developed at Microsoft by Anders Hejlsberg.");

//Console.WriteLine(definitions["B"]);
Console.WriteLine($"C is: {definitions["C"]}");
Console.WriteLine($"C++ is: {definitions["C++"]}");
Console.WriteLine($"C# is: {definitions["C#"]}");

Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();
