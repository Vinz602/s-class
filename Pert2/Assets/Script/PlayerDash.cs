using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDash : Player
{
    public float dashDistance;
    public float dashCooldown;
    private Rigidbody rb;
    private float currentDashCooldown;

    private void Start() {
        rb = GetComponent<Rigidbody>();
        currentDashCooldown = dashCooldown;
    }

    private void Update() {
        currentDashCooldown -= Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.LeftShift) && currentDashCooldown <= 0)
        {
            rb.AddForce(Vector3.forward * dashDistance, ForceMode.Impulse);
            rb.AddForce(GetComponent<PlayerMovement>().moveDirection * dashDistance, ForceMode.Impulse);
            currentDashCooldown = dashCooldown;
        }
    }
}
