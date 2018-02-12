using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BallBehaviour: MonoBehaviour
{
    public float speed1;
    private Rigidbody rb1;
    public float jumpForce = 2.0f;
    public Vector3 jump;
    public bool isGrounded;

    void Start()
    {
        rb1 = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
        }
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb1.AddForce(movement * speed1);
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            rb1.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }


    }
   

}
