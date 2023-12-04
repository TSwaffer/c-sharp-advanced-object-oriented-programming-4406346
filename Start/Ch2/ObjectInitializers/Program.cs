// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using object and collection initializers

// TODO: Use the initializer syntax to create new objects
Dog dog = new() { Name = "Ted", Age = 4, IsTrained = true };
Cat cat = new() { Name = "Todd", Age = 7, IsDeclawed = false };

// Console.WriteLine(dog.Name);
// Console.WriteLine(cat.Name);

// TODO: Initializers can be used on anonymous types


// TODO: Collections can also be initialized this way
int[] numbers = new int[] { 1,2,3,4,5,6 };
// Console.WriteLine(numbers.Length);

// TODO: Initialize a collection with a set of objects
PetOwner owner = new() {
    Name = "Tom",
    Pets = new List<Pet>() {
        dog,
        cat
    }
};

Console.WriteLine(owner.Name);
foreach (Pet p in owner.Pets) {
    Console.WriteLine(p.Name);
}

