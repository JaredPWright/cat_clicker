using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePlayerAbilities : MonoBehaviour
{
    public static string[] activeAbilities = new string[2];

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Powerup"))
            activeAbilities[1] = other.gameObject.name;
    }
}
