using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform player;
    private float yOffset = 90f;
    private float zOffset = -60;

    void Start()
    {
        player = GameObject.Find("CaptainChicken").transform;
    }

    // Update is called once per frame
    void Update()
    {
      
        transform.position = new Vector3(player.position.x, player.position.y + yOffset, player.position.z + zOffset);
        

    }

    
}
