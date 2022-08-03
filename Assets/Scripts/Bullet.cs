using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject effectPrefab;

    public void OnCollisionEnter(Collision collision) {

        if(collision.gameObject.tag == "Enemy") {
            Destroy(collision.gameObject.transform.root.gameObject);
        }
        
        GameObject newEffect = Instantiate(effectPrefab, transform.position, Quaternion.identity);
        
        Destroy(newEffect, 2);
        Destroy(gameObject);
    }
}
