using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StandartWindows;

namespace Umfrage_Auswetung
{
   public class ReadAndAnalyseData
   {
      public Dictionary<string,string> Settings = new Dictionary<string,string>();
      
      private List<Person> Custumers = new List<Person>();
      DataOperation m_DataOperation = new DataOperation();

      public void CreateCustumersList()
      {
         Dictionary<string,string> PersonData = new Dictionary<string,string>();

         string newPath = " ";
         while(true)
         {
            newPath =   m_DataOperation.getnextFilename(Settings["AnalyseDataPath"]);
            if(newPath == "")
               break;

            PersonData = m_DataOperation.DeconvertDataFromJSON(m_DataOperation.ReadFromFile(newPath));
            Custumers.Add(new Person());
            Custumers[Custumers.Count - 1].Age = PersonData["age"];
            Custumers[Custumers.Count - 1].Sex = PersonData["sex"];
            Custumers[Custumers.Count - 1].Reason_string = PersonData["reason"];
            Custumers[Custumers.Count - 1].AlreadyCustumer = PersonData["alreadyClient"];
         }
         
      }



      public IEnumerable<string> SelectFromCustumersList(string preSelect, string mainSelect, string xAchsis)
      {
         switch(xAchsis)
         {
            case "sex":
               return from Person in Custumers
                     where (Person.getValueof = mainSelect) == preSelect
                     select Person.Sex;
            case "age":
               return from Person in Custumers
                     where (Person.getValueof = mainSelect) == preSelect
                     select Person.Age;
            case "alreadyClient":
               return from Person in Custumers
                     where (Person.getValueof = mainSelect) == preSelect
                     select Person.AlreadyCustumer;
            default:
               return from Person in Custumers
                      select Person.Reason_string;
         }



      //IEnumerable<string> names = from person in people
      //                            where person.Pets.All(pet => pet.Age > 5)
      //                            select person.LastName;
      }

      

   }
}
