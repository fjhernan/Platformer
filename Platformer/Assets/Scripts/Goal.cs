using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other){
        if(other.gameObject.name == "Ethan"){
            GameObject.Find("UIManager").GetComponent<UIManager>().beatIt();
        }
    }
}
