using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemys : MonoBehaviour
{
    public GameObject Enemy;
    private Transform _compTransform;
    public float TimeSpawnEnemy;

    void Awake()
    {
        _compTransform = GetComponent<Transform>();
    }
    void Start()
    {
        Invoke("CreateEnemy", TimeSpawnEnemy); 
    }

    void Update()
    {
        
    }
    void CreateEnemy()
    {
        int positionX = Random.Range(-10, 10);
        int positionY = Random.Range(5, 8);
        _compTransform.position = new Vector2(positionX,positionY);
        Instantiate(Enemy, _compTransform.position, transform.rotation);
        Invoke("CreateEnemy", TimeSpawnEnemy);
       
    }

}
