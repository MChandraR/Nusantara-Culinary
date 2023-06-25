using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public CharacterController CC;
    public float playerSpeed = 5f;
    public GameObject Camera;

    void Start()
    {
        CC = this.GetComponent<CharacterController>();
    }

    void Update()
    {
        if (Input.GetKey("w"))
        {
            CC.Move(this.transform.right * -playerSpeed * (Time.deltaTime*10f) );
        }
    }
}
