using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Villager
{
    public GameObject Arrow;
    public Transform spawnPoint;
    protected override void Attack()
    {
        destination = transform.position;
        base.Attack();
        Instantiate(Arrow, spawnPoint.position, spawnPoint.rotation);
    }

}
