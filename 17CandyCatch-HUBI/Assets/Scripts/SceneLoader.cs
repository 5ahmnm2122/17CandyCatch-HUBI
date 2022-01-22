using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void MainScene()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void StartScene()
    {
        SceneManager.LoadScene("StartScene");
    }
}
