using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Main_Menu : MonoBehaviour
{

    public AudioSource AudioSource;
    public void Play()
    {
        SceneManager.LoadScene(1);
        AudioSource.Play();
    }

    public void PlaySound(AudioClip clip)
    {
        AudioSource.PlayOneShot(clip);
        Invoke("Play", 3);
    }
    public void OnApplicationQuit()
    {
        Application.Quit();
        Debug.Log("Game Closed");
    }
}
