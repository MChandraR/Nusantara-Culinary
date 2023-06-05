using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuCamera : MonoBehaviour
{
    public float posX, posY;

    void Start()
    {
        posX = 0f;
        posY = 0f;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            posX += Input.GetAxis("Mouse Y");
            posY += Input.GetAxis("Mouse X");
        }
    }
}
