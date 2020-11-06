using System.IO;
using System;
using System.Collections.Generic;
using System.Collections;


namespace Gonzalez_LinkedListSearch
{
    class FileBoot
    {
        
        StreamReader PopDataFile = new StreamReader("yob2019.txt");
        LinkedList ll = new LinkedList();
        string ln = "";
        string[] splitData;
        static string deliminator = ",";
        char[] CharDeliminator = deliminator.ToCharArray();
        string TempName = " ";
        string TempGender = " ";
        string TempRank =" ";
        MetaData md;
        public MetaData getData()
        {
            
            while ((ln = PopDataFile.ReadLine()) != null)
            {
                splitData = ln.Split(CharDeliminator,3);
                TempName = splitData[0]; 
                TempGender = splitData[1];
                TempRank = splitData[2];
                md = new MetaData(Convert.ToChar(TempGender), TempName, Convert.ToInt32(TempRank));
                ll.Add(md);
                
            }
            PopDataFile.Close();
            return md;
        }
        public LinkedList getList()
        {
            return ll;
        }
    }
}
