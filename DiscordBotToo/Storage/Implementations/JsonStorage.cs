﻿using System;
using System.Collections.Generic;
using System.IO;
using static System.IO.Directory;
using System.Text;
using Newtonsoft.Json;

namespace DiscordBotToo.Storage.Implementations
{
        public class JsonStorage : IDataStorage
        {
            public T RestoreObject<T>(string key)
            {
                var json = File.ReadAllText($"{key}.json");
                return JsonConvert.DeserializeObject<T>(json);
            }

            public void StoreObject(object obj, string key)
            {
            var file = $"{key}.json";
            CreateDirectory(Path.GetDirectoryName(file));
            var json = JsonConvert.SerializeObject(obj);
            File.WriteAllText(file, json);
             //UserSettings/Users/example.json   
            }
        }
    
}
