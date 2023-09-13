using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.SceneManagement;//need to reload scenes



public class StartMenu : MonoBehaviour
{

    public void StartGame()//must be public for button to access it
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);//Load the NEXT scene
    }


}
