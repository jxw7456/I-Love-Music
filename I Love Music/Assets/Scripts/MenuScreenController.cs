﻿using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScreenController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("SelectScene");
    }

    public void LoadVisualizer()
    {
        SceneManager.LoadScene("Visualizer");
    }
}
