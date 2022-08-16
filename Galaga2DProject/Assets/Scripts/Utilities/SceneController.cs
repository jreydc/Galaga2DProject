using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : Singleton<SceneController>
{
    public void LoadLevel(string levelName)
    {
        SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Single);
    }

    public void UnloadLevel(string levelName)
    {
        SceneManager.UnloadSceneAsync(levelName, UnloadSceneOptions.None);
    }

    
}
