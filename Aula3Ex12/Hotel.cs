using System;
using System.Collections.Generic;
using System.Text;

namespace MyInterFaces
{
    public class Hotel : IHasScore
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public int Score
        {
            // Isto está bué noob mas pronto
            get
            {
                if (Score >= 0 || Score <= 5) return Score;
                else if (Score > 5) return 5;
                else return 0;
            }
        }
        public bool Equals(IHasScore other)
        {
            if (other.Score == Score) return true;
            else return false;
        }
    }
}
