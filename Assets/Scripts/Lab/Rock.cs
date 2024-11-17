using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rock : Weapon
{
    private Rigidbody2D rb;
    private Vector2 force;
   
    //override
    public override void Move()
    {
        //Debug.Log("Rock move with Rigidbody : force");
        rb.AddForce(force, ForceMode2D.Impulse);
    }
    public override void OnHitWith(Character character)
    {
        if (character is Player)
            character.TakeDamage(this.Damage);
    }
    //start
    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Damage = 20;
        force = new Vector2(GetShootDirection() * 5, 10);
        Move();
    }
}
