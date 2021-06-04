using System;
using System.Linq;

[Flags]
public enum Allergen
{
  Eggs = 1,
  Peanuts = 2,
  Shellfish = 4,
  Strawberries = 8,
  Tomatoes = 16,
  Chocolate = 32,
  Pollen = 64,
  Cats = 128
}

public class Allergies
{
  public Allergen Mask { get; set; }
  public Allergies(int aMask)
  {
    Mask = (Allergen)aMask;
  }

  public bool IsAllergicTo(Allergen aAllergen) => Mask.HasFlag(aAllergen);

  public Allergen[] List()
  {
    return Enum.GetValues(typeof(Allergen))
      .Cast<Allergen>()
      .Where(aAllergen => IsAllergicTo(aAllergen))
      .ToArray();
  }
}