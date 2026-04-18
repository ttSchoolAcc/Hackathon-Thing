using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;

//#include "GameManager.cs"

public class BPMBar : MonoBehaviour
{

    [SerializeField] UnityEngine.UI.Slider bpmSlider;
    [SerializeField] TextMeshProUGUI message;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bpmSlider.value = 0;
        bpmSlider.maxValue = 120;
    }

    // Update is called once per frame
    void Update()
    {
        // If the space key is pressed and the BPM slider value is between 0 and its maximum value, increase the BPM and update the message accordingly.
        if (Input.GetKeyDown(KeyCode.Space) && bpmSlider.value > 0 && bpmSlider.value < bpmSlider.maxValue)
        {
            // Call the BPMIncrease method to increase the BPM slider value by 10.
            BPMIncrease();

            // If the BPM slider value is between 0 and 100, set the message text to "BPM Needs to be higher."
            if (bpmSlider.value > 0 && bpmSlider.value < 100)
            {
                message.text = "BPM Needs to be higher.";
            }
            else if(bpmSlider.value >= 100 && bpmSlider.value < bpmSlider.maxValue)
            {
                // If the BPM slider value is between 100 and its maximum value, set the message text to "BPM is within range."
                message.text = "BPM is within range.";
            }
            else // If the BPM slider value is greater than or equal to its maximum value, set the message text to "BPM is too high."
            {
                message.text = "BPM is too high.";
                bpmSlider.value = 0;
            }
        }
    }

    // This method increases the BPM slider value by 10.
    void BPMIncrease()
    {
        bpmSlider.value += 10;
    }


}
