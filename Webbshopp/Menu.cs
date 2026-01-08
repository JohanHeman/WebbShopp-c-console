using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowDemo;

namespace Webbshopp
{
    internal class Menu
    {
        public enum HomeEnums
        {
            Customer_menu = 1,
            Admin
        }

        public enum customerEnums
        {
            home_page = 1,
            shopp,
            checkout
        }

        public static void StartMenu()
        {
            // later in this the names of the books will be from the database, isDeal= true

            List<string> welcomeText = new List<string> { "Welcome to the Book store. ", "We provide books" };

            Window windowStart = new Window("The Book Shop", 37, 0, welcomeText);
            windowStart.Draw();

            List<string> dealOne = new List<string> { "Book name 1", "Author", "Press p to purchase" };
            var dealOneWindow = new Window("Deal 1", 10, 5, dealOne);
            dealOneWindow.Draw();

            List<string> dealTwo = new List<string> { "Book name 2", "Author", "Press p to purchase" };
            var dealTwoWindow = new Window("Deal 2", 40, 5, dealTwo);
            dealTwoWindow.Draw();

            List<string> dealThree = new List<string> { "Book name 3", "Author", "Press p to purchase" };
            var dealThreeWindow = new Window("Deal 3", 70, 5, dealThree);
            dealThreeWindow.Draw();

            List<string> menuChoices = Helpers.EnumsToLists(typeof(HomeEnums));

            var menuWindow = new Window("Menu", 2, 0, menuChoices);
            menuWindow.Draw();

            // make a switch statement that also handles errors for the enum menu 


            ConsoleKeyInfo key = Console.ReadKey(true);
            if(int.TryParse(key.KeyChar.ToString(), out int input))
            {
                switch ((HomeEnums)input)
                {
                    case HomeEnums.Customer_menu:
                        CustomerMenu();
                        break;
                }
            }
        }

        public static void CustomerMenu()
        {
            Console.Clear();
            List<string> customerChoices = Helpers.EnumsToLists(typeof(customerEnums));

            var window = new Window("CustomerMenu", 2, 0, customerChoices);
            window.Draw();
            
        }
    }
}
