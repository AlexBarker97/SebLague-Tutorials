using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 6;
    int coinCount;
    Vector3 velocity;
    Vector3 velocityResult;

    Rigidbody myRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        Vector3 direction = input.normalized;
        velocity = direction * speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            velocityResult = velocity + (Vector3.up * 20);
        }
        else
        {
            velocityResult = velocity;
        }

        Vector3 moveAmount = velocityResult * Time.deltaTime;
        transform.Translate(moveAmount);
    }

    void FixedUpdate()
    {
        myRigidBody.position += velocity * Time.fixedDeltaTime;
    }

    void OnTriggerEnter(Collider triggerCollider)
    {
        if (triggerCollider.tag == "Coin")
        {
            Destroy(triggerCollider.gameObject);
            coinCount++;
            print(coinCount);
        }
    }
}
