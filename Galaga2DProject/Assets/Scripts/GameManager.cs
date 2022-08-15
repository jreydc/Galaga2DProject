using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : Singleton<GameManager>
{

    #region GameManager Persistent Instantiation
    private static GameManager instance;
    public static GameManager GetInstance(){
        return instance;
    }
    protected override void Awake() {
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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
