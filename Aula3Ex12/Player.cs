using System;
using System.Collections.Generic;
using System.Text;

namespace MyInterFaces
{
    public class Player : IHasScore
    {
        string Name { get; set; }

        public int Score
        {
            get
            {
                if (Score >= 0) return Score;
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
