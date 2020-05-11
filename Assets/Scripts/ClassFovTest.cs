using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassFovTest : MonoBehaviour
{
    // Reference to player
    public GameObject player;
    // Reference to AI

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (LookForPlayer());
        
    }

    IEnumerator LookForPlayer()
    {
        while(true)
        {
            float angle = Vector3.Angle(this.transform.forward, player.transform.position);
            Vector3 rayDirection = player.transform.position - this.transform.position;
            
            if(angle < 60)
            {
                RaycastHit hit;
                

                if(Physics.Raycast(transform.position, player.transform.position, out hit, 100))
                {
                    if(hit.collider.gameObject.CompareTag("Player"))
                    {
                        Debug.Log("I see the player!");
                        GetComponent<Renderer>().material.color = Color.red;
                        Debug.DrawRay(this.transform.position, player.transform.position, Color.green, 1.5f);
                    }
                    else
                    {
                        Debug.DrawRay(this.transform.position, player.transform.position, Color.red, 1.5f);
                        GetComponent<Renderer>().material.color = Color.white;
                    }
                }
                else
                {
                    Debug.DrawRay(this.transform.position, player.transform.position, Color.cyan, 1.5f);
                }
            }
            else
            {
                //Debug.Log("!Angle<60"); 
                Debug.DrawRay(this.transform.position, player.transform.position, Color.yellow, 1.5f);
                GetComponent<Renderer>().material.color = Color.white;
            }
            //Debug.Log("The angle between my own forward and the player is " + angle);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
