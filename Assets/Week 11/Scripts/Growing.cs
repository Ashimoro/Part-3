using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Growing : MonoBehaviour
{
    public GameObject square;
    public GameObject triangle;
    public GameObject circle;
    public TextMeshProUGUI squareTMP;
    public TextMeshProUGUI triangleTMP;
    public TextMeshProUGUI circleTMP;
    public TextMeshProUGUI crTMP;
    public int running;
    Coroutine coroutine;

    void Start()
    {
        StartCoroutine(growingShapes());
    }

    void Update()
    {
        crTMP.text = "Coroutines: " + running.ToString();

    }

    IEnumerator Square()
    {
        running += 1;
        float size = 0;
        while (size < 5)
        {
            size += Time.deltaTime;
            Vector3 scale = new Vector3(size, size, size);
            square.transform.localScale = scale;
            squareTMP.text = "Square: " + scale;
            yield return null;
        }
        running -= 1;
    }

    IEnumerator growingShapes()
    {
        running += 1;
        StartCoroutine(Square());
        yield return new WaitForSeconds(1);
        StartCoroutine(Triangle());
        yield return new WaitForSeconds(1);
        StartCoroutine(Circle());
        yield return coroutine;
        running -= 1;
    }
    IEnumerator Triangle()
    {
        float size = 0;
        running += 1;
        while (size < 5)
        {
            size += Time.deltaTime;
            Vector3 scale = new Vector3(size, size, size);
            triangle.transform.localScale = scale;
            triangleTMP.text = "Triangle: " + scale;
            yield return null;
        }
        running -= 1;
    }
    IEnumerator Circle()
    {

        running += 1;
        float size = 0;
        while (size < 5)
        {
            size += Time.deltaTime;
            Vector3 scale = new Vector3(size, size, size);
            circle.transform.localScale = scale;
            circleTMP.text = "Cirlce: " + scale;
            yield return null;
        }
        while (size > 0)
        {
            size -= Time.deltaTime;
            Vector3 scale = new Vector3(size, size, size);
            circle.transform.localScale = scale;
            circleTMP.text = "Cirlce: " + scale;
            yield return null;
        }
        running -= 1;
        yield return Circle();
    }
}
