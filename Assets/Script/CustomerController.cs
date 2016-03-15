using UnityEngine;
using System.Collections;

public class CustomerController : MonoBehaviour {

    public GameObject customer;
    GameObject c1;
    FlagScript flag;
    public bool HvCustomer;

    public int count;
    // Use this for initialization
    void Start () {
        count = 0;
        flag = GameObject.FindGameObjectWithTag("Flag").GetComponent<FlagScript>();
	}

    // Update is called once per frame
    void Update()
    {
        if (flag.IsOpen)
        {
            if (c1 != null)
            {
                if (c1.transform.position.x < -9)
                {
                    Destroy(c1);
                }
            }
            else
            {
                c1 = Instantiate(customer, customer.transform.position, Quaternion.identity) as GameObject;               
            }
        }

        if (c1 != null)
        {
            if (c1.transform.position.x < -9)
            {
               // HvCustomer = false;
                Destroy(c1);
            }
        }
    }
}
