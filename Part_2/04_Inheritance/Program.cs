


public class InventoryItem {
    public float Weight;
    public float Volume;

    public InventoryItem(float weight, float volume) {
        Weight = weight;
        Volume = volume;
    }
}
//  Each class should pass the correct weight and volume to the base class constructor but should be creatable themselves with a parameterless constructor(forexample,new Rope()ornew Sword()).

public class Knife : InventoryItem 
{
    // parameterless constructor needs to be defined when a parameter constructor is also defined
    public Knife : base(0,0)
    {

    }
    public Knife() : base(0.1f, 0.05f)
    {
    }
}

public class Bow : InventoryItem 
{
    public Bow : base(0,0)
    {

    }
    public Bow() : base(1f, 4f)
    {
    }
}

public class Rope : InventoryItem 
{
    public Rope : base(0,0)
    {

    }
    public Rope() : base(1f, 1.5f)
    {
    }
}

public class Water : InventoryItem 
{
    public Water : base(0,0)
    {

    }
    public Water() : base(2f, 3f)
    {
    }
}

public class Food : InventoryItem 
{
    public Food : base(0,0)
    {

    }
    public Food() : base(1f, 0.5f)
    {
    }
}

public class Sword : InventoryItem 
{
    public Sword : base(0,0)
    {

    }
    public Sword() : base(1f, 4f)
    {
    }
}
// Build a Pack class that can store an array of items. The total number of items, the maximum weight, and the maximum volume are provided at creation time and cannot change afterward.
public class Pack 
{
    public InventoryItem[] Items;
    public int ItemTotal;
    public float MaxWeight;
    public float MaxVolume;

    public int CurrentCount;
    public float CurrentWeight;
    public float CurrentVolume;

    public Pack(int itemTotal, float maxWeight, float maxVolume)
    {
        ItemTotal = itemTotal;
        MaxWeight = maxWeight;
        MaxVolume = maxVolume;

    }

// Make a public bool Add(InventoryItem item) method to Pack that allows you to add items of any type to the pack’s contents. This method should fail (return false and not modify the pack’s fields) if adding the item would cause it to exceed the pack’s item, weight, or volume limit.
    public bool Add(InventoryItem item)
    {
        Items
        ItemTotal++;
    }
}