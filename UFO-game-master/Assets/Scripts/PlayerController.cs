using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Scripts : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 5;
    public float xRange = 28;
    public Transform blaster;
    public GameObject laserBolt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    //When the user presses the arrow keys, it will move the player
    horizontalInput = Input.GetAxis("Horizontal");
    transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
    

    // if the x position of the player is greater than the xRange, it will stop
    if (transform.position.x > xRange)
    {
        transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
    }

    // if the x position of the player is less than -xRange, it will will stop
    if (transform.position.x < -xRange)
    {
        transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
    }

    // if the space key is pressed, it will spawn a laser
    if (Input.GetKeyDown(KeyCode.Space))
    {
        Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation);
    }

    }
    // If the player collides with anything, it will destroy the other object
    void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
    }
}
