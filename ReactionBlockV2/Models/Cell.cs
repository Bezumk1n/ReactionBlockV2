using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactionBlockV2.Models
{
    public class Cell : BaseCell
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public string Position => GetPosition();

        private string GetPosition()
        {
            return $"{Row}, {Column}";
        }
    }
}
