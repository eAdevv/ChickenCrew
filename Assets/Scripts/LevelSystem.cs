using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSystem : MonoBehaviour
{
    public Button[] levels;
    public float levels_number_to_reach;
    public string levelName;


   
    
    void Start()
    {
        for (int i = 0; i<levels.Length; i++)
        {
             levelName = levels[i].name;

            switch(levelName)
            {
                case "Level1": 
                    levels_number_to_reach = 1f;
                    break;
                case "Level2": 
                    levels_number_to_reach = 2f;
                    break;
                case "Level3":
                    levels_number_to_reach = 3f;
                    break;
                case "Level4":
                    levels_number_to_reach = 4f;
                    break;
                case "Level5":
                    levels_number_to_reach = 5f;
                    break;
                case "Level6":
                    levels_number_to_reach = 6f;
                    break;
                case "Level7":
                    levels_number_to_reach = 7f;
                    break;
                case "Level8":
                    levels_number_to_reach = 8f;
                    break;
                case "Level9":
                    levels_number_to_reach = 9f;
                    break;
                case "Level10":
                    levels_number_to_reach = 10f;
                    break;
                case "Level11":
                    levels_number_to_reach = 10f;
                    break;
                case "Level12":
                    levels_number_to_reach = 11f;
                    break;
                case "Level13":
                    levels_number_to_reach = 12f;
                    break;
                case "Level14":
                    levels_number_to_reach = 13f;
                    break;
                case "Level15":
                    levels_number_to_reach = 14f;
                    break;

            }

            if (PlayerPrefs.GetInt(levelName) == 1)
            {
                levels[i].interactable = true;
            }
            else
            {
                levels[i].interactable = false;
            }
            levels[0].interactable = true;
        }
       

    }

  
}
