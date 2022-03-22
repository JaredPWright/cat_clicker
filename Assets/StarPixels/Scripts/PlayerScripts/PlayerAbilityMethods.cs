using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerAbilityMethods
{
    public class GenericAbility : MonoBehaviour
    {
        public float damage = 0.0f;
        public float duration = 0.0f;
        public static bool isActive = true;

        public void StatSet(float damageVariable, float durationVariable)
        {
            damage = damageVariable;
            duration = durationVariable;
        }

        public void BlankAbility()
        {
            Debug.Log("Nada, fam. Outta juice");
        }
    }

    public class HyperBeamAbility : GenericAbility
    {
        public void HyperBeam()
        {
            StatSet(.75f, 3.5f);
            StartCoroutine("Firing");
            while(isActive)
            {
                RaycastHit hit;
                Physics.Raycast(GameObject.Find("badspaceship").transform.position, Vector3.up, out hit, Mathf.Infinity);

                if(hit.collider.gameObject.CompareTag("Asteroid"))
                    Destroy(hit.collider.gameObject);

                if(hit.collider.gameObject.CompareTag("BadGuy"))
                    hit.collider.gameObject.GetComponent<BadGuyScript>().health -= damage;
            }
        }

        private IEnumerator Firing()
        {
            yield return new WaitForSeconds(duration);
            isActive = false;
        }
    }

    public class EnergyShieldAbility : HyperBeamAbility
    {
        public void EnergyShield()
        {
            StatSet(0.0f, 5.0f);
            StartCoroutine("Shielding");
        }

        private IEnumerator Shielding()
        {
            yield return new WaitForSeconds(duration);
            isActive = false;
        }
    }

    public class Abilities : EnergyShieldAbility{}
} 
