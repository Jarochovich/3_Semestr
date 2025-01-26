using System.Collections.Generic;
using System;

public enum PlantType
{
    Bush,
    Flower,
    Rose,
    Gladiolus,
    Cactus,
    Paper
}

// Структура Растение
public struct Plant
{
    public string Name { get; set; }
    public PlantType Type { get; set; }

    public void Grow()
    {
        switch (Type)
        {
            case PlantType.Bush:
                Console.WriteLine($"{Name} is growing as a bush.");
                break;
            case PlantType.Flower:
                Console.WriteLine($"{Name} is blooming.");
                break;
            case PlantType.Rose:
                Console.WriteLine($"{Name} is blooming as a rose.");
                break;
            case PlantType.Gladiolus:
                Console.WriteLine($"{Name} is blooming as a gladiolus.");
                break;
            case PlantType.Cactus:
                Console.WriteLine($"{Name} is growing as a cactus.");
                break;
            case PlantType.Paper:
                Console.WriteLine($"{Name} is being produced as paper.");
                break;
        }
    }

    public override string ToString()
    {
        return $"Type: {Type}, Name: {Name}";
    }
}

// Класс Букет, содержит коллекцию Цветов
public partial class Bouquet
{
   
}

public interface ICloneable
{
    bool DoClone();
}

public abstract class BaseClone
{
    public abstract bool DoClone();
}

public class UserClass : BaseClone, ICloneable
{
    public override bool DoClone()
    {
        Console.WriteLine("Cloning in BaseClone way.");
        return true;
    }

    bool ICloneable.DoClone()
    {
        Console.WriteLine("Cloning in ICloneable way.");
        return true;
    }
}

public sealed class SealedClass
{
    public string Description { get; set; }
    public override string ToString()
    {
        return $"SealedClass: {Description}";
    }
}

public class Printer
{
    public void IAmPrinting(Plant plant)
    {
        Console.WriteLine(plant.ToString());
    }
}