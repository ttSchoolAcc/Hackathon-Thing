<<<<<<< HEAD
<<<<<<< HEAD
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using TMPro;

enum TimingType
{
    early,
    perfect,
    late,
}

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
    [SerializeField] AudioSource clickSound;
    [SerializeField] TimingType timingType;
    [SerializeField] TextMeshProUGUI timingText;

    Color defaultTextColor;
    Color invis;

    Collider2D currBeat;

    void Awake()
    {
        defaultTextColor = timingText.color;
        invis = timingText.color;
        invis.a = 0;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Find the playerScore component in the scene and assign it to the playerScore variable.
        gameManager = FindFirstObjectByType<GameManager>();

        if(timingType == TimingType.perfect)
            StartCoroutine(SpawnBeat()); //Start spawning the beat
    }

    // Update is called once per frame
    void Update()
    {
        // Call the OnCollisionEnter method to check for collisions with the objectToColilde.
        //OnCollisionEnter(objectToColilde);

        if(timingType == TimingType.perfect) //Just make only one update it
            timingText.color = Color.Lerp(timingText.color, invis, Time.deltaTime * 6);

        if(currBeat != null)
        {
            BeatMovement beatMovement = currBeat.gameObject.GetComponent<BeatMovement>();
            if(Input.GetKeyDown(KeyCode.Space))
            {
                timingText.color = defaultTextColor;
                if(timingType == TimingType.early)
                {
                    gameManager.PointIncrease(1);
                    Destroy(currBeat.gameObject);
                    part.Play();
                    clickSound.Play();           
                    timingText.text = "Too Early";
                }
                else if(timingType == TimingType.perfect)
                {
                    gameManager.PointIncrease(2);
                    Destroy(currBeat.gameObject);
                    part.Play();
                    clickSound.Play();   
                    timingText.text = "Perfect";
                }
                else if(timingType == TimingType.late)
                {
                    gameManager.PointIncrease(1);
                    Destroy(currBeat.gameObject);
                    part.Play();
                    clickSound.Play();   
                    timingText.text = "Too Late";
                }
                //beatMovement.alreadyHit = true;
            }
            
        }
    }

    // This method is called when the object collides with another object.
    // It checks if the collision is with the objectToColilde and if the space key is pressed.
    // If both conditions are true, it increases the player's score by calling the PointIncrease
    // method of the playerScore component.
    public void OnTriggerStay2D(Collider2D collision)
    {
        // If the objectSprite and objectToColilde collide, the player's score is increased.
        //if(currBeat != null && currBeat.tag == "incomingObject")
            currBeat = collision;
        // BeatMovement beatMovement = collision.gameObject.GetComponent<BeatMovement>();
        // if (IsOnCollisionEnter(collision) && !beatMovement.alreadyHit)
        // {
        //     timingText.color = defaultTextColor;
        //     if(timingType == TimingType.early)
        //     {
        //         gameManager.PointIncrease(1);
        //         Destroy(collision.gameObject);
        //         part.Play();
        //         clickSound.Play();           
        //         timingText.text = "Too Early";
        //     }
        //     else if(timingType == TimingType.perfect)
        //     {
        //         gameManager.PointIncrease(2);
        //         Destroy(collision.gameObject);
        //         part.Play();
        //         clickSound.Play();   
        //         timingText.text = "Perfect";
        //     }
        //     else if(timingType == TimingType.late)
        //     {
        //         gameManager.PointIncrease(1);
        //         Destroy(collision.gameObject);
        //         part.Play();
        //         clickSound.Play();   
        //         timingText.text = "Too Late";
        //     }
        //     beatMovement.alreadyHit = true;
        //}
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
=======
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using TMPro;

enum TimingType
{
    early,
    perfect,
    late,
}

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
    [SerializeField] AudioSource clickSound;
    [SerializeField] TimingType timingType;
    [SerializeField] TextMeshProUGUI timingText;

    Color defaultTextColor;
    Color invis;

    void Awake()
    {
        defaultTextColor = timingText.color;
        invis = timingText.color;
        invis.a = 0;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Find the playerScore component in the scene and assign it to the playerScore variable.
        gameManager = FindFirstObjectByType<GameManager>();

        if(timingType == TimingType.perfect)
            StartCoroutine(SpawnBeat()); //Start spawning the beat
    }

    // Update is called once per frame
    void Update()
    {
        // Call the OnCollisionEnter method to check for collisions with the objectToColilde.
        //OnCollisionEnter(objectToColilde);

        if(timingType == TimingType.perfect) //Just make only one update it
            timingText.color = Color.Lerp(timingText.color, invis, Time.deltaTime * 6);
    }

    // This method is called when the object collides with another object.
    // It checks if the collision is with the objectToColilde and if the space key is pressed.
    // If both conditions are true, it increases the player's score by calling the PointIncrease
    // method of the playerScore component.
    public void OnTriggerStay2D(Collider2D collision)
    {
        // If the objectSprite and objectToColilde collide, the player's score is increased.

        BeatMovement beatMovement = collision.gameObject.GetComponent<BeatMovement>();
        if (IsOnCollisionEnter(collision) && !beatMovement.alreadyHit)
        {
            timingText.color = defaultTextColor;
            if(timingType == TimingType.early)
            {
                gameManager.PointIncrease(1);
                Destroy(collision.gameObject);
                part.Play();
                clickSound.Play();           
                timingText.text = "Too Early";
            }
            else if(timingType == TimingType.perfect)
            {
                gameManager.PointIncrease(2);
                Destroy(collision.gameObject);
                part.Play();
                clickSound.Play();   
                timingText.text = "Perfect";
            }
            else if(timingType == TimingType.late)
            {
                gameManager.PointIncrease(1);
                Destroy(collision.gameObject);
                part.Play();
                clickSound.Play();   
                timingText.text = "Too Late";
            }
            beatMovement.alreadyHit = true;
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
>>>>>>> 2bbf8f0f86e2e976094317651800d3dd17b125f2
=======
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using TMPro;

enum TimingType
{
    early,
    perfect,
    late,
}

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
    [SerializeField] AudioSource clickSound;
    [SerializeField] TimingType timingType;
    [SerializeField] TextMeshProUGUI timingText;

    Color defaultTextColor;
    Color invis;

    void Awake()
    {
        defaultTextColor = timingText.color;
        invis = timingText.color;
        invis.a = 0;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Find the playerScore component in the scene and assign it to the playerScore variable.
        gameManager = FindFirstObjectByType<GameManager>();

        if(timingType == TimingType.perfect)
            StartCoroutine(SpawnBeat()); //Start spawning the beat
    }

    // Update is called once per frame
    void Update()
    {
        // Call the OnCollisionEnter method to check for collisions with the objectToColilde.
        //OnCollisionEnter(objectToColilde);

        if(timingType == TimingType.perfect) //Just make only one update it
            timingText.color = Color.Lerp(timingText.color, invis, Time.deltaTime * 6);
    }

    // This method is called when the object collides with another object.
    // It checks if the collision is with the objectToColilde and if the space key is pressed.
    // If both conditions are true, it increases the player's score by calling the PointIncrease
    // method of the playerScore component.
    public void OnTriggerStay2D(Collider2D collision)
    {
        // If the objectSprite and objectToColilde collide, the player's score is increased.

        BeatMovement beatMovement = collision.gameObject.GetComponent<BeatMovement>();
        if (IsOnCollisionEnter(collision) && !beatMovement.alreadyHit)
        {
            timingText.color = defaultTextColor;
            if(timingType == TimingType.early)
            {
                gameManager.PointIncrease(1);
                Destroy(collision.gameObject);
                part.Play();
                clickSound.Play();           
                timingText.text = "Too Early";
            }
            else if(timingType == TimingType.perfect)
            {
                gameManager.PointIncrease(2);
                Destroy(collision.gameObject);
                part.Play();
                clickSound.Play();   
                timingText.text = "Perfect";
            }
            else if(timingType == TimingType.late)
            {
                gameManager.PointIncrease(1);
                Destroy(collision.gameObject);
                part.Play();
                clickSound.Play();   
                timingText.text = "Too Late";
            }
            beatMovement.alreadyHit = true;
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
>>>>>>> 2bbf8f0f86e2e976094317651800d3dd17b125f2
