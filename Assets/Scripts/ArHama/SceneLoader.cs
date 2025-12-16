using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
   public void LoadGallery(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void LoadARScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void BackToMenu(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    
    public void KeluarAplikasi()
    {
        Application.Quit();
        Debug.Log("Keluar aplikasi...");
    }
}
