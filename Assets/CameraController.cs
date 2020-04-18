using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float panSpeed = 30f;

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 position = transform.position;
        if(Input.GetKey("w")) {
            position.z += panSpeed * Time.deltaTime;
        }
        if(Input.GetKey("a")) {
            position.x -= panSpeed * Time.deltaTime;
        }
        if(Input.GetKey("d")) {
            position.x += panSpeed * Time.deltaTime;
        }
        if(Input.GetKey("s")) {
            position.z -= panSpeed * Time.deltaTime;
        }
        transform.position = position;

        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        
    }
}
