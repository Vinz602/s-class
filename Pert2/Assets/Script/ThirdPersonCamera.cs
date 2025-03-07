using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public float distance = 5f;
    public float heigth = 2f;
    public float rotationSpeed;
    private Transform player;
    private float currentRotation;
    private bool Cursor = false;
    private void Start() {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        }
    void LateUpdate()
    {
        float horizontalInput = Input.GetAxis("Mouse X");
        currentRotation += horizontalInput * rotationSpeed;
        Vector3 desiredPosition = player.position - new Vector3(0f,0f,distance);
        desiredPosition.y = player.position.y + heigth;
        transform.position = desiredPosition;
        transform.LookAt(player.position);
        gameObject.transform.rotation = Quaternion.Euler(0f, currentRotation, 0f); 
        player.rotation = Quaternion.Euler(0f, -currentRotation, 0f);
    }

    private void update()
    {

        if(Input.GetKeyDown(KeyCode.LeftAlt))
        {

        }
    }
}
