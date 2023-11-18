using System;
using System.Collections;
using Collections_Practice.Controllers;

#region Homework Practice
//AuthorController authorController = new();
//EmployeeController employeeController = new();
AccountController accountController = new();
ProductController productController = new();


//authorController.GetAllByAge();
//employeeController.GetCountByFilter();



var res = accountController.Login();
if (res)
{
    while (true)
    {
        Console.WriteLine("Select option 1 - GetAllProducts, 2 - Search products by name");
    Option: string option = Console.ReadLine();

        int resultOption;

        bool isCorrectFormatOption = int.TryParse(option, out resultOption);

        if (isCorrectFormatOption)
        {
            switch (resultOption)
            {
                case 1:
                    productController.GetAll();
                    break;

                case 2:
                    productController.Search();
                    break;

                default:
                    Console.WriteLine("Option format not found, please select again:");
                    goto Option;
            }
        }
        else
        {
            Console.WriteLine("Option format is wrong, please select again:");
            goto Option;
        }
    }
}
#endregion





//Hashtable hashtable = new Hashtable();

//hashtable.Add (1, "salam");
//hashtable.Add (2, "salam");

//foreach (DictionaryEntry item in hashtable)
//{
//    Console.WriteLine(item);
//}





//SortedList sortedList = new();

//sortedList.Add("a", "salam");
//sortedList.Add("b", "hello");

//foreach (DictionaryEntry item in sortedList)
//{
//    Console.WriteLine(item);
//}




//SortedList<int, string> datas = new();

//datas.Add (1, "telefonla");
//datas.Add(2, "oynama");

//foreach (KeyValuePair<int,string> data in datas)
//{
//    Console.WriteLine(data.Key + " - " + data.Value );
//}




//Dictionary<int, string> roles = new();

//roles.Add (1, "admin");
//roles.Add (2, "member");

//foreach (KeyValuePair<int,string> item in roles)
//{
//    Console.WriteLine(item.Value);
//}



//List<string> roles = new() { "Admin", "Member", "SuperAdmin" };
//List<string> emails = new() { "t@gmail.com", "s@gmail.com", "m@gmail.com" };



//Dictionary<string, List<string>> datas = new();

//datas.Add("roles", roles);
//datas.Add("emails", emails);

//foreach (var item in datas)
//{
//    if(item.Key == "roles")
//    {
//        foreach (var role in item.Value)
//        {
//            if (role == "Admin")
//            {
//                Console.WriteLine(role);
//            }
//        }
//    }
//}
