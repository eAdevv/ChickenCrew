using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishControl : MonoBehaviour
{

    public string nextLevel;
    PlayerController playerCtrl;
    GroundMoving groundMoving;
    private string activeLevel;
    public GameObject SuccesfulPanel, AgainPanel;

    private Dictionary<string, float> EggCounterMap = new Dictionary<string, float>()
    {
        {"Level1", 1f},
        {"Level2", 2f},
        {"Level3", 3f},
        {"Level4", 4f},
        {"Level5", 5f},
        {"Level6", 6f},
        {"Level7", 7f},
        {"Level8", 8f},
        {"Level9", 9f},
        {"Level10", 10f},
        {"Level11", 10f},
        {"Level12", 11f},
        {"Level13", 12f},
        {"Level14", 13f},
        {"Level15", 14f},
        
    };

    private void Start()
    {
        playerCtrl = GameObject.Find("CaptainChicken").GetComponent<PlayerController>();
        groundMoving = GameObject.Find("Grounds").GetComponent<GroundMoving>();
        activeLevel = SceneManager.GetActiveScene().name;
    }
    private void OnTriggerEnter(Collider collision)
    {
        setEggCounter(collision, EggCounterMap[activeLevel]);
    }

    private void setEggCounter(Collider collision, float counter)
    {
        if (collision.gameObject.tag.Equals("Player") && playerCtrl.numOfChicken >= counter)
        {
            PlayerPrefs.SetInt(nextLevel, 1);
            SuccesfulPanel.SetActive(true);
            groundMoving.groundSpeed = 0f;
            playerCtrl.movementSpeed = 0f;

        }
        else
        {
            AgainPanel.SetActive(true);
            groundMoving.groundSpeed = 0f;
           
        }
    }
}
