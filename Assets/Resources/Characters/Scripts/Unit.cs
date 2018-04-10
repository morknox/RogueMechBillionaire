using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {
    [System.NonSerialized]
    public Mechsuit mechsuit;
    [System.NonSerialized]
    public Transform body;

    [System.NonSerialized]
    public Vector3 moveDirection, aimDirection, velocity;
    float health, maxHealth, moveSpeed = 7f;


    public virtual void Awake(){
        body = transform.Find("body");
        mechsuit = new Mechsuit(this);
        aimDirection = new Vector3(1, 0, -1);
    }

    public virtual void Start () {
	}
    public virtual void Update () {
        mechsuit.Update();

        Movement();
        Rotate();
        Orientation();
        Aim();
    }

    public virtual void Aim()
    {

    }
    
    public virtual void Rotate()
    {
        //?
    }
    void Orientation()
    {
        //Flip images and stuff according to MoveDirection
    }
    public void FireLeft()
    {
        mechsuit.Fire(0);
    }

    public void FireRight()
    {
        mechsuit.Fire(1);
    }

    public void FireAll()
    {
        mechsuit.FireAll();
    }

    public void Special()
    {
        mechsuit.Special();
    }

    public virtual void Movement()
    {
        velocity = moveDirection * moveSpeed;
        transform.position += velocity * Time.deltaTime;
    }

    public virtual bool TakeDamage(Unit dealer, int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            health = 0;
            return true;
        }
        return false;
    }
}
