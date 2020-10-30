using System;
using System.Collections.Generic;
using System.Text;

namespace Gonzalez_LinkedListSearch
{
    class MetaData
    {
        private readonly int Rank;
        private readonly char Gender;
        private readonly string Name;
        private static int TotalNodes;// move outside of this class
        private static int TotalFemales;
        private static int TotalMales;
        
        public MetaData(char gender, string name, int rank)
        {
            if (gender == 'F')
            {
                TotalFemales++;
            }
            else
            {
                TotalMales++;   
            }
            Rank = rank;
            Name = name;
            Gender = gender;
            TotalNodes++;
        }
        public static int GetTotalFemales()
        {
            return TotalFemales;
        }
        public static int GetTotalMales()
        {
            return TotalMales;
        }

        public static int GetTotalNodes()
        {
            return TotalNodes;
        }
        public string GetName()
        {
            return Name;
        }
        public char GetGender()
        {
            return Gender;
        }

        public int GetRank()
        {
            return Rank;
        }
    }
}
