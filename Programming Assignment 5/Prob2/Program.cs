/*
Author: Richard Mora
Date:10/31/2019
CTEC 135: Microsoft Software Development with C#

Programming Assignment 5: LINQ and Unit Testing

Prob2: XML using LINQ

First start off by creating a static method that calls other methods you created 
    below.

Create a static method that creates an XML document and save it.

Create anothe static method that creates another XML document from an array 
    and save it as well.

Create a third static method that loads an XML document (you can use the 
    second document you created with the arrays and print it out on screen.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// here I use System.Xml, Xml,Linq and static System.Console to add some 
// features to this class page. Xml let me create XML documents, Xml.Linq 
// let me create XML documents using LINQ syntax and create it just like I 
// would create using the XML syntax and System.Console allows me to write
// code like Console.WriteLine(); without having to type Console at the 
// beginnning of Console.WriteLine().
using System.Xml;
using System.Xml.Linq;
using static System.Console;

namespace Prob2
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildListFromArray();
            PrintRestaurantMenu();
        }            

        // Here I create a public static void method() called BuildGameList.
        public static void BuildGameList()
        {
            // Here I created a new XML document called GameList where I 
            // declare some code to help set up this document, added some 
            // comments as well as some new elements called Inventory and 
            // Game. I took the element Game and gave it some attributes with
            // XAttribute keyword along with some strings. I also created 
            // some more elements that help describe what this item is (a game
            // ). I also added a new Game element with attributes of it's own
            // similar to the first element.
            XDocument GameList =
                new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XComment("List of Games currently in stock"),
                    new XElement("Inventory",
                     new XElement("Game", new XAttribute("Rating", "M"),
                        new XElement("Title", "Persona 5"),
                        new XElement("Number of players", "one"),
                        new XElement("System", "PS4")
                        ),
                     new XElement("Game", new XAttribute("Rating", "E"),
                        new XElement("Title", "MegaMan"),
                        new XElement("Number of players", "one"),
                        new XElement("System", "Snes")
                        )
                     )
                    );

            // this line simply same the object GameList that acts as the XML
            // document, use the method Save with "ListOfGames.xml" as a 
            // argument as the file name of GameList.
            GameList.Save("ListOfGames.xml");

        }

        // Here I created a static void method called BuildListFromArray().
        static void BuildListFromArray()
        {
            // I use the var keyword to create a new object buffet that holds
            // a array of items which are defined below.
            var buffet = new[]
            {
                // Here I created new key/values pairs data inside the buffet 
                // array where FoodItem, Servings and Rating acts as keys 
                // while anything after the = sign are the values.
                new { FoodItem = "pizza", Servings = 6, Rating = 7 },
                new { FoodItem = "Hambuger", Servings = 1, Rating = 6 },
                new { FoodItem = "Hot Dog", Servings = 1, Rating = 6 },
                new { FoodItem = "Fried Chicken", Servings = 4, Rating = 5 },
                new { FoodItem = "Caesar Salad", Servings = 3, Rating = 6 },
                new { FoodItem = "Fried Rice", Servings = 2, Rating = 8 }
            };

            // Here I created a new element or XML document using LINQ query 

            // syntax called MenuDoc and within MenuDoc I created another 
            // element called Menu. For this query, I refered to buffet or  
            // the array I created and refer to each item as item. For the  
            // select I created a new element Food which have an attribute  
            // Servings that has a value of item and the value of the object 
            // Servings on the buffet array which is an int data type. The 
            // same thing is done to each of the key/value pairs inside 
            // buffet where FoodItem and Rating are new elements and 
            // item.FoodItem and item.Rating are values associated with each
            // element. This query goes through each item inside of buffet 
            // array and selects them.
            XElement MenuDoc =
                new XElement("Menu",
                 from item in buffet
                 select new XElement("Food", new XAttribute("Servings", item.Servings),
                    new XElement("FoodItem", item.FoodItem),
                    new XElement("Rating", item.Rating))
                 );

            // Afterwords, I take MenuDoc from eariler, use the method Save()
            // to save the XML document MenuDoc and named it RestaurantMenu.
            // xml
            MenuDoc.Save("RestaurantMenu.xml");
        }

        // Here I created a static void method called PrintRestaruantMenu().
        static void PrintRestaurantMenu()
        {
            // I created a new Document object MyMenu and give it a value 
            // of XDocunemt.Load("RestaurantMenu.xml") where this loads the
            // xml document RestaruantMenu and put it inside MyMeny as a value
            // so MyMenu acts as opening the xml file.
            XDocument MyMenu = XDocument.Load("RestaurantMenu.xml");
            WriteLine("MyMenu\n");

            // I created a new object using the var keyword called LunchItem
            // and as a value wrote a LINQ query where I use the data from 
            // MyMenu (which is the xml document) and use the Descendants()
            // method to find a sub element of MyMenu and rearrange those
            // items. For example, Menu is the first element you encounter
            // while after that is the Food element, this is what we want.
            var LunchItem = from order in MyMenu.Descendants("Food")
                            select order;

            // Here I created a foreach loop where it takes each item or the
            // object lunch to select each item inside LunchItem and I have
            // each item print out each item that's inside the element Food
            foreach (var lunch in LunchItem)
            {
                // Since I'm using System.Console at the top of this file
                // I don't have to type Console at the beginning of 
                // WriteLine();
                WriteLine(lunch);
            }
        }
    }
}
