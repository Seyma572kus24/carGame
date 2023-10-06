using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Countdown : MonoBehaviour
{
    public GameObject carcontrol;
    public GameObject CauntdownUI;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountStart());
    }

   IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.5f);
        CauntdownUI.GetComponent<Text>().text = "3";
        yield return new WaitForSeconds(1.0f);
        CauntdownUI.GetComponent<Text>().text = "2"; 
        yield return new WaitForSeconds(1.0f);
        CauntdownUI.GetComponent<Text>().text = "1";
        yield return new WaitForSeconds(1.0f);
        CauntdownUI.GetComponent<Text>().text = "GO";
        CauntdownUI.SetActive(false);
        carcontrol.SetActive(false);
    }
}
