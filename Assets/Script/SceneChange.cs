using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {

    UIControll UI;
    
    void Start()
    {
        UI = GameObject.FindGameObjectWithTag("UIController").GetComponent<UIControll>();
    }
    public void toBattleScene()
    {
        UI.closeExitPanel();
        SceneManager.LoadScene(2);
    }

}
