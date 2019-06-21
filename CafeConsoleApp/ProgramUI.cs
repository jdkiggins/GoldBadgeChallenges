using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekThreeChallenges_01;

namespace CafeConsoleApp
{
    public class ProgramUI
    {
        private CafeRepository _listOfMenuItems = new CafeRepository();
        public void Run()
        {
            SeedContentList();
            RunMenu();
        }
        private void RunMenu()
        {
            bool continueToRunMenu = true;
            while (continueToRunMenu)
            {
                Console.Clear();
                Console.WriteLine("What would you like to order?\n" +
                    "1. Show Menu\n" +
                    "2. Add Item To Menu\n" +
                    "3. Remove Item From Menu\n" +
                    "4. Exit\n");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        ShowAllMenuItems();
                        break;

                    case "2":
                        AddMenuItemToList();
                        break;

                    case "3":
                        RemoveMenuItemFromList();
                        break;

                    case "4":
                        continueToRunMenu = false;
                        break;

                    default:
                        Console.WriteLine("Please Enter a Valid Number Between 1-4\n" +
                            "Press Any Key To Contine");
                        Console.ReadKey();
                        break;
                }
            }
        }
        private void ShowAllMenuItems()
        {
            List<CafeMenu> listOfMenuItems = _listOfMenuItems.GetMenuItems();

            foreach (CafeMenu content in listOfMenuItems)
            {
                Console.WriteLine($"{content.MealNumber}. {content.TypeOfOrder}\n ${content.CostOfItem}\n {content.Description}");
            }
            Console.WriteLine("Press Any Key to Continue");
            Console.ReadKey();
        }

        private void AddMenuItemToList()
        {
            CafeMenu content = new CafeMenu();

            Console.WriteLine("What Menu Number is This?");
            content.MealNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the New Item's Name");
            content.TypeOfOrder = Console.ReadLine();

            Console.WriteLine("How Much Does This Item Cost? ");
            content.CostOfItem = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the Desctription of the Item? ");
            content.Description = Console.ReadLine();

            Console.WriteLine("What are the Ingredients in this Item? ");
            content.Ingredients = Console.ReadLine();
        }
        private void RemoveMenuItemFromList()
        {
            Console.WriteLine("Which item would you like to remove?");
            int count = 0;
            List<CafeMenu> contentList = _listOfMenuItems.GetMenuItems();
            foreach (CafeMenu content in contentList)
            {
                count++;
                Console.WriteLine($"{count}. {content.TypeOfOrder}");
            }

            int contentNumber = int.Parse(Console.ReadLine());
            int contentIndexNumber = contentNumber - 1;
            if (contentIndexNumber >= 0 && contentIndexNumber < contentList.Count)
            {
                CafeMenu desiredContent = contentList[contentIndexNumber];
                if (_listOfMenuItems.RemoveMenuItemFromList(desiredContent))
                {
                    Console.WriteLine($"{desiredContent.TypeOfOrder} successfully removed");
                }
                else
                {
                    Console.WriteLine("404 Menu Item Not Found");
                }
            }
            else
            {
                Console.WriteLine("No content has that ID.");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private void SeedContentList()
        {
            CafeMenu hamburger = new CafeMenu(1, "Hamburger", "A Classic Hamburger, can never go wrong with it!", "Bun, Hamburger Patty, Ketchup, Lettuce", 5.49d);
            CafeMenu hotDog = new CafeMenu(2, "Hot Dog", "All American Hot Dog, perfect for Baseball Games!", "Bun, Hot Dog, Ketchup, Mustard, Relish", 4.50d);
            CafeMenu salad = new CafeMenu(3,"Salad", "Healthy Option", "Lettuce, Onion, Tomato, Cheese, Ranch or Ceaser Salad", 7.35d);
            CafeMenu steakPotato = new CafeMenu(4, "Steak and Potato", "Fancy Meal Cooked How You Want It", "Steak, Potato, Cheese", 12.34d);
            CafeMenu mangoSmoothie = new CafeMenu(5, "Mango Smoothie", "Sweet and Cold and nice to drink on a hot summer day", "Ice, Mango, Sweetner", 3.12d);
            CafeMenu cokeDrink = new CafeMenu(6, "Coke", "Coke", "Coke", 1.25d);
            CafeMenu chickenSandwich = new CafeMenu(7, "Chicken Sandwich", "Chicken Sandwich", "Chicken Sandwich", 5.68d);
            CafeMenu chickenStrips = new CafeMenu(8, "Chicken Strips", "Chicken Strips", "Chicken Strpis", 5.30d);
            CafeMenu brisket = new CafeMenu(9, "Brisket", "Brisket", "Brisket", 13.78d);
            CafeMenu pizza = new CafeMenu(10, "Pizza", "Pizza", "Pizza Stuff", 14.55d);

            _listOfMenuItems.AddMenuItemToList(hamburger);
            _listOfMenuItems.AddMenuItemToList(hotDog);
            _listOfMenuItems.AddMenuItemToList(salad);
            _listOfMenuItems.AddMenuItemToList(steakPotato);
            _listOfMenuItems.AddMenuItemToList(mangoSmoothie);
            _listOfMenuItems.AddMenuItemToList(cokeDrink);
            _listOfMenuItems.AddMenuItemToList(chickenSandwich);
            _listOfMenuItems.AddMenuItemToList(chickenStrips);
            _listOfMenuItems.AddMenuItemToList(brisket);
            _listOfMenuItems.AddMenuItemToList(pizza);
        }
    }
}
