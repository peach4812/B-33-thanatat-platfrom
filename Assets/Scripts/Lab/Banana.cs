using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapon
{
    private float speed;
    private void FixedUpdate()
    {
        Move();
    }

    private void Start()
    {
        Damage = 10;
        speed = 4f * GetShootDirection();
    }
    public override void Move()
    {
        float newX = transform.position.x + speed * Time.fixedDeltaTime;
        float newY = transform.position.y;
        Vector2 newPosition = new Vector2(newX, newY);
        transform.position = newPosition;
    }
    
    public override void OnHitWith(Character _character)
    {
        if (_character is Enemy)
            _character.TakeDamage(this.Damage);
    }
}
