using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BadGuyScript : MonoBehaviour
{
    public float health = 100f;
    public ParticleSystem psys;

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
            StartCoroutine("PlayerWin");
    }

    private IEnumerator PlayerWin()
    {
        psys.Play();
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene("WinScene");
    }
}
