using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionTracker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("x: " + gameObject.transform.position.x + "\n" + "z: " + gameObject.transform.position.z);
        }
    }
}
