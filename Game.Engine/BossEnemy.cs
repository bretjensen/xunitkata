namespace Game.Engine
{
    public class BossEnemy : Enemy
    {
        public override double TotalSpecialPower => 1000;
        public override double SpecialPowersUses => 6;
    }
}