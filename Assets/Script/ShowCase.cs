using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ShowCase : MonoBehaviour
{


    public GameObject waiting;
    private GameObject waitingPrefab;
    private bool UIReady;
    public static bool dragable;

    public GameObject weaponStorage;
    public GameObject showCase;
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (UIReady && Input.GetMouseButtonDown(0))
        {
            weaponStorage.SetActive(true);
            showCase.SetActive(true);
            dragable = true;
        }
        if (!UIReady || Input.GetMouseButtonDown(1))
        {
            weaponStorage.SetActive(false);
            showCase.SetActive(false);
            dragable = false;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("hi");
            UIReady = true;
            waitingPrefab = Instantiate(waiting, new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y + 1.5f), Quaternion.identity) as GameObject;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("bye");
            UIReady = false;
            Destroy(waitingPrefab);

        }
    }
}
