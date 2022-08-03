using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

  public Transform shootPoint;
  public GameObject bulletPrefab;
  public float shootForce = 50;

  public void Update() {
      
      if (Input.GetMouseButtonDown(0)) {
          
          GameObject newBullet = Instantiate(bulletPrefab);
          newBullet.transform.position = shootPoint.transform.position;

          Rigidbody rb = newBullet.GetComponent<Rigidbody>();
          rb.AddForce(shootPoint.transform.forward * shootForce, ForceMode.Impulse);

          Destroy(newBullet, 5); 
      }
  }
}
