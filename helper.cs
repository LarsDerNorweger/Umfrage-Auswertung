using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umfrage_Auswetung
{
   public class helper
   {
      public Dictionary<string,string> FindAndReplaceOrSetValue(Dictionary<string, string> inpDict, string keyToTest,string newValue)
      {
         if(newValue == " " || newValue == null || newValue == "")
            newValue = "not given";

         if(inpDict.ContainsKey(keyToTest))
         {
            inpDict[keyToTest] = newValue;
            return inpDict;
         }
         inpDict.Add(keyToTest, newValue);
         return inpDict;
      }
   }
}
