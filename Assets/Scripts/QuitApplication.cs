using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitApplication : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        ExitApp();
    }

    void ExitApp()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("You've exit the game");
            Application.Quit(); 
        }
    }
}
