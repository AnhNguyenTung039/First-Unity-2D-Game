using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // variable ↓
    public float speed = 5f;
    // variable ↑

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Input: get input from the user
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // get the position of our character
        // Vector2: 2D vector and points
        // Vector3: 3D vector and points
        Vector2 pos = transform.position;

        pos.x += horizontal * speed * Time.deltaTime;
        pos.y += vertical * speed * Time.deltaTime;

        transform.position = pos;
    }
}
