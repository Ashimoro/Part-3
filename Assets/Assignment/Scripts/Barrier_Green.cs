using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Barrier_Green : Player
{
    public GameObject Player;
    private Rigidbody2D playerRigibody;

    private void Start()
    {
        playerRigibody = Player.GetComponent<Rigidbody2D>();
        Effect();
    }
    protected override void Effect()
    {
        gravityScale = -50;
        rb.gravityScale = gravityScale;
    }


}
