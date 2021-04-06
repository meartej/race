using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float steeringSpeed = 0.3f;
    public float gasBrakespeed = 1f;
    public float moveSpeed = 3f;
    Camera cam; 

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        var xInput = Input.GetAxis("Horizontal");
        var yInput = Input.GetAxis("Vertical");

        transform.position += (Vector3.up * moveSpeed
            + Vector3.right * xInput * steeringSpeed)
            * Time.deltaTime;

        var camPosition = cam.transform.position;
        camPosition.y = transform.position.y;
        cam.transform.position = camPosition;
    }
}
