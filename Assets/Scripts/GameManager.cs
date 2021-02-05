using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] platformPrefabs;
    public GameObject[] attackableprefabs;
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

            
            int x = Random.Range(0, 10);
            {
                if (x >= 8)
                {
                    GameObject tree = GameObject.Instantiate(attackableprefabs[Random.Range(1, attackableprefabs.Length)]);
                    {
                        tree.transform.position = lastEndPoint + new Vector3(0, 2.7f, 0);
                    }
                }

                else
                    if (x >= 4)
                {
                    GameObject barrel = GameObject.Instantiate(attackableprefabs[Random.Range(0, attackableprefabs.Length)]);
                    {
                        barrel.transform.position = lastEndPoint + new Vector3(0, 1.2f, 0);
                    }
                }

                lastEndPoint = platformScript.ReturnEndPoint();
            }
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
 