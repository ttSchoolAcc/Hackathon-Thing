<<<<<<< HEAD
<<<<<<< HEAD
using UnityEngine;
using TMPro;

public class playerScore : MonoBehaviour
{
    // SerializeField allows you to assign a reference to the TextMeshProUGUI component in the Unity editor.
    [SerializeField] TextMeshProUGUI scoreText;

    // Declare a variable of type incomingObject to reference the incomingObject component in the scene.
    incomingObject Object;
    int score = 0;

    // The method pointIncrease increases the player's score by 1 and updates the score text on the UI.
    public void PointIncrease()
    {
        score += 1;
        scoreText.text = "Score: " + score;
    }

    // The method GetScore returns the current score of the player.
    public int GetScore()
    {
        // Return the current score of the player.
        return score;
    }

}
=======
using UnityEngine;
using TMPro;

public class playerScore : MonoBehaviour
{
    // SerializeField allows you to assign a reference to the TextMeshProUGUI component in the Unity editor.
    [SerializeField] TextMeshProUGUI scoreText;

    // Declare a variable of type incomingObject to reference the incomingObject component in the scene.
    incomingObject Object;
    int score = 0;

    // The method pointIncrease increases the player's score by 1 and updates the score text on the UI.
    public void PointIncrease()
    {
        score += 1;
        scoreText.text = "Score: " + score;
    }

    // The method GetScore returns the current score of the player.
    public int GetScore()
    {
        // Return the current score of the player.
        return score;
    }

}
>>>>>>> 2bbf8f0f86e2e976094317651800d3dd17b125f2
=======
using UnityEngine;
using TMPro;

public class playerScore : MonoBehaviour
{
    // SerializeField allows you to assign a reference to the TextMeshProUGUI component in the Unity editor.
    [SerializeField] TextMeshProUGUI scoreText;

    // Declare a variable of type incomingObject to reference the incomingObject component in the scene.
    incomingObject Object;
    int score = 0;

    // The method pointIncrease increases the player's score by 1 and updates the score text on the UI.
    public void PointIncrease()
    {
        score += 1;
        scoreText.text = "Score: " + score;
    }

    // The method GetScore returns the current score of the player.
    public int GetScore()
    {
        // Return the current score of the player.
        return score;
    }

}
>>>>>>> 2bbf8f0f86e2e976094317651800d3dd17b125f2
