using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal
{
    public override void Move()
    {
        Debug.Log("Flapping it's wings");
    }

    private void Start()
    {
        Eat();
    }
}
