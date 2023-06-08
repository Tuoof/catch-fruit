using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    int speed;
    public int score = 0;

    public Button MoveLeftButton, MoveRightButton;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Rubbish")
        {
            score += 1;
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
        MoveLeft();
        MoveRight();
    }

    void MoveLeft()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(1, 0, 0) * -speed * Time.deltaTime);
        }

        float currentXPos = transform.position.x;
        currentXPos = Mathf.Clamp(currentXPos, -2f, 2f);
        transform.position = new Vector3(currentXPos, transform.position.y, transform.position.z);
    }

    void MoveRight()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
        }

        float currentXPos = transform.position.x;
        currentXPos = Mathf.Clamp(currentXPos, -2f, 2f);
        transform.position = new Vector3(currentXPos, transform.position.y, transform.position.z);
    }
}
