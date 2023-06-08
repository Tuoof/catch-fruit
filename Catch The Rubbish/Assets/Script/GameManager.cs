using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Rubbish_Prefab;
    public GameObject gameOverPanel;
    public PlayerScript playerScript;
    public MenuManager menuManager;
    public GameObject button1, button2;

    public Text WinText;

    public string WinString;
    public string LoseString;

    public string NextLevelScene, buttonTextWin;
    public string CurrentLevelScene, buttonTextLose;

    [SerializeField]
        bool timerIsRunning = true;
    [SerializeField]
        Text timeText;
    [SerializeField]
        float timeRemaining = 60;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRubbish", 2, 2);
    }

    // Update is called once per frame
    void Update()
    {
        menuManager.score.text = playerScript.score.ToString();

        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                StopSpawning(true);
            }
        }
    }

    void SpawnRubbish()
    {
        float tempPos = Random.Range(-2f, 2f);
        Instantiate(Rubbish_Prefab, new Vector3(tempPos, 5.5f, 0), Quaternion.identity);
    }

    public void StopSpawning(bool win)
    {
        if (win)
        {
            WinText.text = WinString;
            menuManager.SetLevelSelect(NextLevelScene, buttonTextWin);
        }
        else
        {
            WinText.text = LoseString;
            menuManager.SetLevelSelect(CurrentLevelScene, buttonTextLose);
        }

        CancelInvoke();
        gameObject.SetActive(false);
        button1.SetActive(false);
        button2.SetActive(false);
        gameOverPanel.SetActive(true);
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
