using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyScene : MonoBehaviour
{
    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        SceneManager.LoadScene("Music");
    }
}
