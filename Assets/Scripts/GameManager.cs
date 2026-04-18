using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI counterText;
    [SerializeField] int score;
    [Space(10)]
    [SerializeField] float timer;
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] GameObject gameScreen;
    [SerializeField] GameObject endScreen;
    [SerializeField] TextMeshProUGUI resultText;

    public void PointIncrease(int value)
    {
        score += value;
        counterText.text = "Compressions Given: " + score;
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
            resultText.text = score.ToString();
            gameScreen.SetActive(false);
            endScreen.SetActive(true);
        }
    }
}
