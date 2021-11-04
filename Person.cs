using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umfrage_Auswetung
{
   public class Person
   {
      string temp;
      public string getValueof {
         get=> temp;
         set => temp = getValue(value);
         
      }
      public string AlreadyCustumer { get; set; }
      public string Reason_string{ get; set; }
      public string Sex { get; set; }
      public string Age { get; set; }
      public List<string> Reason_List { get; set; }

      private string getValue(string switchstring)
      {

         switch(switchstring)
         {
            case "sex":
               return Sex;
            case "age":
               return Age;
            case "alreadyCustumer":
               return AlreadyCustumer;
            default:
               return "nd";
         }

      }
   }
}
