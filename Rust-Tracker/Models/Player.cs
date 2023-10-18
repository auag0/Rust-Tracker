using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rust_Tracker.Models
{
    class SavedPlayer
    {
        public SavedPlayer(int battleMetricsId, string? nickName = null, string? lastPlayerName = null)
        {
            this.BattleMetricsId = battleMetricsId;
            this.NickName = nickName;
            this.LastPlayerName = lastPlayerName;
        }

        public int BattleMetricsId { get; set; }
        public string? NickName { get; set; }
        public string? LastPlayerName { get; set;}
    }
}
