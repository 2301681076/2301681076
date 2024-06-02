using System;
using ArenaGame;

namespace ArenaGame
{
	public class Archer: Hero
	{
		private const int CriticalHitChance = 15;
		public Archer(string name,Weapon weapone) : base (name, weapone) { }
        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(CriticalHitChance))
            {
                attack = attack * 2;
                Console.WriteLine();
            }
            return attack;


        }
    }
}
