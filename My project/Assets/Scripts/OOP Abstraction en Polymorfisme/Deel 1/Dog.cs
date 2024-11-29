using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    public override void Move()
    {
        Debug.Log("Walking on 4 legs");
    }

    private void Start()
    {
        Eat();
    }
}
