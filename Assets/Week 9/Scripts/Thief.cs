using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor;
using UnityEngine;

public class Thief : Villager
{
    public GameObject dagger;
    public Transform SpawnPoint;
    Coroutine dashing;
    protected override void Attack()
    {
        if (dashing != null) 
        { 
        StopCoroutine(dashing);
            StopAllCoroutines();
        }
        dashing = StartCoroutine(Dash());
    }


    IEnumerator Dash()
    {
        destination = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        speed = 7;
        while (speed > 3)
        {
            yield return null;
        }
        base.Attack();
        yield return new WaitForSeconds(0.1f);
        Instantiate(dagger, SpawnPoint.position, SpawnPoint.rotation);
        yield return new WaitForSeconds(0.2f);
        Instantiate(dagger, SpawnPoint.position, SpawnPoint.rotation);


    }


    void spawner()
    {
        
    }

    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }
}
