using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.position += new Vector3(speed, 0.0f, 0.0f);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            transform.position += new Vector3(-speed, 0.0f, 0.0f);
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            transform.position += new Vector3(0.0f, 0.0f, speed);
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            transform.position += new Vector3(0.0f, 0.0f, -speed);
        }
    }
}
