using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllAgent : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float fJumpNum;
    [SerializeField] private float fspeed;
    [SerializeField] private GameObject _bone;
    [SerializeField] private GameObject _bone001;
    private CharacterController characterControrller;
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        characterControrller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetTrigger("Jump");
            animator.ResetTrigger("LandOn");
            rb.velocity = Vector3.up * fJumpNum;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetTrigger("Move");
            rb.velocity = Vector3.left * fspeed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetTrigger("Move");
            rb.velocity = Vector3.right * fspeed;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        animator.SetTrigger("LandOn");
    }

}
