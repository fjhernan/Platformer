using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ethan : MonoBehaviour
{
    private Animator animator;
    public float moveAmplify = 1.0f;
    private float move;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Walk and run movement
        move = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.LeftShift)){
            moveAmplify = 2.0f;
        }
        else{
            moveAmplify = 1.0f;
        }
        float y = (move < 0) ? 270 : 90;
        Vector3 input = new Vector3(0, y, 0);
        transform.eulerAngles = input;
        if(move > 0 || move < 0)
        {
            //Debug.Log(move * moveAmplify);
        }
        animator.SetFloat("Speed", Mathf.Abs(move * moveAmplify));
        //Jump movement
        if(Input.GetKeyDown(KeyCode.Space)){
            //Debug.Log("jumping works");
            animator.SetFloat("Air", 1.0f);
        }
        else{
            animator.SetFloat("Air", 0.0f);
        }
    }
    public void resetPosition(){
        transform.position = new Vector3(1.5f, 36.0f, 0.0f);
    }
}
