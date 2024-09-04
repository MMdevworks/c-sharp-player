// Example use of 'override' modifier. 
// Override is used to provide a new implementation for a method that is already defined in a base class
// In this example ToString is method defined in the object base class - the ultimate parent of all classes in C#

InventoryItem knife = new InventoryItem("Knife", 0.1f, 0.05f);
InventoryItem bow = new InventoryItem("Bow", 1.0f, 4.0f);

// ToString(), now uses the overridden method instead of the default from object base class
Console.WriteLine(knife.ToString());
Console.WriteLine(bow.ToString());

public class InventoryItem 
{
    public string Name { get; }
    public float Weight { get; }
    public float Volume { get; }

    public InventoryItem(string name, float weight, float volume) 
    {   
        Name = name;
        Weight = weight;
        Volume = volume;
    }

    public override string ToString()
    {
        return $"Item: {Name}, Weight: {Weight}, Volume: {Volume}";
    }
}


// Without the override:
// InventoryItem knife = new InventoryItem("Knife", 0.1f, 0.05f);
// InventoryItem bow = new InventoryItem("Bow", 1.0f, 4.0f);

// Console.WriteLine(knife.ToString());
// Console.WriteLine(bow.ToString());

// public class InventoryItem 
// {
//     public string Name { get; }
//     public float Weight { get; }
//     public float Volume { get; }

//     public InventoryItem(string name, float weight, float volume) 
//     {   
//         Name = name;
//         Weight = weight;
//         Volume = volume;
//     }
// }