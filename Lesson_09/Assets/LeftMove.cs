using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LeftMove : MonoBehaviour
{
    bool isPressed = false;
    public GameObject Player;
    public float Force;

    private void Update()
    {
        if (isPressed)
        {
            Player.transform.Translate(Force * Time.deltaTime, 0, 0);
        }
    }
}
