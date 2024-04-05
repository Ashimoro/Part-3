using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    public GameObject barrierEnable;
    public GameObject barrierDisable;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        barrierDisable.SetActive(false);
        barrierEnable.SetActive(true);
    }
}
