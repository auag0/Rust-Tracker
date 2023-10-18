using Rust_Tracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Text.Json;

namespace Rust_Tracker.Data
{
    internal class SavedPlayerDataManager
    {
        private static readonly string DATA_FILE_NAME = "SavedPlayerList.json";
        private static SavedPlayerDataManager? Instance;
        public static SavedPlayerDataManager GetInstance()
        {
            return Instance ??= new SavedPlayerDataManager(); 
        }

        public void SavePlayerList(List<SavedPlayer> players)
        {
            FileStream fileStream = File.Open(DATA_FILE_NAME, FileMode.OpenOrCreate);
            JsonSerializer.Serialize(fileStream, players);
        }
    }
}
