using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private int damage;
    public int Damage
    {
        get {
            return damage;
        }
        set {
            damage = value;
        }
    }
  
    //abstract
    protected Ishootable shooter;

    public abstract void OnHitWith(Character character);
    public abstract void Move();
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        OnHitWith(other.GetComponent<Character>());
        Destroy(this.gameObject, 6f);
    }
    public void Init(int newDamage, Ishootable ower)
    {
        Damage = newDamage;
        shooter = ower;
    }
    public int GetShootDirection()
    {
        float shootDir = shooter.SpawnPoint.position.x - shooter.SpawnPoint.parent.position.x;
        if (shootDir > 0)
            return 1;
        else return -1;
    }
}

