using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChampionshipOfBox.Models
{
    public class Chempionsip
    {
        public int Id { get; set; }
        public Boxer BoxerWinner { get; set; }
        public Boxer BoxerLoser { get; set; }
        public int AmountOfRounds { get; set; }
        public int RefereePoints { get; set; }
        public DateTime DateOfBattle  { get; set; }
    }
}