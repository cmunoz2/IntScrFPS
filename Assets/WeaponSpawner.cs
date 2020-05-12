using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpawner : MonoBehaviour
{
    public GameObject player;
    public List<string> weaponNames;

    public List<GameObject> rifles;
    public float viewDistance = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if ((player.transform.position-this.transform.position).sqrMagnitude<1.5*1.5) 
        {
            // the player is within a radius of 3 units to this game object
            SpawnRifle();
        
        }
        else
        {
            
        }
    }
    
     void SpawnRifle()
    {
        while(true)
        {
            GameObject newGun = Instantiate(rifles[Random.Range(0, rifles.Count)], this.transform.position, this.transform.rotation);
            newGun.name = weaponNames[Random.Range(0, weaponNames.Count)];
            
        }
    }

}
                
        