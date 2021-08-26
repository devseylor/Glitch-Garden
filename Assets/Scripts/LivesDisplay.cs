using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] float baseLive = 3;
    [SerializeField] int damage = 1;
    float lives;
    Text livesText;

    void Start()
    {
        lives = baseLive - PlayerPrefController.GetDifficulty();
        livesText = GetComponent<Text>();
        UpdateDisplay();
    }
    private void UpdateDisplay()
    {
        livesText.text = lives.ToString();
    }

    public void TakeLives()
    { 
        lives -= damage;
        UpdateDisplay();
         
        if (lives <= 0)
        {
            FindObjectOfType<LevelController>().HandleLoseCondition();
        }
    }
}
