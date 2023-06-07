using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Rubbish_Prefab;
    public PlayerScript playerScript;
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRubbish", 2, 2);
    }

    // Update is called once per frame
    void Update()
    {
        score.text = playerScript.score.ToString();
    }

    void SpawnRubbish()
    {
        float tempPos = Random.Range(-2f, 2f);
        Instantiate(Rubbish_Prefab, new Vector3(tempPos, 5.5f, 0), Quaternion.identity);
    }

    public void StopSpawning()
    {
        CancelInvoke();
    }
}
