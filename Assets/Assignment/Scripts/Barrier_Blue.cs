using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier_Blue : Player
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
        gravityScale = 50;
        base.Effect();
    }

}
