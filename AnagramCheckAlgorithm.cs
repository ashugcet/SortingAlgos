using System;
using System.Collections.Generic;

namespace AlgoAndDS
{
    public class AnagramCheckAlgorithm
    {
        public Dictionary<string, IList<string>> GroupAnagrams(string[] stringArray)
        {
            Dictionary<string, IList<string>> dictAnagrams = new Dictionary<string, IList<string>>();
            
            foreach (var item in stringArray)
            {
                char[] cArray = item.ToCharArray();
                Array.Sort(cArray);
                
                string sortedString = new string(cArray);
                if (!dictAnagrams.ContainsKey(sortedString))
                {
                    IList<string> lstString = new List<string>();
                    lstString.Add(item);
                    dictAnagrams.Add(sortedString, lstString);
                }
                else
                {
                    dictAnagrams[sortedString].Add(item);
                }
            }

            return dictAnagrams;
        }
    }
}
