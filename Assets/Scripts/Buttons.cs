using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Buttons : MonoBehaviour
{

    private string currentLevel;
    private int currentSceneIndex;
   
    public void StartLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Play()
    {
        SceneManager.LoadScene("LevelScreen");
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
 
    public void NextLevel()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void TryAgain()
    {

       currentLevel = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentLevel);
    }
}
