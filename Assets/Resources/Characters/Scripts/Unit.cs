using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {
    public Mechsuit mechsuit;
    // Use this for initialization
    public virtual void Start () {
		
	}

    // Update is called once per frame
    public virtual void Update () {
        mechsuit.Update();
	}

    void FireLeft()
    {
        mechsuit.Fire(0);
    }

    void FireRight()
    {
        mechsuit.Fire(1);
    }

    void FireALL()
    {
        mechsuit.FireALL();
    }

    void Special()
    {
        mechsuit.Special();
    }
}
