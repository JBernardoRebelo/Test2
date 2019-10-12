using System.Numerics;

namespace _4xMilitary
{
    public class SettlerUnit : Unit
    {
        public override int Health { get => base.Health; set => base.Health = value; }

        public override float Value { get; }

        public SettlerUnit(Vector2 pos, int health) : base(pos, health)
        {
            position = pos;
            Value = 5;
        }
    }
}
