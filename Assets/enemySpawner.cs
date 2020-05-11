using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public List<string> enemyType;
    public List<GameObject> enemies;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while(true)
        {
            GameObject newDude = Instantiate(enemies[Random.Range(0, enemies.Count)], this.transform.position, this.transform.rotation);

            newDude.name = enemyType[Random.Range(0, enemyType.Count)];
            yield return new WaitForSeconds(3f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
