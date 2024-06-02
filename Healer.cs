using System;
using ArenaGame;


namespace ArenaGame
{
	public class Healer : Hero
	{
		private const int HealChance = 20;
		public Healer(string name, Weapon weapon) : base(name, weapon) 
		{
		}
        public override int Attack()
        {
                int attack = base.Attack();
                if (ThrowDice(HealChance))
                {
                    Heal(StartingHealth * 30 / 100);
                    Console.WriteLine($"{Name} излекува себе си.");
                }
                return attack;
           
        }
             public override void TakeDamage(int incomingDamage)
        {
            base.TakeDamage(incomingDamage);
        }
    }

}