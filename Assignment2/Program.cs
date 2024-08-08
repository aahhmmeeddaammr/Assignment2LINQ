using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using static Assignment2.ListGenerators;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Assignment2
{
    public class MyCompare: IComparer<string>
    {
        public int Compare(string x, string y)
        {
            var sortedX = System.String.Concat(x.OrderBy(c => c));
            var sortedY = System.String.Concat(y.OrderBy(c => c));
            return System.String.Compare(sortedX, sortedY);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ- Element Operators
            #region  1. Get first Product out of Stock
            //var Result = ProductList.FirstOrDefault();
            //Console.WriteLine(Result);
            #endregion

            #region  2. Return the first product whose Price > 1000, unless there is no match, in which case null isreturned.

            //var Result = ProductList.FirstOrDefault((P) => P.UnitPrice > 1000, null);
            //Console.WriteLine(Result);

            #endregion

            #region  3. Retrieve the second number greater than 5
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Where(n => n > 5).ElementAt(1);
            //Console.WriteLine(Result);

            #endregion


            #endregion

            #region  LINQ- Aggregate Operators

            #region  1. Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Count(n => n % 2 == 1);
            //Console.WriteLine(Result);
            #endregion

            #region  2. Return a list of customers and how many orders each has. 
            //var Result = CustomerList.Select(C => new { C.CustomerID, C.CustomerName, NumberOfOrders = C.Orders.Count() });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region  3. Return a list of categories and how many products each has
            //var Result = from p in ProductList
            //             group p by p.Category
            //             into pc
            //             select new {Category =  pc.Key , NoOfProducts = pc.Count()};
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region  4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Sum(x => x);
            //Console.WriteLine(Result);

            #endregion

            #region  5. Get the total number of characters of all words in dictionary_english.txt (Readdictionary_english.txt into Array of String First).

            //string[] lines = File.ReadAllLines("dictionary_english.txt");

            //var result = lines.Select(x => x.Length);
            //Console.WriteLine(result.Sum(x => x));


            #endregion

            #region  6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txtinto Array of String First).
            //string[] lines = File.ReadAllLines("dictionary_english.txt");
            //var Result = lines.Select(x => x.Length);
            //Console.WriteLine(Result.Min());

            #endregion

            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txtinto Array of String First).
            //string[] lines = File.ReadAllLines("dictionary_english.txt");
            //Console.WriteLine(lines.Max(X=>X.Length));
            #endregion

            #region  8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txtinto Array of String First). 
            //string[] lines = File.ReadAllLines("dictionary_english.txt");
            //Console.WriteLine(lines.Average(X => X.Length));
            #endregion

            #region  9. Get the total units in stock for each product category.

            //var Result = ProductList.Select(p => new { p.Category, p.UnitsInStock});
            //var result = Result.GroupBy(p => p.Category).Select(pc => new { pc.Key , UnitsInStock = pc.Sum(p=>p.UnitsInStock) });
            ///OR
            //var result = from p in ProductList 
            //             group p by p.Category
            //             into pc 
            //             select new { pc.Key , UnitsInStock = pc.Sum(p=>p.UnitsInStock)};

            //foreach ( var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region  10. Get the cheapest price among each category's products

            //var result = from p in ProductList
            //             group p by p.Category
            //             into pc
            //             select new { pc.Key, minprice = pc.Min(p => p.UnitPrice) };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region  11. Get the products with the cheapest price in each category (Use Let)

            //var result = from p in ProductList
            //             group p by p.Category
            //             into pc
            //             let cp = pc.Min(p => p.UnitPrice)
            //             select new
            //             {
            //                 pc.Key,
            //                 product = (
            //             from pp in ProductList
            //             where pp.Category == pc.Key
            //             where pp.UnitPrice == cp
            //             select pp)
            //             };
            //foreach (var p in result)
            //{
            //    Console.WriteLine(p.Key);
            //    foreach (var item in p.product)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Console.WriteLine("========================================================================================================");
            //}
            #endregion

            #region  12. Get the most expensive price among each category's products.
            //var result = from p in ProductList
            //             group p by p.Category
            //             into pc
            //             select new { pc.Key, minprice = pc.Max(p => p.UnitPrice) };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region  13. Get the products with the most expensive price in each category.
            //var result = from p in ProductList
            //             group p by p.Category
            //             into pc
            //             let cp = pc.Max(p => p.UnitPrice)
            //             select new
            //             {
            //                 pc.Key,
            //                 product = (
            //             from pp in ProductList
            //             where pp.Category == pc.Key
            //             where pp.UnitPrice == cp
            //             select pp)
            //             };
            //foreach (var p in result)
            //{
            //    Console.WriteLine(p.Key);
            //    foreach (var item in p.product)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Console.WriteLine("========================================================================================================");
            //}


            #endregion

            #region  14. Get the average price of each category's products.
            //var result = from p in ProductList
            //             group p by p.Category
            //             into pc
            //             select new { pc.Key, minprice = pc.Average(p => p.UnitPrice) };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion


            #endregion

            #region  LINQ- Set Operators

            #region  1. Find the unique Category names from Product List

            //var Result = ProductList.Select(x => x.Category).Distinct();
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region  2. Produce a Sequence containing the unique first letter from both product and customernames.

            //var result1 = ProductList.Select(x => x.ProductName[0]);
            //var result2 = CustomerList.Select(x => x.CustomerName[0]);
            //var Result = result1.Union(result2);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region 3. Create one sequence that contains the common first letter from both product andcustomer names.
            //var result1 = ProductList.Select(x => x.ProductName[0]);
            //var result2 = CustomerList.Select(x => x.CustomerName[0]);
            //var Result = result1.Intersect(result2);
            //foreach (var result in Result)
            //{
            //    Console.WriteLine(result);
            //}

            #endregion

            #region  4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var result1 = ProductList.Select(x => x.ProductName[0]);
            //var result2 = CustomerList.Select(x => x.CustomerName[0]);
            //var Result = result1.Except(result2);
            //foreach (var result in Result) {
            //    Console.WriteLine(result);
            //}
            #endregion

            #region  5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var result1 = ProductList.Select(x => x.ProductName.Length>3?x.ProductName.Substring(x.ProductName.Length-3):"");
            //var result2 = CustomerList.Select(x => x.CustomerName.Length > 3 ? x.CustomerName.Substring(x.CustomerName.Length - 3) : "");
            //var Result = result1.Concat(result2);
            //foreach (var result in Result)
            //{
            //    Console.WriteLine(result);
            //}

            #endregion

            #endregion

            #region  LINQ- Partitioning Operators

            #region  1. Get the first 3 orders from customers in Washington

            //var Result = ProductList.Take(3);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 2. Get all but the first 2 orders from customers in Washington.

            //var Result = CustomerList.Where(c => c.Address == "Washington").Select(c=>c.Orders).Skip(2);
            //foreach (var result in Result)
            //{
            //    Console.WriteLine(result);
            //}

            #endregion

            #region  3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.TakeWhile((n, i) => n >= i);
            //foreach ( var i in result)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region 4.Get the elements of the array starting from the first element divisible by 3
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile(x => x%3 !=0);
            //foreach(int x in result)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion

            #region  5. Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile((x,i) => x>i);
            //foreach (int x in result)
            //{
            //    Console.WriteLine(x);
            //}


            #endregion

            #endregion

            #region  LINQ- Quantifiers

            #region  1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

            //string[] lines = File.ReadAllLines("dictionary_english.txt");

            //bool Result = lines.All((x) => x.Contains( "ei"));

            //Console.WriteLine(Result);

            #endregion

            #region  2. Return a grouped a list of products only for categories that have at least one product that is out of stock.

            //var result2 = ProductList.GroupBy(p => p.Category)
            //.Where(g => g.Any(p => p.UnitsInStock==0))
            //.Select(g => new
            //{
            //    Category = g.Key,
            //    Products = g.ToList()
            //});
            //foreach (var item in result2)
            //{
            //    foreach (var item2 in item.Products)
            //    {

            //    Console.WriteLine(item2);
            //    }
            //}

            #endregion

            #region  3. Return a grouped a list of products only for categories that have all of their products in stock.

            //var result = ProductList.GroupBy(p => p.Category)
            //.Where(g => g.All(p => p.UnitsInStock>0))
            //.Select(g => new
            //{
            //    Category = g.Key,
            //    Products = g.ToList()
            //});
            //foreach (var item in result)
            //{
            //    foreach (var item2 in item.Products)
            //    {
            //        Console.WriteLine(item2);
            //    }
            //}
            #endregion

            #endregion

            #region  LINQ– Grouping Operators

            #region  1. Use group by to partition a list of numbers by their remainder when divided by 5

            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var R1 = numbers.Select(x => new { remender = x % 2, number = x }).GroupBy(p => p.remender);
            //foreach ( var r in R1 )
            //{
            //    Console.WriteLine(r.Key);
            //    Console.WriteLine();
            //    foreach (var item in r)
            //    {
            //        Console.WriteLine(item.number);
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}
            #endregion

            #region 2. Uses group by to partition a list of words by their first letter. Use dictionary_english.txt for Input
            //string[] lines = File.ReadAllLines("dictionary_english.txt");
            //var r = lines.Select(x => new { letter = x[0], word = x }).GroupBy(p => p.letter);
            //foreach (var r2 in r)
            //{
            //    Console.WriteLine(r2.Key);
            //    foreach(var  r3 in r2) { Console.WriteLine(r3); }
            //}
            #endregion

            #region 3.Use Group By with a custom comparer that matches words that are consists of thesame Characters Together

            string[] Arr = { "from", "salt", "earn", " last", "near", "form" };

            

            #endregion

            #endregion

        }
    }
}
