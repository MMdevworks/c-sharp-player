// Records are a compact alternative notation for defining a data-centric class or struct: public record Point(float X, float Y);
// The compiler automatically generates a constructor, properties, ToString, equality with value semantics, and deconstruction.
// Records are turned into classes by default or into a struct (public record struct Point(...)).

Sword basic = new Sword(Material.Iron, Gemstone.Bare, 36, 5.5f);
// using record and the 'with' expression
Sword basicFire = basic with { gemstone = Gemstone.Ruby };
Sword basicIceDagger = basic with { gemstone = Gemstone.Sapphire, length = 7, crossguardWidth = 2 };

Console.WriteLine(basic);
Console.WriteLine(basicFire);
Console.WriteLine(basicIceDagger);

public record Sword(Material material, Gemstone gemstone, float length, float crossguardWidth);
public enum Material { Wood, Bronze, Iron, Steel, Adamantium };
public enum Gemstone { Emerald, Amber, Sapphire, Diamond, Ruby, Bare };