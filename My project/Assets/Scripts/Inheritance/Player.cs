using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unit;

public class Player : Unit, IMovable, IDamagable
{
    private float moveSpeed = 2f;
    private float rotationSpeed = 2f;

    public override void Move()
    { 
    transform.position += transform.forward * moveSpeed * Time.deltaTime * Input.GetAxis("Vertical");
    transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
    }
}
