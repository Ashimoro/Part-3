using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 500f;
    public Rigidbody2D rb;
    protected static float gravityScale = 50f;
    private void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        Effect();
    }

    public void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(moveHorizontal, 0);
        rb.velocity = movement * speed * Time.deltaTime;
    }

    protected virtual void Effect()
    {
        
    }

}