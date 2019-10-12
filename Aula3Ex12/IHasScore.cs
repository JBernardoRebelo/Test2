using System;
using System.Collections.Generic;
using System.Text;

namespace MyInterFaces
{
    public interface IHasScore : IEquatable<IHasScore>
    {
        int Score { get; }
    }
}
