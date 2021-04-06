using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float resetDistanceY;

    public float[] roadLinesCentersY = new float[lines];
    public GameObject[] obstPrefabs;
    public GameObject[] carsPrefabs;

    public float roadResetPositionY;
    public float roadSpeedY;

    public static int lines = 4;

    static GameManager instance;


    public static GameObject GetObstacle()
    {
        var prefabs = instance.obstPrefabs;
        return prefabs[Random.Range(0, prefabs.Length)];
    }

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        
        Road.SetManager(this);
        Road.manager = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
