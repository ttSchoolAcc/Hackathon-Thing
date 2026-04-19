using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI counterText;
    [SerializeField] int score;
    [SerializeField] int numOfHits;
    [Space(10)]
    [SerializeField] float timer;
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] GameObject gameScreen;
    [SerializeField] GameObject endScreen;
    [SerializeField] TextMeshProUGUI resultText;
    [SerializeField] TextMeshProUGUI scoreText;


    [SerializeField] int badEndStartRange = 0;
    [SerializeField] int neuEndStartRange = 50;
    [SerializeField] int goodEndStartRange = 100;


    [SerializeField] GameObject[] endScreens; //0 bad, 1 neu, 2 good

    public void PointIncrease(int value)
    {
        score += value;
        numOfHits++;
        counterText.text = "Score: " + score;
    }

    void Update()
    {
        Timer();
    }

    public void Timer()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
            timerText.text = "" + (int)timer;            
        }
        else        
        {
            EndScreen();
        }
    }

    void EndScreen()
    {
        resultText.text = numOfHits.ToString();
        scoreText.text = "Score: " + score.ToString();
        gameScreen.SetActive(false);
        endScreen.SetActive(true);




        if(score >= goodEndStartRange)
        {
            endScreens[2].SetActive(true);
        }
        else if(score >= neuEndStartRange)
        {
            endScreens[1].SetActive(true);
        }
        else if(score >= badEndStartRange)
        {
            endScreens[0].SetActive(true);
        }
    } 
}
