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
        public static void SavePlayerList(List<SavedPlayer> players)
        {
            using FileStream fileStream = File.Open(DATA_FILE_NAME, FileMode.OpenOrCreate, FileAccess.Write);
            JsonSerializer.Serialize(fileStream, players);
        }

        public static List<SavedPlayer> GetSavedPlayerList() {
            using FileStream fileStream = File.Open(DATA_FILE_NAME, FileMode.Open, FileAccess.Read);
            return JsonSerializer.Deserialize<List<SavedPlayer>>(fileStream) ?? new List<SavedPlayer>();
        }

        public static void AppendSavedPlayer(SavedPlayer player)
        {
            List<SavedPlayer> players = GetSavedPlayerList();
            players.Add(player);
            SavePlayerList(players);
        }
    }
}
