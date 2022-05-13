using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cha : MonoBehaviour
{

    Vector4 moveVector = Vector4.zero;
    public Rigidbody rb;
    float inputX = 0.0f;
    float inputZ = 0.0f;
    float speed = 5.0f;
    public Vector2 turn;
    public float sensitivity = 2.0f;
    public Vector3 deltaMove;
    public UnityEngine.CharacterController controller;
    public Animator animator;
    public float jumpSpeed;
    public float gravity;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

    }
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");

        Vector3 move = transform.right * inputX + transform.forward * inputZ;
        controller.Move(move * speed * Time.deltaTime);

        turn.x += Input.GetAxis("Mouse X") * sensitivity;
        turn.y += Input.GetAxis("Mouse Y") * sensitivity;
        //transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
        transform.localRotation = Quaternion.Euler(0, turn.x, 0);

        if (move != Vector3.zero)
        {
            animator.SetBool("isMoving", true);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }

        controller.Move(moveVector * Time.deltaTime);
        if (controller.isGrounded && Input.GetButton("Jump"))
            moveVector.y = jumpSpeed;
        moveVector.y -= gravity * Time.deltaTime;

        if (controller.isGrounded)
        {
            if (Input.GetButton("Jump"))
            {
                animator.SetBool("is_in_air", true);
            }
            else
            {
                animator.SetBool("is_in_air", false);
            }
        }
       
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trap"))
        {
            animator.SetBool("isdying", true);
            //Destroy(gameObject.GetComponent<cha>());
            //Destroy(gameObject.GetComponent<CharacterController>());
        }
        else
        {
            animator.SetBool("isdying", false);
        }
    }
}

