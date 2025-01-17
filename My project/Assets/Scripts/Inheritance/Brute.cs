using UnityEngine;
using static Unit;

public class Brute : Unit, IMovable, IDamagable
{
    
    void Start()
    {
        speed = 1f;
        maxHealth = 300;
        
    }
}
