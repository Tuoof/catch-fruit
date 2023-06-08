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
        SettingPanel.SetActive(false);
        MainPanel.SetActive(false);
    }

    public void ExitButton()
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

    public void Level4()
    {
        SceneManager.LoadScene("Level4");
    }

    public void Level5()
    {
        SceneManager.LoadScene("Level5");
    }
}
