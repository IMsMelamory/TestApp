using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using TestApp.Model;

namespace TestApp.JsonProvider
{
    public class JsonProvider<Cards>
    {
        private readonly string _jsonPath;
        private readonly JsonSerializerSettings _jsonSettings;
        public JsonProvider(string jsonPath)
        {
            _jsonPath = jsonPath;
            _jsonSettings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Objects,
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            };
        }
        public  List<Card> GetAll()
        {
            var jsonData = "";
            if (File.Exists(_jsonPath))
            {
                jsonData = File.ReadAllText(_jsonPath);

            }
            else
            {
                var fileCard = File.Create(_jsonPath);
                fileCard.Close();
            }

            var myList = JsonConvert.DeserializeObject<List<Card>>(jsonData, _jsonSettings) ?? new List<Card>();
            return myList;
        }
        public  void WriteAll(List<Card> list)
        {
            File.WriteAllText(_jsonPath, JsonConvert.SerializeObject(list, Formatting.Indented, _jsonSettings));
        }

    }
}
