using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Singleton : MonoBehaviour
{
    public static Singleton instance;
    private void OnEnable()
    {
        
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else {
            Destroy(this);
        }
    }
}
