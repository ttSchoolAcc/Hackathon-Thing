using System.Collections;
using UnityEngine;

public class FactGiving : MonoBehaviour
{

    [SerializeField] GameObject infoBox;

    void Start()
    {
        StartCoroutine(FactGive());
    }

    IEnumerator FactGive()
    {
        yield return new WaitForSeconds(5);
        while(true)
        {
            infoBox.SetActive(true);
            yield return new WaitForSeconds(10);
            infoBox.SetActive(false);
            yield return new WaitForSeconds(10);
        }
    }
}
