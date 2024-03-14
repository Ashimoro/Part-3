using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Thief : Villager
{
    public GameObject dagger;
    public Transform SpawnPoint;
    protected override void Attack()
    {
        gameObject.transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        destination = gameObject.transform.position;
        base.Attack();
        Invoke("spawner", 0f);
        Invoke("spawner", 0.1f);
    }

    void spawner()
    {
        Instantiate(dagger, SpawnPoint.position, SpawnPoint.rotation);
    }

    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }
}
