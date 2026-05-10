namespace OBP200_RolePlayingGame;

public class Enemy : IEnemy
{
    public string Name  { get; private set; }
    public int HP { get; private set; }
    public int Attack { get; private set; }
    public int Defense { get; private set; }
    public int XPReward {get; private set;}
    public int GoldReward {get; private set;}

    public Enemy(string name, int hp, int attack, int defense, int xpReward, int goldReward)
    {
        this.Name = name;
        this.HP = hp;
        this.Attack = attack;
        this.Defense = defense;
        this.XPReward = xpReward;
        this.GoldReward = goldReward;
    }

    public virtual int CalculateDamage(Random random)
    {
        return Attack + random.Next(0, 3);
    }

    public void TakeDamage(int damage)
    {
        HP -= Math.Max(0, damage);
        if (HP <= 0)
        {
            HP = 0;
        }
    }

    public bool IsDead()
    {
        return HP <= 0;
    }
}