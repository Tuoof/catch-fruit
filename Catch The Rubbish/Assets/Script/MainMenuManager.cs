using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{

    public GameObject MainPanel;
    public GameObject LevelPanel;
    public GameObject SettingPanel;
    public GameObject CreditPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HideAllPanel()
    {
        MainPanel.SetActive(true);
        LevelPanel.SetActive(false);
        SettingPanel.SetActive(false);
        CreditPanel.SetActive(false);
    }

    public void ShowLevelPanel()
    {
        LevelPanel.SetActive(true);
        MainPanel.SetActive(false);
    }

    public void ShowSettingPanel()
    {
        SettingPanel.SetActive(true);
        MainPanel.SetActive(false);
    }

    public void ShowCreditPanel()
    {
        CreditPanel.SetActive(true);
        MainPanel.SetActive(false);
    }

    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }
}
