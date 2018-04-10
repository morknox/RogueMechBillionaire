using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit {
    

    public override void Awake()
    {
        base.Awake();
        //first thing that happens
    }
    public override void Start()
    {
        base.Start();
        //second thing that happens
    }
    public override void Update()
    {
        base.Update();
        // CODE HERE

        if (Input.GetMouseButton(0))
        {
            FireAll();
        }
    }

    public override void Rotate()
    {
        base.Rotate();
    }

    public override void Aim()
    {
        base.Aim();

        //temporary, replace with mouse aim
        if (moveDirection != Vector3.zero)
            aimDirection = moveDirection;
    }

    public override void Movement()
    {     
        moveDirection = Vector3.zero;


        if (Input.GetKey(KeyCode.A))
            moveDirection -= new Vector3(1, 0, -1);
        if (Input.GetKey(KeyCode.D))
            moveDirection += new Vector3(1, 0, -1);
        if (Input.GetKey(KeyCode.W))
            moveDirection -= new Vector3(-1, 0, -1);
        if (Input.GetKey(KeyCode.S))
            moveDirection += new Vector3(-1, 0, -1);

        moveDirection.Normalize();

        base.Movement();
    }
}
