using Newtonsoft.Json;
using System;
using System.IO;
using WpfApp.Model.Interfaces;
using WpfApp.ViewModel.Enum;

namespace WpfApp.Model
{
   public class Settings : ISettings
   {
      public StoredTheme WindowTheme { get; set; }

      public int Language { get; set; }

      public Settings()
      {
      }

      public void Save() 
      {
         string output = JsonConvert.SerializeObject(this);

         string destPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
         File.WriteAllText(destPath, output);
      }

      public void Load()
      {
         var settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName)));
         WindowTheme = settings.WindowTheme;
         Language = settings.Language;
      }

      private const string fileName = "Settings.json";
   }
}
