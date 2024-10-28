using System;
using System.Collections.Generic;

// Class representing a single menu item
public class MenuItem
{
    public string Name { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public string Category { get; set; } // "Appetizer", "Entree", or "Dessert"
    public bool IsNew { get; set; }

    public MenuItem(string name, double price, string description, string category, bool isNew)
    {
        Name = name;
        Price = price;
        Description = description;
        Category = category;
        IsNew = isNew;
    }

    public void Display()
    {
        Console.WriteLine($"{Name} (${Price}): {Description}");
        Console.WriteLine($"Category: {Category}");
        if (IsNew)
        {
            Console.WriteLine("This is a new item!");
        }
        Console.WriteLine();
    }
}

// Class representing the restaurant's menu
public class Menu
{
    public List<MenuItem> Items { get; set; } = new List<MenuItem>();
    public DateTime LastUpdated { get; set; }

    public Menu()
    {
        LastUpdated = DateTime.Now;
    }

    public void DisplayMenu()
    {
        Console.WriteLine($"Menu (last updated {LastUpdated}):\n");
        foreach (var item in Items)
        {
            item.Display();
        }
    }
}

// Main program class
class Program
{
    static void Main(string[] args)
    {
        // Create menu items
        MenuItem appetizer = new MenuItem("Parisien Cheese", 13.00, "Warm ricotta cheese, Nicoise olives, tomato confit, olive oil and fresh herbs. Served with toasted crostini", "Appetizer", false);
        MenuItem entree = new MenuItem("Salmon", 28.00, "Potato encrusted salmon topped with lemon beurre blanc. Served with haricot verts and garnish with arugula salad", "Entree", true);
        MenuItem dessert = new MenuItem("Chocolate Mousse Cake", 10.00, "It's just cake man", "Dessert", false);

        // Create a menu and add items
        Menu menu = new Menu();
        menu.Items.Add(appetizer);
        menu.Items.Add(entree);
        menu.Items.Add(dessert);

        // Display the menu
        menu.DisplayMenu();
    }
}
