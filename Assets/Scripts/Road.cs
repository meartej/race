using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    static float[] linesCentersY;

    public static GameManager manager;
    static Vector3 startPosition;
    static float resetPositionY;
    static float speedY;


    public static void SetManager(GameManager manager)
    {
        linesCentersY = manager.roadLinesCentersY;
        resetPositionY = manager.roadResetPositionY;
        speedY = manager.roadSpeedY;
    }

    void Start()
    {
        if (gameObject.name != "road (2)")
            return;
        startPosition = transform.position;
    }

    void Update()
    {
        //transform.position += Vector3.down * speedY * Time.deltaTime;
        //if (transform.position.y <= resetPositionY) Reset();
        var distToCamera = Camera.main.transform.position - transform.position;
        if (distToCamera.y <= manager.resetDistanceY) return;
        OvertakePlayer();
    }

    private void OvertakePlayer()
    {
        transform.position += manager.resetDistanceY * Vector3.up + startPosition;
    }

    private void Reset()
    {
        transform.position = startPosition;

    }
}
