using System;
using System.Collections.Generic;

class Backpack
{
    public string Color { get; set; }
    public string Manufacturer { get; set; }
    public string Material { get; set; }
    public double Weight { get; set; }
    public double Volume { get; set; }
    public double UsedVolume { get; private set; } = 0;

    public List<Item> Contents { get; } = new List<Item>();

    public Action<Item> OnItemAddedCallback { get; set; }

    public void AddItem(Item item)
    {
        if (UsedVolume + item.Volume > Volume)
        {
            throw new InvalidOperationException("Превышен объём рюкзака. Невозможно добавить объект.");
        }

        Contents.Add(item);
        UsedVolume += item.Volume;

        OnItemAddedCallback?.Invoke(item);
    }
}
class Item
{
    public string Name { get; set; }
    public double Volume { get; set; }

    public Item(string name, double volume)
    {
        Name = name;
        Volume = volume;
    }
}

class Program
{
    static void Main()
    {
        Backpack backpack = new Backpack
        {
            Color = "Чёрный",
            Manufacturer = "Adidas",
            Material = "Нейлон",
            Weight = 1.2,
            Volume = 20
        };

        backpack.OnItemAddedCallback = item =>
        {
            Console.WriteLine($"Объект '{item.Name}' добавлен в рюкзак. Объем: {item.Volume}");
        };

        try
        {
            backpack.AddItem(new Item("Учебник", 3));
            backpack.AddItem(new Item("Ноутбук", 5));
            backpack.AddItem(new Item("Термос", 2));
            backpack.AddItem(new Item("Куртка", 4));
            backpack.AddItem(new Item("Палатка", 8));
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
