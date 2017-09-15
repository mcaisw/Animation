using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CameraInertiaMove : MonoBehaviour
{
    
    Rigidbody rigid;
    int PointerUp;
    float currentSpeed;
    float magnitude;
    float sensitive;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
        PointerUp = 0;
        magnitude = -0.2f;
        sensitive = 20;
    }
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            PointerUp = -1;
            currentSpeed = Mathf.Lerp(currentSpeed, 2*Input.GetAxis("Mouse X") / Time.deltaTime, sensitive * Time.deltaTime);
            rigid.velocity = magnitude*new Vector3(currentSpeed,0,0);
        }
       
        if (PointerUp==1)
        {
            currentSpeed = Mathf.Lerp(currentSpeed, 0,Time.deltaTime);
            rigid.velocity = magnitude*new Vector3(currentSpeed, 0, 0);
            if (Mathf.Abs( rigid.velocity.x)<0.2)
            {
                PointerUp = 0;
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            PointerUp = 1;
        }
    }
}
    
