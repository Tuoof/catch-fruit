using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonPressed : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    bool buttonPressed;
    public bool isMoveRight;
    public PlayerScript player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (buttonPressed)
        {
            if (isMoveRight)
            {
                player.MoveRight();
            }
            else
            {
                player.MoveLeft();
            }
        }
    }

    void IPointerUpHandler.OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
    {
        buttonPressed = false;
    }

    void IPointerDownHandler.OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
    {
        buttonPressed = true;
    }
}
