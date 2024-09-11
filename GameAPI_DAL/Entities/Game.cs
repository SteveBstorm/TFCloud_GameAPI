using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAPI_DAL.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Editor { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
    }
}
