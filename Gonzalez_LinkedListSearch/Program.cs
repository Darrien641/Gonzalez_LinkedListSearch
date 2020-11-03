using System;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace Gonzalez_LinkedListSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input = "";
            FileBoot fb = new FileBoot();           
            LinkedList DLL = fb.getList();
            ArrayList menu = new ArrayList();
            Node tempNode;
            fb.getData();
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
                    tempNode = DLL.Search(Input);
                    Console.WriteLine($"Search result: \n" +
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
                    Console.WriteLine("Please ");
                }
                if (Input == "6")
                {
                    tempNode = DLL.PopSearch('M');
                    Console.WriteLine($"Search result: \n" +
                        $"Name: {tempNode.MData.GetName()}" +
                        $" Gender: {tempNode.MData.GetGender()}" +
                        $" Popularity: {tempNode.MData.GetRank()}");
                }
                if (Input == "7")
                {
                    tempNode = DLL.PopSearch('F');
                    Console.WriteLine($"Search result: \n" +
                        $"Name: {tempNode.MData.GetName()}" +
                        $" Gender: {tempNode.MData.GetGender()}" +
                        $" Popularity: {tempNode.MData.GetRank()}");
                }
                if (Input == "8")
                { }
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
