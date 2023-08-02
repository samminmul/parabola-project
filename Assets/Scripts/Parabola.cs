using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parabola : MonoBehaviour
{
    float lineWidth = 0.2f;
    public float xRange = 3f;
    public float p = 1f;
    public float deltaX = -5f;
    public float deltaY = 0;

    public float yBottom;
    public float yTop;

    [SerializeField]
    int lengthOfLineRenderer = 201;
    int LineRendererHalfLength;
    LineRenderer lineRenderer;


    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.startWidth = lineWidth;
        lineRenderer.endWidth = lineWidth;
        lineRenderer.positionCount = lengthOfLineRenderer;
        LineRendererHalfLength = Mathf.FloorToInt(lengthOfLineRenderer / 2);
    }

    void Update()
    {
        for (int i=0; i < lengthOfLineRenderer; i++)
        {
            float dotX = xRange * Mathf.Abs(i - LineRendererHalfLength) / LineRendererHalfLength;
            float dotY = Mathf.Sqrt(Mathf.Abs(4 * p * dotX));
            if (i < LineRendererHalfLength) { dotY = -dotY; }

            lineRenderer.SetPosition(i, new Vector3(dotX + deltaX, dotY + deltaY, 0));
        }

        yTop = Mathf.Sqrt(Mathf.Abs(4 * p * xRange)) + deltaY;
        yBottom = -Mathf.Sqrt(Mathf.Abs(4 * p * xRange)) + deltaY;
    }

    public void SetDeltaX(float _deltaX)
    {
        deltaX = _deltaX;
    }

    public void SetDeltaY(float _deltaY)
    {
        deltaY = _deltaY;
    }

    public void SetXRange(float _xRange)
    {
        xRange = _xRange;
    }

    public void SetP(float _p)
    {
        p = _p;
    }
}
