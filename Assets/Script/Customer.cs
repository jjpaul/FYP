using UnityEngine;
using System.Collections;

public class Customer : MonoBehaviour
{

    public float speed = 2.0f;
    public float pos1;
    public float pos2;
    public float pos3;
    public float temp;
    public float initPos;
    
    public bool first = true;
    public bool second = false;
    public bool third = false;
    public bool pass = false;
    public bool isBuy = false;
    public bool exit = false;

    GameObject eventNotic;
    GameObject eventNotic_love;
    GameObject eventNotic_frustrated;

    TempSelling tempSelling;
    Item item;
    CharacterAttributes character;



    // Use this for initialization
    void Start()
    {
        pos1 = Random.Range(1f, 2f);
        pos2 = Random.Range(-4f, -2f);
        pos3 = Random.Range(-1f, 2f);
        initPos = transform.position.x;

        character = GameObject.FindGameObjectWithTag("CharacterAttribute").GetComponent<CharacterAttributes>();
        tempSelling = GameObject.FindGameObjectWithTag("TempSell").GetComponent<TempSelling>();
        eventNotic = GameObject.FindGameObjectWithTag("Event");
        eventNotic_love = GameObject.FindGameObjectWithTag("Event_love");
        eventNotic_frustrated = GameObject.FindGameObjectWithTag("Event_frustrated");
        item = new Item();
        eventNotic.SetActive(false);
        eventNotic_love.SetActive(false);
        eventNotic_frustrated.SetActive(false);
    }

    //Update is called once per frame
    void Update()
    {
        if (first && !second && !third)
        {
            firstStep();
            if (transform.position.x > pos1)
            {
                first = false;
                second = true;
                StartCoroutine(waiting());
            }
        }
        else if (!first && second && !third && pass)
        {
            secondStep();
            if (transform.position.x < pos2)
            {
                second = false;
                third = true;
                StartCoroutine(waiting());
            }
        }
        else if (!first && !second && third && pass)
        {
            thirdStep();
            if (transform.position.x > pos3)
            {
                eventNotic.SetActive(true);
                StartCoroutine(waiting());
                third = false;
              //  isBuy = true;
            }
        }
        else if(!first && !second && ! third && pass && !exit)
        {
            if (transform.position.x < 3.8f)
            {
                transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
            }
            if (transform.position.x >= 3.8f)
            {
                isBuy = true;
                exit = true;
                StartCoroutine(waiting());                
            }
        }
        else if (exit)
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        }


        if (isBuy)
        {
            buy();
        }

    }


    void firstStep()
    {
        if (transform.position.x < pos1)
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
            temp = pos1;
        }
    }

    void secondStep()
    {
        if (transform.position.x < pos2)
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
            temp = pos2;
        }
        else
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
            temp = pos2;
        }

    }

    void thirdStep()
    {
        if (transform.position.x < pos3)
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        }
        else
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        }

    }

    public IEnumerator waiting()
    {
        pass = false;
        yield return new WaitForSeconds(2f);
        pass = true;
        eventNotic.SetActive(false);
    }

    void buy()
    {
        for(int i = 0; i < 8; i++)
        {
            if(tempSelling.tempItem[i].itemValue > 0)
            {
                item = tempSelling.tempItem[i];
                eventNotic_love.SetActive(true);
                break;
            }
            else
            {
                eventNotic_frustrated.SetActive(true);
            }
        }
        character.Asset += item.itemCost;
        item.itemValue--;

        if(item.itemValue <= 0 && item.itemName != null)
        {
            Debug.Log(item.itemName + " sold out");
        }
        isBuy = false;
    }
}
