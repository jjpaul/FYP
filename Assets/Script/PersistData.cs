﻿using UnityEngine;
using System.Collections;

public class PersistData : MonoBehaviour {

    void Awake()
    {
        DontDestroyOnLoad(this);

        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
    }
}
