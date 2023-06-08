using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuCamera : MonoBehaviour
{
    public float posX, posY;
    public float mouseSensitivity;
    public float[] limitX;
    public float[] limitZ;
    public float[] limitFOV;
    public float FOV;
    public Camera camera;

    void Start()
    {
        camera = this.GetComponent<Camera>();
        if (camera!= null)
        {
            FOV = camera.fieldOfView;
        }
        mouseSensitivity = 5f;
        posX = this.transform.position.z;
        posY = this.transform.position.x;
        limitFOV = new float[2] {30f,60f };
        limitZ = new float[2] { 275f, 750f};
        limitX = new float[2] { -50f, 475f };
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float mouseX = Input.GetAxis("Mouse Y") * mouseSensitivity; 
            float mouseY = Input.GetAxis("Mouse X") * mouseSensitivity;
            posX -= posX - mouseX > limitX[0] && posX - mouseX < limitX[1] ? mouseX : 0f;
            posY -= posY - mouseY > limitZ[0] && posY - mouseY < limitZ[1] ? mouseY : 0f;
           
        }


        FOV -= FOV - Input.mouseScrollDelta.y >= 30f && FOV - Input.mouseScrollDelta.y <= 60f ? Input.mouseScrollDelta.y : 0f;
        camera.fieldOfView = FOV;

        this.transform.position = new Vector3(posY,this.transform.position.y,posX);
    }
}
