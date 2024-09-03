Pack mediumPack = new Pack(10, 20f, 30f);
Knife myKnife = new Knife();
Console.WriteLine(mediumPack.MaxCount);
Console.WriteLine(mediumPack.MaxWeight);
Console.WriteLine(mediumPack.MaxVolume);
mediumPack.Add(myKnife);
Console.WriteLine(mediumPack.CurrentCount);
Console.WriteLine(mediumPack.CurrentWeight);
Console.WriteLine(mediumPack.CurrentVolume);

Console.WriteLine($"Items in pack: {mediumPack.CurrentCount}/{mediumPack.MaxCount} | Weight: {mediumPack.CurrentWeight}/{mediumPack.MaxWeight} | Volume: {mediumPack.CurrentVolume}/{mediumPack.MaxVolume}");

Console.WriteLine("What do you want to pack?")
public class Pack 
{
    public InventoryItem[] Items;

    public int MaxCount;
    public float MaxWeight;
    public float MaxVolume;

    public int CurrentCount; //cant be > total
    public float CurrentWeight; //cant be > max
    public float CurrentVolume; //cant be > max

    public Pack(int maxCount, float maxWeight, float maxVolume)
    {
        MaxCount = maxCount;
        MaxWeight = maxWeight;
        MaxVolume = maxVolume;
    }

// allows you to add items of any type to the pack’s contents.
// fail/return false if adding the item would exceed count/wt/vol limits
    public bool Add(InventoryItem item)
    {
        if (CurrentCount > MaxCount) return false;
        if (CurrentWeight + item.Weight > MaxWeight) return false;
        if (CurrentVolume + item.Volume > MaxVolume) return false;
        CurrentWeight += item.Weight;
        CurrentVolume = item.Volume;
        CurrentCount++;
        return true;
    }
}

public class InventoryItem {
    public float Weight;
    public float Volume;

    public InventoryItem(float weight, float volume) {
        Weight = weight;
        Volume = volume;
    }
}
//  Each class should pass the correct weight and volume to the base class constructor but should be creatable themselves with a parameterless constructor(forexample,new Rope()ornew Sword()).
// Build a Pack class that can store an array of items. The total number of items, the maximum weight, and the maximum volume are provided at creation time and cannot change afterward.


public class Knife : InventoryItem {public Knife() : base(0.1f, 0.05f){}}
public class Bow : InventoryItem {public Bow() : base(1f, 4f){}}
public class Rope : InventoryItem {public Rope() : base(1f, 1.5f){}}
public class Water : InventoryItem {public Water() : base(2f, 3f){}}
public class Food : InventoryItem {public Food() : base(1f, 0.5f){}}
public class Sword : InventoryItem {public Sword() : base(1f, 4f){}}