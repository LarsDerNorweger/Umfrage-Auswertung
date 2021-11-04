using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Umfrage_Auswetung
{
   public class DataOperation
   {
      public void DumpInFile(string Data, string FilePath = null)
      {
         if(FilePath == null)
            throw new Exception("No FilePath is given");

         using(FileStream fs = File.Create(FilePath))
         {
            byte[] info = new UTF8Encoding(true).GetBytes(Data);
            // Add some information to the file.
            fs.Write(info, 0, info.Length);
         }
         
         return;
      }

      public string ReadFromFile(string Path)
      {
         return System.IO.File.ReadAllText(Path);
      }

      public string ConvertDataToJSON(Dictionary<string, string> Data)
      {
         string json = JsonConvert.SerializeObject(Data, Formatting.Indented);
         return json;
      }

      public Dictionary<string,string> DeconvertDataFromJSON(string JSONData)
      {
         Dictionary<string,string> dic = new Dictionary<string, string>();
         dic = JsonConvert.DeserializeObject<Dictionary<string, string>>(JSONData);
         return dic;
      }

      public string FindNewFileName(string FilePath = null)
      {
         if(FilePath == null)
            throw new Exception("No FilePath is given");

         int newFileNumber = 0;
         string fp;
         while(true)
         {
            fp = FilePath + newFileNumber+".json";
            if(!File.Exists(fp))
               return fp;
            newFileNumber++;
         }
      }

      public string FindnextFile(string FilePath = null)
      {
         if(FilePath == null)
            throw new Exception("No FilePath is given");

         int FirstFile = 0;
         string fp;
         while(true)
         {
            fp = FilePath + FirstFile+".json";
            if(!File.Exists(fp))
               return fp;
            FirstFile++;
         }
      }

   }
}
