using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LaserGenerator : MonoBehaviour
{
    public GameObject laser;

    public float lasersDistance = 6f;
    public float laserGroundY = 6f;
    [HideInInspector]
    public int curLaserIndex = 0;


    void Start()
    {
        GenerateLasers();
    }

    public void SetLasersDistance(float distance)
    {
        lasersDistance = distance;
    }

    public void SetLaserGroundY(float groundY)
    {
        laserGroundY = groundY;
    }

    void GenerateLasers()
    {
        for (int i = 0; i < 100; i++)
        {
            Instantiate(laser);
            curLaserIndex++;
        }
    }
}
