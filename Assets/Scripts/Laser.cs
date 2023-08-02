using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    int index;

    float lineWidth = 0.075f;
    float startX = 20f;
    float startY;

    LineRenderer lineRenderer;

    Parabola parabola;
    LaserGenerator laserGenerator;


    void Awake()
    {
        parabola = FindObjectOfType<Parabola>();
        laserGenerator = FindObjectOfType<LaserGenerator>();
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.startWidth = lineWidth;
        lineRenderer.endWidth = lineWidth;
        
        index = laserGenerator.curLaserIndex;
    }

    void Update()
    {
        startY = laserGenerator.laserGroundY - index * laserGenerator.lasersDistance;

        if (startY > -5 && startY < 5)
        {
            ShowLaser();
        }
        else
        {
            lineRenderer.positionCount = 0;
        }
    }

    void ShowLaser()
    {
        if (startY > parabola.yBottom && startY < parabola.yTop)
        {
            lineRenderer.positionCount = 3;

            lineRenderer.SetPosition(0, new Vector3(startX, startY, 0));
            lineRenderer.SetPosition(1,
            new Vector3(Mathf.Pow(startY - parabola.deltaY, 2) / parabola.p / 4 + parabola.deltaX, startY, 0));
            lineRenderer.SetPosition(2, new Vector3(parabola.p + parabola.deltaX, parabola.deltaY, 0));
        }
        else
        {
            lineRenderer.positionCount = 2;

            lineRenderer.SetPosition(0, new Vector3(startX, startY, 0));
            lineRenderer.SetPosition(1, new Vector3(-startX + 3, startY, 0));
        }
    }
}
