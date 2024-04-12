using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public string whatScene;
    public AudioSource clicks;


    void Start()
    {
        clicks.GetComponent<AudioSource>();
    }
    public void Quit()
    {
        clicks.Play();
        Application.Quit();
        Debug.Log("Quit!!!");
    }

    public void PlayScene()
    {
        clicks.Play();
        SceneManager.LoadScene(whatScene);
        Time.timeScale = 1.0f;
    }

    public void MainMenu() 
    {
        clicks.Play();
        SceneManager.LoadSceneAsync(0);
    }

}