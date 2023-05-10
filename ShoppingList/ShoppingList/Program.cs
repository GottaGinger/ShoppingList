
using System.Numerics;

Dictionary<string, double> menuItems = new Dictionary<string, double>()
{
    {"apple", 0.99 },
    {"banana", .59 },
    {"cauliflower", 1.59 },
    {"dragonfruit", 2.19 },
    {"elderberry", 1.79 },
    {"figs", 2.09 },
    {"grapefruit", 1.99 },
    {"honeydew", 3.49 } 

};

List<string> shoppingList = new List<string>(); 
bool keepShopping = false;
string continueQuestion = "";
Console.WriteLine("Welcome to the market!");

do
{
    keepShopping = false;
    Console.WriteLine("What item would you like to order?");
    printMenu(menuItems);

    string input = Console.ReadLine();

    if (menuItems.ContainsKey(input))
    {
        shoppingList.Add(input);
        Console.WriteLine($"Added {input} to the cart for {menuItems[input]}");
        Console.WriteLine("Do you want to continue? y/n");
        continueQuestion = Console.ReadLine();
        if (continueQuestion.Equals("y"))
        {
            keepShopping = true;
        }
        else
        {
            Console.WriteLine("You have ordered:");
            foreach(string item in shoppingList)
            {
                Console.WriteLine($"{item}");
            }
            orderSum(menuItems,shoppingList);
        }
    }
    else
    {
        Console.WriteLine("That item does not exist.");
        keepShopping = true;
    }

} while (keepShopping);


static void printMenu(Dictionary<string,double> menuItems)
{
    Console.WriteLine("Item\tPrice"); // prints out the menu
   foreach(string key in menuItems.Keys)  
    {
        Console.WriteLine($"{key}  {menuItems[key]}") ;
    }
}
 

 static void orderSum(Dictionary<string, double> menuItems, List<string> shoppingList)
{  
    double sum = 0;
    foreach (string item in shoppingList)
    {
        sum += menuItems[item];
    }
    Console.WriteLine($"Your total is: ${sum}");

}