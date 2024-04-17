using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BlasterMove : MonoBehaviour
{
    public float speed = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Moves the object forward
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
