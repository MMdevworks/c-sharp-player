
Pack mediumPack = new Pack(0, 5, 4.5);
Console.WriteLine(mediumPack.Weight());

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
    public Knife() : base(0.1f, 0.05f)
    {
    }
}

public class Bow : InventoryItem 
{
    public Bow() : base(1f, 4f)
    {
    }
}

public class Rope : InventoryItem 
{
    public Rope() : base(1f, 1.5f)
    {
    }
}

public class Water : InventoryItem 
{
    public Water() : base(2f, 3f)
    {
    }
}

public class Food : InventoryItem 
{
    public Food() : base(1f, 0.5f)
    {
    }
}

public class Sword : InventoryItem 
{
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

    public int CurrentCount; //cant be > total
    public float CurrentWeight; //cant be > max
    public float CurrentVolume; //cant be > max

    public Pack(int itemTotal, float maxWeight, float maxVolume)
    {
        ItemTotal = itemTotal;
        MaxWeight = maxWeight;
        MaxVolume = maxVolume;
    }

// allows you to add items of any type to the pack’s contents.
// fail/return false if adding the item would exceed count/wt/vol limits
//     public bool Add(InventoryItem item)
//     {
//         if (CurrentCount > ItemsTotal) return false;
//         if (CurrentWeight + item.Weight > MaxWeight) return false;
//         if (CurrentVolume + item.Volume > MaxVolume) return false;
//         Items
//         ItemTotal++;
//     }
}

//create pack 
// add items to pack from menu