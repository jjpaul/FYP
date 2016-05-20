using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CharacterController : MonoBehaviour {

    private Animator animator;

    public float speed = 4.0f;
    public float tempSpeed;
    public float jumpSpeed = 8.0f;

    public bool IsHurt;
    public bool jumped = false;
    public bool grounded = false;
    public Transform groundCheck;
    float groundradius = 0.2f;
    public LayerMask whatIsGround;

    public Vector3 initPos;

    FlagScript Flag;
    CharacterAttributes character;

	// Use this for initialization
	void Start () {
        IsHurt = false;
        animator = GetComponent<Animator>();
        character = GameObject.FindGameObjectWithTag("CharacterAttribute").GetComponent<CharacterAttributes>();

        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            Flag = GameObject.FindGameObjectWithTag("Flag").GetComponent<FlagScript>();
            initPos = transform.position;
        }
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            if (Flag.IsOpen)
            {
                transform.position = initPos;
            }
        }

        if(SceneManager.GetActiveScene().buildIndex == 2)
        {
            jump();
            walk();
            attack();
            dodge();
            run();
            hurt();
        }

        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            jump();
            walk();
        }
    }
	
	void FixedUpdate () {

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundradius, whatIsGround);
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            if (!Flag.IsOpen)
            {
                jump();
                walk();
            }
        }
    }

    void attack()
    {
        if (Input.GetMouseButtonDown(1))
        {
            animator.SetBool("attack", true);
        }
        else
        {
            animator.SetBool("attack", false);
        }
    }

    void dodge()
    {
  //      animator.SetBool("dodge", false);
    }

    void run()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetKey(KeyCode.A))
            {
    //            animator.SetBool("run", true);
                transform.position -= new Vector3(speed *1.5f * Time.deltaTime, 0.0f, 0.0f);
            }
            else if (Input.GetKey(KeyCode.D))
            {
     //           animator.SetBool("run", true);
                transform.position += new Vector3(speed *1.5f * Time.deltaTime, 0.0f, 0.0f);
            }
        }
        else
        {
    //        animator.SetBool("run", false);
        }
    }

    void jump()
    {
        if (grounded && Input.GetKeyDown(KeyCode.W))
        {
            //        animator.SetBool("jump", true);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
            jumped = true;
        }
        else
        {
     //       animator.SetBool("jump", false);
        }
    }

    void walk()
    {
        if (Input.GetKey(KeyCode.A))
        {

            animator.SetBool("walk", true);
            this.gameObject.GetComponent<SpriteRenderer>().flipX = false;
            transform.position -= new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("walk", true);
            this.gameObject.GetComponent<SpriteRenderer>().flipX = true;
            transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        }
        else
        {
            animator.SetBool("walk", false);
        }
    }

    void hurt()
    {
        if (IsHurt)
        {
            //         animator.SetBool("hurt", true);
        }
        else
        {
            //        animator.SetBool("hurt", false);
        }
    }
}
