using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    bool move = false;
    bool isGrounded = false;
    float speed = 20f;
    float rotationSpeed = 7f;

    public Rigidbody2D rb;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            move = true;
        }
        if (Input.GetButtonUp("Fire1"))
        {
            move = false;
        }
    }

    void FixedUpdate()
    {
        if (move == true)
        {
            if (isGrounded)
            {
                rb.AddForce(
                    transform.right * speed * Time.deltaTime * 100f, ForceMode2D.Force);
            }
            else
            {
                rb.AddTorque(
                    rotationSpeed * Time.deltaTime * 100f, ForceMode2D.Force);
            }
        }
    }

    void OnCollisionEnter2D()
    {
        isGrounded = true;
    }

    void OnCollisionExit2D()
    {
        isGrounded = false;
    }
}
