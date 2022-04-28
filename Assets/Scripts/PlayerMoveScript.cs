using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{
    public float forwardSpeed = 1000;
    Rigidbody rb;
    public float sideSpeed = 500;
    private Vector3 position;
    private float width;
    private float height;

    void Awake()
    {
        width = (float)Screen.width / 2.0f;
        height = (float)Screen.height / 2.0f;

        // Position used for the cube.
        position = new Vector3(0.0f, 0.0f, 0.0f);
    }
    // Start is called before the first frame update
    void Start()
    {
        //connect the player's rigidbody to the script
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        {
            // Handle screen touches.
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                // Move the cube if the screen has the finger moving.
                if (touch.phase == TouchPhase.Moved)
                {
                    Vector2 pos = touch.position;
                    pos.x = (pos.x - width) / width;
                    pos.y = (pos.y - height) / height;
                    position = new Vector3(-pos.x, pos.y, 0.0f);

                    // Position the cube.
                    transform.position = position;
                }
            }
        }
    }

    private void FixedUpdate()
    {
        //set the forward force for the player (with no input)
        rb.AddForce(0, 0, forwardSpeed * Time.deltaTime);
        //set the input for X-axis movement
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideSpeed * Time.deltaTime, 0, 0);
        }

    }
}
