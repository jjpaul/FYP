using UnityEngine;
using System.Collections;

public class monsterMove : MonoBehaviour {

    private Animator animator;
    public CharacterAttributes character;
    float speed = 3.0f;
    public int HP;
    public AttackParticle AP;
    public Transform player;

    ItemDatabase database;
    Item DroppedItem;
    ItemManager IM;
    public int itemId;


    public GameObject Damage;

	// Use this for initialization
	void Start () {
        character = GameObject.FindGameObjectWithTag("CharacterAttribute").GetComponent<CharacterAttributes>();
        database = GameObject.FindGameObjectWithTag("ItemDatabase").GetComponent<ItemDatabase>();
        AP = GameObject.FindGameObjectWithTag("Player").GetComponent<AttackParticle>();
        IM = GameObject.FindGameObjectWithTag("IM").GetComponent<ItemManager>();
        animator = GetComponent<Animator>();
        HP = 1000;
    }
	
	// Update is called once per frame
	void Update () {
        //  walk();
     //   chase();
        if(HP <= 0)
        {
            ItemDropped();
            //    Dead();
        }
        else
        {
            chase();
        }
    }

    void walk()
    {
        animator.SetBool("walk", true);
        transform.position -= new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
    }

    void chase()
    {
        animator.SetBool("walk", true);
        if(Vector3.Distance(transform.position,player.position) <= 12 && player.position.y >= this.transform.position.y)
        {
            if (transform.position.x > player.position.x)
            {
                this.GetComponent<SpriteRenderer>().flipX = false;
                transform.position -= transform.right * speed * Time.deltaTime;
            }
            else
            {
                this.GetComponent<SpriteRenderer>().flipX = true;
                transform.position += transform.right * speed * Time.deltaTime;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "particle")
        {
            HP -= character.Att;
            Debug.Log(HP);
            if (!AP.left)
            {
                transform.position += new Vector3(2, 0.0f, 0.0f);
            }
            else
            {
                transform.position += new Vector3(-2, 0.0f, 0.0f);
            }
            AP.destroyPf();
        }

        if(col.gameObject.tag == "Player")
        {
            if(HP <= 0)
            {
                IM.add(itemId);
                Dead();
            }
        }
    }

    public void Dead()
    {
     //   animator.SetBool("dead", true);

        Destroy(this.gameObject);
        
    }

    void ItemDropped()
    {
        Debug.Log("item");
        animator.Stop();
        itemId = 116;
        for(int i = 0; i < database.items.Count; i++)
        {
            if(database.items[i].itemID == itemId)
            {
                DroppedItem = database.items[i];
                Debug.Log(DroppedItem.itemName);
            //    this.gameObject.GetComponent<PolygonCollider2D>().isTrigger = true;
                this.gameObject.GetComponent<SpriteRenderer>().sprite = DroppedItem.itemIcon;
                this.gameObject.transform.localScale = new Vector3(1, 1, 1);
                break;
            }
        }
      //  this.gameObject.GetComponent<SpriteRenderer>().sprite = DroppedItem.itemIcon;
    }
}
