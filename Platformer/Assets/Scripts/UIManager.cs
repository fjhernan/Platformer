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
    public TextMeshProUGUI victory;
    public TextMeshProUGUI failure;
    private int t = 100;
    private int score = 0;
    private bool temp = false;
    private int counter = 0;
    private bool win = false, fail = false;

    // Start is called before the first frame update
    void Start(){
        marioScore.text = "MARIO\n" + score.ToString("D6");
        coinCounter.text = "COIN\n" + counter.ToString("D2");
        timer.text = "TIMER\n"+t;
    }

    // Update is called once per frame
    void Update()
    {
        if (win == false && fail == false)
        {
            if (temp == false && t > 0)
                StartCoroutine(Countdown());
            else if (t <= 0)
            {
                fail = true;
            }

            marioScore.text = "Mario\n" + score.ToString("D6");

            if (counter >= 100)
                counter = 0;

            coinCounter.text = "COIN\n" + counter.ToString("D2");
        }
        else if (win == true && fail == false){
            victory.text = "<color=black>You beat the level!</color>";
        }
        else if(win == false && fail == true){
            failure.text = "<color=black>You couldn't beat the level in time.</color>";
        }
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
    public void beatIt()
    {
        win = true;
    }
    public void failed(){
        fail = true;
    }
}
