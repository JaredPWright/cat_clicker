using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static int health = 3;
    public ParticleSystem psys;

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
            StartCoroutine("PlayerLose");
    }

    private IEnumerator PlayerLose()
    {
        psys.Play();
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene("MainMenu");
    }

}
