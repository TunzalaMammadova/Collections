using System.Numerics;
using Collections_Homework;
using Domain.Models;
using static System.Collections.Specialized.BitVector32;

List<Person> persons = new();

PersonController personController = new();

string option;

do
{
    Console.WriteLine("1.Save Phone Number :");
    Console.WriteLine("2.Delete Phone Number :");
    Console.WriteLine("3.Update Phone Number :");
    Console.WriteLine("4.Guide Listing(A - Z, Z - A selection) :");
    Console.WriteLine("5.Search in Contacts :");

    Console.WriteLine("\n Please select options :");
    option = Console.ReadLine();

    switch (option)
    {
        case "1":
            personController.GetAll();
            break;
        case "2":
            personController.Delete();
            break;


        default:

            break;
    }





} while (option != " ");