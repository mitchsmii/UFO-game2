using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if the object is higher than 14 z, then it will destroy itself
        if (transform.position.z  < -25 || transform.position.z > 25)
        {
            Destroy(gameObject);
        }
    }
}
