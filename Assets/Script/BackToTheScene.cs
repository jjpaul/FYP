using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BackToTheScene : MonoBehaviour {

	public void back()
    {
        SceneManager.LoadScene(0);
    }
}
