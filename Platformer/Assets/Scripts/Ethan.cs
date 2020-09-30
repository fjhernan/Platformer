using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ethan : MonoBehaviour
{
    private Animator animator;
    public float moveAmplify = 1;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        float y = (move < 0) ? 180 : 0;
        if(move > 0 || move < 0)
        {
            Debug.Log("Moving works");
        }
        Vector3 input = new Vector3(0, y, 0);
        transform.eulerAngles = input;
        animator.SetFloat("Speed", move);
    }
}
