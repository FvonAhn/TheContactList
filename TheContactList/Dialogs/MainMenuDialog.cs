using Business.Interfaces;
using Business.Models;
using Business.Services;
using System.Security.Cryptography;

namespace TheContactList.Dialogs;
public class MainMenuDialog
{
    private readonly ContactService _contactService = new();

    public void MainMenu()
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

    public void NewContact()
    {

            var contact = new ContactForm();
            Console.Clear();
            Console.Write("Enter your first name: ");
            contact.FirstName = Console.ReadLine()!;
            Console.Write("Enter your last name: ");
            contact.LastName = Console.ReadLine()!;
            Console.Write("Enter your adress: ");
            contact.Adress = Console.ReadLine()!;
            Console.Write("Enter the postal code: ");
            contact.PostalCode = Console.ReadLine()!;
            Console.Write("Enter what city: ");
            contact.City = Console.ReadLine()!;
            Console.Write("Enter your email: ");
            contact.Email = Console.ReadLine()!;
            Console.Write("Enter your phonenumber: ");
            contact.Phone = Console.ReadLine()!;

            _contactService.Add(contact);
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

    public void ShowContacts()
    {

        Console.Clear();
        foreach (var contacts in _contactService.GetContacts()) 
        {
            Console.WriteLine("----------- Contact ----------");
            Console.WriteLine($"{"Name:",-5}{contacts.FullName}");
            Console.WriteLine($"{"Name:",-5}{contacts.FullAdress}");
            Console.WriteLine($"{"Name:",-5}{contacts.City}");
            Console.WriteLine($"{"Name:",-5}{contacts.Email}");
            Console.WriteLine($"{"Name:",-5}{contacts.Phone}");
            Console.WriteLine("------------------------------");
            Console.WriteLine("");
        }
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
            Environment.Exit(0);
        }
    }
}
