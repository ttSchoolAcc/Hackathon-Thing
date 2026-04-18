using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI counterText;
    [SerializeField] int score;

    public void PointIncrease(int value)
    {
        score += value;
        counterText.text = "Compressions Given: " + score;
    }
}
