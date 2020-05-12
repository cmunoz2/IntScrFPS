using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthSystem : MonoBehaviour
{
    public int health = 4;
    public int maxHealth = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health == 0)
        {
            Time.timeScale = 0;
            
            Destroy(gameObject);
        }
    }

        void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Ouch!");
            health -= 1;
        }
    }
}
