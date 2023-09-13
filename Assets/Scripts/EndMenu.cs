using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.SceneManagement;//need to reload scenes


public class EndMenu : MonoBehaviour
{
   // Start is called before the first frame update
    public void QuitGame()//must be public for button to access it
    {
       Application.Quit();

    }
}
