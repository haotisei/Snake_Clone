using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    /* public Transform target;
     public Vector3 offsetZ;

     void Update()
     {
         transform.position = target.transform.position + offsetZ;    
     }
    */

    Transform CamTransform;
    public Transform Player;
    public Vector3 offset;
    public float followspeed;

    void Start()
    {
        CamTransform = Camera.main.transform;
    }

    void Update()
    {
        Vector3 targetPosition = new Vector3(CamTransform.position.x, CamTransform.position.y, Player.position.z);

        CamTransform.position = Vector3.Lerp(CamTransform.position, targetPosition + offset, Time.deltaTime * followspeed);
    }
}
