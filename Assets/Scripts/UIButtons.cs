using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtons : MonoBehaviour
{
    private void Update()
    {
        //Check if we are hitting R on the keyboard.
        if(Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }
    }

    //Reload the same scene when we restart.
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
