using Rust_Tracker.Data;
using Rust_Tracker.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rust_Tracker.ViewModels
{
    class SavedPlayerListViewModel: BaseViewModel
    {
        private ObservableCollection<SavedPlayer> SavedPlayers;

        public SavedPlayerListViewModel()
        {
            SavedPlayers = new ObservableCollection<SavedPlayer>();
        }
    }
}
