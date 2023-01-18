// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// string greeting = "      Hello World!       ";
// Console.WriteLine($"[{greeting}]");

// string trimmedGreeting = greeting.TrimStart();
// Console.WriteLine($"[{trimmedGreeting}]");

// trimmedGreeting = greeting.TrimEnd();
// Console.WriteLine($"[{trimmedGreeting}]");

// trimmedGreeting = greeting.Trim();
// Console.WriteLine($"[{trimmedGreeting}]");

// string sayHello = "Hello World!";
// Console.WriteLine(sayHello);
// sayHello = sayHello.Replace("Hello", "Greetings");
// Console.WriteLine(sayHello);

// Console.WriteLine(sayHello.ToUpper());
// Console.WriteLine(sayHello.ToLower());

// string songLyrics = "You say goodbye, and I say hello";
// Console.WriteLine(songLyrics.Contains("goodbye"));
// Console.WriteLine(songLyrics.Contains("greetings"));

//string songLyrics = "You say goodbye, and I say hello";
//Console.WriteLine(songLyrics.StartsWith("You"));
//Console.WriteLine(songLyrics.StartsWith("goodbye"));

//Console.WriteLine(songLyrics.EndsWith("hello"));
//Console.WriteLine(songLyrics.EndsWith("goodbye"));

//int a = 18;
//int b = 6;
//int c = a + b;
//Console.WriteLine(c);

//int a = 5;
//int b = 4;
//int c = 2;
//int d = a + b * c;
//Console.WriteLine(d);

//int a = 5;
//int b = 4;
//int c = 2;
//int d = (a + b) * c;
//Console.WriteLine(d);

//int a = 7;
//int b = 4;
//int c = 3;
//int d = (a + b) / c;
//Console.WriteLine(d);

//int a = 7;
//int b = 4;
//int c = 3;
//int d = (a + b) / c;
//int e = (a + b) % c;
//Console.WriteLine($"quotient: {d}");
//Console.WriteLine($"remainder: {e}");

//int max = int.MaxValue;
//int min = int.MinValue;
//Console.WriteLine($"The range of integers is {min} to {max}");

//int what = max + 3;
//Console.WriteLine($"An example of overflow: {what}");

//double a = 5;
//double b = 4;
//double c = 2;
//double d = (a + b) / c;
//Console.WriteLine(d);

//double a = 19;
//double b = 23;
//double c = 8;
//double d = (a + b) / c;
//Console.WriteLine(d);

//double max = double.MaxValue;
//double min = double.MinValue;
//Console.WriteLine($"The range of double is {min} to {max}");

//double third = 1.0 / 3.0;
//Console.WriteLine(third);

//decimal min = decimal.MinValue;
//decimal max = decimal.MaxValue;
//Console.WriteLine($"The range of the decimal type is {min} to {max}");

//double a = 1.0;
//double b = 3.0;
//Console.WriteLine(a / b);


//The M suffix on the numbers is how you indicate that a constant should use the decimal type. Otherwise, the compiler assumes the double type.

// Note The letter M was chosen as the most visually distinct letter between the double and decimal keywords.
//decimal c = 1.0M;
//decimal d = 3.0M;
//Console.WriteLine(c / d);

double r, per_cir;
//double PI = 3.14;
Console.WriteLine("Input the radius of the circle : ");
r = Convert.ToDouble(Console.ReadLine());
per_cir = (r * r) * Math.PI;
Console.WriteLine("Perimeter of Circle : {0}", per_cir);
Console.Read();