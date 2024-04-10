using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{  
    //Hit the collectible, add to the counter and destroy the collected item.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("Counter").GetComponent<Counter>().UpdateCounter();
            Destroy(gameObject);
            //gameObject.SetActive(false);
        }
    }
}
