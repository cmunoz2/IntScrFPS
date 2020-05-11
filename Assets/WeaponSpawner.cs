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
        StartCoroutine(SpawnRifle());
    }

    IEnumerator SpawnRifle()
    {
        while(true)
        {
            RaycastHit hit;
            if(Physics.Raycast(transform.position, player.transform.position, out hit, viewDistance))
            {
                if(hit.collider.gameObject.CompareTag("Player"))
                {
                    GameObject newGun = Instantiate(rifles[Random.Range(0, rifles.Count)], this.transform.position, this.transform.rotation);

                    newGun.name = weaponNames[Random.Range(0, weaponNames.Count)];

                
                    //Debug.Log("I see the player!");
                    GetComponent<Renderer>().material.color = Color.red;
                    Debug.DrawRay(this.transform.position, player.transform.position, Color.green, 1.5f);
                }
                else
                {
                    Debug.DrawRay(this.transform.position, player.transform.position, Color.red, 1.5f);
                    GetComponent<Renderer>().material.color = Color.white;
                }
                yield return new WaitForSeconds(1f);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
                
        