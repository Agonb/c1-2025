using System;

class Program
{
    static string[] inventory = new string[5];

    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- GAME INVENTORY SYSTEM ---");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Remove Item");
            Console.WriteLine("3. Show Inventory");
            Console.WriteLine("4. Search Item");
            Console.WriteLine("5. Count Items");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option (1-6): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddItemFlow();
                    break;
                case "2":
                    RemoveItemFlow();
                    break;
                case "3":
                    ShowInventory();
                    break;
                case "4":
                    SearchItemFlow();
                    break;
                case "5":
                    CountItems();
                    break;
                case "6":
                    running = false;
                    Console.WriteLine("Exiting the inventory system. See you next quest!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again!");
                    break;
            }
        }
    }

    static void AddItemFlow()
    {
        Console.Write("Enter item name to add: ");
        string item = Console.ReadLine();

        Console.Write("Enter slot number (0-4): ");
        int index;
        if (int.TryParse(Console.ReadLine(), out index))
        {
            AddItem(item, index);
        }
        else
        {
            Console.WriteLine("Invalid slot number!");
        }
    }

    static void AddItem(string item, int index)
    {
        if (index >= 0 && index < inventory.Length)
        {
            if (inventory[index] == null)
            {
                inventory[index] = item;
                Console.WriteLine($"{item} added to slot {index}.");
            }
            else
            {
                Console.WriteLine($"Slot {index} is already occupied by {inventory[index]}.");
            }
        }
        else
        {
            Console.WriteLine("Slot index out of range.");
        }
    }

    static void RemoveItemFlow()
    {
        Console.Write("Enter slot number to remove item from (0-4): ");
        int index;
        if (int.TryParse(Console.ReadLine(), out index))
        {
            RemoveItem(index);
        }
        else
        {
            Console.WriteLine("Invalid slot number!");
        }
    }

    static void RemoveItem(int index)
    {
        if (index >= 0 && index < inventory.Length)
        {
            if (inventory[index] != null)
            {
                Console.WriteLine($"{inventory[index]} removed from slot {index}.");
                inventory[index] = null;
            }
            else
            {
                Console.WriteLine($"Slot {index} is already empty.");
            }
        }
        else
        {
            Console.WriteLine("Slot index out of range.");
        }
    }

    static void ShowInventory()
    {
        Console.WriteLine("\nYour Inventory:");
        for (int i = 0; i < inventory.Length; i++)
        {
            string content = inventory[i] ?? "Empty";
            Console.WriteLine($"Slot {i}: {content}");
        }
    }

    static void SearchItemFlow()
    {
        Console.Write("Enter item to search: ");
        string searchItem = Console.ReadLine();

        bool found = false;
        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i] != null && inventory[i].Equals(searchItem, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"{searchItem} found in slot {i}.");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine($"{searchItem} not found in inventory.");
        }
    }

    static void CountItems()
    {
        int count = 0;
        foreach (var item in inventory)
        {
            if (item != null) count++;
        }
        Console.WriteLine($"You have {count} item(s) in your inventory.");
    }
}
