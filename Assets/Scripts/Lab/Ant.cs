using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Ant : Enemy
{
    [SerializeField] private Vector2 Velocity;
    [SerializeField] private Transform[] movePoints;

    private void Start()
    {
        Init(10);
        Debug.Log(" Ant Health " + Health);
    }

    private void FixedUpdate()
    {
        Behavior();
    }

    public override void Behavior()

    {
        rb.MovePosition(rb.position + Velocity * Time.fixedDeltaTime);

        if (rb.position.x <= movePoints[0].position.x && Velocity.x < 0)
        {
            FlipCharacter();
        }
        else if (rb.position.x >= movePoints[1].position.x && Velocity.x > 0)
        {
            FlipCharacter();
        }


    }
    private void FlipCharacter()
    {
        Velocity *= -1;

        Vector2 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;

    }
}


