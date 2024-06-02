namespace ArenaGame
{
    public class Arena
    {
        private List<Hero> heroes;

        public Arena(params Hero[] heroes)
        {
            this.heroes = new List<Hero>(heroes);
        }

        public Hero Battle()
        {
            int currentHeroIndex = 0;

            while (heroes.Count > 1)
            {
                Hero attacker = heroes[currentHeroIndex];
                Hero defender = heroes[(currentHeroIndex + 1) % heroes.Count];

                int damage = attacker.Attack();
                defender.TakeDamage(damage);

                if (defender.IsDead)
                {
                    Console.WriteLine($"{defender.Name} е мъртъв!");
                    heroes.Remove(defender);
                }

                currentHeroIndex = (currentHeroIndex + 1) % heroes.Count;
            }

            return heroes[0];
        }
    }
}
