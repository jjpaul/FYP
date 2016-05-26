﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {

    UIControll UI;
    
    void Start()
    {
        UI = GameObject.FindGameObjectWithTag("UIController").GetComponent<UIControll>();
    }

    public void toMapScene()
    {
        UI.closeExitPanel();
        SceneManager.LoadScene(4);
    }

    public void toEastScene()
    {
        SceneManager.LoadScene(3);
    }

    void Awake()
    {
        DontDestroyOnLoad(this);

        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
    }

}
