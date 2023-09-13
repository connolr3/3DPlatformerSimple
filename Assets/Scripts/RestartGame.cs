using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.SceneManagement;//need to reload scenes


public class RestartGame : MonoBehaviour
{
     // Start is called before the first frame update
    public void RestartEntireGame()//must be public for button to access it
    {
       SceneManager.LoadScene(1);//Load the NEXT scene
    }
}
