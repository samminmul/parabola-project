using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusPoint : MonoBehaviour
{
    Transform tr;
    Parabola parabola;

    
    void Start()
    {
        tr = GetComponent<Transform>();
        parabola = FindObjectOfType<Parabola>();
    }

    void Update()
    {
        tr.position = new Vector3(parabola.p + parabola.deltaX, parabola.deltaY, 0);
    }
}
