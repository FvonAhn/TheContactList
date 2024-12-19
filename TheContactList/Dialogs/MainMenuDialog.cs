using Business.Models;
using System.Security.Cryptography;

namespace TheContactList.Dialogs;
public class MainMenuDialog
{
    public static void MainMenu()
    {
        Console.WriteLine("Welcome!");
        Console.ReadKey();

        while (true) 
        {
            Console.Clear();
            Console.WriteLine("----------- Menu -----------");
            Console.WriteLine($"{"",-5}1. New Contact.");
            Console.WriteLine($"{"",-5}2. Update Contact.");
            Console.WriteLine($"{"",-5}3. Remove Contact.");
            Console.WriteLine($"{"",-5}4. Show All Contacts.");
            Console.WriteLine($"{"",-5}Q. Close Applicaton.");
            Console.WriteLine("----------------------------");
            TheSwitch();           
            Console.ReadKey();
        }

    }

    public static void TheSwitch()
    {
        string answer = Console.ReadLine()!;

        switch (answer.ToLower())
        {
            case "1":
                NewContact();
                break;
            case "2":
                UpdateContact();
                break;
            case "3":
                RemoveContact();
                break;
            case "4":
                ShowContacts();
                break;
            case "q":
                QuitApp();
                break;
            default:
                break;
        }
    }

    public static void NewContact()
    {
        bool isTrue = true;
        while (isTrue) 
        {
            var contact = new ContactForm();
            Console.Clear();
            Console.Write("First Name: ");
            contact.FirstName = Console.ReadLine()!;
            Console.Write("Last Name: ");
            contact.LastName = Console.ReadLine()!;
            Console.Write("Adress: ");
            contact.Adress = Console.ReadLine()!;
            Console.Write("Postal Code: ");
            contact.PostalCode = Console.ReadLine()!;
            Console.Write("City: ");
            contact.City = Console.ReadLine()!;
            Console.Write("Email: ");
            contact.Email = Console.ReadLine()!;
            Console.Write("Phone: ");
            contact.Phone = Console.ReadLine()!;
            isTrue = false;
        }
    }

    public static void UpdateContact()
    {
        bool isTrue = true;
        while (isTrue)
        {
            Console.Clear();
            Console.WriteLine("What Contact would you like to update?");
            Console.ReadKey();
            isTrue = false;
        }
    }

    public static void RemoveContact()
    {
        bool isTrue = true;
        while (isTrue)
        {
            Console.Clear();
            Console.WriteLine("What Contact would you like to remove?");
            Console.ReadKey();
            isTrue = false;
        }
    }

    public static void ShowContacts()
    {
        var contacts = new Contact();
        Console.Clear();
        Console.WriteLine("----------- Contacts ----------");
        Console.WriteLine($"{contacts.FullName}");
        Console.ReadKey();
    }

    public static void QuitApp()
    {
        Console.Clear();
        Console.WriteLine("Are you sure you want to quit?");
        Console.WriteLine($"{"",-11}Y / N");
        var quitAppAnswer = Console.ReadLine()!;

        if (quitAppAnswer.ToLower() == "y")
        {
            Console.Clear();
            Console.WriteLine("Goodbye!");
            Console.ReadKey();
            Console.Clear();
            Environment.Exit(0);
        }
    }
}
