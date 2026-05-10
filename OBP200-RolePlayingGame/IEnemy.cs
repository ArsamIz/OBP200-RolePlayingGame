namespace OBP200_RolePlayingGame;

public interface IEnemy
{
    string Name { get;}
    int HP { get; }
    int Attack{get;}
    int Defense{get;}
    int XPReward{get;}
    int GoldReward{get;}
     
    int CalculateDamage(Random random);
    void TakeDamage(int damage);
    bool IsDead();
}