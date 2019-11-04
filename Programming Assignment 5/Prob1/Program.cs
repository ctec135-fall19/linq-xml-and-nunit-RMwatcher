/*
Author: Richard Mora
Date: 11/1/2019
CTEC 135: Microsoft Software Development with C#

Programming Assignment 5: LINQ and Unit Testing

Prob1: LINQ

Create a static method then creates an array of strings (the order of the 
    string should be random.

Create a LINQ statement that returns the strings which starts with "a" 
    through "f" then output the result.

Modify the same array so the results will be different then output the 
    result again.

Modifty the same array again so once again the results of the array will 
    be different.

This time capture the result as a List<string> object, return it then in 
    Main(), output the returned result.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here I called the QueryOverFruit() method I created outside
            // Main further down this file.
            QueryOverFruit();

            // I created a new List<string> object called basket which has the
            // value of the QueryOverFruit() method and any data it has onto
            // the basket object
            List<string> basket = QueryOverFruit();

            // This foreach loop takes the object basket, create a string 
            // object item and print out each item inside of basket, which
            // happens to have the value of QueryOverFruit() method, one at 
            // at time
            foreach (string item in basket)
            {
                Console.WriteLine("Fruits: {0}", item);
            }
            Console.WriteLine();
        }

        // here I created a List of strings as part of a method I created 
        // named QueryOverFruit() method.
        static List<string> QueryOverFruit()
        {
            // Here I created a string array called FruitTitles and added 
            // six items into the list consists of strings
            string[] FruitTitles = {"dates", "figs", "apple", "strawberry",
            "banana", "kiwi"};

            // Here I created a object called subset using the var keyword.
            // I used LINQ syntax to select each item from the array 
            // FruitTitles where I use a where keyword to select strings from
            // the FruitTitles array where that string starts with either
            // the letter a, b, c, d, e, and f, and ordered them alphabetically
            var subset = from titles in FruitTitles
                         where titles.StartsWith("a")
                               || titles.StartsWith("b")
                               || titles.StartsWith("c")
                               || titles.StartsWith("d")
                               || titles.StartsWith("e")
                               || titles.StartsWith("f")                               
                         orderby titles
                         select titles;

            Console.WriteLine("List of original fruits");

            // Here I create a foreach loop that takes each item from subset
            // the object I created adove that has a list of strings that 
            // starts with a through f while creating a object fruit.
            foreach (var fruit in subset)
            {
                // This line prints out each item from the subset object
                // which contains the array of strings from FruitTitles and
                // prints out one item at a time depending on whether they 
                // match the conditions of the where statement.
                Console.WriteLine("Fruits: {0}", fruit);
            }
            Console.WriteLine();

            // I select a string from the array FruitTitles with an index of
            // 5 and replace it with another string "beets".
            FruitTitles[5] = "beets";

            Console.WriteLine("original fruits after change");
            // This foreach loop is the same as the one adove while the only
            // differences is since I change one of the strings eariler, it'll
            // reflect that change when it prints out each item inside this 
            // loop. 
            foreach (var fruit in subset)
            {
                // This prints out each item from subset which takes the same
                // items from the string array FruitTitles after going through
                // a LINQ query.
                Console.WriteLine("Fruits: {0}", fruit);
            }
            Console.WriteLine();

            // The following two lines of code is where I selected two items
            // from the FruitTitles array, select a certain index from the 
            // same array ([0] and [3]) and replaced that string with a new
            // string I came up with.
            FruitTitles[0] = "fruit";
            FruitTitles[3] = "chocolate";

            Console.WriteLine("Fruits executed in a List");
            // for this LINQ query is similar from the previous query except
            // BasketOfFruit acts as a List<string> instead of a var, 
            // surrounded by parenthese, have the same where statements and
            // orderby and select statements with the differents is I used the
            // method ToList<string>() to have LINQ to move the results from 
            // this query and move it to a List<string> once it finished with
            // the query
            List<string> BasketOfFruit = (from item in FruitTitles
                                          where item.StartsWith("a")
                                               || item.StartsWith("b")
                                               || item.StartsWith("c")
                                               || item.StartsWith("d")
                                               || item.StartsWith("e")
                                               || item.StartsWith("f")
                                          orderby item
                                          select item).ToList<string>();

            // towards the end of this method, I have the QueryOverFruit() 
            // method return the object BasketOfFruit after it ran through
            // the LINQ query and the results return back to BasketOfFruit 
            // object and display the results it got when QueryOverFruit()
            // method got called from main().
            return BasketOfFruit;
        }
    }
}
