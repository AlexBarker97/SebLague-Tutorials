using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 10;

    void Update()
    {
        Movement();
        LookDirection();
    }

    void Movement()
    {
        Vector3 moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        Vector3 direction = moveInput.normalized;
        Vector3 velocity = direction * speed;
        Vector3 moveAmount = velocity * Time.deltaTime;

        transform.Translate(moveAmount);
    }
    
    void LookDirection()
    {
        Vector3 mousePos = Input.mousePosition;
        print("Mouse X: " + mousePos.x + ", Mouse Y: " + mousePos.y);
    }
}