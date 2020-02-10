using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Verticalspeed = 20;
    public float Horizontalspeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Hello this is my comment
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * Verticalspeed * verticalInput);
        //transform.Translate(Vector3.right * Time.deltaTime * Horizontalspeed * horizontalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * Horizontalspeed * horizontalInput);
    }
}
