using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class auto_movement : MonoBehaviour
{
    public float speed = 5.0f;  // movement speed in units per second
    public Vector3 forwardDirection = Vector3.forward;  // forward direction of movement

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(forwardDirection * speed * Time.deltaTime);
    }
}
