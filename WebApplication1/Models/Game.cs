using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string GamePlatform { get; set; }
        public int GamePrice { get; set; }
        public string GameDescription { get; set; }
        public Game()
        {

        }
    }
}
