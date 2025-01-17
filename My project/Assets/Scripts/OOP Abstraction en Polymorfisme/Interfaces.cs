public interface IMovable
{
    void Move();
}

public interface IDamagable
{
    int Health { get; }
    void TakeDamage(float _);
}