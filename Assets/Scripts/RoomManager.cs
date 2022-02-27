using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomManager : MonoBehaviour
{
    static int sceneState = 0;
    public void CheckSceneState()
    {
        if (transform.childCount <= 1)
        {
            //show aniamtion
            print("scne ended");
            LoadNextScene();


        }
    }
    public void LoadNextScene()
    {
        if (sceneState == 1)
        {
            sceneState++;
            GameObject.FindGameObjectWithTag("Fashion").SetActive(false);
            SceneManager.LoadScene("Biolagi", LoadSceneMode.Additive);
        }
        //for now -> after set player to the other object and change on click
        else if (sceneState == 0)
        {
            sceneState++;
            GameObject.FindGameObjectWithTag("Music").SetActive(false);
            SceneManager.LoadScene("Fashion", LoadSceneMode.Additive);
        }
    }
}
