// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Defining and instantiating classes

// TODO: Create some new Rectangle objects with dimensions
Rectangle rec1 = new(10, 20);
Rectangle rec2 = new(30);

Console.WriteLine(rec1.GetArea());
Console.WriteLine(rec2.GetArea());

// TODO: Change the values of width and height
rec2.width = 5;
rec2.height = 7;

Console.WriteLine(rec2.GetArea());