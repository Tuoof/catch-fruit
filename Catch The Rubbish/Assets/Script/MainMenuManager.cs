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
    public GameObject ExitConfirm;
    public GameObject HelpPanel;

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
        ExitConfirm.SetActive(false);
    }

    public void ShowLevelPanel()
    {
        LevelPanel.SetActive(true);
        MainPanel.SetActive(false);
        HelpPanel.SetActive(false);
    }

    public void ShowSettingPanel()
    {
        SettingPanel.SetActive(true);
        MainPanel.SetActive(false);
        CreditPanel.SetActive(false);
    }

    public void ShowCreditPanel()
    {
        CreditPanel.SetActive(true);
        SettingPanel.SetActive(false);
        MainPanel.SetActive(false);
    }

    public void ShowExitPanel()
    {
        CreditPanel.SetActive(false);
        SettingPanel.SetActive(false);
        MainPanel.SetActive(false);
        ExitConfirm.SetActive(true);
    }

    public void ShowHelpPanel()
    {
        CreditPanel.SetActive(false);
        LevelPanel.SetActive(false);
        SettingPanel.SetActive(false);
        MainPanel.SetActive(false);
        ExitConfirm.SetActive(false);
        HelpPanel.SetActive(true);
    }

    public void YesExit()
    {
        Application.Quit();
    }

    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void Level3()
    {
        SceneManager.LoadScene("Level3");
    }
}

