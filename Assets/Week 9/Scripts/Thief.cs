using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Thief : Villager
{
    public GameObject dagger;
    public Transform SpawnPoint;
    public Transform SpawnPoint2;

    protected override void Attack()
    {
        gameObject.transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        destination = gameObject.transform.position;
        Instantiate(dagger, SpawnPoint.position, SpawnPoint.rotation);
        Instantiate(dagger, SpawnPoint2.position, SpawnPoint2.rotation);

    }

    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }
}
