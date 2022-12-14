using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

    public Transform playerBody; //questo √® il "corpo" del personaggio, serve per la roba di fisica
    float xRotation = 0f;
    public float sensitivity = 10f; //sensibilit√†

    void Start() 
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void FixedUpdate() //aggiorna a ogni frame
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp (xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); // quaternions bitch
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
