using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] platformPrefabs;
    
    public int platformSpawnCount;
    
    public Vector3 lastEndPoint;
    
        
        public void SpawnPlatforms()
    
    {  
        //8 Times
        for (int i = 0; i < platformSpawnCount; i++)
        {
            GameObject platform = GameObject.Instantiate(platformPrefabs[Random.Range(0,platformPrefabs.Length)]);
            platform platformScript = platform.GetComponent<platform>();
            platform.transform.position = lastEndPoint;
            lastEndPoint = platformScript.ReturnEndPoint();
        }
    }
    
    void Start()
    {
        SpawnPlatforms();
    }

    
    void Update()
    {
        
    }
}
 