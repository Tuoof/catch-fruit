using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*StartCoroutine(RestartGame());*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator RestartGame()
    {
        /*yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Level1");*/
        yield return false;
    }
}
