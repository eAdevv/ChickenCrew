using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour
{

    public float movementSpeed = 110f;
    public GameObject chicken;
    public Text numOfChickenText;
    public float numOfChicken = 0f;
    private string ColliderTag , currentLevel;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    

    void Update()
    {
        
        float hMovement = CrossPlatformInputManager.GetAxis("Horizontal") * movementSpeed ;
        float ownPos = transform.position.x;
        ownPos =  Mathf.Clamp(ownPos, -93f, 93f);
        transform.position = new Vector3(ownPos, transform.position.y, transform.position.z);
        transform.Translate(new Vector3(hMovement, 0, 0) * Time.deltaTime);
       
        
    }


    void OnTriggerEnter(Collider collider)
    {
        ColliderTag = collider.gameObject.tag;

        if (collider.gameObject.tag.Equals("Egg"))
        {
            GameObject gameobject_1 = Instantiate(chicken, collider.gameObject.transform.position, collider.gameObject.transform.rotation) as GameObject;
            Destroy(collider.gameObject);
            numOfChicken += 1f;
            numOfChickenText.text = "C H I C K E N  N U M B E R : " + numOfChicken;
        }

        if(collider.gameObject.tag.Equals("Finish"))
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("Chicken");

            for(int i = 0 ; i<go.Length ; i++) Destroy(go[i]);

            movementSpeed = 0f;
      
        }

        if (ColliderTag.Equals("Wolf")  || ColliderTag.Equals("Thorn") || ColliderTag.Equals("Fire"))
        {
            currentLevel = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentLevel);
        }

    }

   

}
