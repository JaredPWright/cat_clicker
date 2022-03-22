using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespectableMainMenuScript : MonoBehaviour
{
   public void GoToStarPixels()
   {
       SceneManager.LoadScene("SpaceShooter");
   }
}
