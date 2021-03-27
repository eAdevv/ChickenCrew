using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfControl : MonoBehaviour
{

    float speed = 50f;
    float rightPos, leftPos;
    float Yrotation;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rightPos = 70f;
        leftPos = -70f;
    }

    
    void Update()
    {
        float Pos = transform.position.x;
        Pos = Mathf.Clamp(Pos, leftPos, rightPos);
        transform.position = new Vector3(Pos, transform.position.y, transform.position.z);
        transform.Translate(new Vector3(0, 0, speed) * Time.deltaTime);

        if(this.gameObject.transform.position.x >= rightPos || this.gameObject.transform.position.x <= leftPos)
        {
           
            transform.Rotate(0f, -180f, 0f, Space.Self);
        }
    }
}
