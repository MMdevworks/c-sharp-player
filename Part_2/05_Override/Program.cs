// Example use of 'override' modifier. 
// Override is used to provide a new implementation for a method that is already defined in a base class
// In this example ToString is method defined in the object base class - the ultimate parent of all classes in C#

public class InventoryItem {
    public string Name { get; }
    public float Weight { get; }
    public float Volume { get; }

    public InventoryItem(string name, float weight, float volume) 
    {   
        Name = name;
        Weight = weight;
        Volume = volume;
    }
}