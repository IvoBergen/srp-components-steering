using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollower : SteeringVehicle
{
    [SerializeField] private GameObject playerObject;
    [SerializeField] private GameObject enemyObject;
    private float distanceX;
    private float distanceY;
    private Vector2 target;


    private void PlayerInRange()
    {
        target = playerObject.transform.position;
        if (distanceX < 4 && distanceY < 4)
        { 
            SetTarget(target);
        }
    }

    protected override void Move()
    {
        base.Move();
        
        distanceX = Mathf.Abs(enemyObject.transform.position.x - playerObject.transform.position.x);
        distanceY = Mathf.Abs(enemyObject.transform.position.y - playerObject.transform.position.y);
        PlayerInRange();
    }
}
