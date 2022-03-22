using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject laserPrefab;
    public float speed = 1.5f;
    public float rateOfFire = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ShootPlayer", 1.5f, rateOfFire);
    }

   void ShootPlayer()
   {
       GameObject temp = Instantiate(laserPrefab, transform.position, Quaternion.identity);
       temp.GetComponent<Rigidbody>().AddForce(Vector3.down * speed, ForceMode.Impulse);
   }
}
