using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Directrix : MonoBehaviour
{
    LineRenderer lineRenderer;
    Parabola parabola;

    float lineWidth = 0.1f;

    
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        parabola = FindObjectOfType<Parabola>();
        lineRenderer.startWidth = lineWidth;
        lineRenderer.endWidth = lineWidth;
        lineRenderer.positionCount = 2;
    }

    void Update()
    {
        lineRenderer.SetPosition(0, new Vector3(-parabola.p + parabola.deltaX, 6, 0));
        lineRenderer.SetPosition(1, new Vector3(-parabola.p + parabola.deltaX, -6, 0));
    }
}
