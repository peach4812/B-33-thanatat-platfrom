using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Ishootable
{
   GameObject Bullet { get; set; }
    Transform SpawnPoint { get; set; }
    float BulletSpawnTime { get; set; }
    float BulletTime { get; set; }
    void Shoot();
}
