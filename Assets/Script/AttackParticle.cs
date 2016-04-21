using UnityEngine;
using System.Collections;

public class AttackParticle : MonoBehaviour {

    private Animator animator;
    public GameObject particle;
    private bool showed;
    private GameObject particleIn;
    private float initPos;
    public bool left;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (this.gameObject.GetComponent<SpriteRenderer>().flipX == false)
        {
            particle.GetComponent<SpriteRenderer>().flipX = true;
            if(!showed)
             left = true;
        }
        else
        {
            particle.GetComponent<SpriteRenderer>().flipX = false;
            if(!showed)
            left = false;
        }

        if (animator.GetBool("attack") == true)
        {
            Debug.Log("attack");
            if (showed == false)
            {
                if (!left)
                {
                    particleIn = (GameObject)Instantiate(particle, new Vector3(this.transform.position.x + 0.5f, this.transform.position.y, 0), Quaternion.identity);
                }
                else
                {
                    particleIn = (GameObject)Instantiate(particle, new Vector3(this.transform.position.x - 0.5f, this.transform.position.y, 0), Quaternion.identity);
                }
                initPos = particleIn.transform.position.x;                
                showed = true;
                Debug.Log(initPos);
            }
        }
        if (showed)
        {
            if (!left )
            {
                particleIn.transform.position += new Vector3(5 * Time.deltaTime, 0.0f, 0.0f);
                if (particleIn.transform.position.x > initPos + 3)
                {
                    destroyPf();
                }
            }
            else if(left)
            {
                particleIn.transform.position -= new Vector3(5 * Time.deltaTime, 0.0f, 0.0f);
                if (particleIn.transform.position.x < initPos - 3)
                {
                    destroyPf();
                }
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "enemy")
        {
            destroyPf();
            Debug.Log("123123");
        }
    }
    //void show()
    //{
    //    particleIn = (GameObject) Instantiate(particle, new Vector3(this.transform.position.x + 1, this.transform.position.y, 0), Quaternion.identity);
    //    initPos = particleIn.transform.position.x;
    //    particleIn.transform.position += new Vector3(5 * Time.deltaTime,0.0f,0.0f);
    //}

    public void destroyPf()
    {
        Destroy(particleIn);
        showed = false;
    }
}
