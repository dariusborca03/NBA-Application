using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_T1_BorcaDarius
{
    public static class Data
    {
        public static List<Player> Players = new List<Player>
        {
            new Player
            {
                Name = "LeBron James",
                Team = "Los Angeles Lakers",
                Position = "Power Forward",
                LastPoints = 32,
                LastRebounds = 8,
                LastAssists = 5,
                VideoPath = @"Videos\lebron_james.mp4",
                ImagePath = @"Images\lebron_james.png"
            },
            new Player
            {
                Name = "Stephen Curry",
                Team = "Golden State Warriors",
                Position = "Point Guard",
                LastPoints = 45,
                LastRebounds = 3,
                LastAssists = 7,
                VideoPath = @"Videos\stephen_curry.mp4",
                ImagePath = @"Images\stephen_curry.png"
            },
            new Player
            {
                Name = "Kevin Durant",
                Team = "Phoenix Suns",
                Position = "Power Forward",
                LastPoints = 38,
                LastRebounds = 6,
                LastAssists = 4,
                VideoPath = @"Videos\kevin_durant.mp4",
                ImagePath = @"Images\kevin_durant.png"
            }
        };
    }

}
