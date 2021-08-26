using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DefenderButton : MonoBehaviour
{
    [SerializeField] Defender defenderPrefab;

    private void Start()
    {
        LableButtonCost();
    }

    private void LableButtonCost()
    {
        Text costText = GetComponentInChildren<Text>();
        if (!costText)
        {
            Debug.LogError(name + "has no text");
        }
        else
        {
            costText.text = defenderPrefab.GetStarCost().ToString();
        }
    }

    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach(DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(0, 0, 0, 255);
        }
        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<SpawnDefenders>().SetSelectedDefender(defenderPrefab);
    }
}
