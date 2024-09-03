


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