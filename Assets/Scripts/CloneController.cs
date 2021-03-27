using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class CloneController : MonoBehaviour
{
    private GameObject target;
    public GameObject chickenParticle;
    private string gameobjectTag;
    public Transform LookTarget;
    NavMeshAgent navMesh;
    PlayerController playerCtrl;


    void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();
        target = GameObject.Find("CaptainChicken");
        playerCtrl = GameObject.Find("CaptainChicken").GetComponent<PlayerController>();

    }


    void Update()
    {
        transform.LookAt(LookTarget);
        navMesh.destination = target.transform.position;
    }

    private void OnTriggerEnter(Collider collider)
    {
        gameobjectTag = collider.gameObject.tag;

        if (gameobjectTag.Equals("Egg") )
        {
            GameObject gameobject_1 = Instantiate(playerCtrl.chicken, collider.gameObject.transform.position, collider.gameObject.transform.rotation) as GameObject;
            Destroy(collider.gameObject);
            playerCtrl.numOfChicken += 1f;
            playerCtrl.numOfChickenText.text = "C H I C K E N  N U M B E R : " + playerCtrl.numOfChicken;
        }

        if (gameobjectTag.Equals("Wolf") || gameobjectTag.Equals("RunningWolf") || gameobjectTag.Equals("Thorn") || gameobjectTag.Equals("Fire") )
        {
            Destroy(gameObject);
            GameObject go = Instantiate(chickenParticle, gameObject.transform.position, gameObject.transform.rotation) as GameObject;
            Destroy(go.gameObject, 2f);
            playerCtrl.numOfChicken -= 1f;
            playerCtrl.numOfChickenText.text = "C H I C K E N  N U M B E R : " + playerCtrl.numOfChicken;
        }
        
    }


}
