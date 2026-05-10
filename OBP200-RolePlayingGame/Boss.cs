namespace OBP200_RolePlayingGame;

public class Boss : Enemy
{
    public Boss(string name, int hp, int attack, int defense, int xpReward, int goldReward)
        : base(name, hp, attack, defense, xpReward, goldReward)
    {
    }

    public override int CalculateDamage(Random random)
    {
        return base.CalculateDamage(random) + random.Next(1,4);
    }
}
