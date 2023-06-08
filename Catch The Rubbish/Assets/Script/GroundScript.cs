using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour
{
    private int endGame = 3;

    public GameManager gameManager;
    public GameObject health1, health2, health3;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Rubbish")
        {
            endGame -= 1;
            Destroy(collision.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (endGame)
        {
            case 0: 
                health1.SetActive(false);
                health2.SetActive(false);
                health3.SetActive(false);
                break;
            case 1:
                health1.SetActive(true);
                health2.SetActive(false);
                health3.SetActive(false);
                break;
            case 2:
                health1.SetActive(true);
                health2.SetActive(true);
                health3.SetActive(false);
                break;
            case 3:
                health1.SetActive(true);
                health2.SetActive(true);
                health3.SetActive(true);
                break;
            default:
                health1.SetActive(false);
                health2.SetActive(false);
                health3.SetActive(false);
                break;
        }

        if (endGame <= 0)
        {
            gameManager.StopSpawning(false);
        }
    }
}
