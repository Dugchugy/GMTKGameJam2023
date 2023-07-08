using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingController : MonoBehaviour
{
    private TMPro.TMP_Text endingText;

    // Start is called before the first frame update
    void Start()
    {
        string[] endingConditions = InterMenuSelection.Endtext.Split("|$|");

        endingText = GameObject.Find("Ending Text").GetComponent<TMPro.TMP_Text>();

        endingText.text = endingConditions[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
