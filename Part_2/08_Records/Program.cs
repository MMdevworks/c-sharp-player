// Records are a compact alternative notation for defining a data-centric class or struct: public record Point(float X, float Y);
// The compiler automatically generates a constructor, properties, ToString, equality with value semantics, and deconstruction.
// Records are turned into classes by default or into a struct (public record struct Point(...)).

public record Sword(Material material, Gemstone gemstone, Length length, CrossguardWidth crossguardWidth);

enum Material { Wood, Bronze, Iron, Steel, Binarium };
enum Gemstone { Emerald, Amber, Sapphire, Diamond, Bitstone, Bare };