# Object initializers

[Source](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers)

Object initializers let you assign values to any accessible fields or properties of an object at `creation time` without having to invoke a constructor followed by lines of assignment statements.

The object initializer syntax enables you to specify arguments for a constructor or `omit` the arguments (and parentheses syntax).

```csharp
public class Cat
{
    // Auto-implemented properties.
    public int Age { get; set; }
    public string? Name { get; set; }

    public Cat()
    {
    }

    public Cat(string name)
    {
        this.Name = name;
    }
}

Cat cat = new Cat { Age = 10, Name = "Fluffy" };
Cat sameCat = new Cat("Fluffy"){ Age = 10 };
```
