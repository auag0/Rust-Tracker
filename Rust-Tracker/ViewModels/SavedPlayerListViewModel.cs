using Rust_Tracker.Data;
using Rust_Tracker.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rust_Tracker.ViewModels
{
    class SavedPlayerListViewModel: BaseViewModel
    {
        public ObservableCollection<SavedPlayer> SavedPlayers { get; set; }

        public SavedPlayerListViewModel()
        {
            SavedPlayers = new ObservableCollection<SavedPlayer>();
            LoadSavedPlayers();
        }

        public void LoadSavedPlayers()
        {
            SavedPlayers.Clear();
            SavedPlayerDataManager.GetSavedPlayerList().ForEach(player => SavedPlayers.Add(player));
        }
    }
}
