using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{


    public Transform target;
    public float smoothing = 10f;
    Vector3 sOffset = new Vector3(-7.5f, 10.61f, -7.5f);
    void Start()
    {

        sOffset = target.position + sOffset;
    }

    void Update()
    {
        if (target != null)
        {

            Vector3 targetCamPos = target.position + sOffset;
            //Vector3 targetCamPos = new Vector3(temp.x, sOffset.y, temp.y);

            transform.position = new Vector3(Mathf.Lerp(transform.position.x, targetCamPos.x, smoothing * Time.deltaTime), transform.position.y, Mathf.Lerp(transform.position.z, targetCamPos.z, smoothing * Time.deltaTime));
        }
    }
}
