using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI counterText;
    int counterVal;

    void Update()
    {
        DoSomethingWithCounter(1);
    }

    public void DoSomethingWithCounter(int value)
    {
        counterVal += value;
        counterText.text = "Counter for something: " + counterVal;
    }
}
