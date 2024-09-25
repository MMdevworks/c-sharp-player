Pack mediumPack = new Pack(10, 20f, 30f);

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
        _=> null
    };

    if (userItem == null)
    {
        Console.WriteLine("Invalid selection, pick again.");
        continue;
    }

    if (!mediumPack.Add(userItem)){
        break;
    };

    Console.WriteLine("Pack Contains:");

    foreach (InventoryItem item in mediumPack.Items)
    {
        Console.WriteLine(item);
    }
}

public class Pack 
{
    private InventoryItem[] _items;

    public int MaxCount { get; }
    public float MaxWeight { get; }
    public float MaxVolume { get; }

    public int CurrentCount { get; private set; }
    public float CurrentWeight { get; private set; }
    public float CurrentVolume { get; private set; }

    public Pack(int maxCount, float maxWeight, float maxVolume)
    {
        MaxCount = maxCount;
        MaxWeight = maxWeight;
        MaxVolume = maxVolume;
        // make the items array the size of max count
        _items = new InventoryItem[maxCount];
    }

    // public property to expose the  private _items array 
    public InventoryItem[] Items
    {
        get { return _items; }
    }

    // add items to pack
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
        // add items to array at index of current count
        _items[CurrentCount] = item;
        CurrentWeight += item.Weight;
        CurrentVolume += item.Volume;
        CurrentCount++;
        return true;
    }
}

public class InventoryItem 
{
    public float Weight { get; }
    public float Volume { get; }

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