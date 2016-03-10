using UnityEngine;
using System.Collections;

public class PersistData : MonoBehaviour {

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
