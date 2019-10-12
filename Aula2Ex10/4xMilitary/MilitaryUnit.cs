using System.Numerics;

namespace _4xMilitary
{
    public class MilitaryUnit : Unit
    {
        public int AttackPower { get; }
        public int XP { get; set; }
        public override int Health
        {
            get => base.Health + XP;
            set => base.Health = value;
        }
        public override float Value { get => AttackPower + XP; }

        public MilitaryUnit(Vector2 pos, int health, int attackPower) : base(pos, health)
        {
            position = pos;
            AttackPower = attackPower;
            XP = 0;
        }

        public void Attack(Unit other)
        {
            other.Health -= AttackPower;
        }

        public override string ToString()
        {
            return $"{base.ToString()} \nAttackPower: {AttackPower}\nXP: {XP}";
        }
    }
}
