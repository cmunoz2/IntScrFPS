using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FovTest : MonoBehaviour
{

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LookForPlayer());
    }

    IEnumerator LookForPlayer()
    {
        while(true)
        {
            Debug.Log("Looking for player");
            yield return new WaitForSeconds(0.1f);
        }
    }

}
