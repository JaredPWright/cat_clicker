using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerAbilityMethods;

public class PlayerAttackScript : Abilities
{
    public GameObject laserFab;
    public float speed  = 6.0f;
    public float rateOfFire = 6.0f;

    void Start()
    {
        InvokeRepeating("ShootEmUp", .5f, rateOfFire);
    }

    public void Ability1()
    {
        Invoke(ActivePlayerAbilities.activeAbilities[0], 0.0f);
        ActivePlayerAbilities.activeAbilities[0] = "BlankAbility";
    }

    public void Ability2()
    {
        Invoke(ActivePlayerAbilities.activeAbilities[1], 0.0f);
        ActivePlayerAbilities.activeAbilities[1] = "BlankAbility";
    }

    void ShootEmUp()
    {
        GameObject temp = Instantiate(laserFab, transform.position, Quaternion.identity);
        temp.GetComponent<Rigidbody>().AddForce(Vector3.down * speed, ForceMode.Impulse);
    }
}
