using System.Numerics;

namespace _4xMilitary
{
    public abstract class Unit
    {
        public virtual int Health { get; set; }

        public Vector2 position { get; set; }

        public Vector2 vector2 { get; set; }

        public abstract float Value { get; }

        // Base constructor
        public Unit(Vector2 pos, int health)
        {
            position = pos;
            Health = health;
        }

        public void Move(Vector2 v)
        {
            position += v;
            Vector2.Distance(position, v);
        }

        // Personalized ToString
        public override string ToString()
        {
            return $"Health: {Health}\nValue: {Value}";
        }
    }
}
