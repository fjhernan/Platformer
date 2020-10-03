using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ethan : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rb;
    public float moveAmplify = 1.0f;
    private float jump;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Walk and run movement
        float move = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.LeftShift)){
            moveAmplify = 2.0f;
        }
        else{
            moveAmplify = 1.0f;
        }
        Debug.Log("Current move is "+move);
        float y = (move < 0) ? 270 : 90;
        Vector3 input = new Vector3(0, y, 0);
        transform.eulerAngles = input;
        animator.SetFloat("Speed", Mathf.Abs(move)*moveAmplify);
        //Jump movement     
        jump = Input.GetAxis("Vertical");
        animator.SetFloat("Air", jump * 2.0f);
    }
    public void resetPosition(){
        transform.position = new Vector3(1.5f, 36.0f, 0.0f);
    }
}
