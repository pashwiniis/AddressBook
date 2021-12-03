﻿
using AddressDemo;
using System;
using System.Collections.Generic;

class AddressPrompt
{
    AddressBook book;

    public AddressPrompt()
    {
        book = new AddressBook();
    }

    public static void Main(string[] args)
    {
        //string selection = "";
       int choice =0 ;
        AddressPrompt prompt = new AddressPrompt();
       // var continue = "y";
        prompt.displayMenu();
        while (choice!=5)
        {
            Console.WriteLine("Select your choice");
            choice = Convert.ToInt32(Console.ReadLine());
            prompt.performAction(choice);
        }
    }

    void displayMenu()
    {
        Console.WriteLine("Main Menu");
        Console.WriteLine("=========");
        Console.WriteLine("1. - Add an Address");
        Console.WriteLine("2. - Edit the Addresses");
        Console.WriteLine("3. - Quit");
    }

    void performAction(int choice)
    {
        string firstName = "";

        string lastName = "";
         string address = "";
        string phoneNumber = "";
        string city = "";
        string state = "";
        string zipCode = "";
        string emailId = "";

        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter First Name: ");
                firstName = Console.ReadLine();
                Console.WriteLine("Enter Last Name: ");
                lastName = Console.ReadLine();
                Console.WriteLine("Enter Address: ");
                address = Console.ReadLine();
                Console.WriteLine("Enter PhoneNumber: ");
                phoneNumber = Console.ReadLine();
                Console.WriteLine("Enter the city name: ");
                city = Console.ReadLine();
                Console.WriteLine("Enter the State: ");
                state = Console.ReadLine();
                Console.WriteLine("Enter the Zipcode");
                zipCode = Console.ReadLine();
                Console.WriteLine("Enter the EmailId");
                emailId = Console.ReadLine();
                if (book.add(firstName, lastName, address, phoneNumber, city, state, zipCode, emailId))
                {
                    Console.WriteLine("Address successfully added!");
                }
                else
                {
                    Console.WriteLine("An address is already on file for {0}.", firstName);
                }
                break;
            case 2:
                Console.WriteLine("Enter Name to Edit: ");
               firstName = Console.ReadLine();
                Address addr = book.find(firstName);
                if (addr == null)
                {
                   Console.WriteLine("Address for {0} count not be found.", firstName);
                }
                else
                {
                     Console.WriteLine("Enter new Address: ");
                    addr.address = Console.ReadLine();
                    Console.WriteLine("Address updated for {0}", firstName);
                }
                break;

            default:
                Console.WriteLine("ReEnter the Choice");
                break;
        }
    }
}