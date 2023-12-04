// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Creating and using Anonymous types

// TODO: Anonymous types can be declared using "new" and { }, similar to JS
var myObj = new {
    Name = "Tom",
    Age = 31,
    Address = new {
        Street = "Test Street",
        Cirt = "Test City"
    }
};
// Console.WriteLine($"{myObj.Name}, {myObj.Address.Street}");
// Console.WriteLine(myObj);
// Anonymous types are read-only and cannot be modified
// myobj.Name = "Jane Doe"; # will cause an error

// TODO: To change a value, use non-destructive mutation and "with" clause
// var myNewObj = myObj with { Name = "Jane Doe" };
// Console.WriteLine($"{myNewObj.Name}, {myNewObj.Address.Street}");

// TODO: You can check to see if an anonymous object contains a property
Console.WriteLine($"{myObj.GetType().GetProperty("Name") != null}");
Console.WriteLine($"{myObj.GetType().GetProperty("Job") != null}");