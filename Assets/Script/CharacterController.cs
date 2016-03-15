using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {

    public float speed = 4.0f;
    public float jumpSpeed = 10.0f;

    bool grounded = false;
    public Transform groundCheck;
    float groundradius = 0.2f;
    public LayerMask whatIsGround;

    public Vector3 initPos;

    FlagScript Flag;

	// Use this for initialization
	void Start () {
        Flag = GameObject.FindGameObjectWithTag("Flag").GetComponent<FlagScript>();
        initPos = transform.position;
    }

    void Update ()
    {
        if (Flag.IsOpen)
        {
            transform.position = initPos;
        }
    }
	
	void FixedUpdate () {

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundradius, whatIsGround);

        if (grounded && Input.GetKeyDown(KeyCode.W) && !Flag.IsOpen)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.A) && !Flag.IsOpen)
        {
            transform.position -= new Vector3(speed * Time.deltaTime,0.0f,0.0f);
        }
        if (Input.GetKey(KeyCode.D) && !Flag.IsOpen)
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        }

    }
}
