using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Gonzalez_LinkedListSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            ArrayList menu = new ArrayList();
            FileBoot fb = new FileBoot();
            fb.getData();
            LinkedList DLL = fb.getList();
            MetaData TempMData;
            Node tempNode;
            string Input = "";
            string Name = "";
            string Gender = "";
            string Rank = "";
            menu.Add("1. Search By Name");
            menu.Add("2. See Total Items in List");
            menu.Add("3. See Total Female List Items");
            menu.Add("4. See Total Male List Items");
            menu.Add("5. Add a List Item");
            menu.Add("6. See Most Popular Male In List");
            menu.Add("7. See Most Popular Female In List");
            menu.Add("8. Exit");


            while (Input != "8")
            {
                tempNode = null;
                Input = "";
                //Console.Clear();
                Console.WriteLine("Select an option from the list");
                foreach (string item in menu)
                {
                    Console.WriteLine($"{item}");
                }
                Input = Console.ReadLine();

                if (Input == "1")
                {
                    Console.WriteLine("Search by name:");
                    Input = Console.ReadLine();
                    stopwatch.Start();
                    tempNode = DLL.Search(Input);
                    stopwatch.Stop();
                    string time = stopwatch.ElapsedMilliseconds.ToString(@"m\:ss\.ff");
                    Console.WriteLine($"Search result in {stopwatch.}: \n" +
                        $"Name: {tempNode.MData.GetName()}" +
                        $" Gender: {tempNode.MData.GetGender()}" +
                        $" Popularity: {tempNode.MData.GetRank()}");
                    
                }
                if (Input == "2")
                {
                    Console.WriteLine($"Total Items in List: {MetaData.GetTotalNodes()}");
                }
                if (Input == "3")
                {
                    Console.WriteLine($"Total Females in List: {MetaData.GetTotalFemales()}");
                }
                if (Input == "4")
                {
                    Console.WriteLine($"Total Males in List: {MetaData.GetTotalMales()}");
                }
                if (Input == "5")
                {
                    Input = "";
                    Console.WriteLine("Please enter the name you would like to add: ");
                    Name = Console.ReadLine();
                    Console.WriteLine($"Please enter the Gender of {Name}");
                    Gender = Console.ReadLine();
                    Console.WriteLine($"Please Enter the Rank of {Name}");
                    Rank = Console.ReadLine();

                    if (DLL.Search(Name) != null)
                    {
                        Console.WriteLine($"{Name} of gender {Gender.ToUpper()} already exists Would you like to add a _1 or cancel? Add/Cancel");
                        Input = Console.ReadLine();
                        if (Input.ToLower() == "add")
                        {
                            Name += "_1";
                            TempMData = new MetaData(Convert.ToChar(Gender.ToUpper()), Name, Convert.ToInt32(Rank));
                            DLL.Add(TempMData);
                            Console.WriteLine($"{Name} was added too the list");
                        }
                        else if(Input.ToLower() == "cancel")
                        {
                            continue;
                        }
                        else 
                        {
                            Console.WriteLine("Please choose a valid option.");
                        }
                    }
                    
                }
                if (Input == "6")
                {
                    tempNode = DLL.MalePopSearch();
                    Console.WriteLine($"Search result: \n" +
                        $"Name: {tempNode.MData.GetName()}" +
                        $" Gender: {tempNode.MData.GetGender()}" +
                        $" Popularity: {tempNode.MData.GetRank()}");
                }
                if (Input == "7")
                {
                    tempNode = DLL.FemalePopSearch();
                    Console.WriteLine($"Search result: \n" +
                        $"Name: {tempNode.MData.GetName()}" +
                        $" Gender: {tempNode.MData.GetGender()}" +
                        $" Popularity: {tempNode.MData.GetRank()}");
                }
                if (Input == "8")
                {
                   Console.WriteLine(DLL.Print());
                }
                //break;
            }
            //MetaData mdata = new MetaData('M', "Mark",500);


            //try
            //{
            //    Console.WriteLine(fb.getData());
            //    DLL.Add(mdata);
            //    Console.WriteLine(DLL.Print());
            //    Console.WriteLine("User was added");
            //}
            //catch
            //{

            //    Console.WriteLine("user could not be added");
            //}

            //try
            //{

            //    tempnode = DLL.Search("liam");
            //    temp2 = DLL.PopSearch();
            //    Console.WriteLine($"{tempnode.MData.GetName()}, was found in the list");
            //    Console.WriteLine($"{temp2.MData.GetName()}, is the most popular in the list with a rank of {temp2.MData.GetRank()}");
            //}
            //catch 
            //{
            //    Console.WriteLine("User was not found");
            //}
            //Console.WriteLine($"Total Nodes: {MetaData.GetTotalNodes()}\n" +
            //    $"Total Females in list: {MetaData.GetTotalFemales()}\n" +
            //    $"Total Males in list: {MetaData.GetTotalMales()}");
        }
    }
}
