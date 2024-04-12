using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BGM : MonoBehaviour
{

    public AudioSource audioSrc;
    

    public static BGM music;
    void Awake()
    {
        if (music == null)
        {
            music = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}