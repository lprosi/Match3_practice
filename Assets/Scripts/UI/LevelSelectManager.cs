using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectManager : MonoBehaviour
{
    public GameObject[] panels;
    public GameObject currentPanel;
    public int page;
    private GameData gameData;
    public int currentLevel = 0;

    // Start is called before the first frame update
    void Start()
    {
        gameData = FindObjectOfType<GameData>();
        for (int i = 0; i < panels.Length; i++)
        {
            panels[i].SetActive(false);
        }
        if(gameData != null)
        {
            for (int i = 0; i < gameData.saveData.isActive.Length; i++)
            {
                if (gameData.saveData.isActive[i])
                {
                    currentLevel = i;
                }
            }
        }
        if (currentLevel <= 9)
        {   
            page = 0;
            currentPanel = panels[page];
            panels[page].SetActive(true);
        }
        else if (currentLevel <= 18)
        {
            page = 1;
            currentPanel = panels[page];
            panels[page].SetActive(true);
        }
        else
        {
            page = 0;
            panels[0].SetActive(true);
        }
        //page = (int)Mathf.Floor(currentLevel / 2);
        //currentPanel = panels[page];
        //panels[page].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PageRight()
    {
        if(page < panels.Length - 1)
        {
            currentPanel.SetActive(false);
            page++;
            currentPanel = panels[page];
            currentPanel.SetActive(true);
        }
    }

    public void PageLeft()
    {
        if (page > 0)
        {
            currentPanel.SetActive(false);
            page--;
            currentPanel = panels[page];
            currentPanel.SetActive(true);
        }
    }
}
