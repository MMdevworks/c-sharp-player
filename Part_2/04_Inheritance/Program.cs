Pack mediumPack = new Pack(10, 20f, 30f);
// Knife myKnife = new Knife();
// Console.WriteLine(mediumPack.MaxCount);
// Console.WriteLine(mediumPack.MaxWeight);
// Console.WriteLine(mediumPack.MaxVolume);
// mediumPack.Add(myKnife);
// Console.WriteLine(mediumPack.CurrentCount);
// Console.WriteLine(mediumPack.CurrentWeight);
// Console.WriteLine(mediumPack.CurrentVolume);

while (true)
{
    Console.WriteLine($"Items in pack: {mediumPack.CurrentCount}/{mediumPack.MaxCount} | Weight: {mediumPack.CurrentWeight}/{mediumPack.MaxWeight} | Volume: {mediumPack.CurrentVolume}/{mediumPack.MaxVolume}");

    Console.WriteLine("What do you want to pack? Choose it's number:");
    Console.WriteLine("1 - Knife");
    Console.WriteLine("2 - Bow");
    Console.WriteLine("3 - Rope");
    Console.WriteLine("4 - Water");
    Console.WriteLine("5 - Food");
    Console.WriteLine("6 - Sword");
    int selection = Convert.ToInt32(Console.ReadLine());

    InventoryItem userItem = selection switch
    {
        1 => new Knife(),
        2 => new Bow(),
        3 => new Rope(),
        4 => new Water(),
        5 => new Food(),
        6 => new Sword(),
    };
    mediumPack.Add(userItem);

    foreach (InventoryItem item in mediumPack.Items)
    {
        Console.WriteLine(item);
    }
}

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
        // make the items array the size of max count
        Items = new InventoryItem[maxCount];
    }

// allows you to add items of any type to the pack’s contents.
// fail/return false if adding the item would exceed count/wt/vol limits
    public bool Add(InventoryItem item)
    {
        if (CurrentCount >= MaxCount) 
        {
            Console.WriteLine("PACK IS FULL");
            return false;
        }
        if (CurrentWeight + item.Weight > MaxWeight)
        {
            Console.WriteLine("PACK TOO HEAVY"); 
            return false;
        }
        if (CurrentVolume + item.Volume > MaxVolume)
        {
            Console.WriteLine("NOT ENOUGH ROOM");
            return false;
        }
        // add items at index of current count
        Items[CurrentCount] = item;
        CurrentWeight += item.Weight;
        CurrentVolume += item.Volume;
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

public class Knife : InventoryItem {public Knife() : base(0.1f, 0.05f){}}
public class Bow : InventoryItem {public Bow() : base(1f, 4f){}}
public class Rope : InventoryItem {public Rope() : base(1f, 1.5f){}}
public class Water : InventoryItem {public Water() : base(2f, 3f){}}
public class Food : InventoryItem {public Food() : base(1f, 0.5f){}}
public class Sword : InventoryItem {public Sword() : base(1f, 4f){}}