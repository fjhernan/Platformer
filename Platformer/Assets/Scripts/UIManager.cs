using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI marioScore;
    public TextMeshProUGUI coinCounter;
    public TextMeshProUGUI timer;
    private int t = 100;
    public int score = 0;
    private bool temp = false;
    public int counter = 0;

    // Start is called before the first frame update
    void Start(){
        marioScore.text = "MARIO\n" + score.ToString("D6");
        coinCounter.text = "COIN\n" + counter.ToString("D2");
        timer.text = "TIMER\n"+t;
    }

    // Update is called once per frame
    void Update()
    {
        if(temp == false && t > 0)
           StartCoroutine(Countdown());
        else if(t <= 0)
        {
            Debug.Log("Failed. Couldn't reach the goal in time.");
        }

        marioScore.text = "Mario\n" + score.ToString("D6");
        
        if (counter >= 100)
            counter = 0;

        coinCounter.text = "COIN\n" + counter.ToString("D2");
    }

    IEnumerator Countdown() //Not my code. Credit goes to youtuber Jimmy Vegas
    {
        temp = true;
        yield return new WaitForSeconds(1.0f);
        t -= 1;
        if (t < 100)
            timer.text = "TIMER\n" + t.ToString("D3");
        else
            timer.text = "TIMER\n" + t;
        temp = false;
    }
    
    public void blockBroken()
    {
        score += 100;
    }

    public void questionBlockHit()
    {
        score += 100;
        counter++;
    }
}
