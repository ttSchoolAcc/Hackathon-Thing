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
            resultText.text = numOfHits.ToString();
            scoreText.text = "Score: " + score.ToString();
            gameScreen.SetActive(false);
            endScreen.SetActive(true);
        }
    }
}
