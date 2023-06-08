using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuCamera : MonoBehaviour
{
    public float posX, posY;
    public float mouseSensitivity;

    void Start()
    {
        mouseSensitivity = 3f;
        posX = this.transform.position.z;
        posY = this.transform.position.x;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        { 
            posX -= Input.GetAxis("Mouse Y") * mouseSensitivity;
            posY -= Input.GetAxis("Mouse X") * mouseSensitivity;
        }
        this.transform.position = new Vector3(posY,this.transform.position.y,posX);
    }
}
