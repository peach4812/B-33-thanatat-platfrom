using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Crocodlie : Enemy, Ishootable
{

    [SerializeField] private float attackRange;
    public Player player;
    [SerializeField] private GameObject bullet;
    public GameObject Bullet { get { return bullet; } set { bullet = value; } }
    [SerializeField] private Transform bulletSpawnPoint;
    public Transform SpawnPoint { get { return bulletSpawnPoint; } set { bulletSpawnPoint = value; } }
    [SerializeField] private float bulletSpawnTime;
    public float BulletSpawnTime { get { return bulletSpawnTime; } set { bulletSpawnTime = value; } }
    public float BulletTime { get { return bulletTimer; } set { bulletTimer = value; } }
    [SerializeField] private float bulletTimer;

    private void Update()
    {
        BulletTime -= Time.deltaTime;
        Behavior();
        if (BulletTime <= 0)
        {
            BulletTime = BulletSpawnTime;
        }
    }
    public override void Behavior()
    {
        Vector2 direction = player.transform.position - transform.position;
        float distance = direction.magnitude;
        if (distance < attackRange)
        {
            Shoot();
        }
    }
    public void Shoot()
    {
        if (BulletTime <= 0)
        {
            anim.SetTrigger("Shoot");
            GameObject obj = Instantiate(Bullet, SpawnPoint.position, Quaternion.identity);
            Rock rock = obj.GetComponent<Rock>();
            rock.Init(20, this);
            BulletTime = BulletSpawnTime;
        }
    }
    void Start()
    {
        Init(100);
    }
}
