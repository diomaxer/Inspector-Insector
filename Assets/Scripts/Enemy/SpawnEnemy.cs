using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public float spawnCoolDown = 2f;
    public float currentTime = 0;
    public Transform player;

    // Enemy Prefabs
    private GameObject EnemyFollower;
    private GameObject SquareEnemy;

    private void Start()
    {
        EnemyFollower = Resources.Load("Prefabs/EnemyFollower", typeof(GameObject)) as GameObject;
        SquareEnemy = Resources.Load("Prefabs/SquareEnemy", typeof(GameObject)) as GameObject;
    }

    private void FixedUpdate()
    {
        if(currentTime >= spawnCoolDown && player)
        {
            SpqamPrefab(EnemyFollower, player.position.x, player.position.y);
            currentTime = 0;
        }
        else
        {
            currentTime += Time.deltaTime;
        }
    }

    public void SpqamPrefab(GameObject prefab, float x, float y)
    {
        if(Random.value < 0.5)
        {
            Instantiate(prefab, new Vector2(x + Random.Range(-15, 15), y + RandomBetweenTwoInt(-10, 10)), Quaternion.identity);
        }
        else
        {
            Instantiate(prefab, new Vector2(x + RandomBetweenTwoInt(-15, 15), y + Random.Range(-10, 10)), Quaternion.identity);
        }
        
    }

    public int RandomBetweenTwoInt(int a, int b)
    {
        if (Random.value < 0.5)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}
