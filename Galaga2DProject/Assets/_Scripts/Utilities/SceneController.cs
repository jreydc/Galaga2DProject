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

    /* 
        Reference: https://gamedevbeginner.com/how-to-load-a-new-scene-in-unity-with-a-loading-screen/

        By: John French - May 14, 2020
     */
    public IEnumerator LoadingDetails(){
        yield return null;

        //Begin to load the Scene you specify
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync("MainScene");
        //Don't let the Scene activate until you allow it to
        asyncOperation.allowSceneActivation = false;
        Debug.Log("Pro :" + asyncOperation.progress);
        //When the load is still in progress, output the Text and progress bar
        while (!asyncOperation.isDone)
        {
            //Output the current progress
            Debug.Log("Loading progress: " + (asyncOperation.progress * 100) + "%");

            // Check if the load has finished
            if (asyncOperation.progress >= 0.9f)
            {
                //Change the Text to show the Scene is ready
                //loadText.text = "Press the space bar to continue";
                Debug.Log("Loaded all of the resources");
                //Wait to you press the space key to activate the Scene
                
                //if (Input.GetKeyDown(KeyCode.Space))
                    //Activate the Scene
                asyncOperation.allowSceneActivation = true;

            }

            yield return null;
        }
    }
}
