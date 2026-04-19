using System.Collections;
using TMPro;
using UnityEngine;

public class FactGiving : MonoBehaviour
{

    [SerializeField] GameObject infoBox;
    [SerializeField] TextMeshProUGUI info;
    [SerializeField] string[] factsToSay;
    [SerializeField] float factStayTime = 8;
    [SerializeField] float factRestTime = 2;

    void Start()
    {
        StartCoroutine(FactGive());
    }

    IEnumerator FactGive()
    {
        yield return new WaitForSeconds(5);
        while(true)
        {
            info.text = factsToSay[Random.Range(0, factsToSay.Length)];
            infoBox.SetActive(true);
            yield return new WaitForSeconds(factStayTime);
            infoBox.SetActive(false);
            yield return new WaitForSeconds(factRestTime);
        }
    }
}
