using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class Barrier_TimeEffects : MonoBehaviour
{
    public GameObject barrier;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(timer());
    }

    IEnumerator timer()
    {
        barrier.SetActive(true);
        yield return new WaitForSeconds(3);
        barrier.SetActive(false);
        yield return null;
    }
}
