using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   public GameObject Enemy1;
   public GameObject Enemy2;
   public GameObject Enemy3;
   public Transform spawnPosition;
    private float timer;

    void Awake()
    {
        timer = 5;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <=0)
        {
            SpawnEnemy();
            timer = 5;
        }    
    }

    void SpawnEnemy()
    {
        var enemy = Instantiate(Enemy1, spawnPosition.position, spawnPosition.rotation);
    }
}
