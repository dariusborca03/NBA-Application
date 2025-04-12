using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_T1_BorcaDarius
{
    public class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public string Position { get; set; }
        public int LastPoints { get; set; }  
        public int LastRebounds { get; set; } 
        public int LastAssists { get; set; }  

        public string VideoPath { get; set; }
        public string ImagePath { get; set; }
    }
}
