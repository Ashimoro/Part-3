using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public class Barrier_Red : Player
{
    public GameObject Player;
    private Rigidbody2D playerRigibody;
    public void Start()
    {
        speed = 500;
        Effect();
    }
    protected override void Effect()
    {
        StartCoroutine(speedBoost());
    }

    public IEnumerator speedBoost()
    {
        while (speed <= 1200)
        {
            speed += 10;
            yield return null;

        }
    }

}
