using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnManager : MonoBehaviour
{
    public GameObject UFO;
    public float xRange = 20f;
    public float zPos = 4f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnUFO");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

IEnumerator SpawnUFO()
{
    // Instantiate the UFO object with a rotation of 180 degrees around the y-axis
    while (true)
    {
        yield return new WaitForSeconds(2);
        Instantiate(UFO, new Vector3(Random.Range(-xRange, xRange), 1, zPos), Quaternion.Euler(0, 180, 0));
    }
}

}
