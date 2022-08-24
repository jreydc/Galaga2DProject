using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StaticInstance<T> : MonoBehaviour where T : MonoBehaviour {
    public static T _instance;
    public static T _SingleInstance{ 
        get { return _instance; }
        private set{}
    }
    protected virtual void Awake() => _instance = this as T;

    protected virtual void OnApplicationQuit() {
        _instance = null;
        Destroy(gameObject);
    }
}

public class Singleton<T> : StaticInstance<T> where T : Singleton<T>
{
    protected override void Awake()
    {
        if (_instance == null)
        {
            Debug.Log(typeof(T).ToString() + " is NULL.");
            base.Awake();
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            Debug.Log(typeof(T).ToString() + " has tried to instantiate again!");
        }

    }

}
