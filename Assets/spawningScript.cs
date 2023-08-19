using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawningScript : MonoBehaviour
{
    public GameObject ballprefab;
    public Transform Goal;
    public bool spawnBall;
    public static spawningScript instance;
    private void Awake()
    {
        instance = this; 
    }
    private void Start()
    {
        ballSpawn();
        
    }
    private void Update()
    {
        if (spawnBall==true)
        {
            ballSpawn();
        }
    }

    public void ballSpawn()
    {
        Instantiate(ballprefab, transform);
        spawnBall = false;
    }
}
