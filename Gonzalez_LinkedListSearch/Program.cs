using System;
using System.IO;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace Gonzalez_LinkedListSearch
{
    class Program
    {
        static void Main(string[] args)
        {

            FileBoot fb = new FileBoot();
            MetaData mdata = new MetaData('M', "Mark",500);
            Node tempnode;
            Node temp2;
            LinkedList DLL = fb.getList();

            
           
            try
            {
                Console.WriteLine(fb.getData());
                DLL.Add(mdata);
                Console.WriteLine("User was added");
            }
            catch
            {
                Console.WriteLine("user could not be added");
            }

            try
            {

                tempnode = DLL.search("liam");
                temp2 = DLL.PopSearch();
                Console.WriteLine($"{tempnode.MData.GetName()}, was found in the list");
                Console.WriteLine($"{temp2.MData.GetName()}, is the most popular in the list with a rank of {temp2.MData.GetRank()}");
            }
            catch 
            {
                Console.WriteLine("User was not found");
            }
            Console.WriteLine($"Total Nodes: {MetaData.GetTotalNodes()}\n" +
                $"Total Females in list: {MetaData.GetTotalFemales()}\n" +
                $"Total Males in list: {MetaData.GetTotalMales()}");
        }
    }
}
