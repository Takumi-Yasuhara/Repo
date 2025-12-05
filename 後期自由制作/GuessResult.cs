using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English_NumerOn
{
    public class GuessResult
    {
        public string Word { get; set; }
        public bool[] Hits { get; set; } = new bool[5];
        public bool[] Blows { get; set; } = new bool[5];
        public int HitCount { get; set; }
        public int BlowCount { get; set; }

        public override string ToString()
        {
            return $"{Word.ToUpper()} → Hit: {HitCount}, Blow: {BlowCount}";
        }


    }
}
