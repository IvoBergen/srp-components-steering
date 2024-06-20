using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wandering : SteeringVehicle
{
    private int _randomPointx;
    private int _randomPointy;
    private Vector2 position = new Vector2();
    private void Start()
    {
        InvokeRepeating("GetRandomPoint", 1, 1);
    }
    
    private void GetRandomPoint()
    { 
        _randomPointx = Random.Range(-10, 10);
        _randomPointy = Random.Range(-5, 5);

        position = new Vector2(_randomPointx, _randomPointy);
        SetTarget(position);
    }
}
