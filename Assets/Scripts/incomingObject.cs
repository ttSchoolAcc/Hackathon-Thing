using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

public class incomingObject : MonoBehaviour
{
    // the objectSprite variable is used to store the sprite of the incoming object.
    //[SerializeField] Sprite objectSprite;
    // the objectToColilde variable is used to store the sprite of the object that the incoming object will collide with.
    //[SerializeField] Sprite objectToColilde;

    // Declare a variable of type playerScore to reference the playerScore component in the scene.
    GameManager gameManager;
    [SerializeField] ParticleSystem part;
    [SerializeField] float beatInterval;
    [SerializeField] GameObject beat;
    [SerializeField] Transform spawnPoint;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Find the playerScore component in the scene and assign it to the playerScore variable.
        gameManager = FindFirstObjectByType<GameManager>();

        StartCoroutine(SpawnBeat()); //Start spawning the beat
    }

    // Update is called once per frame
    void Update()
    {
        // Call the OnCollisionEnter method to check for collisions with the objectToColilde.
        //OnCollisionEnter(objectToColilde);
    }

    // This method is called when the object collides with another object.
    // It checks if the collision is with the objectToColilde and if the space key is pressed.
    // If both conditions are true, it increases the player's score by calling the PointIncrease
    // method of the playerScore component.
    public void OnTriggerStay2D(Collider2D collision)
    {
        // If the objectSprite and objectToColilde collide, the player's score is increased.
        if (IsOnCollisionEnter(collision))
        {
            gameManager.PointIncrease(1);
            Destroy(collision.gameObject);
            part.Play();
        }
    }

    // This method checks if the collision is with the objectToColilde and if the space key is pressed.
    public bool IsOnCollisionEnter(Collider2D collision)
    {
        // Check if the collided object's tag is "incomingObject" and if the space key is pressed, true is returned.
        if (collision.gameObject.tag == "incomingObject" && Input.GetKeyDown(KeyCode.Space))
        {
            return true;
        }
        else // If the conditions are not met, false is returned.
        {
            return false;
        }
    }

    IEnumerator SpawnBeat()
    {
        while(true)
        {
            Instantiate(beat, spawnPoint.position, Quaternion.identity, null);
            yield return new WaitForSeconds(beatInterval);            
        }
    }

}
