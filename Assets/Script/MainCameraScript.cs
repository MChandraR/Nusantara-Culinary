using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraScript : MonoBehaviour
{
    public float Xpos, Ypos;
    public GameObject player;
    float mouseSpeed;

    void Start()
    {
        Xpos = this.transform.rotation.x ; Ypos = this.transform.rotation.y;
        mouseSpeed = 1f;
    }
    void Update()
    {
        this.transform.position = player.transform.position;

        if (Input.GetMouseButton(0))
        {
            float Xin = Input.GetAxis("Mouse Y") * mouseSpeed;
            float Yin = Input.GetAxis("Mouse X") * mouseSpeed;
            Ypos += Xin;
            Xpos += Yin;

            
            this.transform.rotation = Quaternion.Euler(Ypos, Xpos, 0f);
            player.transform.rotation = Quaternion.Euler(player.transform.rotation.x, Xpos+90, player.transform.rotation.z);
        }
       
    }
}
