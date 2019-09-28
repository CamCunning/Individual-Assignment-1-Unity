using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            transform.SetPositionAndRotation(new Vector3(0.0f, 0.0f, 0.0f), new Quaternion());
        }
    }
}
