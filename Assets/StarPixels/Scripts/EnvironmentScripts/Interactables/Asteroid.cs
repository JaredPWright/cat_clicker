using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerAbilityMethods;

public class Asteroid : MonoBehaviour
{
    private Rigidbody rb;
    public float asteroidSpeed = 2.75f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Destroy(this.gameObject, 20.0f);
    }

    void Update()
    {
        rb.transform.Translate(Vector3.down * asteroidSpeed * Time.deltaTime);
    }
    
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player") && !EnergyShieldAbility.isActive)
            Player.health--;
    }

}
