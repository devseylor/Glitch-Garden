using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    int currentSceneIndex;
    [SerializeField] int timeToWait = 4;

    
    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(currentSceneIndex == 0)
        {
            StartCoroutine(WaitForTime());
        }
        
    }

    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(timeToWait);
        LoadNextScene();
    }

    public void RestartScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void LoadMainManu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Start Screen");
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadGameOverScene()
    {
        SceneManager.LoadScene("Game Over");
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadOptionScene()
    {
        SceneManager.LoadScene("Options Screen");
    }
}
