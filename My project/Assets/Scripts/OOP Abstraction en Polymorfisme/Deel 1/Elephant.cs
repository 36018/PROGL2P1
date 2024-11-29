using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elephant : Animal
{
    public override void Move()
    {
        Debug.Log("Walking on 4 bigger legs");
    }

    private void Start()
    {
        Eat();
    }
}
