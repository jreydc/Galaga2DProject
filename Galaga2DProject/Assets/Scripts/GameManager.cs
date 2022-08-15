using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{

    #region GameManager GetInstantiation
    private static GameManager instance;
    public static GameManager GetInstance(){
        return instance;
    }
    protected void Awake() {
        if (instance == null){
            instance = this;
            DontDestroyOnLoad(instance.gameObject);
        }else{
            Destroy(instance.gameObject);
        }
    }
    #endregion
    
    // Start is called before the first frame update
    void Start()
    {
        SceneController._SingleInstance.LoadLevel("GamePlayScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
