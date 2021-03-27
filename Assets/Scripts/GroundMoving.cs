using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMoving : MonoBehaviour
{

    public float groundSpeed = 50f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vMovement = groundSpeed;
        transform.Translate(new Vector3(0, 0, -vMovement) * Time.deltaTime);
    }

    
}
