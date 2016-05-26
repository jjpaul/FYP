using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Map : MonoBehaviour
{

    UIControll UI;

    void Start()
    {
        UI = GameObject.FindGameObjectWithTag("UIController").GetComponent<UIControll>();
    }

    public void toEastScene()
    {
        SceneManager.LoadScene(3);
    }

    public void toStoreScene()
    {
        SceneManager.LoadScene(1);
    }

    public void toItemStoreScene()
    {
        SceneManager.LoadScene(5);
    }

}
