using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeTest : MonoBehaviour
{
    public TextMeshProUGUI TestText;
    public float currCountdownValue;
    public string TestBody;

    public IEnumerator TimeTester(float timeRemainder)
    {
        Debug.Log("Time Test");
        //var rem = (remains) => remains - 5f;
        yield return new WaitForSeconds(timeRemainder);
        Debug.Log("Time Remaining: " + timeRemainder);
        Debug.Log("Five Second Passed");
    }

    public IEnumerator StartCountdown(float countdownValue = 10)
    {
        currCountdownValue = countdownValue;
        while (currCountdownValue > -1)
        {

            TestText.text = currCountdownValue + "";
            Debug.Log("Countdown: " + currCountdownValue);
            yield return new WaitForSeconds(1.0f);
            //Entity.Movable = false;
            GetComponent<Button>().interactable = false;
            currCountdownValue--;
        }

        GetComponent<Button>().interactable = true;
    }


    public void testCountdown()
    {
        StartCoroutine(StartCountdown());
    }

    // Start is called before the first frame update
    void Start()
    {
        TestBody = TestText.text;
    }
}
