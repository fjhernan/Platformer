﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    GameObject score;
    //Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("UIManager");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit))
            {
                BoxCollider bc = hit.collider as BoxCollider;
                Debug.Log(bc.name);
                if(bc.name == "Brick(Clone)"){
                    Destroy(bc.gameObject);
                    score.GetComponent<UIManager>().score += 100;
                }
                if(bc.name == "Question(Clone)"){
                    score.GetComponent<UIManager>().score += 500;
                    score.GetComponent<UIManager>().counter += 1;
                }
            }
        }   
    }
}