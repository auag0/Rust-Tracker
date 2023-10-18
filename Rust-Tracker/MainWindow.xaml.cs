using Rust_Tracker.Data;
using Rust_Tracker.Models;
using Rust_Tracker.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Rust_Tracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<SavedPlayer> players = new List<SavedPlayer>();
            players.Add(new SavedPlayer(1149045620));
            players.Add(new SavedPlayer(1104663416));
            players.Add(new SavedPlayer(935652611));

            SavedPlayerDataManager.GetInstance().SavePlayerList(players);
        }

        private void navBtnSavedPlayerList_Click(object sender, RoutedEventArgs e)
        {
            main_content.Navigate(new SavedPlayerList());
        }
    }
}
