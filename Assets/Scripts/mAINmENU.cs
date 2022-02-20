using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class mAINmENU : MonoBehaviour{public TextMeshProUGUI hIGHsCOREtEXT;void Start(){if(PlayerPrefs.HasKey("highscore"))hIGHsCOREtEXT.text = "High Score: " + PlayerPrefs.GetInt("highscore");else hIGHsCOREtEXT.text = "High Score: 0";}public void HitPlay(){SceneManager.LoadScene("SampleScene");}}
