using System;

class ParkingLot
{
    static void Main()
    {
        string[] slots = new string[10];
        int choice;

        do
        {
            Console.WriteLine("--- Parking Lot Menu ---");
            Console.WriteLine("1 → Park a Car");
            Console.WriteLine("2 → Remove a Car");
            Console.WriteLine("3 → View All Slots");
            Console.WriteLine("4 → Search for a Car");
            Console.WriteLine("5 → Exit");
            Console.Write("Choose an option: ");
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter car license number to park: ");
                    string license = Console.ReadLine();

                    if (Array.Exists(slots, x => x == license))
                    {
                        Console.WriteLine("Car already parked.");
                        break;
                    }

                    bool parked = false;
                    for (int i = 0; i < slots.Length; i++)
                    {
                        if (string.IsNullOrEmpty(slots[i]))
                        {
                            slots[i] = license;
                            Console.WriteLine($"Car parked at slot {i + 1}.");
                            parked = true;
                            break;
                        }
                    }

                    if (!parked)
                        Console.WriteLine("Parking lot is full.");
                    break;

                case 2:
                    Console.Write("Enter license number to remove: ");
                    string removeLicense = Console.ReadLine();
                    bool removed = false;
                    for (int i = 0; i < slots.Length; i++)
                    {
                        if (slots[i] == removeLicense)
                        {
                            slots[i] = null;
                            Console.WriteLine("Car removed from slot " + (i + 1));
                            removed = true;
                            break;
                        }
                    }

                    if (!removed)
                        Console.WriteLine("Car not found.");
                    break;

                case 3:
                    Console.WriteLine("\nParking Slots:");
                    for (int i = 0; i < slots.Length; i++)
                    {
                        string status = string.IsNullOrEmpty(slots[i]) ? "Empty" : slots[i];
                        Console.WriteLine($"Slot {i + 1}: {status}");
                    }
                    break;

                case 4:
                    Console.Write("Enter license number to search: ");
                    string search = Console.ReadLine();
                    bool found = false;
                    for (int i = 0; i < slots.Length; i++)
                    {
                        if (slots[i] == search)
                        {
                            Console.WriteLine($"Car found in slot {i + 1}.");
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                        Console.WriteLine("Car not found.");
                    break;

                case 5:
                    Console.WriteLine("Exiting Parking System.");
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

        } while (choice != 5);
    }
}
